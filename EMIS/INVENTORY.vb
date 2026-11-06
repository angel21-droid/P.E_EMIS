Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class frmEquipment

    Dim printDT As New DataTable
    Dim printRowIndex As Integer = 0

    ' NOTE: Make sure you have a function named GetConnection() in a Module 
    ' or change it to your actual connection string variable.

    Private Sub frmEquipment_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadCategories()
        LoadConditions()
        LoadStatuses()
        LoadFilterCategories()
        LoadFilterStatuses()
        GenerateEquipmentCode()
        LoadEquipment()
    End Sub

    '==========================================
    ' REFRESH DASHBOARD IF OPEN
    '==========================================
    Private Sub RefreshDashboard()
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is frmDashboard Then
                CType(frm, frmDashboard).LoadDashboardData()
            End If
        Next
    End Sub

    '==========================================
    ' LOAD COMBOBOXES
    '==========================================
    Private Sub LoadCategories()
        cboCategory.Items.Clear()
        cboCategory.Items.Add("Ball Sports")
        cboCategory.Items.Add("Net Sports")
        cboCategory.Items.Add("Racket Sports")
        cboCategory.Items.Add("Track & Field")
        cboCategory.Items.Add("Gymnastics")
        cboCategory.Items.Add("Others")
        cboCategory.SelectedIndex = 0
    End Sub

    Private Sub LoadConditions()
        cboCondition.Items.Clear()
        cboCondition.Items.Add("Good")
        cboCondition.Items.Add("Fair")
        cboCondition.Items.Add("Damaged")
        cboCondition.Items.Add("For Disposal")
        cboCondition.SelectedIndex = 0
    End Sub

    Private Sub LoadStatuses()
        cboStatus.Items.Clear()
        cboStatus.Items.Add("Available")
        cboStatus.Items.Add("Borrowed")
        cboStatus.Items.Add("Under Repair")
        cboStatus.Items.Add("Retired")
        cboStatus.SelectedIndex = 0
    End Sub

    Private Sub LoadFilterCategories()
        cboFilterCategory.Items.Clear()
        cboFilterCategory.Items.Add("All Categories")
        cboFilterCategory.Items.Add("Ball Sports")
        cboFilterCategory.Items.Add("Net Sports")
        cboFilterCategory.Items.Add("Racket Sports")
        cboFilterCategory.Items.Add("Track & Field")
        cboFilterCategory.Items.Add("Gymnastics")
        cboFilterCategory.Items.Add("Others")
        cboFilterCategory.SelectedIndex = 0
    End Sub

    Private Sub LoadFilterStatuses()
        cboFilterStatus.Items.Clear()
        cboFilterStatus.Items.Add("All Status")
        cboFilterStatus.Items.Add("Available")
        cboFilterStatus.Items.Add("Borrowed")
        cboFilterStatus.Items.Add("Under Repair")
        cboFilterStatus.Items.Add("Retired")
        cboFilterStatus.SelectedIndex = 0
    End Sub

    '==========================================
    ' AUTO GENERATE EQUIPMENT CODE
    '==========================================
    Private Sub GenerateEquipmentCode()
        Try
            Dim con As SqlConnection = GetConnection()
            con.Open()

            Dim cmd As New SqlCommand("SELECT ISNULL(MAX(CAST(SUBSTRING(EquipmentCode, 9, LEN(EquipmentCode)) AS INT)), 0) FROM tbl_Equipment", con)
            Dim maxNum As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            con.Close()

            Dim year As String = DateTime.Now.Year.ToString()
            Dim num As String = (maxNum + 1).ToString("D3")
            txtEquipmentCode.Text = "EQ-" & year & "-" & num
            txtEquipmentCode.ReadOnly = True

        Catch ex As Exception
            MsgBox("Error generating code: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    '==========================================
    ' LOAD EQUIPMENT INTO DATAGRIDVIEW
    '==========================================
    Private Sub LoadEquipment()
        Try
            Dim con As SqlConnection = GetConnection()
            con.Open()

            Dim sql As String = "SELECT EquipmentID, EquipmentCode, EquipmentName, " & _
                                "Category, TotalQuantity, AvailableQuantity, " & _
                                "Condition, Status, DateAcquired, Remarks " & _
                                "FROM tbl_Equipment ORDER BY EquipmentName ASC"

            Dim da As New SqlDataAdapter(sql, con)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgvEquipment.DataSource = dt

            ' Formatting the Grid
            If dgvEquipment.Columns.Contains("EquipmentID") Then dgvEquipment.Columns("EquipmentID").Visible = False

            dgvEquipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvEquipment.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvEquipment.ReadOnly = True
            dgvEquipment.AllowUserToAddRows = False
            dgvEquipment.RowHeadersVisible = False

            con.Close()

            ' FIX: This now points to your Label control
            lblRecordCount.Text = "Total Records: " & dgvEquipment.Rows.Count.ToString()

        Catch ex As Exception
            MsgBox("Error loading equipment: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ClearFields()
        GenerateEquipmentCode()
        txtEquipmentName.Text = ""
        cboCategory.SelectedIndex = 0
        nudTotalQty.Value = 1
        nudAvailableQty.Value = 1
        cboCondition.SelectedIndex = 0
        cboStatus.SelectedIndex = 0
        dtpDateAcquired.Value = DateTime.Now
        txtRemarks.Text = ""
        txtSearch.Text = ""
        cboFilterCategory.SelectedIndex = 0
        cboFilterStatus.SelectedIndex = 0
        btnAdd.Enabled = True
        dgvEquipment.ClearSelection()
    End Sub

    Private Function ValidateFields() As Boolean
        If txtEquipmentName.Text.Trim = "" Then
            MsgBox("Please enter Equipment Name.", MsgBoxStyle.Exclamation, "Validation")
            txtEquipmentName.Focus()
            Return False
        End If
        Return True
    End Function

    '==========================================
    ' BUTTON ACTIONS
    '==========================================
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        If Not ValidateFields() Then Exit Sub
        Try
            Dim con As SqlConnection = GetConnection()
            con.Open()
            Dim sql As String = "INSERT INTO tbl_Equipment (EquipmentCode, EquipmentName, Category, TotalQuantity, AvailableQuantity, Condition, Status, DateAcquired, Remarks, DateAdded) VALUES (@Code, @Name, @Category, @TotalQty, @AvailQty, @Condition, @Status, @DateAcquired, @Remarks, @DateAdded)"
            Dim cmd As New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@Code", txtEquipmentCode.Text.Trim)
            cmd.Parameters.AddWithValue("@Name", txtEquipmentName.Text.Trim)
            cmd.Parameters.AddWithValue("@Category", cboCategory.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@TotalQty", CInt(nudTotalQty.Value))
            cmd.Parameters.AddWithValue("@AvailQty", CInt(nudAvailableQty.Value))
            cmd.Parameters.AddWithValue("@Condition", cboCondition.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Status", cboStatus.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@DateAcquired", dtpDateAcquired.Value)
            cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text.Trim)
            cmd.Parameters.AddWithValue("@DateAdded", DateTime.Now)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Equipment added!", MsgBoxStyle.Information)
            ClearFields()
            LoadEquipment()
            RefreshDashboard()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    '==========================================
    ' SEARCH & FILTER LOGIC
    '==========================================
    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSearch.TextChanged
        ApplyFilter()
    End Sub

    Private Sub cboFilterCategory_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboFilterCategory.SelectedIndexChanged
        ApplyFilter()
    End Sub

    Private Sub cboFilterStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboFilterStatus.SelectedIndexChanged
        ApplyFilter()
    End Sub

    Private Sub ApplyFilter()
        Try
            Dim con As SqlConnection = GetConnection()
            con.Open()
            Dim sql As String = "SELECT * FROM tbl_Equipment WHERE 1=1"

            If txtSearch.Text.Trim <> "" Then
                sql &= " AND (EquipmentName LIKE @Search OR EquipmentCode LIKE @Search)"
            End If

            If cboFilterCategory.SelectedIndex > 0 Then
                sql &= " AND Category = @Cat"
            End If

            If cboFilterStatus.SelectedIndex > 0 Then
                sql &= " AND Status = @Stat"
            End If

            Dim cmd As New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text.Trim & "%")
            If cboFilterCategory.SelectedIndex > 0 Then cmd.Parameters.AddWithValue("@Cat", cboFilterCategory.Text)
            If cboFilterStatus.SelectedIndex > 0 Then cmd.Parameters.AddWithValue("@Stat", cboFilterStatus.Text)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvEquipment.DataSource = dt
            con.Close()

            lblRecordCount.Text = "Total Records: " & dgvEquipment.Rows.Count.ToString()
        Catch ex As Exception
            ' Silent error handling for filters
        End Try
    End Sub

    '==========================================
    ' DATA SELECTION
    '==========================================
    Private Sub dgvEquipment_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvEquipment.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvEquipment.Rows(e.RowIndex)
            txtEquipmentCode.Text = row.Cells("EquipmentCode").Value.ToString()
            txtEquipmentName.Text = row.Cells("EquipmentName").Value.ToString()
            cboCategory.SelectedItem = row.Cells("Category").Value.ToString()
            nudTotalQty.Value = Convert.ToInt32(row.Cells("TotalQuantity").Value)
            nudAvailableQty.Value = Convert.ToInt32(row.Cells("AvailableQuantity").Value)
            cboCondition.SelectedItem = row.Cells("Condition").Value.ToString()
            cboStatus.SelectedItem = row.Cells("Status").Value.ToString()
            dtpDateAcquired.Value = Convert.ToDateTime(row.Cells("DateAcquired").Value)
            txtRemarks.Text = row.Cells("Remarks").Value.ToString()
            btnAdd.Enabled = False
        End If
    End Sub
    ' Paste this anywhere inside your Class frmEquipment
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000 ' Turn on WS_EX_COMPOSITED
            Return cp
        End Get
    End Property
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        ' 1. Basic Validation
        If Not ValidateFields() Then Exit Sub

        ' 2. Confirmation
        Dim ask As MsgBoxResult = MsgBox("Are you sure you want to update this equipment record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Update")
        If ask = MsgBoxResult.No Then Exit Sub

        Try
            Using con As SqlConnection = GetConnection()
                con.Open()
                ' We use EquipmentCode to find the right record
                Dim sql As String = "UPDATE tbl_Equipment SET EquipmentName=@Name, Category=@Cat, TotalQuantity=@Total, " & _
                                   "AvailableQuantity=@Avail, Condition=@Cond, Status=@Stat, DateAcquired=@Date, Remarks=@Rem " & _
                                   "WHERE EquipmentCode=@Code"

                Using cmd As New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@Name", txtEquipmentName.Text.Trim)
                    cmd.Parameters.AddWithValue("@Cat", cboCategory.Text)
                    cmd.Parameters.AddWithValue("@Total", CInt(nudTotalQty.Value))
                    cmd.Parameters.AddWithValue("@Avail", CInt(nudAvailableQty.Value))
                    cmd.Parameters.AddWithValue("@Cond", cboCondition.Text)
                    cmd.Parameters.AddWithValue("@Stat", cboStatus.Text)
                    cmd.Parameters.AddWithValue("@Date", dtpDateAcquired.Value)
                    cmd.Parameters.AddWithValue("@Rem", txtRemarks.Text.Trim)
                    cmd.Parameters.AddWithValue("@Code", txtEquipmentCode.Text.Trim)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Equipment updated successfully!", MsgBoxStyle.Information)
            LoadEquipment()     ' Refresh Grid
            RefreshDashboard()  ' Update Dashboard numbers
            ClearFields()       ' Reset form
        Catch ex As Exception
            MsgBox("Update Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ' 1. Check if an item is actually selected
        If txtEquipmentName.Text.Trim = "" Then
            MsgBox("Please select an equipment from the list first.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ' 2. Double Confirmation
        Dim ask As MsgBoxResult = MsgBox("Are you sure you want to DELETE " & txtEquipmentName.Text & "? This cannot be undone.", _
                                        MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Delete Warning")

        If ask = MsgBoxResult.Yes Then
            Try
                Using con As SqlConnection = GetConnection()
                    con.Open()
                    Dim sql As String = "DELETE FROM tbl_Equipment WHERE EquipmentCode=@Code"
                    Using cmd As New SqlCommand(sql, con)
                        cmd.Parameters.AddWithValue("@Code", txtEquipmentCode.Text.Trim)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MsgBox("Equipment has been removed from the system.", MsgBoxStyle.Information)
                LoadEquipment()     ' Refresh Grid
                RefreshDashboard()  ' Update Dashboard numbers
                ClearFields()       ' Reset form
            Catch ex As Exception
                MsgBox("Delete Error: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
End Class