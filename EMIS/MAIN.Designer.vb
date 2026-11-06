<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnNavStudents = New System.Windows.Forms.Button()
        Me.lblSystemTitle = New System.Windows.Forms.Label()
        Me.lblSystemSub = New System.Windows.Forms.Label()
        Me.btnNavLogout = New System.Windows.Forms.Button()
        Me.btnNavReports = New System.Windows.Forms.Button()
        Me.btnNavBorrowing = New System.Windows.Forms.Button()
        Me.btnNavEquipment = New System.Windows.Forms.Button()
        Me.btnNavDashboard = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnlogs = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnTopLogout = New System.Windows.Forms.Button()
        Me.btnToggle = New System.Windows.Forms.Button()
        Me.tmrAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.pnlSidebar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.btnNavStudents)
        Me.pnlSidebar.Controls.Add(Me.lblSystemTitle)
        Me.pnlSidebar.Controls.Add(Me.lblSystemSub)
        Me.pnlSidebar.Controls.Add(Me.btnNavLogout)
        Me.pnlSidebar.Controls.Add(Me.btnNavReports)
        Me.pnlSidebar.Controls.Add(Me.btnNavBorrowing)
        Me.pnlSidebar.Controls.Add(Me.btnNavEquipment)
        Me.pnlSidebar.Controls.Add(Me.btnNavDashboard)
        Me.pnlSidebar.Controls.Add(Me.PictureBox1)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(246, 609)
        Me.pnlSidebar.TabIndex = 0
        '
        'btnNavStudents
        '
        Me.btnNavStudents.BackColor = System.Drawing.Color.SteelBlue
        Me.btnNavStudents.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavStudents.Location = New System.Drawing.Point(10, 406)
        Me.btnNavStudents.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNavStudents.Name = "btnNavStudents"
        Me.btnNavStudents.Size = New System.Drawing.Size(219, 45)
        Me.btnNavStudents.TabIndex = 9
        Me.btnNavStudents.Text = "STUDENTS"
        Me.btnNavStudents.UseVisualStyleBackColor = False
        '
        'lblSystemTitle
        '
        Me.lblSystemTitle.AutoSize = True
        Me.lblSystemTitle.Font = New System.Drawing.Font("Bernard MT Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemTitle.Location = New System.Drawing.Point(43, 119)
        Me.lblSystemTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSystemTitle.Name = "lblSystemTitle"
        Me.lblSystemTitle.Size = New System.Drawing.Size(161, 28)
        Me.lblSystemTitle.TabIndex = 8
        Me.lblSystemTitle.Text = "Alegria's School"
        '
        'lblSystemSub
        '
        Me.lblSystemSub.AutoSize = True
        Me.lblSystemSub.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemSub.Location = New System.Drawing.Point(72, 148)
        Me.lblSystemSub.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSystemSub.Name = "lblSystemSub"
        Me.lblSystemSub.Size = New System.Drawing.Size(98, 14)
        Me.lblSystemSub.TabIndex = 7
        Me.lblSystemSub.Text = "PE Department"
        '
        'btnNavLogout
        '
        Me.btnNavLogout.BackColor = System.Drawing.Color.SteelBlue
        Me.btnNavLogout.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavLogout.Location = New System.Drawing.Point(10, 719)
        Me.btnNavLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNavLogout.Name = "btnNavLogout"
        Me.btnNavLogout.Size = New System.Drawing.Size(219, 50)
        Me.btnNavLogout.TabIndex = 6
        Me.btnNavLogout.Text = "LOGOUT"
        Me.btnNavLogout.UseVisualStyleBackColor = False
        '
        'btnNavReports
        '
        Me.btnNavReports.BackColor = System.Drawing.Color.SteelBlue
        Me.btnNavReports.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavReports.Location = New System.Drawing.Point(11, 462)
        Me.btnNavReports.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNavReports.Name = "btnNavReports"
        Me.btnNavReports.Size = New System.Drawing.Size(219, 51)
        Me.btnNavReports.TabIndex = 5
        Me.btnNavReports.Text = "REPORTS & PRINT"
        Me.btnNavReports.UseVisualStyleBackColor = False
        '
        'btnNavBorrowing
        '
        Me.btnNavBorrowing.BackColor = System.Drawing.Color.SteelBlue
        Me.btnNavBorrowing.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavBorrowing.Location = New System.Drawing.Point(10, 345)
        Me.btnNavBorrowing.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNavBorrowing.Name = "btnNavBorrowing"
        Me.btnNavBorrowing.Size = New System.Drawing.Size(219, 50)
        Me.btnNavBorrowing.TabIndex = 4
        Me.btnNavBorrowing.Text = "BORROWING RECORDS"
        Me.btnNavBorrowing.UseVisualStyleBackColor = False
        '
        'btnNavEquipment
        '
        Me.btnNavEquipment.BackColor = System.Drawing.Color.SteelBlue
        Me.btnNavEquipment.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavEquipment.Location = New System.Drawing.Point(10, 284)
        Me.btnNavEquipment.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNavEquipment.Name = "btnNavEquipment"
        Me.btnNavEquipment.Size = New System.Drawing.Size(219, 51)
        Me.btnNavEquipment.TabIndex = 3
        Me.btnNavEquipment.Text = "EQUIPMENT INVENTORY"
        Me.btnNavEquipment.UseVisualStyleBackColor = False
        '
        'btnNavDashboard
        '
        Me.btnNavDashboard.BackColor = System.Drawing.Color.SteelBlue
        Me.btnNavDashboard.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavDashboard.Location = New System.Drawing.Point(10, 225)
        Me.btnNavDashboard.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNavDashboard.Name = "btnNavDashboard"
        Me.btnNavDashboard.Size = New System.Drawing.Size(219, 46)
        Me.btnNavDashboard.TabIndex = 1
        Me.btnNavDashboard.Text = "DASHBOARD"
        Me.btnNavDashboard.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(61, 20)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.btnlogs)
        Me.pnlTop.Controls.Add(Me.btnTopLogout)
        Me.pnlTop.Controls.Add(Me.btnToggle)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(246, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(782, 39)
        Me.pnlTop.TabIndex = 2
        '
        'btnlogs
        '
        Me.btnlogs.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnlogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogs.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnlogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogs.ImageIndex = 0
        Me.btnlogs.ImageList = Me.ImageList1
        Me.btnlogs.Location = New System.Drawing.Point(55, 8)
        Me.btnlogs.Name = "btnlogs"
        Me.btnlogs.Size = New System.Drawing.Size(61, 28)
        Me.btnlogs.TabIndex = 2
        Me.btnlogs.Text = "Logs"
        Me.btnlogs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlogs.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "user-plus.png")
        '
        'btnTopLogout
        '
        Me.btnTopLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTopLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTopLogout.ForeColor = System.Drawing.Color.Red
        Me.btnTopLogout.Location = New System.Drawing.Point(695, 11)
        Me.btnTopLogout.Name = "btnTopLogout"
        Me.btnTopLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnTopLogout.TabIndex = 1
        Me.btnTopLogout.Text = "LOGOUT"
        Me.btnTopLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTopLogout.UseVisualStyleBackColor = True
        '
        'btnToggle
        '
        Me.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToggle.Location = New System.Drawing.Point(7, 8)
        Me.btnToggle.Name = "btnToggle"
        Me.btnToggle.Size = New System.Drawing.Size(31, 28)
        Me.btnToggle.TabIndex = 0
        Me.btnToggle.Text = "≡"
        Me.btnToggle.UseVisualStyleBackColor = True
        '
        'tmrAnimation
        '
        Me.tmrAnimation.Interval = 10
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlSidebar)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMain"
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnNavLogout As System.Windows.Forms.Button
    Friend WithEvents btnNavReports As System.Windows.Forms.Button
    Friend WithEvents btnNavBorrowing As System.Windows.Forms.Button
    Friend WithEvents btnNavEquipment As System.Windows.Forms.Button
    Friend WithEvents btnNavDashboard As System.Windows.Forms.Button
    Friend WithEvents lblSystemSub As System.Windows.Forms.Label
    Friend WithEvents lblSystemTitle As System.Windows.Forms.Label
    Friend WithEvents btnNavStudents As System.Windows.Forms.Button
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents btnToggle As System.Windows.Forms.Button
    Friend WithEvents tmrAnimation As System.Windows.Forms.Timer
    Friend WithEvents btnTopLogout As System.Windows.Forms.Button
    Friend WithEvents btnlogs As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
