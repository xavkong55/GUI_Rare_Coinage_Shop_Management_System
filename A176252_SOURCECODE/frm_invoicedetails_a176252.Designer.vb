<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_invoicedetails_a176252
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_invoicedetails_a176252))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_tac = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.txt_date = New System.Windows.Forms.TextBox()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.lbl_tax = New System.Windows.Forms.Label()
        Me.txt_tax = New System.Windows.Forms.TextBox()
        Me.lbl_overallprice = New System.Windows.Forms.Label()
        Me.txt_overall = New System.Windows.Forms.TextBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(685, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INVOICE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grd_order
        '
        Me.grd_order.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(367, 106)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.RowHeadersWidth = 51
        Me.grd_order.RowTemplate.Height = 24
        Me.grd_order.Size = New System.Drawing.Size(885, 314)
        Me.grd_order.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(378, 485)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(256, 23)
        Me.Label11.TabIndex = 79
        Me.Label11.Text = "Overall Price is inclusive with Tax"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(378, 457)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(239, 23)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Payment is due within 15 days"
        '
        'lbl_tac
        '
        Me.lbl_tac.AutoSize = True
        Me.lbl_tac.Font = New System.Drawing.Font("Russo One", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tac.Location = New System.Drawing.Point(377, 428)
        Me.lbl_tac.Name = "lbl_tac"
        Me.lbl_tac.Size = New System.Drawing.Size(240, 25)
        Me.lbl_tac.TabIndex = 77
        Me.lbl_tac.Text = "*Terms && Conditions"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Russo One", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 443)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(263, 54)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Thank You!"
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Location = New System.Drawing.Point(439, 75)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(75, 17)
        Me.lbl_ID.TabIndex = 86
        Me.lbl_ID.Text = "ORDER ID"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Location = New System.Drawing.Point(904, 76)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(45, 17)
        Me.lbl_date.TabIndex = 85
        Me.lbl_date.Text = "DATE"
        '
        'txt_date
        '
        Me.txt_date.Location = New System.Drawing.Point(953, 73)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(175, 22)
        Me.txt_date.TabIndex = 84
        '
        'txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(520, 73)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(175, 22)
        Me.txt_ID.TabIndex = 83
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(25, 323)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(267, 88)
        Me.PictureBox2.TabIndex = 87
        Me.PictureBox2.TabStop = False
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Location = New System.Drawing.Point(22, 152)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(94, 17)
        Me.lbl_price.TabIndex = 89
        Me.lbl_price.Text = "Total Price($)"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(117, 149)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(175, 22)
        Me.txt_total.TabIndex = 88
        '
        'lbl_tax
        '
        Me.lbl_tax.AutoSize = True
        Me.lbl_tax.Location = New System.Drawing.Point(22, 187)
        Me.lbl_tax.Name = "lbl_tax"
        Me.lbl_tax.Size = New System.Drawing.Size(55, 17)
        Me.lbl_tax.TabIndex = 91
        Me.lbl_tax.Text = "Tax 6%"
        '
        'txt_tax
        '
        Me.txt_tax.Location = New System.Drawing.Point(117, 187)
        Me.txt_tax.Name = "txt_tax"
        Me.txt_tax.Size = New System.Drawing.Size(175, 22)
        Me.txt_tax.TabIndex = 90
        '
        'lbl_overallprice
        '
        Me.lbl_overallprice.AutoSize = True
        Me.lbl_overallprice.Location = New System.Drawing.Point(114, 231)
        Me.lbl_overallprice.Name = "lbl_overallprice"
        Me.lbl_overallprice.Size = New System.Drawing.Size(107, 17)
        Me.lbl_overallprice.TabIndex = 93
        Me.lbl_overallprice.Text = "Overall Price($)"
        '
        'txt_overall
        '
        Me.txt_overall.Location = New System.Drawing.Point(58, 251)
        Me.txt_overall.Multiline = True
        Me.txt_overall.Name = "txt_overall"
        Me.txt_overall.Size = New System.Drawing.Size(215, 39)
        Me.txt_overall.TabIndex = 92
        Me.txt_overall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_back.Font = New System.Drawing.Font("Lemon", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(997, 447)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(236, 43)
        Me.btn_back.TabIndex = 94
        Me.btn_back.Text = "See All History"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_order
        '
        Me.btn_order.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_order.Font = New System.Drawing.Font("Lemon", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order.Location = New System.Drawing.Point(715, 447)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(236, 43)
        Me.btn_order.TabIndex = 95
        Me.btn_order.Text = "Add New Order"
        Me.btn_order.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(118, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(196, 28)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Rare Coinage Shop"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(119, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(209, 20)
        Me.Label9.TabIndex = 103
        Me.Label9.Text = "81500 Pekan Nanas, Johor"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(118, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 20)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "Taman Daya 2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(119, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(167, 20)
        Me.Label12.TabIndex = 101
        Me.Label12.Text = "No 127, Jalan Bawah"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 102)
        Me.PictureBox1.TabIndex = 100
        Me.PictureBox1.TabStop = False
        '
        'frm_invoicedetails_a176252
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1288, 518)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_order)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_overallprice)
        Me.Controls.Add(Me.txt_overall)
        Me.Controls.Add(Me.lbl_tax)
        Me.Controls.Add(Me.txt_tax)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lbl_ID)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_tac)
        Me.Controls.Add(Me.grd_order)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_invoicedetails_a176252"
        Me.Text = "Invoice"
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grd_order As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_tac As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_ID As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents txt_date As TextBox
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbl_price As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents lbl_tax As Label
    Friend WithEvents txt_tax As TextBox
    Friend WithEvents lbl_overallprice As Label
    Friend WithEvents txt_overall As TextBox
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_order As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
