Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class frmBorrowing

    Dim printDT As New DataTable
    Dim selectedTransactionID As Integer = 0

    Private Sub RefreshDashboard()
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is frmDashboard Then
                CType(frm, frmDashboard).LoadDashboardData()
            End If
        Next
    End Sub

    Private Sub frmBorrowing_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadStudents()
        LoadEquipment()
        LoadBorrowStatus()
        LoadConditionReturn()
        LoadFilterStatus()
        GenerateTransactionCode()
        LoadBorrowingRecords()

        ' Default settings
        dtpActualReturn.Enabled = False
        cboConditionReturn.Enabled = False
        nudQtyReturned.Enabled = False
        nudQtyReturned.Value = 0
        chkReturned.Checked = False
        dtpFilterFrom.Value = New DateTime(DateTime.Now.Year, 1, 1)
        dtpFilterTo.Value = DateTime.Now
    End Sub

    '==========================================
    ' LOAD COMBOBOXES
    '==========================================
    Private Sub LoadStudents()
        Try
            Dim con As SqlConnection = GetConnection()
            con.Open()

            Dim sql As String = "SELECT StudentID, FirstName + ' ' + LastName + " &
                                "' (' + StudentLRN + ')' AS StudentName " &
                                "FROM tbl_Students ORDER BY LastName ASC"

            Dim cmd As New SqlCommand(sql, con)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            cboBorrowStudent.DataSource = dt
            cboBorrowStudent.DisplayMember = "StudentName"
            cboBorrowStudent.ValueMember = "StudentID"
            cboBorrowStudent.SelectedIndex = -1

            con.Close()

        Catch ex As Exception
            MsgBox("Error loading students: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub LoadEquipment()
        Try
            Dim con As SqlConnection = GetConnection()
            con.Open()

            Dim sql As String = "SELECT EquipmentID, EquipmentName + ' (' + EquipmentCode + ')' AS EquipmentDisplay " &
                                "FROM tbl_Equipment WHERE Status = 'Available' AND AvailableQuantity > 0 " &
                                "ORDER BY EquipmentName ASC"

            Dim cmd As New SqlCommand(sql, con)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            cboBorrowEquipment.DataSource = dt
            cboBorrowEquipment.DisplayMember = "EquipmentDisplay"
            cboBorrowEquipment.ValueMember = "EquipmentID"
            cboBorrowEquipment.SelectedIndex = -1

            con.Close()

        Catch ex As Exception
            MsgBox("Error loading equipment: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub LoadAllEquipmentForEdit()
        Try
            Dim con As SqlConnection = GetConnection()
            con.Open()

            Dim sql As String = "SELECT EquipmentID, EquipmentName + ' (' + EquipmentCode + ')' AS EquipmentDisplay " &
                                "FROM tbl_Equipment ORDER BY EquipmentName ASC"

            Dim cmd As New SqlCommand(sql, con)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            cboBorrowEquipment.DataSource = dt
            cboBorrowEquipment.DisplayMember = "EquipmentDisplay"
            cboBorrowEquipment.ValueMember = "EquipmentID"

            con.Close()

        Catch ex As Exception
            MsgBox("Error loading equipment: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub LoadBorrowStatus()
        cboBorrowStatus.Items.Clear()
        cboBorrowStatus.Items.Add("Borrowed")
        cboBorrowStatus.Items.Add("Returned")
        cboBorrowStatus.Items.Add("Overdue")
        cboBorrowStatus.Items.Add("Lost")
        cboBorrowStatus.SelectedIndex = 0
    End Sub

    Private Sub LoadConditionReturn()
        cboConditionReturn.Items.Clear()
        cboConditionReturn.Items.Add("Good")
        cboConditionReturn.Items.Add("Fair")
        cboConditionReturn.Items.Add("Damaged")
        cboConditionReturn.SelectedIndex = 0
    End Sub

    Private Sub LoadFilterStatus()
        cboFilterBorrowStatus.Items.Clear()
        cboFilterBorrowStatus.Items.Add("All Status")
        cboFilterBorrowStatus.Items.Add("Borrowed")
        cboFilterBorrowStatus.Items.Add("Returned")
        cboFilterBorrowStatus.Items.Add("Overdue")
        cboFilterBorrowStatus.Items.Add("Lost")
        cboFilterBorrowStatus.SelectedIndex = 0
    End Sub

    '==========================================
    ' AUTO GENERATE TRANSACTION CODE
    '==========================================
    Private Sub GenerateTransactionCode()
        Try
            Dim con As SqlConnection = GetConnection()
            con.Open()

            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tbl_Borrowing", con)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            con.Close()

            Dim year As String = DateTime.Now.Year.ToString()
            Dim num As String = (count + 1).ToString("D4")
            txtTransactionCode.Text = "BR-" & year & "-" & num
            txtTransactionCode.ReadOnly = True

        Catch ex As Exception
            MsgBox("Error generating code: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    '==========================================
    ' LOAD BORROWING RECORDS
    '==========================================
    Private Sub LoadBorrowingRecords()
        Try
            Dim con As SqlConnection = GetConnection()
            con.Open()

            Dim sql As String = "SELECT b.TransactionID, b.TransactionCode, " &
                                "s.FirstName + ' ' + s.LastName AS Student, " &
                                "s.GradeLevel + ' - ' + s.Section AS Section, " &
                                "e.EquipmentName AS Equipment, " &
                                "b.QuantityBorrowed AS Qty, " &
                                "CONVERT(VARCHAR, b.DateBorrowed, 101) AS DateBorrowed, " &
                                "CONVERT(VARCHAR, b.ExpectedReturnDate, 101) AS DueDate, " &
                                "CONVERT(VARCHAR, b.ActualReturnDate, 101) AS ReturnDate, " &
                                "b.ConditionOnReturn AS Condition, " &
                                "b.Status, b.Remarks " &
                                "FROM tbl_Borrowing b " &
                                "INNER JOIN tbl_Students s ON b.StudentID = s.StudentID " &
                                "INNER JOIN tbl_Equipment e ON b.EquipmentID = e.EquipmentID " &
                                "ORDER BY b.DateRecorded DESC"

            Dim cmd As New SqlCommand(sql, con)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgvBorrowing.DataSource = dt
            dgvBorrowing.Columns("TransactionID").Visible = False
            dgvBorrowing.Columns("TransactionCode").HeaderText = "Trans. Code"
            dgvBorrowing.Columns("Student").HeaderText = "Student Name"
            dgvBorrowing.Columns("Section").HeaderText = "Section"
            dgvBorrowing.Columns("Equipment").HeaderText = "Equipment"
            dgvBorrowing.Columns("Qty").HeaderText = "Qty"
            dgvBorrowing.Columns("DateBorrowed").HeaderText = "Date Borrowed"
            dgvBorrowing.Columns("DueDate").HeaderText = "Due Date"
            dgvBorrowing.Columns("ReturnDate").HeaderText = "Return Date"
            dgvBorrowing.Columns("Condition").HeaderText = "Condition"
            dgvBorrowing.Columns("Status").HeaderText = "Status"
            dgvBorrowing.Columns("Remarks").HeaderText = "Remarks"

            dgvBorrowing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvBorrowing.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvBorrowing.ReadOnly = True
            dgvBorrowing.AllowUserToAddRows = False
            dgvBorrowing.RowHeadersVisible = False

            con.Close()

        Catch ex As Exception
            MsgBox("Error loading records: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    '==========================================
    ' CLEAR FIELDS
    '==========================================
    Private Sub ClearFields()
        GenerateTransactionCode()
        LoadStudents()
        LoadEquipment()
        cboBorrowStudent.SelectedIndex = -1
        cboBorrowEquipment.SelectedIndex = -1
        nudQtyBorrowed.Value = 1
        nudQtyReturned.Value = 0
        nudQtyReturned.Enabled = False
        dtpDateBorrowed.Value = DateTime.Now
        dtpExpectedReturn.Value = DateTime.Now
        dtpActualReturn.Value = DateTime.Now
        dtpActualReturn.Enabled = False
        chkReturned.Checked = False
        cboConditionReturn.Enabled = False
        cboConditionReturn.SelectedIndex = 0
        cboBorrowStatus.SelectedIndex = 0
        txtBorrowRemarks.Text = ""
        txtSearchBorrow.Text = ""
        cboFilterBorrowStatus.SelectedIndex = 0
        btnRecordBorrow.Enabled = True
        cboBorrowStudent.Enabled = True
        cboBorrowEquipment.Enabled = True
        nudQtyBorrowed.Enabled = True
        selectedTransactionID = 0
        dgvBorrowing.ClearSelection()
    End Sub

    '==========================================
    ' VALIDATE FIELDS
    '==========================================
    Private Function ValidateFields() As Boolean
        If cboBorrowStudent.SelectedIndex = -1 Then
            MsgBox("Please select a Student.", MsgBoxStyle.Exclamation, "Validation")
            cboBorrowStudent.Focus()
            Return False
        End If

        If selectedTransactionID = 0 AndAlso cboBorrowEquipment.SelectedIndex = -1 Then
            MsgBox("Please select an Equipment.", MsgBoxStyle.Exclamation, "Validation")
            cboBorrowEquipment.Focus()
            Return False
        End If

        If nudQtyBorrowed.Value < 1 Then
            MsgBox("Quantity must be at least 1.", MsgBoxStyle.Exclamation, "Validation")
            nudQtyBorrowed.Focus()
            Return False
        End If

        If dtpExpectedReturn.Value.Date < dtpDateBorrowed.Value.Date Then
            MsgBox("Expected Return Date cannot be earlier than Date Borrowed.", MsgBoxStyle.Exclamation, "Validation")
            dtpExpectedReturn.Focus()
            Return False
        End If

        If chkReturned.Checked Then
            If nudQtyReturned.Value < 1 Then
                MsgBox("Please enter Quantity Returned.", MsgBoxStyle.Exclamation, "Validation")
                nudQtyReturned.Focus()
                Return False
            End If

            If nudQtyReturned.Value > nudQtyBorrowed.Value Then
                MsgBox("Quantity Returned cannot be more than Quantity Borrowed.", MsgBoxStyle.Exclamation, "Validation")
                nudQtyReturned.Focus()
                Return False
            End If
        End If

        Return True
    End Function

    '==========================================
    ' MARK AS RETURNED CHECKBOX
    '==========================================
    Private Sub chkReturned_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkReturned.CheckedChanged
        If chkReturned.Checked Then
            dtpActualReturn.Enabled = True
            dtpActualReturn.Value = DateTime.Now
            cboConditionReturn.Enabled = True
            nudQtyReturned.Enabled = True
            nudQtyReturned.Value = nudQtyBorrowed.Value
            cboBorrowStatus.SelectedItem = "Returned"
        Else
            dtpActualReturn.Enabled = False
            cboConditionReturn.Enabled = False
            nudQtyReturned.Enabled = False
            nudQtyReturned.Value = 0
            cboBorrowStatus.SelectedItem = "Borrowed"
        End If
    End Sub

    '==========================================
    ' RECORD BORROW
    '==========================================
    Private Sub btnRecordBorrow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRecordBorrow.Click
        If Not ValidateFields() Then Exit Sub

        Try
            Dim con As SqlConnection = GetConnection()
            con.Open()

            Dim equipID As Integer = Convert.ToInt32(cboBorrowEquipment.SelectedValue)
            Dim cmdCheck As New SqlCommand("SELECT AvailableQuantity FROM tbl_Equipment WHERE EquipmentID = @ID", con)
            cmdCheck.Parameters.AddWithValue("@ID", equipID)
            Dim availQty As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

            If nudQtyBorrowed.Value > availQty Then
                MsgBox("Not enough available quantity. Only " & availQty & " left.", MsgBoxStyle.Exclamation, "Insufficient Quantity")
                con.Close()
                Exit Sub
            End If

            Dim sql As String = "INSERT INTO tbl_Borrowing (TransactionCode, StudentID, EquipmentID, " &
                                "QuantityBorrowed, DateBorrowed, ExpectedReturnDate, " &
                                "ActualReturnDate, ConditionOnReturn, Status, Remarks, DateRecorded) " &
                                "VALUES (@Code, @StudentID, @EquipmentID, @Qty, @DateBorrowed, " &
                                "@ExpectedReturn, @ActualReturn, @Condition, @Status, @Remarks, @DateRecorded)"

            Dim cmd As New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@Code", txtTransactionCode.Text.Trim)
            cmd.Parameters.AddWithValue("@StudentID", Convert.ToInt32(cboBorrowStudent.SelectedValue))
            cmd.Parameters.AddWithValue("@EquipmentID", equipID)
            cmd.Parameters.AddWithValue("@Qty", CInt(nudQtyBorrowed.Value))
            cmd.Parameters.AddWithValue("@DateBorrowed", dtpDateBorrowed.Value)
            cmd.Parameters.AddWithValue("@ExpectedReturn", dtpExpectedReturn.Value)

            If chkReturned.Checked Then
                cmd.Parameters.AddWithValue("@ActualReturn", dtpActualReturn.Value)
                cmd.Parameters.AddWithValue("@Condition", cboConditionReturn.SelectedItem.ToString())
            Else
                cmd.Parameters.AddWithValue("@ActualReturn", DBNull.Value)
                cmd.Parameters.AddWithValue("@Condition", DBNull.Value)
            End If

            cmd.Parameters.AddWithValue("@Status", cboBorrowStatus.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Remarks", txtBorrowRemarks.Text.Trim)
            cmd.Parameters.AddWithValue("@DateRecorded", DateTime.Now)
            cmd.ExecuteNonQuery()

            Dim newAvail As Integer = availQty - CInt(nudQtyBorrowed.Value)
            Dim updateStatus As String = If(newAvail = 0, "Borrowed", "Available")

            Dim cmdUpdate As New SqlCommand("UPDATE tbl_Equipment SET AvailableQuantity = @Avail, " &
                                           "Status = @Status WHERE EquipmentID = @ID", con)
            cmdUpdate.Parameters.AddWithValue("@Avail", newAvail)
            cmdUpdate.Parameters.AddWithValue("@Status", updateStatus)
            cmdUpdate.Parameters.AddWithValue("@ID", equipID)
            cmdUpdate.ExecuteNonQuery()

            con.Close()

            MsgBox("Borrowing record saved successfully!", MsgBoxStyle.Information, "Success")
            ClearFields()
            LoadBorrowingRecords()
            RefreshDashboard()

        Catch ex As Exception
            MsgBox("Error recording borrow: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    '==========================================
    ' UPDATE BORROWING RECORD
    '==========================================
    Private Sub btnUpdateBorrow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdateBorrow.Click
        If selectedTransactionID = 0 Then
            MsgBox("Please select a record to update.", MsgBoxStyle.Exclamation, "No Selection")
            Exit Sub
        End If

        If Not ValidateFields() Then Exit Sub

        Dim confirm As MsgBoxResult
        confirm = MsgBox("Are you sure you want to update this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Update")
        If confirm = MsgBoxResult.No Then Exit Sub

        Try
            Dim con As SqlConnection = GetConnection()
            con.Open()

            Dim sql As String = "UPDATE tbl_Borrowing SET StudentID = @StudentID, " &
                                "EquipmentID = @EquipmentID, QuantityBorrowed = @Qty, " &
                                "DateBorrowed = @DateBorrowed, ExpectedReturnDate = @ExpectedReturn, " &
                                "ActualReturnDate = @ActualReturn, ConditionOnReturn = @Condition, " &
                                "Status = @Status, Remarks = @Remarks, DateModified = @DateModified " &
                                "WHERE TransactionID = @ID"

            Dim cmd As New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@StudentID", Convert.ToInt32(cboBorrowStudent.SelectedValue))
            cmd.Parameters.AddWithValue("@EquipmentID", Convert.ToInt32(cboBorrowEquipment.SelectedValue))
            cmd.Parameters.AddWithValue("@Qty", CInt(nudQtyBorrowed.Value))
            cmd.Parameters.AddWithValue("@DateBorrowed", dtpDateBorrowed.Value)
            cmd.Parameters.AddWithValue("@ExpectedReturn", dtpExpectedReturn.Value)

            If chkReturned.Checked Then
                cmd.Parameters.AddWithValue("@ActualReturn", dtpActualReturn.Value)
                cmd.Parameters.AddWithValue("@Condition", cboConditionReturn.SelectedItem.ToString())
            Else
                cmd.Parameters.AddWithValue("@ActualReturn", DBNull.Value)
                cmd.Parameters.AddWithValue("@Condition", DBNull.Value)
            End If

            cmd.Parameters.AddWithValue("@Status", cboBorrowStatus.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Remarks", txtBorrowRemarks.Text.Trim)
            cmd.Parameters.AddWithValue("@DateModified", DateTime.Now)
            cmd.Parameters.AddWithValue("@ID", selectedTransactionID)
            cmd.ExecuteNonQuery()

            ' Update equipment quantity if returned
            If chkReturned.Checked Then
                Dim equipID As Integer = Convert.ToInt32(cboBorrowEquipment.SelectedValue)

                Dim cmdGetAvail As New SqlCommand("SELECT AvailableQuantity, TotalQuantity FROM tbl_Equipment WHERE EquipmentID = @ID", con)
                cmdGetAvail.Parameters.AddWithValue("@ID", equipID)
                Dim drEquip As SqlDataReader = cmdGetAvail.ExecuteReader()

                Dim currentAvail As Integer = 0
                Dim totalQty As Integer = 0
                If drEquip.Read() Then
                    currentAvail = Convert.ToInt32(drEquip("AvailableQuantity"))
                    totalQty = Convert.ToInt32(drEquip("TotalQuantity"))
                End If
                drEquip.Close()

                Dim newAvail As Integer = currentAvail + CInt(nudQtyReturned.Value)
                If newAvail > totalQty Then newAvail = totalQty

                Dim remainingBorrowed As Integer = CInt(nudQtyBorrowed.Value) - CInt(nudQtyReturned.Value)
                Dim newStatus As String = If(remainingBorrowed <= 0, "Available", "Borrowed")

                Dim cmdEquip As New SqlCommand("UPDATE tbl_Equipment SET " &
                                              "AvailableQuantity = @NewAvail, " &
                                              "Status = @Status WHERE EquipmentID = @ID", con)
                cmdEquip.Parameters.AddWithValue("@NewAvail", newAvail)
                cmdEquip.Parameters.AddWithValue("@Status", newStatus)
                cmdEquip.Parameters.AddWithValue("@ID", equipID)
                cmdEquip.ExecuteNonQuery()

                If remainingBorrowed > 0 Then
                    Dim cmdPartial As New SqlCommand("UPDATE tbl_Borrowing SET QuantityBorrowed = @Remaining, " &
                                                    "Status = 'Borrowed' WHERE TransactionID = @ID", con)
                    cmdPartial.Parameters.AddWithValue("@Remaining", remainingBorrowed)
                    cmdPartial.Parameters.AddWithValue("@ID", selectedTransactionID)
                    cmdPartial.ExecuteNonQuery()

                    MsgBox("Partial return recorded! " & CInt(nudQtyReturned.Value) & " returned, " &
                           remainingBorrowed & " still borrowed.", MsgBoxStyle.Information, "Partial Return")
                Else
                    MsgBox("Equipment fully returned!", MsgBoxStyle.Information, "Success")
                End If
            Else
                MsgBox("Record updated successfully!", MsgBoxStyle.Information, "Success")
            End If

            con.Close()
            ClearFields()
            LoadBorrowingRecords()
            RefreshDashboard()

        Catch ex As Exception
            MsgBox("Error updating record: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    '==========================================
    ' DELETE BORROWING RECORD
    '==========================================
    Private Sub btnDeleteBorrow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeleteBorrow.Click
        If selectedTransactionID = 0 Then
            MsgBox("Please select a record to delete.", MsgBoxStyle.Exclamation, "No Selection")
            Exit Sub
        End If

        Dim confirm As MsgBoxResult
        confirm = MsgBox("Are you sure you want to delete this record? This cannot be undone.", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Confirm Delete")
        If confirm = MsgBoxResult.No Then Exit Sub

        Try
            Dim con As SqlConnection = GetConnection()
            con.Open()

            Dim sql As String = "DELETE FROM tbl_Borrowing WHERE TransactionID = @ID"
            Dim cmd As New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@ID", selectedTransactionID)
            cmd.ExecuteNonQuery()
            con.Close()

            MsgBox("Record deleted successfully!", MsgBoxStyle.Information, "Success")
            ClearFields()
            LoadBorrowingRecords()
            RefreshDashboard()

        Catch ex As Exception
            MsgBox("Error deleting record: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    '==========================================
    ' CLEAR BUTTON
    '==========================================
    Private Sub btnClearBorrow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClearBorrow.Click
        ClearFields()
    End Sub

    '==========================================
    ' SELECT ROW — LOAD TO FIELDS
    '==========================================
    Private Sub dgvBorrowing_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvBorrowing.CellClick
        If e.RowIndex >= 0 Then
            Try
                Dim row As DataGridViewRow = dgvBorrowing.Rows(e.RowIndex)
                selectedTransactionID = Convert.ToInt32(row.Cells("TransactionID").Value)
                txtTransactionCode.Text = row.Cells("TransactionCode").Value.ToString()

                Dim con As SqlConnection = GetConnection()
                con.Open()

                ' Load all equipment for editing
                LoadAllEquipmentForEdit()

                Dim cmdBorrow As New SqlCommand("SELECT StudentID, EquipmentID, QuantityBorrowed, " &
                                               "DateBorrowed, ExpectedReturnDate, ActualReturnDate, " &
                                               "ConditionOnReturn, Status, Remarks " &
                                               "FROM tbl_Borrowing WHERE TransactionID = @ID", con)
                cmdBorrow.Parameters.AddWithValue("@ID", selectedTransactionID)

                Dim dr As SqlDataReader = cmdBorrow.ExecuteReader()
                If dr.Read() Then
                    cboBorrowStudent.SelectedValue = dr("StudentID")
                    cboBorrowEquipment.SelectedValue = dr("EquipmentID")
                    nudQtyBorrowed.Value = Convert.ToInt32(dr("QuantityBorrowed"))

                    dtpDateBorrowed.Value = Convert.ToDateTime(dr("DateBorrowed"))
                    dtpExpectedReturn.Value = Convert.ToDateTime(dr("ExpectedReturnDate"))

                    If Not IsDBNull(dr("ActualReturnDate")) Then
                        chkReturned.Checked = True
                        dtpActualReturn.Value = Convert.ToDateTime(dr("ActualReturnDate"))
                    Else
                        chkReturned.Checked = False
                    End If

                    If Not IsDBNull(dr("ConditionOnReturn")) Then
                        cboConditionReturn.SelectedItem = dr("ConditionOnReturn").ToString()
                    End If

                    cboBorrowStatus.SelectedItem = dr("Status").ToString()
                    txtBorrowRemarks.Text = dr("Remarks").ToString()
                End If

                dr.Close()
                con.Close()

                ' Lock fields when editing
                btnRecordBorrow.Enabled = False
                cboBorrowStudent.Enabled = False
                cboBorrowEquipment.Enabled = False
                nudQtyBorrowed.Enabled = False
                nudQtyReturned.Value = 0
                nudQtyReturned.Enabled = False

            Catch ex As Exception
                MsgBox("Error loading record: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    '==========================================
    ' SEARCH AND FILTER
    '==========================================
    Private Sub txtSearchBorrow_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSearchBorrow.TextChanged
        ApplyFilter()
    End Sub

    Private Sub cboFilterBorrowStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboFilterBorrowStatus.SelectedIndexChanged
        ApplyFilter()
    End Sub

    Private Sub btnFilterBorrow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFilterBorrow.Click
        ApplyFilter()
    End Sub

    Private Sub ApplyFilter()
        Try
            Dim con As SqlConnection = GetConnection()
            con.Open()

            Dim sql As String = "SELECT b.TransactionID, b.TransactionCode, " &
                                "s.FirstName + ' ' + s.LastName AS Student, " &
                                "s.GradeLevel + ' - ' + s.Section AS Section, " &
                                "e.EquipmentName AS Equipment, " &
                                "b.QuantityBorrowed AS Qty, " &
                                "CONVERT(VARCHAR, b.DateBorrowed, 101) AS DateBorrowed, " &
                                "CONVERT(VARCHAR, b.ExpectedReturnDate, 101) AS DueDate, " &
                                "CONVERT(VARCHAR, b.ActualReturnDate, 101) AS ReturnDate, " &
                                "b.ConditionOnReturn AS Condition, " &
                                "b.Status, b.Remarks " &
                                "FROM tbl_Borrowing b " &
                                "INNER JOIN tbl_Students s ON b.StudentID = s.StudentID " &
                                "INNER JOIN tbl_Equipment e ON b.EquipmentID = e.EquipmentID " &
                                "WHERE b.DateBorrowed BETWEEN @From AND @To"

            If cboFilterBorrowStatus.SelectedIndex > 0 Then
                sql = sql & " AND b.Status = @Status"
            End If

            If txtSearchBorrow.Text.Trim <> "" Then
                sql = sql & " AND (s.FirstName + ' ' + s.LastName LIKE @Search " &
                            "OR e.EquipmentName LIKE @Search " &
                            "OR b.TransactionCode LIKE @Search)"
            End If

            sql = sql & " ORDER BY b.DateRecorded DESC"

            Dim cmd As New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@From", dtpFilterFrom.Value.Date)
            cmd.Parameters.AddWithValue("@To", dtpFilterTo.Value.Date.AddDays(1))

            If cboFilterBorrowStatus.SelectedIndex > 0 Then
                cmd.Parameters.AddWithValue("@Status", cboFilterBorrowStatus.SelectedItem.ToString())
            End If

            If txtSearchBorrow.Text.Trim <> "" Then
                cmd.Parameters.AddWithValue("@Search", "%" & txtSearchBorrow.Text.Trim & "%")
            End If

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgvBorrowing.DataSource = dt
            dgvBorrowing.Columns("TransactionID").Visible = False
            dgvBorrowing.Columns("TransactionCode").HeaderText = "Trans. Code"
            dgvBorrowing.Columns("Student").HeaderText = "Student Name"
            dgvBorrowing.Columns("Section").HeaderText = "Section"
            dgvBorrowing.Columns("Equipment").HeaderText = "Equipment"
            dgvBorrowing.Columns("Qty").HeaderText = "Qty"
            dgvBorrowing.Columns("DateBorrowed").HeaderText = "Date Borrowed"
            dgvBorrowing.Columns("DueDate").HeaderText = "Due Date"
            dgvBorrowing.Columns("ReturnDate").HeaderText = "Return Date"
            dgvBorrowing.Columns("Condition").HeaderText = "Condition"
            dgvBorrowing.Columns("Status").HeaderText = "Status"
            dgvBorrowing.Columns("Remarks").HeaderText = "Remarks"

            con.Close()

        Catch ex As Exception
            MsgBox("Error filtering: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    '==========================================
    ' PRINT SLIP
    '==========================================
    Private Sub btnPrintSlip_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrintSlip.Click
        If selectedTransactionID = 0 Then
            MsgBox("Please select a borrowing record to print.", MsgBoxStyle.Exclamation, "No Selection")
            Exit Sub
        End If

        Try
            Dim con As SqlConnection = GetConnection()
            con.Open()

            Dim sql As String = "SELECT b.TransactionCode, " &
                                "s.FirstName + ' ' + s.LastName AS Student, " &
                                "s.StudentLRN, s.GradeLevel, s.Section, " &
                                "e.EquipmentName, e.EquipmentCode, " &
                                "b.QuantityBorrowed, " &
                                "CONVERT(VARCHAR, b.DateBorrowed, 101) AS DateBorrowed, " &
                                "CONVERT(VARCHAR, b.ExpectedReturnDate, 101) AS DueDate, " &
                                "b.Status, b.Remarks " &
                                "FROM tbl_Borrowing b " &
                                "INNER JOIN tbl_Students s ON b.StudentID = s.StudentID " &
                                "INNER JOIN tbl_Equipment e ON b.EquipmentID = e.EquipmentID " &
                                "WHERE b.TransactionID = @ID"

            Dim cmd As New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@ID", selectedTransactionID)

            Dim da As New SqlDataAdapter(cmd)
            printDT = New DataTable()
            da.Fill(printDT)
            con.Close()

            pdBorrowSlip.Print()

        Catch ex As Exception
            MsgBox("Error printing slip: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub pdBorrowSlip_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles pdBorrowSlip.PrintPage
        If printDT.Rows.Count = 0 Then Exit Sub

        Dim g As Graphics = e.Graphics
        Dim row As DataRow = printDT.Rows(0)
        Dim y As Integer = 50
        Dim left As Integer = 50

        Dim titleFont As New Font("Arial", 14, FontStyle.Bold)
        Dim headerFont As New Font("Arial", 11, FontStyle.Bold)
        Dim dataFont As New Font("Arial", 10, FontStyle.Regular)

        g.DrawString("PE Sports Equipment Monitoring & Inventory System", titleFont, Brushes.Black, left, y)
        y += 25
        g.DrawString("EQUIPMENT BORROWING SLIP", headerFont, Brushes.Black, left, y)
        y += 20
        g.DrawLine(Pens.Black, left, y, 550, y)
        y += 15

        g.DrawString("Transaction Code : " & row("TransactionCode").ToString(), dataFont, Brushes.Black, left, y)
        y += 20
        g.DrawString("Date Printed     : " & DateTime.Now.ToString("MM/dd/yyyy"), dataFont, Brushes.Black, left, y)
        y += 25
        g.DrawLine(Pens.Black, left, y, 550, y)
        y += 15

        g.DrawString("STUDENT INFORMATION", headerFont, Brushes.Black, left, y)
        y += 20
        g.DrawString("Name      : " & row("Student").ToString(), dataFont, Brushes.Black, left, y)
        y += 20
        g.DrawString("LRN       : " & row("StudentLRN").ToString(), dataFont, Brushes.Black, left, y)
        y += 20
        g.DrawString("Grade     : " & row("GradeLevel").ToString(), dataFont, Brushes.Black, left, y)
        y += 20
        g.DrawString("Section   : " & row("Section").ToString(), dataFont, Brushes.Black, left, y)
        y += 25
        g.DrawLine(Pens.Black, left, y, 550, y)
        y += 15

        g.DrawString("EQUIPMENT INFORMATION", headerFont, Brushes.Black, left, y)
        y += 20
        g.DrawString("Equipment : " & row("EquipmentName").ToString(), dataFont, Brushes.Black, left, y)
        y += 20
        g.DrawString("Code      : " & row("EquipmentCode").ToString(), dataFont, Brushes.Black, left, y)
        y += 20
        g.DrawString("Quantity  : " & row("QuantityBorrowed").ToString(), dataFont, Brushes.Black, left, y)
        y += 20
        g.DrawString("Borrowed  : " & row("DateBorrowed").ToString(), dataFont, Brushes.Black, left, y)
        y += 20
        g.DrawString("Due Date  : " & row("DueDate").ToString(), dataFont, Brushes.Black, left, y)
        y += 20
        g.DrawString("Status    : " & row("Status").ToString(), dataFont, Brushes.Black, left, y)
        y += 20
        g.DrawString("Remarks   : " & row("Remarks").ToString(), dataFont, Brushes.Black, left, y)
        y += 30
        g.DrawLine(Pens.Black, left, y, 550, y)
        y += 30

        g.DrawString("Received by:", dataFont, Brushes.Black, left, y)
        g.DrawString("Released by:", dataFont, Brushes.Black, 350, y)
        y += 40
        g.DrawLine(Pens.Black, left, y, 250, y)
        g.DrawLine(Pens.Black, 350, y, 550, y)
        y += 10
        g.DrawString("Student Signature", dataFont, Brushes.Black, left, y)
        g.DrawString("PE Teacher / Admin", dataFont, Brushes.Black, 350, y)

        e.HasMorePages = False
    End Sub

    ' Paste this anywhere inside your Class frmEquipment
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000 ' Turn on WS_EX_COMPOSITED
            Return cp
        End Get
    End Property
End Class