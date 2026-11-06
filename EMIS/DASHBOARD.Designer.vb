<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.dgvRecentActivity = New System.Windows.Forms.DataGridView()
        Me.lblCaptionDamaged = New System.Windows.Forms.Label()
        Me.lblCaptionBorrowed = New System.Windows.Forms.Label()
        Me.lblCaptionAvailable = New System.Windows.Forms.Label()
        Me.lblCaptionTotal = New System.Windows.Forms.Label()
        Me.lblDamaged = New System.Windows.Forms.Label()
        Me.lblBorrowed = New System.Windows.Forms.Label()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.lblTotalEquipment = New System.Windows.Forms.Label()
        CType(Me.dgvRecentActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRecentActivity
        '
        Me.dgvRecentActivity.AllowUserToAddRows = False
        Me.dgvRecentActivity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRecentActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRecentActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecentActivity.Location = New System.Drawing.Point(142, 289)
        Me.dgvRecentActivity.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvRecentActivity.Name = "dgvRecentActivity"
        Me.dgvRecentActivity.ReadOnly = True
        Me.dgvRecentActivity.RowHeadersVisible = False
        Me.dgvRecentActivity.RowTemplate.Height = 24
        Me.dgvRecentActivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecentActivity.Size = New System.Drawing.Size(704, 203)
        Me.dgvRecentActivity.TabIndex = 28
        '
        'lblCaptionDamaged
        '
        Me.lblCaptionDamaged.AutoSize = True
        Me.lblCaptionDamaged.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaptionDamaged.Location = New System.Drawing.Point(736, 108)
        Me.lblCaptionDamaged.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCaptionDamaged.Name = "lblCaptionDamaged"
        Me.lblCaptionDamaged.Size = New System.Drawing.Size(220, 39)
        Me.lblCaptionDamaged.TabIndex = 27
        Me.lblCaptionDamaged.Text = "Damaged / Lost"
        '
        'lblCaptionBorrowed
        '
        Me.lblCaptionBorrowed.AutoSize = True
        Me.lblCaptionBorrowed.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaptionBorrowed.Location = New System.Drawing.Point(543, 108)
        Me.lblCaptionBorrowed.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCaptionBorrowed.Name = "lblCaptionBorrowed"
        Me.lblCaptionBorrowed.Size = New System.Drawing.Size(143, 39)
        Me.lblCaptionBorrowed.TabIndex = 26
        Me.lblCaptionBorrowed.Text = "Borrowed"
        '
        'lblCaptionAvailable
        '
        Me.lblCaptionAvailable.AutoSize = True
        Me.lblCaptionAvailable.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaptionAvailable.Location = New System.Drawing.Point(354, 108)
        Me.lblCaptionAvailable.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCaptionAvailable.Name = "lblCaptionAvailable"
        Me.lblCaptionAvailable.Size = New System.Drawing.Size(137, 39)
        Me.lblCaptionAvailable.TabIndex = 25
        Me.lblCaptionAvailable.Text = "Available"
        '
        'lblCaptionTotal
        '
        Me.lblCaptionTotal.AutoSize = True
        Me.lblCaptionTotal.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaptionTotal.Location = New System.Drawing.Point(76, 108)
        Me.lblCaptionTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCaptionTotal.Name = "lblCaptionTotal"
        Me.lblCaptionTotal.Size = New System.Drawing.Size(228, 39)
        Me.lblCaptionTotal.TabIndex = 24
        Me.lblCaptionTotal.Text = "Total Equipment"
        '
        'lblDamaged
        '
        Me.lblDamaged.AutoSize = True
        Me.lblDamaged.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDamaged.Location = New System.Drawing.Point(814, 171)
        Me.lblDamaged.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDamaged.Name = "lblDamaged"
        Me.lblDamaged.Size = New System.Drawing.Size(34, 39)
        Me.lblDamaged.TabIndex = 23
        Me.lblDamaged.Text = "0"
        '
        'lblBorrowed
        '
        Me.lblBorrowed.AutoSize = True
        Me.lblBorrowed.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowed.Location = New System.Drawing.Point(587, 171)
        Me.lblBorrowed.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBorrowed.Name = "lblBorrowed"
        Me.lblBorrowed.Size = New System.Drawing.Size(34, 39)
        Me.lblBorrowed.TabIndex = 22
        Me.lblBorrowed.Text = "0"
        '
        'lblAvailable
        '
        Me.lblAvailable.AutoSize = True
        Me.lblAvailable.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailable.Location = New System.Drawing.Point(393, 171)
        Me.lblAvailable.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(34, 39)
        Me.lblAvailable.TabIndex = 21
        Me.lblAvailable.Text = "0"
        '
        'lblTotalEquipment
        '
        Me.lblTotalEquipment.AutoSize = True
        Me.lblTotalEquipment.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEquipment.Location = New System.Drawing.Point(153, 171)
        Me.lblTotalEquipment.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalEquipment.Name = "lblTotalEquipment"
        Me.lblTotalEquipment.Size = New System.Drawing.Size(34, 39)
        Me.lblTotalEquipment.TabIndex = 20
        Me.lblTotalEquipment.Text = "0"
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1015, 600)
        Me.Controls.Add(Me.dgvRecentActivity)
        Me.Controls.Add(Me.lblCaptionDamaged)
        Me.Controls.Add(Me.lblCaptionBorrowed)
        Me.Controls.Add(Me.lblCaptionAvailable)
        Me.Controls.Add(Me.lblCaptionTotal)
        Me.Controls.Add(Me.lblDamaged)
        Me.Controls.Add(Me.lblBorrowed)
        Me.Controls.Add(Me.lblAvailable)
        Me.Controls.Add(Me.lblTotalEquipment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmDashboard"
        Me.Text = "DASHBOARD"
        CType(Me.dgvRecentActivity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvRecentActivity As System.Windows.Forms.DataGridView
    Friend WithEvents lblCaptionDamaged As System.Windows.Forms.Label
    Friend WithEvents lblCaptionBorrowed As System.Windows.Forms.Label
    Friend WithEvents lblCaptionAvailable As System.Windows.Forms.Label
    Friend WithEvents lblCaptionTotal As System.Windows.Forms.Label
    Friend WithEvents lblDamaged As System.Windows.Forms.Label
    Friend WithEvents lblBorrowed As System.Windows.Forms.Label
    Friend WithEvents lblAvailable As System.Windows.Forms.Label
    Friend WithEvents lblTotalEquipment As System.Windows.Forms.Label
End Class
