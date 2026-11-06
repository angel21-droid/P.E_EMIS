Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class frmReports

    Dim printDT As New DataTable
    Dim reportTitle As String = ""

    Private Sub frmReports_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Set default date range
        dtpReportFrom.Value = New DateTime(DateTime.Now.Year, 1, 1)
        dtpReportTo.Value = DateTime.Now

        ' Set default radio button
        rdoInventoryList.Checked = True

        ' Style datagridview
        dgvReport.ReadOnly = True
        dgvReport.AllowUserToAddRows = False
        dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReport.RowHeadersVisible = False
        dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    '==========================================
    ' GENERATE REPORT
    '==========================================
    Private Sub btnGenerateReport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerateReport.Click
        If rdoInventoryList.Checked Then
            GenerateInventoryList()
        ElseIf rdoBorrowingRecords.Checked Then
            GenerateBorrowingRecords()
        ElseIf rdoOverdue.Checked Then
            GenerateOverdueReport()
        ElseIf rdoDamagedLost.Checked Then
            GenerateDamagedLostReport()
        End If
    End Sub

    '==========================================
    ' REPORT 1 — EQUIPMENT INVENTORY LIST
    '==========================================
    Private Sub GenerateInventoryList()
        Try
            reportTitle = "Equipment Inventory List"
            Dim con As SqlConnection = GetConnection()
            con.Open()

            Dim sql As String = "SELECT EquipmentCode AS 'Code', " &
                                "EquipmentName AS 'Equipment Name', " &
                                "Category, " &
                                "TotalQuantity AS 'Total Qty', " &
                                "AvailableQuantity AS 'Available Qty', " &
                                "Condition, Status, " &
                                "CONVERT(VARCHAR, DateAcquired, 101) AS 'Date Acquired', " &
                                "Remarks " &
                                "FROM tbl_Equipment " &
                                "ORDER BY EquipmentName ASC"

            Dim da As New SqlDataAdapter(sql, con)
            printDT = New DataTable()
            da.Fill(printDT)
            dgvReport.DataSource = printDT
            con.Close()

            MsgBox("Report generated! " & printDT.Rows.Count & " record(s) found.", MsgBoxStyle.Information, "Report Ready")

        Catch ex As Exception
            MsgBox("Error generating report: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    '==========================================
    ' REPORT 2 — BORROWING RECORDS REPORT
    '==========================================
    Private Sub GenerateBorrowingRecords()
        Try
            reportTitle = "Borrowing Records Report"
            Dim con As SqlConnection = GetConnection()
            con.Open()

            Dim sql As String = "SELECT b.TransactionCode AS 'Trans. Code', " &
                                "s.FirstName + ' ' + s.LastName AS 'Student Name', " &
                                "s.GradeLevel + ' - ' + s.Section AS 'Section', " &
                                "e.EquipmentName AS 'Equipment', " &
                                "b.QuantityBorrowed AS 'Qty', " &
                                "CONVERT(VARCHAR, b.DateBorrowed, 101) AS 'Date Borrowed', " &
                                "CONVERT(VARCHAR, b.ExpectedReturnDate, 101) AS 'Due Date', " &
                                "CONVERT(VARCHAR, b.ActualReturnDate, 101) AS 'Return Date', " &
                                "b.ConditionOnReturn AS 'Condition', " &
                                "b.Status, b.Remarks " &
                                "FROM tbl_Borrowing b " &
                                "INNER JOIN tbl_Students s ON b.StudentID = s.StudentID " &
                                "INNER JOIN tbl_Equipment e ON b.EquipmentID = e.EquipmentID " &
                                "WHERE b.DateBorrowed BETWEEN @From AND @To " &
                                "ORDER BY b.DateBorrowed DESC"

            Dim cmd As New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@From", dtpReportFrom.Value.Date)
            cmd.Parameters.AddWithValue("@To", dtpReportTo.Value.Date.AddDays(1))

            Dim da As New SqlDataAdapter(cmd)
            printDT = New DataTable()
            da.Fill(printDT)
            dgvReport.DataSource = printDT
            con.Close()

            MsgBox("Report generated! " & printDT.Rows.Count & " record(s) found.", MsgBoxStyle.Information, "Report Ready")

        Catch ex As Exception
            MsgBox("Error generating report: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    '==========================================
    ' REPORT 3 — OVERDUE ITEMS REPORT
    '==========================================
    Private Sub GenerateOverdueReport()
        Try
            reportTitle = "Overdue Items Report"
            Dim con As SqlConnection = GetConnection()
            con.Open()

            Dim sql As String = "SELECT b.TransactionCode AS 'Trans. Code', " &
                                "s.FirstName + ' ' + s.LastName AS 'Student Name', " &
                                "s.GradeLevel + ' - ' + s.Section AS 'Section', " &
                                "s.StudentLRN AS 'LRN', " &
                                "e.EquipmentName AS 'Equipment', " &
                                "b.QuantityBorrowed AS 'Qty Borrowed', " &
                                "CONVERT(VARCHAR, b.DateBorrowed, 101) AS 'Date Borrowed', " &
                                "CONVERT(VARCHAR, b.ExpectedReturnDate, 101) AS 'Due Date', " &
                                "DATEDIFF(day, b.ExpectedReturnDate, GETDATE()) AS 'Days Overdue', " &
                                "b.Status " &
                                "FROM tbl_Borrowing b " &
                                "INNER JOIN tbl_Students s ON b.StudentID = s.StudentID " &
                                "INNER JOIN tbl_Equipment e ON b.EquipmentID = e.EquipmentID " &
                                "WHERE b.Status = 'Borrowed' " &
                                "AND b.ExpectedReturnDate < GETDATE() " &
                                "ORDER BY b.ExpectedReturnDate ASC"

            Dim da As New SqlDataAdapter(sql, con)
            printDT = New DataTable()
            da.Fill(printDT)
            dgvReport.DataSource = printDT
            con.Close()

            If printDT.Rows.Count = 0 Then
                MsgBox("No overdue items found!", MsgBoxStyle.Information, "Report Ready")
            Else
                MsgBox("Report generated! " & printDT.Rows.Count & " overdue record(s) found.", MsgBoxStyle.Exclamation, "Overdue Items Found")
            End If

        Catch ex As Exception
            MsgBox("Error generating report: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    '==========================================
    ' REPORT 4 — DAMAGED / LOST REPORT
    '==========================================
    Private Sub GenerateDamagedLostReport()
        Try
            reportTitle = "Damaged / Lost Equipment Report"
            Dim con As SqlConnection = GetConnection()
            con.Open()

            Dim sql As String = "SELECT EquipmentCode AS 'Code', " &
                                "EquipmentName AS 'Equipment Name', " &
                                "Category, " &
                                "TotalQuantity AS 'Total Qty', " &
                                "AvailableQuantity AS 'Available Qty', " &
                                "Condition, Status, " &
                                "Remarks " &
                                "FROM tbl_Equipment " &
                                "WHERE Condition IN ('Damaged', 'For Disposal') " &
                                "OR Status IN ('Under Repair', 'Retired') " &
                                "ORDER BY Condition ASC"

            Dim da As New SqlDataAdapter(sql, con)
            printDT = New DataTable()
            da.Fill(printDT)
            dgvReport.DataSource = printDT
            con.Close()

            MsgBox("Report generated! " & printDT.Rows.Count & " record(s) found.", MsgBoxStyle.Information, "Report Ready")

        Catch ex As Exception
            MsgBox("Error generating report: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    '==========================================
    ' PRINT PREVIEW
    '==========================================
    Private Sub btnPrintPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrintPreview.Click
        If printDT Is Nothing OrElse printDT.Rows.Count = 0 Then
            MsgBox("Please generate a report first before previewing.", MsgBoxStyle.Exclamation, "No Data")
            Exit Sub
        End If

        ppvReport.Document = pdReport
        ppvReport.ShowDialog()
    End Sub

    '==========================================
    ' PRINT NOW
    '==========================================
    Private Sub btnPrintReport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrintReport.Click
        If printDT Is Nothing OrElse printDT.Rows.Count = 0 Then
            MsgBox("Please generate a report first before printing.", MsgBoxStyle.Exclamation, "No Data")
            Exit Sub
        End If

        Dim confirm As MsgBoxResult
        confirm = MsgBox("Send report to printer?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Print Report")
        If confirm = MsgBoxResult.Yes Then
            pdReport.Print()
        End If
    End Sub

    '==========================================
    ' PRINT DOCUMENT — PAGE LAYOUT
    '==========================================
    Private Sub pdReport_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles pdReport.PrintPage
        If printDT Is Nothing OrElse printDT.Rows.Count = 0 Then Exit Sub

        Dim g As Graphics = e.Graphics
        Dim y As Integer = 40
        Dim leftMargin As Integer = 40
        Dim pageWidth As Integer = 750

        Dim titleFont As New Font("Arial", 13, FontStyle.Bold)
        Dim subFont As New Font("Arial", 10, FontStyle.Bold)
        Dim dataFont As New Font("Arial", 8, FontStyle.Regular)
        Dim headerFont As New Font("Arial", 8, FontStyle.Bold)

        ' Header
        g.DrawString("PE Sports Equipment Monitoring & Inventory System", titleFont, Brushes.Black, leftMargin, y)
        y += 22
        g.DrawString(reportTitle, subFont, Brushes.Black, leftMargin, y)
        y += 18
        g.DrawString("Date Generated: " & DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"), dataFont, Brushes.Black, leftMargin, y)

        If rdoBorrowingRecords.Checked Then
            g.DrawString("   Period: " & dtpReportFrom.Value.ToString("MM/dd/yyyy") & " to " & dtpReportTo.Value.ToString("MM/dd/yyyy"), dataFont, Brushes.Black, 300, y)
        End If

        y += 5
        g.DrawLine(Pens.Black, leftMargin, y, pageWidth, y)
        y += 10

        ' Calculate column widths
        Dim colCount As Integer = printDT.Columns.Count
        Dim colWidth As Integer = (pageWidth - leftMargin) \ colCount

        ' Column headers
        Dim x As Integer = leftMargin
        For Each col As DataColumn In printDT.Columns
            g.DrawString(col.ColumnName, headerFont, Brushes.Black, x, y)
            x += colWidth
        Next
        y += 5
        g.DrawLine(Pens.Black, leftMargin, y, pageWidth, y)
        y += 8

        ' Data rows
        Dim rowCount As Integer = 0
        For Each row As DataRow In printDT.Rows
            x = leftMargin
            For Each col As DataColumn In printDT.Columns
                Dim cellValue As String = row(col).ToString()
                ' Trim long text to fit column
                If cellValue.Length > 15 Then
                    cellValue = cellValue.Substring(0, 15) & ".."
                End If
                g.DrawString(cellValue, dataFont, Brushes.Black, x, y)
                x += colWidth
            Next
            y += 16
            rowCount += 1

            ' Check if page is full
            If y > 1020 Then
                e.HasMorePages = True
                Exit Sub
            End If
        Next

        ' Footer
        y += 10
        g.DrawLine(Pens.Black, leftMargin, y, pageWidth, y)
        y += 10
        g.DrawString("Total Records: " & printDT.Rows.Count.ToString(), dataFont, Brushes.Black, leftMargin, y)
        g.DrawString("Printed by: Admin", dataFont, Brushes.Black, 600, y)

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