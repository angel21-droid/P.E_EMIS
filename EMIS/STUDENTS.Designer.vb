<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudents))
        Me.txtSearchStudent = New System.Windows.Forms.TextBox()
        Me.lblSearchStudent = New System.Windows.Forms.Label()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClearStudent = New System.Windows.Forms.Button()
        Me.btnDeleteStudent = New System.Windows.Forms.Button()
        Me.btnUpdateStudent = New System.Windows.Forms.Button()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.cboGradeLevel = New System.Windows.Forms.ComboBox()
        Me.lblGradeLevel = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtStudentLRN = New System.Windows.Forms.TextBox()
        Me.lblStudentLRN = New System.Windows.Forms.Label()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContent.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSearchStudent
        '
        Me.txtSearchStudent.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchStudent.Location = New System.Drawing.Point(561, 89)
        Me.txtSearchStudent.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearchStudent.Name = "txtSearchStudent"
        Me.txtSearchStudent.Size = New System.Drawing.Size(216, 29)
        Me.txtSearchStudent.TabIndex = 806
        '
        'lblSearchStudent
        '
        Me.lblSearchStudent.AutoSize = True
        Me.lblSearchStudent.BackColor = System.Drawing.Color.White
        Me.lblSearchStudent.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchStudent.Location = New System.Drawing.Point(483, 92)
        Me.lblSearchStudent.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSearchStudent.Name = "lblSearchStudent"
        Me.lblSearchStudent.Size = New System.Drawing.Size(70, 21)
        Me.lblSearchStudent.TabIndex = 805
        Me.lblSearchStudent.Text = "Search:"
        '
        'dgvStudents
        '
        Me.dgvStudents.AllowUserToAddRows = False
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Location = New System.Drawing.Point(541, 135)
        Me.dgvStudents.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.ReadOnly = True
        Me.dgvStudents.RowTemplate.Height = 24
        Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudents.Size = New System.Drawing.Size(702, 316)
        Me.dgvStudents.TabIndex = 807
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.Transparent
        Me.pnlContent.Controls.Add(Me.GroupBox1)
        Me.pnlContent.Controls.Add(Me.dgvStudents)
        Me.pnlContent.Controls.Add(Me.txtSearchStudent)
        Me.pnlContent.Controls.Add(Me.lblSearchStudent)
        Me.pnlContent.Location = New System.Drawing.Point(2, 0)
        Me.pnlContent.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1262, 821)
        Me.pnlContent.TabIndex = 808
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnClearStudent)
        Me.GroupBox1.Controls.Add(Me.btnDeleteStudent)
        Me.GroupBox1.Controls.Add(Me.btnUpdateStudent)
        Me.GroupBox1.Controls.Add(Me.btnAddStudent)
        Me.GroupBox1.Controls.Add(Me.txtSection)
        Me.GroupBox1.Controls.Add(Me.lblSection)
        Me.GroupBox1.Controls.Add(Me.cboGradeLevel)
        Me.GroupBox1.Controls.Add(Me.lblGradeLevel)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.lblLastName)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.lblFirstName)
        Me.GroupBox1.Controls.Add(Me.txtStudentLRN)
        Me.GroupBox1.Controls.Add(Me.lblStudentLRN)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 135)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(452, 475)
        Me.GroupBox1.TabIndex = 819
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 21)
        Me.Label1.TabIndex = 819
        Me.Label1.Text = "Section:"
        '
        'btnClearStudent
        '
        Me.btnClearStudent.BackColor = System.Drawing.Color.SteelBlue
        Me.btnClearStudent.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearStudent.Location = New System.Drawing.Point(348, 350)
        Me.btnClearStudent.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClearStudent.Name = "btnClearStudent"
        Me.btnClearStudent.Size = New System.Drawing.Size(91, 32)
        Me.btnClearStudent.TabIndex = 818
        Me.btnClearStudent.Text = "Clear"
        Me.btnClearStudent.UseVisualStyleBackColor = False
        '
        'btnDeleteStudent
        '
        Me.btnDeleteStudent.BackColor = System.Drawing.Color.SteelBlue
        Me.btnDeleteStudent.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteStudent.Location = New System.Drawing.Point(253, 350)
        Me.btnDeleteStudent.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteStudent.Name = "btnDeleteStudent"
        Me.btnDeleteStudent.Size = New System.Drawing.Size(91, 32)
        Me.btnDeleteStudent.TabIndex = 817
        Me.btnDeleteStudent.Text = "Delete"
        Me.btnDeleteStudent.UseVisualStyleBackColor = False
        '
        'btnUpdateStudent
        '
        Me.btnUpdateStudent.BackColor = System.Drawing.Color.SteelBlue
        Me.btnUpdateStudent.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateStudent.Location = New System.Drawing.Point(158, 350)
        Me.btnUpdateStudent.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdateStudent.Name = "btnUpdateStudent"
        Me.btnUpdateStudent.Size = New System.Drawing.Size(91, 32)
        Me.btnUpdateStudent.TabIndex = 816
        Me.btnUpdateStudent.Text = "Update"
        Me.btnUpdateStudent.UseVisualStyleBackColor = False
        '
        'btnAddStudent
        '
        Me.btnAddStudent.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAddStudent.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStudent.Location = New System.Drawing.Point(63, 350)
        Me.btnAddStudent.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(91, 32)
        Me.btnAddStudent.TabIndex = 815
        Me.btnAddStudent.Text = "Add"
        Me.btnAddStudent.UseVisualStyleBackColor = False
        '
        'txtSection
        '
        Me.txtSection.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection.Location = New System.Drawing.Point(204, 248)
        Me.txtSection.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(216, 29)
        Me.txtSection.TabIndex = 814
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.Location = New System.Drawing.Point(-94, 305)
        Me.lblSection.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(73, 21)
        Me.lblSection.TabIndex = 813
        Me.lblSection.Text = "Section:"
        '
        'cboGradeLevel
        '
        Me.cboGradeLevel.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGradeLevel.FormattingEnabled = True
        Me.cboGradeLevel.Items.AddRange(New Object() {"Grade 7", "Grade 8", "Grade 9", "Grade 10", "Grade 11", "Grade 12"})
        Me.cboGradeLevel.Location = New System.Drawing.Point(202, 210)
        Me.cboGradeLevel.Margin = New System.Windows.Forms.Padding(2)
        Me.cboGradeLevel.Name = "cboGradeLevel"
        Me.cboGradeLevel.Size = New System.Drawing.Size(216, 30)
        Me.cboGradeLevel.TabIndex = 812
        '
        'lblGradeLevel
        '
        Me.lblGradeLevel.AutoSize = True
        Me.lblGradeLevel.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeLevel.Location = New System.Drawing.Point(33, 214)
        Me.lblGradeLevel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGradeLevel.Name = "lblGradeLevel"
        Me.lblGradeLevel.Size = New System.Drawing.Size(111, 21)
        Me.lblGradeLevel.TabIndex = 811
        Me.lblGradeLevel.Text = "Grade Level:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(202, 175)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(216, 29)
        Me.txtLastName.TabIndex = 810
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(29, 179)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(101, 21)
        Me.lblLastName.TabIndex = 809
        Me.lblLastName.Text = "Last Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(202, 139)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(216, 29)
        Me.txtFirstName.TabIndex = 808
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(29, 143)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(105, 21)
        Me.lblFirstName.TabIndex = 807
        Me.lblFirstName.Text = "First Name:"
        '
        'txtStudentLRN
        '
        Me.txtStudentLRN.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentLRN.Location = New System.Drawing.Point(202, 104)
        Me.txtStudentLRN.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStudentLRN.Name = "txtStudentLRN"
        Me.txtStudentLRN.Size = New System.Drawing.Size(216, 29)
        Me.txtStudentLRN.TabIndex = 806
        '
        'lblStudentLRN
        '
        Me.lblStudentLRN.AutoSize = True
        Me.lblStudentLRN.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentLRN.Location = New System.Drawing.Point(29, 107)
        Me.lblStudentLRN.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStudentLRN.Name = "lblStudentLRN"
        Me.lblStudentLRN.Size = New System.Drawing.Size(147, 21)
        Me.lblStudentLRN.TabIndex = 805
        Me.lblStudentLRN.Text = "Student Records:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1040, 640)
        Me.Controls.Add(Me.pnlContent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmStudents"
        Me.Text = "STUDENTS"
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSearchStudent As System.Windows.Forms.TextBox
    Friend WithEvents lblSearchStudent As System.Windows.Forms.Label
    Friend WithEvents dgvStudents As System.Windows.Forms.DataGridView
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClearStudent As System.Windows.Forms.Button
    Friend WithEvents btnDeleteStudent As System.Windows.Forms.Button
    Friend WithEvents btnUpdateStudent As System.Windows.Forms.Button
    Friend WithEvents btnAddStudent As System.Windows.Forms.Button
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents lblSection As System.Windows.Forms.Label
    Friend WithEvents cboGradeLevel As System.Windows.Forms.ComboBox
    Friend WithEvents lblGradeLevel As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtStudentLRN As System.Windows.Forms.TextBox
    Friend WithEvents lblStudentLRN As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
