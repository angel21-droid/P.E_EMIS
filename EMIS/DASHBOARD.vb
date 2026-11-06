Imports System.Data.SqlClient

Public Class frmDashboard

    Private Sub frmDashboard_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadDashboardData()
    End Sub

    Public Sub LoadDashboardData()
        Try
            Dim con As SqlConnection = GetConnection()
            con.Open()

            Dim cmdTotal As New SqlCommand("SELECT ISNULL(SUM(TotalQuantity), 0) FROM tbl_Equipment", con)
            lblTotalEquipment.Text = cmdTotal.ExecuteScalar().ToString()

            Dim cmdAvailable As New SqlCommand("SELECT ISNULL(SUM(AvailableQuantity), 0) FROM tbl_Equipment", con)
            lblAvailable.Text = cmdAvailable.ExecuteScalar().ToString()

            Dim cmdBorrowed As New SqlCommand("SELECT COUNT(*) FROM tbl_Borrowing WHERE Status = 'Borrowed'", con)
            lblBorrowed.Text = cmdBorrowed.ExecuteScalar().ToString()

            Dim cmdDamaged As New SqlCommand("SELECT COUNT(*) FROM tbl_DamagedLost", con)
            lblDamaged.Text = cmdDamaged.ExecuteScalar().ToString()

            Dim sql As String = "SELECT TOP 10 b.TransactionCode, " &
                    "s.FirstName + ' ' + s.LastName AS Student, " &
                    "s.GradeLevel + ' - ' + s.Section AS Section, " &
                    "e.EquipmentName, " &
                    "CONVERT(VARCHAR, b.DateBorrowed, 101) AS DateBorrowed, " &
                    "CONVERT(VARCHAR, b.ExpectedReturnDate, 101) AS DueDate, " &
                    "b.Status " &
                    "FROM tbl_Borrowing b " &
                    "INNER JOIN tbl_Students s ON b.StudentID = s.StudentID " &
                    "INNER JOIN tbl_Equipment e ON b.EquipmentID = e.EquipmentID " &
                    "ORDER BY b.DateRecorded DESC"

            Dim cmdRecent As New SqlCommand(sql, con)
            Dim da As New SqlDataAdapter(cmdRecent)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvRecentActivity.DataSource = dt

            If dgvRecentActivity.Columns.Count > 0 Then
                dgvRecentActivity.Columns("TransactionCode").HeaderText = "Trans. Code"
                dgvRecentActivity.Columns("Student").HeaderText = "Student Name"
                dgvRecentActivity.Columns("Section").HeaderText = "Section"
                dgvRecentActivity.Columns("EquipmentName").HeaderText = "Equipment"
                dgvRecentActivity.Columns("DateBorrowed").HeaderText = "Date Borrowed"
                dgvRecentActivity.Columns("DueDate").HeaderText = "Due Date"
                dgvRecentActivity.Columns("Status").HeaderText = "Status"
            End If

            con.Close()

        Catch ex As Exception
            MsgBox("Error loading dashboard: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
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