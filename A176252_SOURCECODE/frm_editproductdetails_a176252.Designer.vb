<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_editproductdetails_a176252
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_editproductdetails_a176252))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.pic_coin = New System.Windows.Forms.PictureBox()
        Me.lis_ID = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.lbl_pro = New System.Windows.Forms.Label()
        Me.txt_country = New System.Windows.Forms.TextBox()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.lbl_cus = New System.Windows.Forms.Label()
        Me.lbl_stff = New System.Windows.Forms.Label()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.txt_size = New System.Windows.Forms.TextBox()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_up = New System.Windows.Forms.Button()
        Me.txt_pic = New System.Windows.Forms.TextBox()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.grid_country = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pic_coin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_country, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_title.Font = New System.Drawing.Font("Bernard MT Condensed", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(238, 14)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(400, 40)
        Me.lbl_title.TabIndex = 94
        Me.lbl_title.Text = "PRODUCT DETAILS"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pic_coin
        '
        Me.pic_coin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_coin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_coin.Location = New System.Drawing.Point(540, 65)
        Me.pic_coin.Name = "pic_coin"
        Me.pic_coin.Size = New System.Drawing.Size(368, 167)
        Me.pic_coin.TabIndex = 92
        Me.pic_coin.TabStop = False
        '
        'lis_ID
        '
        Me.lis_ID.FormattingEnabled = True
        Me.lis_ID.ItemHeight = 16
        Me.lis_ID.Location = New System.Drawing.Point(376, 102)
        Me.lis_ID.Name = "lis_ID"
        Me.lis_ID.Size = New System.Drawing.Size(144, 132)
        Me.lis_ID.TabIndex = 91
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 275)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "DESCRIPTION"
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(33, 295)
        Me.txt_description.Multiline = True
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Size = New System.Drawing.Size(487, 215)
        Me.txt_description.TabIndex = 89
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "QUANTITY"
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(173, 239)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(175, 22)
        Me.txt_quantity.TabIndex = 87
        '
        'lbl_pro
        '
        Me.lbl_pro.AutoSize = True
        Me.lbl_pro.Location = New System.Drawing.Point(30, 187)
        Me.lbl_pro.Name = "lbl_pro"
        Me.lbl_pro.Size = New System.Drawing.Size(76, 17)
        Me.lbl_pro.TabIndex = 86
        Me.lbl_pro.Text = "COUNTRY"
        '
        'txt_country
        '
        Me.txt_country.Location = New System.Drawing.Point(173, 184)
        Me.txt_country.Name = "txt_country"
        Me.txt_country.Size = New System.Drawing.Size(175, 22)
        Me.txt_country.TabIndex = 85
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.Location = New System.Drawing.Point(30, 217)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(38, 17)
        Me.lbl_quantity.TabIndex = 84
        Me.lbl_quantity.Text = "SIZE"
        '
        'lbl_cus
        '
        Me.lbl_cus.AutoSize = True
        Me.lbl_cus.Location = New System.Drawing.Point(30, 156)
        Me.lbl_cus.Name = "lbl_cus"
        Me.lbl_cus.Size = New System.Drawing.Size(45, 17)
        Me.lbl_cus.TabIndex = 83
        Me.lbl_cus.Text = "YEAR"
        '
        'lbl_stff
        '
        Me.lbl_stff.AutoSize = True
        Me.lbl_stff.Location = New System.Drawing.Point(30, 128)
        Me.lbl_stff.Name = "lbl_stff"
        Me.lbl_stff.Size = New System.Drawing.Size(70, 17)
        Me.lbl_stff.TabIndex = 82
        Me.lbl_stff.Text = "PRICE ($)"
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Location = New System.Drawing.Point(30, 72)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(21, 17)
        Me.lbl_ID.TabIndex = 81
        Me.lbl_ID.Text = "ID"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Location = New System.Drawing.Point(30, 100)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(47, 17)
        Me.lbl_date.TabIndex = 80
        Me.lbl_date.Text = "NAME"
        '
        'txt_size
        '
        Me.txt_size.Location = New System.Drawing.Point(173, 212)
        Me.txt_size.Name = "txt_size"
        Me.txt_size.Size = New System.Drawing.Size(175, 22)
        Me.txt_size.TabIndex = 79
        '
        'txt_year
        '
        Me.txt_year.Location = New System.Drawing.Point(173, 156)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(175, 22)
        Me.txt_year.TabIndex = 78
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(173, 128)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(175, 22)
        Me.txt_price.TabIndex = 77
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(173, 100)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(175, 22)
        Me.txt_name.TabIndex = 76
        '
        'txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(173, 72)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(175, 22)
        Me.txt_ID.TabIndex = 75
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_back.Font = New System.Drawing.Font("Lemon", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btn_back.Location = New System.Drawing.Point(787, 467)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(121, 43)
        Me.btn_back.TabIndex = 74
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.Red
        Me.btn_del.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del.Location = New System.Drawing.Point(658, 467)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(121, 43)
        Me.btn_del.TabIndex = 96
        Me.btn_del.Text = "DELETE"
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'btn_up
        '
        Me.btn_up.BackColor = System.Drawing.Color.Gold
        Me.btn_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_up.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_up.Location = New System.Drawing.Point(531, 467)
        Me.btn_up.Name = "btn_up"
        Me.btn_up.Size = New System.Drawing.Size(121, 43)
        Me.btn_up.TabIndex = 95
        Me.btn_up.Text = "UPDATE"
        Me.btn_up.UseVisualStyleBackColor = False
        '
        'txt_pic
        '
        Me.txt_pic.Location = New System.Drawing.Point(641, 238)
        Me.txt_pic.Multiline = True
        Me.txt_pic.Name = "txt_pic"
        Me.txt_pic.Size = New System.Drawing.Size(175, 23)
        Me.txt_pic.TabIndex = 98
        '
        'btn_picture
        '
        Me.btn_picture.Location = New System.Drawing.Point(671, 266)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(108, 23)
        Me.btn_picture.TabIndex = 97
        Me.btn_picture.Text = "Select Picture"
        Me.btn_picture.UseVisualStyleBackColor = True
        '
        'grid_country
        '
        Me.grid_country.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grid_country.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_country.Location = New System.Drawing.Point(540, 295)
        Me.grid_country.Name = "grid_country"
        Me.grid_country.RowHeadersWidth = 51
        Me.grid_country.RowTemplate.Height = 24
        Me.grid_country.Size = New System.Drawing.Size(358, 148)
        Me.grid_country.TabIndex = 99
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_editproductdetails_a176252
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(938, 525)
        Me.Controls.Add(Me.grid_country)
        Me.Controls.Add(Me.txt_pic)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_up)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pic_coin)
        Me.Controls.Add(Me.lis_ID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_description)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.lbl_pro)
        Me.Controls.Add(Me.txt_country)
        Me.Controls.Add(Me.lbl_quantity)
        Me.Controls.Add(Me.lbl_cus)
        Me.Controls.Add(Me.lbl_stff)
        Me.Controls.Add(Me.lbl_ID)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.txt_size)
        Me.Controls.Add(Me.txt_year)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.btn_back)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_editproductdetails_a176252"
        Me.Text = "Edit Product Details"
        CType(Me.pic_coin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_country, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_title As Label
    Friend WithEvents pic_coin As PictureBox
    Friend WithEvents lis_ID As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_description As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents lbl_pro As Label
    Friend WithEvents txt_country As TextBox
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents lbl_cus As Label
    Friend WithEvents lbl_stff As Label
    Friend WithEvents lbl_ID As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents txt_size As TextBox
    Friend WithEvents txt_year As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_up As Button
    Friend WithEvents txt_pic As TextBox
    Friend WithEvents btn_picture As Button
    Friend WithEvents grid_country As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
