<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReports))
        Me.grpReportType = New System.Windows.Forms.GroupBox()
        Me.rdoDamagedLost = New System.Windows.Forms.RadioButton()
        Me.rdoOverdue = New System.Windows.Forms.RadioButton()
        Me.rdoBorrowingRecords = New System.Windows.Forms.RadioButton()
        Me.rdoInventoryList = New System.Windows.Forms.RadioButton()
        Me.grpDateFilter = New System.Windows.Forms.GroupBox()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.btnPrintReport = New System.Windows.Forms.Button()
        Me.btnPrintPreview = New System.Windows.Forms.Button()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        Me.dtpReportTo = New System.Windows.Forms.DateTimePicker()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.dtpReportFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.pdReport = New System.Drawing.Printing.PrintDocument()
        Me.ppvReport = New System.Windows.Forms.PrintPreviewDialog()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.grpReportType.SuspendLayout()
        Me.grpDateFilter.SuspendLayout()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpReportType
        '
        Me.grpReportType.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpReportType.Controls.Add(Me.rdoDamagedLost)
        Me.grpReportType.Controls.Add(Me.rdoOverdue)
        Me.grpReportType.Controls.Add(Me.rdoBorrowingRecords)
        Me.grpReportType.Controls.Add(Me.rdoInventoryList)
        Me.grpReportType.Location = New System.Drawing.Point(161, 36)
        Me.grpReportType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpReportType.Name = "grpReportType"
        Me.grpReportType.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpReportType.Size = New System.Drawing.Size(872, 93)
        Me.grpReportType.TabIndex = 43
        Me.grpReportType.TabStop = False
        Me.grpReportType.Text = "Report Type"
        '
        'rdoDamagedLost
        '
        Me.rdoDamagedLost.AutoSize = True
        Me.rdoDamagedLost.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoDamagedLost.Location = New System.Drawing.Point(667, 44)
        Me.rdoDamagedLost.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdoDamagedLost.Name = "rdoDamagedLost"
        Me.rdoDamagedLost.Size = New System.Drawing.Size(186, 26)
        Me.rdoDamagedLost.TabIndex = 3
        Me.rdoDamagedLost.Text = "Damaged / Lost Report"
        Me.rdoDamagedLost.UseVisualStyleBackColor = True
        '
        'rdoOverdue
        '
        Me.rdoOverdue.AutoSize = True
        Me.rdoOverdue.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoOverdue.Location = New System.Drawing.Point(463, 44)
        Me.rdoOverdue.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdoOverdue.Name = "rdoOverdue"
        Me.rdoOverdue.Size = New System.Drawing.Size(177, 26)
        Me.rdoOverdue.TabIndex = 2
        Me.rdoOverdue.Text = "Overdue Items Report"
        Me.rdoOverdue.UseVisualStyleBackColor = True
        '
        'rdoBorrowingRecords
        '
        Me.rdoBorrowingRecords.AutoSize = True
        Me.rdoBorrowingRecords.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoBorrowingRecords.Location = New System.Drawing.Point(237, 44)
        Me.rdoBorrowingRecords.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdoBorrowingRecords.Name = "rdoBorrowingRecords"
        Me.rdoBorrowingRecords.Size = New System.Drawing.Size(206, 26)
        Me.rdoBorrowingRecords.TabIndex = 1
        Me.rdoBorrowingRecords.Text = "Borrowing Records Report"
        Me.rdoBorrowingRecords.UseVisualStyleBackColor = True
        '
        'rdoInventoryList
        '
        Me.rdoInventoryList.AutoSize = True
        Me.rdoInventoryList.Checked = True
        Me.rdoInventoryList.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoInventoryList.Location = New System.Drawing.Point(26, 44)
        Me.rdoInventoryList.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdoInventoryList.Name = "rdoInventoryList"
        Me.rdoInventoryList.Size = New System.Drawing.Size(203, 26)
        Me.rdoInventoryList.TabIndex = 0
        Me.rdoInventoryList.TabStop = True
        Me.rdoInventoryList.Text = "Equipment Inventory List"
        Me.rdoInventoryList.UseVisualStyleBackColor = True
        '
        'grpDateFilter
        '
        Me.grpDateFilter.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpDateFilter.Controls.Add(Me.dgvReport)
        Me.grpDateFilter.Controls.Add(Me.btnPrintReport)
        Me.grpDateFilter.Controls.Add(Me.btnPrintPreview)
        Me.grpDateFilter.Controls.Add(Me.btnGenerateReport)
        Me.grpDateFilter.Controls.Add(Me.dtpReportTo)
        Me.grpDateFilter.Controls.Add(Me.lblToDate)
        Me.grpDateFilter.Controls.Add(Me.dtpReportFrom)
        Me.grpDateFilter.Controls.Add(Me.lblFromDate)
        Me.grpDateFilter.Location = New System.Drawing.Point(154, 172)
        Me.grpDateFilter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpDateFilter.Name = "grpDateFilter"
        Me.grpDateFilter.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpDateFilter.Size = New System.Drawing.Size(872, 474)
        Me.grpDateFilter.TabIndex = 44
        Me.grpDateFilter.TabStop = False
        Me.grpDateFilter.Text = "Filter by Date"
        '
        'dgvReport
        '
        Me.dgvReport.AllowUserToAddRows = False
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Location = New System.Drawing.Point(134, 175)
        Me.dgvReport.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.ReadOnly = True
        Me.dgvReport.RowTemplate.Height = 24
        Me.dgvReport.Size = New System.Drawing.Size(616, 225)
        Me.dgvReport.TabIndex = 801
        '
        'btnPrintReport
        '
        Me.btnPrintReport.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPrintReport.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintReport.Location = New System.Drawing.Point(697, 108)
        Me.btnPrintReport.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPrintReport.Name = "btnPrintReport"
        Me.btnPrintReport.Size = New System.Drawing.Size(141, 44)
        Me.btnPrintReport.TabIndex = 800
        Me.btnPrintReport.Text = "Print Now"
        Me.btnPrintReport.UseVisualStyleBackColor = False
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPrintPreview.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintPreview.Location = New System.Drawing.Point(551, 108)
        Me.btnPrintPreview.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.Size = New System.Drawing.Size(141, 44)
        Me.btnPrintPreview.TabIndex = 799
        Me.btnPrintPreview.Text = "Print Preview"
        Me.btnPrintPreview.UseVisualStyleBackColor = False
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.BackColor = System.Drawing.Color.SteelBlue
        Me.btnGenerateReport.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateReport.Location = New System.Drawing.Point(406, 108)
        Me.btnGenerateReport.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(141, 44)
        Me.btnGenerateReport.TabIndex = 10
        Me.btnGenerateReport.Text = "Generate Report"
        Me.btnGenerateReport.UseVisualStyleBackColor = False
        '
        'dtpReportTo
        '
        Me.dtpReportTo.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReportTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReportTo.Location = New System.Drawing.Point(542, 33)
        Me.dtpReportTo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpReportTo.Name = "dtpReportTo"
        Me.dtpReportTo.Size = New System.Drawing.Size(215, 29)
        Me.dtpReportTo.TabIndex = 798
        '
        'lblToDate
        '
        Me.lblToDate.AutoSize = True
        Me.lblToDate.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToDate.Location = New System.Drawing.Point(503, 39)
        Me.lblToDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(37, 21)
        Me.lblToDate.TabIndex = 797
        Me.lblToDate.Text = "To:"
        '
        'dtpReportFrom
        '
        Me.dtpReportFrom.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReportFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReportFrom.Location = New System.Drawing.Point(202, 33)
        Me.dtpReportFrom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpReportFrom.Name = "dtpReportFrom"
        Me.dtpReportFrom.Size = New System.Drawing.Size(215, 29)
        Me.dtpReportFrom.TabIndex = 796
        '
        'lblFromDate
        '
        Me.lblFromDate.AutoSize = True
        Me.lblFromDate.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromDate.Location = New System.Drawing.Point(130, 40)
        Me.lblFromDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(60, 21)
        Me.lblFromDate.TabIndex = 783
        Me.lblFromDate.Text = "From:"
        '
        'pdReport
        '
        '
        'ppvReport
        '
        Me.ppvReport.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ppvReport.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ppvReport.ClientSize = New System.Drawing.Size(400, 300)
        Me.ppvReport.Enabled = True
        Me.ppvReport.Icon = CType(resources.GetObject("ppvReport.Icon"), System.Drawing.Icon)
        Me.ppvReport.Name = "ppvReport"
        Me.ppvReport.Visible = False
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.Transparent
        Me.pnlContent.Controls.Add(Me.grpDateFilter)
        Me.pnlContent.Location = New System.Drawing.Point(7, -1)
        Me.pnlContent.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1107, 817)
        Me.pnlContent.TabIndex = 45
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1040, 640)
        Me.Controls.Add(Me.grpReportType)
        Me.Controls.Add(Me.pnlContent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmReports"
        Me.Text = "Form7"
        Me.grpReportType.ResumeLayout(False)
        Me.grpReportType.PerformLayout()
        Me.grpDateFilter.ResumeLayout(False)
        Me.grpDateFilter.PerformLayout()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContent.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpReportType As System.Windows.Forms.GroupBox
    Friend WithEvents rdoInventoryList As System.Windows.Forms.RadioButton
    Friend WithEvents rdoBorrowingRecords As System.Windows.Forms.RadioButton
    Friend WithEvents rdoOverdue As System.Windows.Forms.RadioButton
    Friend WithEvents rdoDamagedLost As System.Windows.Forms.RadioButton
    Friend WithEvents grpDateFilter As System.Windows.Forms.GroupBox
    Friend WithEvents lblFromDate As System.Windows.Forms.Label
    Friend WithEvents dtpReportFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpReportTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblToDate As System.Windows.Forms.Label
    Friend WithEvents btnGenerateReport As System.Windows.Forms.Button
    Friend WithEvents btnPrintReport As System.Windows.Forms.Button
    Friend WithEvents btnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents dgvReport As System.Windows.Forms.DataGridView
    Friend WithEvents pdReport As System.Drawing.Printing.PrintDocument
    Friend WithEvents ppvReport As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
End Class
