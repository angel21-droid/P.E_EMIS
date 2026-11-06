Public Class frmMain
    ' Variables for the Hamburger Menu logic
    Dim isCollapsed As Boolean = False
    Dim maxWidth As Integer = 200
    Dim minWidth As Integer = 50

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Ensure panels stay on top of the MDI background
        pnlTop.BringToFront()
        pnlSidebar.BringToFront()

        ' Style the sidebar and topbar
        pnlSidebar.BackColor = Color.SkyBlue
        pnlTop.BackColor = Color.CornflowerBlue
        If modGlobal.CurrentUserRole = "ADMIN" Then
            btnlogs.Visible = True
        Else
            btnlogs.Visible = False
        End If

        ' Style nav buttons
        StyleNavButton(btnNavDashboard)
        StyleNavButton(btnNavEquipment)
        StyleNavButton(btnNavBorrowing)
        StyleNavButton(btnNavStudents)
        StyleNavButton(btnNavReports)

        ' Style logout button
        btnNavLogout.BackColor = Color.FromArgb(163, 45, 45)
        btnNavLogout.ForeColor = Color.White
        btnNavLogout.FlatStyle = FlatStyle.Flat
        btnNavLogout.FlatAppearance.BorderSize = 0
        btnNavLogout.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        btnNavLogout.Cursor = Cursors.Hand
        btnNavLogout.TextAlign = ContentAlignment.MiddleLeft
        btnNavLogout.Padding = New Padding(10, 0, 0, 0)

        ' Open dashboard by default
        OpenChildForm(New frmDashboard())
        SetActiveButton(btnNavDashboard)
    End Sub

    ' ==========================================
    ' HAMBURGER MENU LOGIC
    ' ==========================================
    Private Sub tmrAnimation_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAnimation.Tick
        If isCollapsed Then
            pnlSidebar.Width += 20
            If pnlSidebar.Width >= maxWidth Then
                pnlSidebar.Width = maxWidth
                tmrAnimation.Stop()
                isCollapsed = False
            End If
        Else
            pnlSidebar.Width -= 20
            If pnlSidebar.Width <= minWidth Then
                pnlSidebar.Width = minWidth
                tmrAnimation.Stop()
                isCollapsed = True
            End If
        End If
    End Sub

    Private Sub btnToggle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToggle.Click
        tmrAnimation.Start()
    End Sub

    ' ==========================================
    ' STYLING & NAVIGATION METHODS
    ' ==========================================
    Private Sub StyleNavButton(ByVal btn As Button)
        btn.BackColor = Color.SkyBlue
        btn.ForeColor = Color.Black
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        btn.Cursor = Cursors.Hand
        btn.TextAlign = ContentAlignment.MiddleLeft
        btn.Padding = New Padding(10, 0, 0, 0)
        btn.TextImageRelation = TextImageRelation.ImageBeforeText
    End Sub

    Private Sub SetActiveButton(ByVal activeBtn As Button)
        StyleNavButton(btnNavDashboard)
        StyleNavButton(btnNavEquipment)
        StyleNavButton(btnNavBorrowing)
        StyleNavButton(btnNavStudents)
        StyleNavButton(btnNavReports)
        activeBtn.BackColor = Color.DeepSkyBlue
        activeBtn.Font = New Font("Segoe UI", 10, FontStyle.Bold)
    End Sub

    Private Sub OpenChildForm(ByVal frm As Form)
        If Me.ActiveMdiChild IsNot Nothing Then
            Me.ActiveMdiChild.Close()
        End If

        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Show()
    End Sub

    ' ==========================================
    ' NAV BUTTON CLICKS
    ' ==========================================
    Private Sub btnNavDashboard_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNavDashboard.Click
        OpenChildForm(New frmDashboard())
        SetActiveButton(btnNavDashboard)
    End Sub

    Private Sub btnNavEquipment_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNavEquipment.Click
        OpenChildForm(New frmEquipment())
        SetActiveButton(btnNavEquipment)
    End Sub

    Private Sub btnNavBorrowing_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNavBorrowing.Click
        OpenChildForm(New frmBorrowing())
        SetActiveButton(btnNavBorrowing)
    End Sub

    Private Sub btnNavStudents_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNavStudents.Click
        OpenChildForm(New frmStudents())
        SetActiveButton(btnNavStudents)
    End Sub

    Private Sub btnNavReports_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNavReports.Click
        OpenChildForm(New frmReports())
        SetActiveButton(btnNavReports)
    End Sub

    ' ==========================================
    ' LOGOUT & EXIT
    ' ==========================================
    Private Sub btnTopLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTopLogout.Click
        Dim confirm As MsgBoxResult = MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Logout")
        If confirm = MsgBoxResult.Yes Then
            frmLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Dim confirm As MsgBoxResult = MsgBox("Are you sure you want to exit the system?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Exit")
            If confirm = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub btnlogs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogs.Click
        LOGS.ShowDialog()
    End Sub
End Class