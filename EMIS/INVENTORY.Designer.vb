<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEquipment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEquipment))
        Me.lblEquipmentCode = New System.Windows.Forms.Label()
        Me.txtEquipmentCode = New System.Windows.Forms.TextBox()
        Me.txtEquipmentName = New System.Windows.Forms.TextBox()
        Me.lblEquipmentName = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.lblTotalQty = New System.Windows.Forms.Label()
        Me.nudTotalQty = New System.Windows.Forms.NumericUpDown()
        Me.lblAvailableQty = New System.Windows.Forms.Label()
        Me.nudAvailableQty = New System.Windows.Forms.NumericUpDown()
        Me.lblCondition = New System.Windows.Forms.Label()
        Me.cboCondition = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.lblDateAcquired = New System.Windows.Forms.Label()
        Me.dtpDateAcquired = New System.Windows.Forms.DateTimePicker()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnPrintList = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cboFilterCategory = New System.Windows.Forms.ComboBox()
        Me.cboFilterStatus = New System.Windows.Forms.ComboBox()
        Me.dgvEquipment = New System.Windows.Forms.DataGridView()
        Me.pdEquipment = New System.Drawing.Printing.PrintDocument()
        Me.ppvEquipment = New System.Windows.Forms.PrintPreviewDialog()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.lblRecordCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.nudTotalQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAvailableQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContent.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEquipmentCode
        '
        Me.lblEquipmentCode.AutoSize = True
        Me.lblEquipmentCode.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquipmentCode.Location = New System.Drawing.Point(47, 29)
        Me.lblEquipmentCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEquipmentCode.Name = "lblEquipmentCode"
        Me.lblEquipmentCode.Size = New System.Drawing.Size(147, 21)
        Me.lblEquipmentCode.TabIndex = 46
        Me.lblEquipmentCode.Text = "Equipment Code:"
        '
        'txtEquipmentCode
        '
        Me.txtEquipmentCode.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEquipmentCode.Location = New System.Drawing.Point(220, 25)
        Me.txtEquipmentCode.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEquipmentCode.Name = "txtEquipmentCode"
        Me.txtEquipmentCode.ReadOnly = True
        Me.txtEquipmentCode.Size = New System.Drawing.Size(216, 29)
        Me.txtEquipmentCode.TabIndex = 781
        '
        'txtEquipmentName
        '
        Me.txtEquipmentName.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEquipmentName.Location = New System.Drawing.Point(220, 58)
        Me.txtEquipmentName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEquipmentName.Name = "txtEquipmentName"
        Me.txtEquipmentName.Size = New System.Drawing.Size(216, 29)
        Me.txtEquipmentName.TabIndex = 783
        '
        'lblEquipmentName
        '
        Me.lblEquipmentName.AutoSize = True
        Me.lblEquipmentName.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquipmentName.Location = New System.Drawing.Point(47, 61)
        Me.lblEquipmentName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEquipmentName.Name = "lblEquipmentName"
        Me.lblEquipmentName.Size = New System.Drawing.Size(153, 21)
        Me.lblEquipmentName.TabIndex = 782
        Me.lblEquipmentName.Text = "Equipment Name:"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(47, 93)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(85, 21)
        Me.lblCategory.TabIndex = 784
        Me.lblCategory.Text = "Category:"
        '
        'cboCategory
        '
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(220, 89)
        Me.cboCategory.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(216, 30)
        Me.cboCategory.TabIndex = 785
        '
        'lblTotalQty
        '
        Me.lblTotalQty.AutoSize = True
        Me.lblTotalQty.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalQty.Location = New System.Drawing.Point(47, 124)
        Me.lblTotalQty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalQty.Name = "lblTotalQty"
        Me.lblTotalQty.Size = New System.Drawing.Size(130, 21)
        Me.lblTotalQty.TabIndex = 786
        Me.lblTotalQty.Text = "Total Quantity:"
        '
        'nudTotalQty
        '
        Me.nudTotalQty.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTotalQty.Location = New System.Drawing.Point(220, 124)
        Me.nudTotalQty.Margin = New System.Windows.Forms.Padding(2)
        Me.nudTotalQty.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudTotalQty.Name = "nudTotalQty"
        Me.nudTotalQty.Size = New System.Drawing.Size(214, 29)
        Me.nudTotalQty.TabIndex = 787
        Me.nudTotalQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblAvailableQty
        '
        Me.lblAvailableQty.AutoSize = True
        Me.lblAvailableQty.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailableQty.Location = New System.Drawing.Point(46, 161)
        Me.lblAvailableQty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAvailableQty.Name = "lblAvailableQty"
        Me.lblAvailableQty.Size = New System.Drawing.Size(159, 21)
        Me.lblAvailableQty.TabIndex = 788
        Me.lblAvailableQty.Text = "Available Quantity:"
        '
        'nudAvailableQty
        '
        Me.nudAvailableQty.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudAvailableQty.Location = New System.Drawing.Point(220, 159)
        Me.nudAvailableQty.Margin = New System.Windows.Forms.Padding(2)
        Me.nudAvailableQty.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudAvailableQty.Name = "nudAvailableQty"
        Me.nudAvailableQty.Size = New System.Drawing.Size(214, 29)
        Me.nudAvailableQty.TabIndex = 789
        Me.nudAvailableQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblCondition
        '
        Me.lblCondition.AutoSize = True
        Me.lblCondition.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCondition.Location = New System.Drawing.Point(46, 194)
        Me.lblCondition.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCondition.Name = "lblCondition"
        Me.lblCondition.Size = New System.Drawing.Size(92, 21)
        Me.lblCondition.TabIndex = 790
        Me.lblCondition.Text = "Condition:"
        '
        'cboCondition
        '
        Me.cboCondition.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCondition.FormattingEnabled = True
        Me.cboCondition.Items.AddRange(New Object() {" Good", " Fair", " Damaged", "For Disposal"})
        Me.cboCondition.Location = New System.Drawing.Point(220, 193)
        Me.cboCondition.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCondition.Name = "cboCondition"
        Me.cboCondition.Size = New System.Drawing.Size(216, 30)
        Me.cboCondition.TabIndex = 791
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(46, 228)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(65, 21)
        Me.lblStatus.TabIndex = 792
        Me.lblStatus.Text = "Status:"
        '
        'cboStatus
        '
        Me.cboStatus.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Available", " Borrowed", "Under Repair", " Retired"})
        Me.cboStatus.Location = New System.Drawing.Point(220, 228)
        Me.cboStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(216, 30)
        Me.cboStatus.TabIndex = 793
        '
        'lblDateAcquired
        '
        Me.lblDateAcquired.AutoSize = True
        Me.lblDateAcquired.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateAcquired.Location = New System.Drawing.Point(47, 263)
        Me.lblDateAcquired.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDateAcquired.Name = "lblDateAcquired"
        Me.lblDateAcquired.Size = New System.Drawing.Size(129, 21)
        Me.lblDateAcquired.TabIndex = 794
        Me.lblDateAcquired.Text = "Date Acquired:"
        '
        'dtpDateAcquired
        '
        Me.dtpDateAcquired.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateAcquired.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateAcquired.Location = New System.Drawing.Point(220, 260)
        Me.dtpDateAcquired.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDateAcquired.Name = "dtpDateAcquired"
        Me.dtpDateAcquired.Size = New System.Drawing.Size(215, 29)
        Me.dtpDateAcquired.TabIndex = 795
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemarks.Location = New System.Drawing.Point(46, 292)
        Me.lblRemarks.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(88, 21)
        Me.lblRemarks.TabIndex = 796
        Me.lblRemarks.Text = "Remarks:"
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(220, 293)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(216, 41)
        Me.txtRemarks.TabIndex = 797
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAdd.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(48, 350)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(91, 32)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.SteelBlue
        Me.btnUpdate.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(143, 350)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(91, 32)
        Me.btnUpdate.TabIndex = 798
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.SteelBlue
        Me.btnDelete.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(238, 350)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(91, 32)
        Me.btnDelete.TabIndex = 799
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SteelBlue
        Me.btnClear.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(333, 350)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 32)
        Me.btnClear.TabIndex = 800
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnPrintList
        '
        Me.btnPrintList.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPrintList.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintList.Location = New System.Drawing.Point(1004, 722)
        Me.btnPrintList.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrintList.Name = "btnPrintList"
        Me.btnPrintList.Size = New System.Drawing.Size(92, 46)
        Me.btnPrintList.TabIndex = 801
        Me.btnPrintList.Text = "Print List"
        Me.btnPrintList.UseVisualStyleBackColor = False
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.BackColor = System.Drawing.Color.White
        Me.lblSearch.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.Black
        Me.lblSearch.Location = New System.Drawing.Point(55, 30)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(70, 21)
        Me.lblSearch.TabIndex = 802
        Me.lblSearch.Text = "Search:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(134, 28)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(220, 29)
        Me.txtSearch.TabIndex = 803
        '
        'cboFilterCategory
        '
        Me.cboFilterCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterCategory.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFilterCategory.FormattingEnabled = True
        Me.cboFilterCategory.Items.AddRange(New Object() {"All Categories + categories"})
        Me.cboFilterCategory.Location = New System.Drawing.Point(489, 26)
        Me.cboFilterCategory.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFilterCategory.Name = "cboFilterCategory"
        Me.cboFilterCategory.Size = New System.Drawing.Size(216, 30)
        Me.cboFilterCategory.TabIndex = 804
        '
        'cboFilterStatus
        '
        Me.cboFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterStatus.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFilterStatus.FormattingEnabled = True
        Me.cboFilterStatus.Items.AddRange(New Object() {"All Status", "Available", "Borrowed", "Under Repair", "Retired"})
        Me.cboFilterStatus.Location = New System.Drawing.Point(822, 26)
        Me.cboFilterStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFilterStatus.Name = "cboFilterStatus"
        Me.cboFilterStatus.Size = New System.Drawing.Size(216, 30)
        Me.cboFilterStatus.TabIndex = 805
        '
        'dgvEquipment
        '
        Me.dgvEquipment.AllowUserToAddRows = False
        Me.dgvEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEquipment.Location = New System.Drawing.Point(539, 121)
        Me.dgvEquipment.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvEquipment.Name = "dgvEquipment"
        Me.dgvEquipment.ReadOnly = True
        Me.dgvEquipment.RowTemplate.Height = 24
        Me.dgvEquipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEquipment.Size = New System.Drawing.Size(670, 392)
        Me.dgvEquipment.TabIndex = 806
        '
        'ppvEquipment
        '
        Me.ppvEquipment.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ppvEquipment.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ppvEquipment.ClientSize = New System.Drawing.Size(400, 300)
        Me.ppvEquipment.Enabled = True
        Me.ppvEquipment.Icon = CType(resources.GetObject("ppvEquipment.Icon"), System.Drawing.Icon)
        Me.ppvEquipment.Name = "ppvEquipment"
        Me.ppvEquipment.Visible = False
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.Transparent
        Me.pnlContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlContent.Controls.Add(Me.lblRecordCount)
        Me.pnlContent.Controls.Add(Me.cboFilterCategory)
        Me.pnlContent.Controls.Add(Me.Label1)
        Me.pnlContent.Controls.Add(Me.cboFilterStatus)
        Me.pnlContent.Controls.Add(Me.GroupBox1)
        Me.pnlContent.Controls.Add(Me.Label2)
        Me.pnlContent.Controls.Add(Me.dgvEquipment)
        Me.pnlContent.Controls.Add(Me.btnPrintList)
        Me.pnlContent.Controls.Add(Me.txtSearch)
        Me.pnlContent.Controls.Add(Me.lblSearch)
        Me.pnlContent.Location = New System.Drawing.Point(-1, 0)
        Me.pnlContent.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1278, 795)
        Me.pnlContent.TabIndex = 807
        '
        'lblRecordCount
        '
        Me.lblRecordCount.AutoSize = True
        Me.lblRecordCount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecordCount.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblRecordCount.Location = New System.Drawing.Point(535, 515)
        Me.lblRecordCount.Name = "lblRecordCount"
        Me.lblRecordCount.Size = New System.Drawing.Size(60, 21)
        Me.lblRecordCount.TabIndex = 809
        Me.lblRecordCount.Text = "Label3"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(400, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 21)
        Me.Label1.TabIndex = 805
        Me.Label1.Text = "Category:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.txtRemarks)
        Me.GroupBox1.Controls.Add(Me.lblEquipmentCode)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.txtEquipmentCode)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.lblEquipmentName)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.txtEquipmentName)
        Me.GroupBox1.Controls.Add(Me.lblCategory)
        Me.GroupBox1.Controls.Add(Me.cboCategory)
        Me.GroupBox1.Controls.Add(Me.lblRemarks)
        Me.GroupBox1.Controls.Add(Me.lblTotalQty)
        Me.GroupBox1.Controls.Add(Me.dtpDateAcquired)
        Me.GroupBox1.Controls.Add(Me.nudTotalQty)
        Me.GroupBox1.Controls.Add(Me.lblDateAcquired)
        Me.GroupBox1.Controls.Add(Me.lblAvailableQty)
        Me.GroupBox1.Controls.Add(Me.cboStatus)
        Me.GroupBox1.Controls.Add(Me.nudAvailableQty)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.lblCondition)
        Me.GroupBox1.Controls.Add(Me.cboCondition)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 121)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(475, 392)
        Me.GroupBox1.TabIndex = 808
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(749, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 21)
        Me.Label2.TabIndex = 807
        Me.Label2.Text = "Status:"
        '
        'frmEquipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1040, 640)
        Me.Controls.Add(Me.pnlContent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmEquipment"
        Me.Text = "Form6"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.nudTotalQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAvailableQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEquipment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblEquipmentCode As System.Windows.Forms.Label
    Friend WithEvents txtEquipmentCode As System.Windows.Forms.TextBox
    Friend WithEvents txtEquipmentName As System.Windows.Forms.TextBox
    Friend WithEvents lblEquipmentName As System.Windows.Forms.Label
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents lblTotalQty As System.Windows.Forms.Label
    Friend WithEvents nudTotalQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblAvailableQty As System.Windows.Forms.Label
    Friend WithEvents nudAvailableQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblCondition As System.Windows.Forms.Label
    Friend WithEvents cboCondition As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblDateAcquired As System.Windows.Forms.Label
    Friend WithEvents dtpDateAcquired As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRemarks As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnPrintList As System.Windows.Forms.Button
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cboFilterCategory As System.Windows.Forms.ComboBox
    Friend WithEvents cboFilterStatus As System.Windows.Forms.ComboBox
    Friend WithEvents dgvEquipment As System.Windows.Forms.DataGridView
    Friend WithEvents pdEquipment As System.Drawing.Printing.PrintDocument
    Friend WithEvents ppvEquipment As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblRecordCount As System.Windows.Forms.Label
End Class
