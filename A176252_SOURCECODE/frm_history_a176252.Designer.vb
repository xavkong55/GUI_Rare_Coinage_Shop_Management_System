<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_history_a176252
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_history_a176252))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.txt_invoice = New System.Windows.Forms.Button()
        Me.lis_ID = New System.Windows.Forms.ListBox()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(443, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 17)
        Me.Label3.TabIndex = 24
        '
        'grd_order
        '
        Me.grd_order.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(171, 97)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.RowHeadersWidth = 51
        Me.grd_order.RowTemplate.Height = 24
        Me.grd_order.Size = New System.Drawing.Size(832, 275)
        Me.grd_order.TabIndex = 16
        '
        'lbl_title
        '
        Me.lbl_title.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_title.Font = New System.Drawing.Font("Bernard MT Condensed", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(245, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(400, 40)
        Me.lbl_title.TabIndex = 35
        Me.lbl_title.Text = "ORDER HISTORY"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_back.Font = New System.Drawing.Font("Lemon", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(825, 408)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(141, 43)
        Me.btn_back.TabIndex = 88
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'txt_invoice
        '
        Me.txt_invoice.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_invoice.Font = New System.Drawing.Font("Lemon", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_invoice.Location = New System.Drawing.Point(582, 408)
        Me.txt_invoice.Name = "txt_invoice"
        Me.txt_invoice.Size = New System.Drawing.Size(141, 43)
        Me.txt_invoice.TabIndex = 96
        Me.txt_invoice.Text = "Invoice"
        Me.txt_invoice.UseVisualStyleBackColor = False
        '
        'lis_ID
        '
        Me.lis_ID.FormattingEnabled = True
        Me.lis_ID.ItemHeight = 16
        Me.lis_ID.Location = New System.Drawing.Point(21, 97)
        Me.lis_ID.Name = "lis_ID"
        Me.lis_ID.Size = New System.Drawing.Size(120, 276)
        Me.lis_ID.TabIndex = 97
        '
        'frm_history_a176252
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1015, 479)
        Me.Controls.Add(Me.lis_ID)
        Me.Controls.Add(Me.txt_invoice)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grd_order)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_history_a176252"
        Me.Text = "History"
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents grd_order As DataGridView
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents txt_invoice As Button
    Friend WithEvents lis_ID As ListBox
End Class
