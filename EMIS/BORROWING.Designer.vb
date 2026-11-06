<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrowing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBorrowing))
        Me.txtTransactionCode = New System.Windows.Forms.TextBox()
        Me.lblTransactionCode = New System.Windows.Forms.Label()
        Me.lblBorrowStudent = New System.Windows.Forms.Label()
        Me.cboBorrowStudent = New System.Windows.Forms.ComboBox()
        Me.lblBorrowEquipment = New System.Windows.Forms.Label()
        Me.cboBorrowEquipment = New System.Windows.Forms.ComboBox()
        Me.lblQtyBorrowed = New System.Windows.Forms.Label()
        Me.nudQtyBorrowed = New System.Windows.Forms.NumericUpDown()
        Me.lblDateBorrowed = New System.Windows.Forms.Label()
        Me.dtpDateBorrowed = New System.Windows.Forms.DateTimePicker()
        Me.dtpExpectedReturn = New System.Windows.Forms.DateTimePicker()
        Me.lblExpectedReturn = New System.Windows.Forms.Label()
        Me.dtpActualReturn = New System.Windows.Forms.DateTimePicker()
        Me.lblActualReturn = New System.Windows.Forms.Label()
        Me.chkReturned = New System.Windows.Forms.CheckBox()
        Me.btnPrintSlip = New System.Windows.Forms.Button()
        Me.btnClearBorrow = New System.Windows.Forms.Button()
        Me.btnDeleteBorrow = New System.Windows.Forms.Button()
        Me.btnUpdateBorrow = New System.Windows.Forms.Button()
        Me.btnRecordBorrow = New System.Windows.Forms.Button()
        Me.txtSearchBorrow = New System.Windows.Forms.TextBox()
        Me.lblSearchBorrow = New System.Windows.Forms.Label()
        Me.cboFilterBorrowStatus = New System.Windows.Forms.ComboBox()
        Me.dtpFilterFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpFilterTo = New System.Windows.Forms.DateTimePicker()
        Me.btnFilterBorrow = New System.Windows.Forms.Button()
        Me.dgvBorrowing = New System.Windows.Forms.DataGridView()
        Me.pdBorrowSlip = New System.Drawing.Printing.PrintDocument()
        Me.ppvBorrowSlip = New System.Windows.Forms.PrintPreviewDialog()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nudQtyReturned = New System.Windows.Forms.NumericUpDown()
        Me.lblQtyReturned = New System.Windows.Forms.Label()
        Me.lblConditionReturn = New System.Windows.Forms.Label()
        Me.cboConditionReturn = New System.Windows.Forms.ComboBox()
        Me.cboBorrowStatus = New System.Windows.Forms.ComboBox()
        Me.lblBorrowStatus = New System.Windows.Forms.Label()
        Me.lblBorrowRemarks = New System.Windows.Forms.Label()
        Me.txtBorrowRemarks = New System.Windows.Forms.TextBox()
        CType(Me.nudQtyBorrowed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBorrowing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContent.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudQtyReturned, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTransactionCode
        '
        Me.txtTransactionCode.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionCode.Location = New System.Drawing.Point(244, 28)
        Me.txtTransactionCode.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTransactionCode.Name = "txtTransactionCode"
        Me.txtTransactionCode.ReadOnly = True
        Me.txtTransactionCode.Size = New System.Drawing.Size(216, 29)
        Me.txtTransactionCode.TabIndex = 783
        '
        'lblTransactionCode
        '
        Me.lblTransactionCode.AutoSize = True
        Me.lblTransactionCode.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactionCode.Location = New System.Drawing.Point(41, 33)
        Me.lblTransactionCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTransactionCode.Name = "lblTransactionCode"
        Me.lblTransactionCode.Size = New System.Drawing.Size(155, 21)
        Me.lblTransactionCode.TabIndex = 782
        Me.lblTransactionCode.Text = "Transaction Code:"
        '
        'lblBorrowStudent
        '
        Me.lblBorrowStudent.AutoSize = True
        Me.lblBorrowStudent.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowStudent.Location = New System.Drawing.Point(41, 68)
        Me.lblBorrowStudent.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBorrowStudent.Name = "lblBorrowStudent"
        Me.lblBorrowStudent.Size = New System.Drawing.Size(76, 21)
        Me.lblBorrowStudent.TabIndex = 784
        Me.lblBorrowStudent.Text = "Student:"
        '
        'cboBorrowStudent
        '
        Me.cboBorrowStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBorrowStudent.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBorrowStudent.FormattingEnabled = True
        Me.cboBorrowStudent.Location = New System.Drawing.Point(244, 61)
        Me.cboBorrowStudent.Margin = New System.Windows.Forms.Padding(2)
        Me.cboBorrowStudent.Name = "cboBorrowStudent"
        Me.cboBorrowStudent.Size = New System.Drawing.Size(216, 30)
        Me.cboBorrowStudent.TabIndex = 786
        '
        'lblBorrowEquipment
        '
        Me.lblBorrowEquipment.AutoSize = True
        Me.lblBorrowEquipment.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowEquipment.Location = New System.Drawing.Point(41, 102)
        Me.lblBorrowEquipment.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBorrowEquipment.Name = "lblBorrowEquipment"
        Me.lblBorrowEquipment.Size = New System.Drawing.Size(103, 21)
        Me.lblBorrowEquipment.TabIndex = 787
        Me.lblBorrowEquipment.Text = "Equipment:"
        '
        'cboBorrowEquipment
        '
        Me.cboBorrowEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBorrowEquipment.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBorrowEquipment.FormattingEnabled = True
        Me.cboBorrowEquipment.Location = New System.Drawing.Point(244, 93)
        Me.cboBorrowEquipment.Margin = New System.Windows.Forms.Padding(2)
        Me.cboBorrowEquipment.Name = "cboBorrowEquipment"
        Me.cboBorrowEquipment.Size = New System.Drawing.Size(216, 30)
        Me.cboBorrowEquipment.TabIndex = 788
        '
        'lblQtyBorrowed
        '
        Me.lblQtyBorrowed.AutoSize = True
        Me.lblQtyBorrowed.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtyBorrowed.Location = New System.Drawing.Point(41, 133)
        Me.lblQtyBorrowed.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQtyBorrowed.Name = "lblQtyBorrowed"
        Me.lblQtyBorrowed.Size = New System.Drawing.Size(84, 21)
        Me.lblQtyBorrowed.TabIndex = 789
        Me.lblQtyBorrowed.Text = "Quantity:"
        '
        'nudQtyBorrowed
        '
        Me.nudQtyBorrowed.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudQtyBorrowed.Location = New System.Drawing.Point(244, 125)
        Me.nudQtyBorrowed.Margin = New System.Windows.Forms.Padding(2)
        Me.nudQtyBorrowed.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudQtyBorrowed.Name = "nudQtyBorrowed"
        Me.nudQtyBorrowed.Size = New System.Drawing.Size(215, 29)
        Me.nudQtyBorrowed.TabIndex = 790
        Me.nudQtyBorrowed.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblDateBorrowed
        '
        Me.lblDateBorrowed.AutoSize = True
        Me.lblDateBorrowed.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateBorrowed.Location = New System.Drawing.Point(41, 165)
        Me.lblDateBorrowed.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDateBorrowed.Name = "lblDateBorrowed"
        Me.lblDateBorrowed.Size = New System.Drawing.Size(136, 21)
        Me.lblDateBorrowed.TabIndex = 791
        Me.lblDateBorrowed.Text = "Date Borrowed:"
        '
        'dtpDateBorrowed
        '
        Me.dtpDateBorrowed.CalendarFont = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateBorrowed.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateBorrowed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateBorrowed.Location = New System.Drawing.Point(245, 158)
        Me.dtpDateBorrowed.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDateBorrowed.Name = "dtpDateBorrowed"
        Me.dtpDateBorrowed.Size = New System.Drawing.Size(215, 29)
        Me.dtpDateBorrowed.TabIndex = 792
        '
        'dtpExpectedReturn
        '
        Me.dtpExpectedReturn.CalendarFont = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExpectedReturn.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExpectedReturn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExpectedReturn.Location = New System.Drawing.Point(244, 190)
        Me.dtpExpectedReturn.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpExpectedReturn.Name = "dtpExpectedReturn"
        Me.dtpExpectedReturn.Size = New System.Drawing.Size(215, 29)
        Me.dtpExpectedReturn.TabIndex = 794
        '
        'lblExpectedReturn
        '
        Me.lblExpectedReturn.AutoSize = True
        Me.lblExpectedReturn.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpectedReturn.Location = New System.Drawing.Point(41, 196)
        Me.lblExpectedReturn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblExpectedReturn.Name = "lblExpectedReturn"
        Me.lblExpectedReturn.Size = New System.Drawing.Size(192, 21)
        Me.lblExpectedReturn.TabIndex = 793
        Me.lblExpectedReturn.Text = "Expected Return Date:"
        '
        'dtpActualReturn
        '
        Me.dtpActualReturn.CalendarFont = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpActualReturn.Enabled = False
        Me.dtpActualReturn.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpActualReturn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpActualReturn.Location = New System.Drawing.Point(244, 223)
        Me.dtpActualReturn.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpActualReturn.Name = "dtpActualReturn"
        Me.dtpActualReturn.Size = New System.Drawing.Size(215, 29)
        Me.dtpActualReturn.TabIndex = 796
        '
        'lblActualReturn
        '
        Me.lblActualReturn.AutoSize = True
        Me.lblActualReturn.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualReturn.Location = New System.Drawing.Point(41, 228)
        Me.lblActualReturn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblActualReturn.Name = "lblActualReturn"
        Me.lblActualReturn.Size = New System.Drawing.Size(169, 21)
        Me.lblActualReturn.TabIndex = 795
        Me.lblActualReturn.Text = "Actual Return Date:"
        '
        'chkReturned
        '
        Me.chkReturned.AutoSize = True
        Me.chkReturned.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReturned.Location = New System.Drawing.Point(282, 254)
        Me.chkReturned.Margin = New System.Windows.Forms.Padding(2)
        Me.chkReturned.Name = "chkReturned"
        Me.chkReturned.Size = New System.Drawing.Size(151, 26)
        Me.chkReturned.TabIndex = 797
        Me.chkReturned.Text = "Mark as Returned"
        Me.chkReturned.UseVisualStyleBackColor = True
        '
        'btnPrintSlip
        '
        Me.btnPrintSlip.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPrintSlip.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintSlip.Location = New System.Drawing.Point(1126, 889)
        Me.btnPrintSlip.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrintSlip.Name = "btnPrintSlip"
        Me.btnPrintSlip.Size = New System.Drawing.Size(95, 46)
        Me.btnPrintSlip.TabIndex = 808
        Me.btnPrintSlip.Text = "Print List"
        Me.btnPrintSlip.UseVisualStyleBackColor = False
        '
        'btnClearBorrow
        '
        Me.btnClearBorrow.BackColor = System.Drawing.Color.SteelBlue
        Me.btnClearBorrow.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearBorrow.Location = New System.Drawing.Point(363, 481)
        Me.btnClearBorrow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClearBorrow.Name = "btnClearBorrow"
        Me.btnClearBorrow.Size = New System.Drawing.Size(91, 32)
        Me.btnClearBorrow.TabIndex = 807
        Me.btnClearBorrow.Text = "Clear"
        Me.btnClearBorrow.UseVisualStyleBackColor = False
        '
        'btnDeleteBorrow
        '
        Me.btnDeleteBorrow.BackColor = System.Drawing.Color.SteelBlue
        Me.btnDeleteBorrow.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteBorrow.Location = New System.Drawing.Point(268, 481)
        Me.btnDeleteBorrow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteBorrow.Name = "btnDeleteBorrow"
        Me.btnDeleteBorrow.Size = New System.Drawing.Size(91, 32)
        Me.btnDeleteBorrow.TabIndex = 806
        Me.btnDeleteBorrow.Text = "Delete"
        Me.btnDeleteBorrow.UseVisualStyleBackColor = False
        '
        'btnUpdateBorrow
        '
        Me.btnUpdateBorrow.BackColor = System.Drawing.Color.SteelBlue
        Me.btnUpdateBorrow.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateBorrow.Location = New System.Drawing.Point(173, 481)
        Me.btnUpdateBorrow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdateBorrow.Name = "btnUpdateBorrow"
        Me.btnUpdateBorrow.Size = New System.Drawing.Size(91, 32)
        Me.btnUpdateBorrow.TabIndex = 805
        Me.btnUpdateBorrow.Text = "Update"
        Me.btnUpdateBorrow.UseVisualStyleBackColor = False
        '
        'btnRecordBorrow
        '
        Me.btnRecordBorrow.BackColor = System.Drawing.Color.SteelBlue
        Me.btnRecordBorrow.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecordBorrow.Location = New System.Drawing.Point(43, 481)
        Me.btnRecordBorrow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRecordBorrow.Name = "btnRecordBorrow"
        Me.btnRecordBorrow.Size = New System.Drawing.Size(125, 32)
        Me.btnRecordBorrow.TabIndex = 804
        Me.btnRecordBorrow.Text = "Record Borrow"
        Me.btnRecordBorrow.UseVisualStyleBackColor = False
        '
        'txtSearchBorrow
        '
        Me.txtSearchBorrow.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBorrow.Location = New System.Drawing.Point(186, 89)
        Me.txtSearchBorrow.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearchBorrow.Name = "txtSearchBorrow"
        Me.txtSearchBorrow.ReadOnly = True
        Me.txtSearchBorrow.Size = New System.Drawing.Size(216, 29)
        Me.txtSearchBorrow.TabIndex = 810
        '
        'lblSearchBorrow
        '
        Me.lblSearchBorrow.AutoSize = True
        Me.lblSearchBorrow.BackColor = System.Drawing.Color.White
        Me.lblSearchBorrow.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchBorrow.Location = New System.Drawing.Point(108, 92)
        Me.lblSearchBorrow.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSearchBorrow.Name = "lblSearchBorrow"
        Me.lblSearchBorrow.Size = New System.Drawing.Size(70, 21)
        Me.lblSearchBorrow.TabIndex = 809
        Me.lblSearchBorrow.Text = "Search:"
        '
        'cboFilterBorrowStatus
        '
        Me.cboFilterBorrowStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterBorrowStatus.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFilterBorrowStatus.FormattingEnabled = True
        Me.cboFilterBorrowStatus.Items.AddRange(New Object() {"All", "Borrowed", "Returned", "Overdue", "Lost"})
        Me.cboFilterBorrowStatus.Location = New System.Drawing.Point(520, 88)
        Me.cboFilterBorrowStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFilterBorrowStatus.Name = "cboFilterBorrowStatus"
        Me.cboFilterBorrowStatus.Size = New System.Drawing.Size(173, 30)
        Me.cboFilterBorrowStatus.TabIndex = 811
        '
        'dtpFilterFrom
        '
        Me.dtpFilterFrom.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFilterFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFilterFrom.Location = New System.Drawing.Point(777, 88)
        Me.dtpFilterFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFilterFrom.Name = "dtpFilterFrom"
        Me.dtpFilterFrom.Size = New System.Drawing.Size(152, 29)
        Me.dtpFilterFrom.TabIndex = 812
        '
        'dtpFilterTo
        '
        Me.dtpFilterTo.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFilterTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFilterTo.Location = New System.Drawing.Point(984, 89)
        Me.dtpFilterTo.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFilterTo.Name = "dtpFilterTo"
        Me.dtpFilterTo.Size = New System.Drawing.Size(146, 29)
        Me.dtpFilterTo.TabIndex = 813
        '
        'btnFilterBorrow
        '
        Me.btnFilterBorrow.BackColor = System.Drawing.Color.SteelBlue
        Me.btnFilterBorrow.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilterBorrow.Location = New System.Drawing.Point(1134, 85)
        Me.btnFilterBorrow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFilterBorrow.Name = "btnFilterBorrow"
        Me.btnFilterBorrow.Size = New System.Drawing.Size(91, 32)
        Me.btnFilterBorrow.TabIndex = 814
        Me.btnFilterBorrow.Text = "Filter"
        Me.btnFilterBorrow.UseVisualStyleBackColor = False
        '
        'dgvBorrowing
        '
        Me.dgvBorrowing.AllowUserToAddRows = False
        Me.dgvBorrowing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBorrowing.Location = New System.Drawing.Point(546, 146)
        Me.dgvBorrowing.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvBorrowing.Name = "dgvBorrowing"
        Me.dgvBorrowing.ReadOnly = True
        Me.dgvBorrowing.RowTemplate.Height = 24
        Me.dgvBorrowing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBorrowing.Size = New System.Drawing.Size(757, 347)
        Me.dgvBorrowing.TabIndex = 815
        '
        'pdBorrowSlip
        '
        '
        'ppvBorrowSlip
        '
        Me.ppvBorrowSlip.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ppvBorrowSlip.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ppvBorrowSlip.ClientSize = New System.Drawing.Size(400, 300)
        Me.ppvBorrowSlip.Enabled = True
        Me.ppvBorrowSlip.Icon = CType(resources.GetObject("ppvBorrowSlip.Icon"), System.Drawing.Icon)
        Me.ppvBorrowSlip.Name = "ppvBorrowSlip"
        Me.ppvBorrowSlip.Visible = False
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.Transparent
        Me.pnlContent.Controls.Add(Me.Label3)
        Me.pnlContent.Controls.Add(Me.Label2)
        Me.pnlContent.Controls.Add(Me.Label1)
        Me.pnlContent.Controls.Add(Me.dgvBorrowing)
        Me.pnlContent.Controls.Add(Me.btnPrintSlip)
        Me.pnlContent.Controls.Add(Me.GroupBox1)
        Me.pnlContent.Controls.Add(Me.btnFilterBorrow)
        Me.pnlContent.Controls.Add(Me.txtSearchBorrow)
        Me.pnlContent.Controls.Add(Me.dtpFilterTo)
        Me.pnlContent.Controls.Add(Me.lblSearchBorrow)
        Me.pnlContent.Controls.Add(Me.dtpFilterFrom)
        Me.pnlContent.Controls.Add(Me.cboFilterBorrowStatus)
        Me.pnlContent.Location = New System.Drawing.Point(-1, -63)
        Me.pnlContent.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1447, 857)
        Me.pnlContent.TabIndex = 816
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(945, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 21)
        Me.Label3.TabIndex = 821
        Me.Label3.Text = "To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(717, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 21)
        Me.Label2.TabIndex = 820
        Me.Label2.Text = "From:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(450, 91)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 21)
        Me.Label1.TabIndex = 819
        Me.Label1.Text = "Status:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.btnClearBorrow)
        Me.GroupBox1.Controls.Add(Me.nudQtyReturned)
        Me.GroupBox1.Controls.Add(Me.btnDeleteBorrow)
        Me.GroupBox1.Controls.Add(Me.lblQtyReturned)
        Me.GroupBox1.Controls.Add(Me.btnUpdateBorrow)
        Me.GroupBox1.Controls.Add(Me.lblConditionReturn)
        Me.GroupBox1.Controls.Add(Me.btnRecordBorrow)
        Me.GroupBox1.Controls.Add(Me.cboConditionReturn)
        Me.GroupBox1.Controls.Add(Me.cboBorrowStatus)
        Me.GroupBox1.Controls.Add(Me.lblBorrowStatus)
        Me.GroupBox1.Controls.Add(Me.lblBorrowRemarks)
        Me.GroupBox1.Controls.Add(Me.txtBorrowRemarks)
        Me.GroupBox1.Controls.Add(Me.lblTransactionCode)
        Me.GroupBox1.Controls.Add(Me.txtTransactionCode)
        Me.GroupBox1.Controls.Add(Me.lblBorrowStudent)
        Me.GroupBox1.Controls.Add(Me.cboBorrowStudent)
        Me.GroupBox1.Controls.Add(Me.chkReturned)
        Me.GroupBox1.Controls.Add(Me.lblBorrowEquipment)
        Me.GroupBox1.Controls.Add(Me.dtpActualReturn)
        Me.GroupBox1.Controls.Add(Me.cboBorrowEquipment)
        Me.GroupBox1.Controls.Add(Me.lblActualReturn)
        Me.GroupBox1.Controls.Add(Me.lblQtyBorrowed)
        Me.GroupBox1.Controls.Add(Me.dtpExpectedReturn)
        Me.GroupBox1.Controls.Add(Me.nudQtyBorrowed)
        Me.GroupBox1.Controls.Add(Me.lblExpectedReturn)
        Me.GroupBox1.Controls.Add(Me.lblDateBorrowed)
        Me.GroupBox1.Controls.Add(Me.dtpDateBorrowed)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 146)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(494, 547)
        Me.GroupBox1.TabIndex = 818
        Me.GroupBox1.TabStop = False
        '
        'nudQtyReturned
        '
        Me.nudQtyReturned.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudQtyReturned.Location = New System.Drawing.Point(241, 284)
        Me.nudQtyReturned.Margin = New System.Windows.Forms.Padding(2)
        Me.nudQtyReturned.Name = "nudQtyReturned"
        Me.nudQtyReturned.Size = New System.Drawing.Size(215, 29)
        Me.nudQtyReturned.TabIndex = 817
        '
        'lblQtyReturned
        '
        Me.lblQtyReturned.AutoSize = True
        Me.lblQtyReturned.BackColor = System.Drawing.Color.Transparent
        Me.lblQtyReturned.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtyReturned.Location = New System.Drawing.Point(40, 286)
        Me.lblQtyReturned.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQtyReturned.Name = "lblQtyReturned"
        Me.lblQtyReturned.Size = New System.Drawing.Size(163, 21)
        Me.lblQtyReturned.TabIndex = 817
        Me.lblQtyReturned.Text = "Quantity Returned:"
        '
        'lblConditionReturn
        '
        Me.lblConditionReturn.AutoSize = True
        Me.lblConditionReturn.BackColor = System.Drawing.Color.Transparent
        Me.lblConditionReturn.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConditionReturn.Location = New System.Drawing.Point(40, 326)
        Me.lblConditionReturn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConditionReturn.Name = "lblConditionReturn"
        Me.lblConditionReturn.Size = New System.Drawing.Size(176, 21)
        Me.lblConditionReturn.TabIndex = 798
        Me.lblConditionReturn.Text = "Condition on Return:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cboConditionReturn
        '
        Me.cboConditionReturn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConditionReturn.Enabled = False
        Me.cboConditionReturn.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConditionReturn.FormattingEnabled = True
        Me.cboConditionReturn.Items.AddRange(New Object() {"Good", "Fair", "Damaged "})
        Me.cboConditionReturn.Location = New System.Drawing.Point(241, 318)
        Me.cboConditionReturn.Margin = New System.Windows.Forms.Padding(2)
        Me.cboConditionReturn.Name = "cboConditionReturn"
        Me.cboConditionReturn.Size = New System.Drawing.Size(216, 30)
        Me.cboConditionReturn.TabIndex = 799
        '
        'cboBorrowStatus
        '
        Me.cboBorrowStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBorrowStatus.Enabled = False
        Me.cboBorrowStatus.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBorrowStatus.FormattingEnabled = True
        Me.cboBorrowStatus.Items.AddRange(New Object() {"Borrowed", "Returned", "Overdue", "Lost"})
        Me.cboBorrowStatus.Location = New System.Drawing.Point(241, 352)
        Me.cboBorrowStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.cboBorrowStatus.Name = "cboBorrowStatus"
        Me.cboBorrowStatus.Size = New System.Drawing.Size(216, 30)
        Me.cboBorrowStatus.TabIndex = 801
        '
        'lblBorrowStatus
        '
        Me.lblBorrowStatus.AutoSize = True
        Me.lblBorrowStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblBorrowStatus.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowStatus.Location = New System.Drawing.Point(41, 355)
        Me.lblBorrowStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBorrowStatus.Name = "lblBorrowStatus"
        Me.lblBorrowStatus.Size = New System.Drawing.Size(65, 21)
        Me.lblBorrowStatus.TabIndex = 800
        Me.lblBorrowStatus.Text = "Status:"
        '
        'lblBorrowRemarks
        '
        Me.lblBorrowRemarks.AutoSize = True
        Me.lblBorrowRemarks.BackColor = System.Drawing.Color.Transparent
        Me.lblBorrowRemarks.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowRemarks.Location = New System.Drawing.Point(41, 393)
        Me.lblBorrowRemarks.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBorrowRemarks.Name = "lblBorrowRemarks"
        Me.lblBorrowRemarks.Size = New System.Drawing.Size(88, 21)
        Me.lblBorrowRemarks.TabIndex = 802
        Me.lblBorrowRemarks.Text = "Remarks:"
        '
        'txtBorrowRemarks
        '
        Me.txtBorrowRemarks.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowRemarks.Location = New System.Drawing.Point(241, 385)
        Me.txtBorrowRemarks.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBorrowRemarks.Multiline = True
        Me.txtBorrowRemarks.Name = "txtBorrowRemarks"
        Me.txtBorrowRemarks.ReadOnly = True
        Me.txtBorrowRemarks.Size = New System.Drawing.Size(216, 41)
        Me.txtBorrowRemarks.TabIndex = 803
        '
        'frmBorrowing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1324, 788)
        Me.Controls.Add(Me.pnlContent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmBorrowing"
        Me.Text = "BORROWING"
        CType(Me.nudQtyBorrowed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBorrowing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudQtyReturned, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtTransactionCode As System.Windows.Forms.TextBox
    Friend WithEvents lblTransactionCode As System.Windows.Forms.Label
    Friend WithEvents lblBorrowStudent As System.Windows.Forms.Label
    Friend WithEvents cboBorrowStudent As System.Windows.Forms.ComboBox
    Friend WithEvents lblBorrowEquipment As System.Windows.Forms.Label
    Friend WithEvents cboBorrowEquipment As System.Windows.Forms.ComboBox
    Friend WithEvents lblQtyBorrowed As System.Windows.Forms.Label
    Friend WithEvents nudQtyBorrowed As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblDateBorrowed As System.Windows.Forms.Label
    Friend WithEvents dtpDateBorrowed As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpExpectedReturn As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblExpectedReturn As System.Windows.Forms.Label
    Friend WithEvents dtpActualReturn As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblActualReturn As System.Windows.Forms.Label
    Friend WithEvents chkReturned As System.Windows.Forms.CheckBox
    Friend WithEvents btnPrintSlip As System.Windows.Forms.Button
    Friend WithEvents btnClearBorrow As System.Windows.Forms.Button
    Friend WithEvents btnDeleteBorrow As System.Windows.Forms.Button
    Friend WithEvents btnUpdateBorrow As System.Windows.Forms.Button
    Friend WithEvents btnRecordBorrow As System.Windows.Forms.Button
    Friend WithEvents txtSearchBorrow As System.Windows.Forms.TextBox
    Friend WithEvents lblSearchBorrow As System.Windows.Forms.Label
    Friend WithEvents cboFilterBorrowStatus As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFilterFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFilterTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnFilterBorrow As System.Windows.Forms.Button
    Friend WithEvents dgvBorrowing As System.Windows.Forms.DataGridView
    Friend WithEvents pdBorrowSlip As System.Drawing.Printing.PrintDocument
    Friend WithEvents ppvBorrowSlip As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents nudQtyReturned As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblQtyReturned As System.Windows.Forms.Label
    Friend WithEvents lblConditionReturn As System.Windows.Forms.Label
    Friend WithEvents cboConditionReturn As System.Windows.Forms.ComboBox
    Friend WithEvents cboBorrowStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblBorrowStatus As System.Windows.Forms.Label
    Friend WithEvents lblBorrowRemarks As System.Windows.Forms.Label
    Friend WithEvents txtBorrowRemarks As System.Windows.Forms.TextBox
End Class
