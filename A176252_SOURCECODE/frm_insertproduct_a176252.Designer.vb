<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertproduct_a176252
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertproduct_a176252))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.lbl_pro = New System.Windows.Forms.Label()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.lbl_cus = New System.Windows.Forms.Label()
        Me.lbl_stff = New System.Windows.Forms.Label()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txt_country = New System.Windows.Forms.ComboBox()
        Me.txt_size = New System.Windows.Forms.ComboBox()
        Me.btn_add = New System.Windows.Forms.Button()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_title.Font = New System.Drawing.Font("Bernard MT Condensed", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(275, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(400, 40)
        Me.lbl_title.TabIndex = 89
        Me.lbl_title.Text = "ADD PRODUCT "
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(586, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "DESCRIPTION"
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(356, 310)
        Me.txt_description.Multiline = True
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Size = New System.Drawing.Size(553, 153)
        Me.txt_description.TabIndex = 86
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 482)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "QUANTITY"
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(155, 478)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(175, 22)
        Me.txt_quantity.TabIndex = 84
        '
        'lbl_pro
        '
        Me.lbl_pro.AutoSize = True
        Me.lbl_pro.Location = New System.Drawing.Point(12, 425)
        Me.lbl_pro.Name = "lbl_pro"
        Me.lbl_pro.Size = New System.Drawing.Size(76, 17)
        Me.lbl_pro.TabIndex = 83
        Me.lbl_pro.Text = "COUNTRY"
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.Location = New System.Drawing.Point(12, 455)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(38, 17)
        Me.lbl_quantity.TabIndex = 81
        Me.lbl_quantity.Text = "SIZE"
        '
        'lbl_cus
        '
        Me.lbl_cus.AutoSize = True
        Me.lbl_cus.Location = New System.Drawing.Point(12, 394)
        Me.lbl_cus.Name = "lbl_cus"
        Me.lbl_cus.Size = New System.Drawing.Size(45, 17)
        Me.lbl_cus.TabIndex = 80
        Me.lbl_cus.Text = "YEAR"
        '
        'lbl_stff
        '
        Me.lbl_stff.AutoSize = True
        Me.lbl_stff.Location = New System.Drawing.Point(12, 366)
        Me.lbl_stff.Name = "lbl_stff"
        Me.lbl_stff.Size = New System.Drawing.Size(70, 17)
        Me.lbl_stff.TabIndex = 79
        Me.lbl_stff.Text = "PRICE ($)"
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Location = New System.Drawing.Point(12, 310)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(21, 17)
        Me.lbl_ID.TabIndex = 78
        Me.lbl_ID.Text = "ID"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Location = New System.Drawing.Point(12, 338)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(47, 17)
        Me.lbl_date.TabIndex = 77
        Me.lbl_date.Text = "NAME"
        '
        'txt_year
        '
        Me.txt_year.Location = New System.Drawing.Point(155, 394)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(175, 22)
        Me.txt_year.TabIndex = 75
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(155, 366)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(175, 22)
        Me.txt_price.TabIndex = 74
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(155, 338)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(175, 22)
        Me.txt_name.TabIndex = 73
        '
        'txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(155, 310)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(175, 22)
        Me.txt_ID.TabIndex = 72
        '
        'grd_product
        '
        Me.grd_product.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(280, 73)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.RowHeadersWidth = 51
        Me.grd_product.RowTemplate.Height = 24
        Me.grd_product.Size = New System.Drawing.Size(629, 182)
        Me.grd_product.TabIndex = 90
        '
        'txt_picture
        '
        Me.txt_picture.Location = New System.Drawing.Point(49, 244)
        Me.txt_picture.Multiline = True
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.Size = New System.Drawing.Size(175, 23)
        Me.txt_picture.TabIndex = 93
        '
        'btn_picture
        '
        Me.btn_picture.Location = New System.Drawing.Point(83, 273)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(108, 23)
        Me.btn_picture.TabIndex = 92
        Me.btn_picture.Text = "Select Picture"
        Me.btn_picture.UseVisualStyleBackColor = True
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(48, 43)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(176, 195)
        Me.pic_product.TabIndex = 91
        Me.pic_product.TabStop = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_back.Font = New System.Drawing.Font("Lemon", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(768, 469)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(121, 43)
        Me.btn_back.TabIndex = 95
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txt_country
        '
        Me.txt_country.FormattingEnabled = True
        Me.txt_country.Items.AddRange(New Object() {"AG", "CD", "CN", "MY", "PO", "RE", "RR", "SA", "UK", "US"})
        Me.txt_country.Location = New System.Drawing.Point(155, 422)
        Me.txt_country.Name = "txt_country"
        Me.txt_country.Size = New System.Drawing.Size(175, 24)
        Me.txt_country.TabIndex = 96
        '
        'txt_size
        '
        Me.txt_size.FormattingEnabled = True
        Me.txt_size.Items.AddRange(New Object() {"S", "M", "B"})
        Me.txt_size.Location = New System.Drawing.Point(155, 450)
        Me.txt_size.Name = "txt_size"
        Me.txt_size.Size = New System.Drawing.Size(175, 24)
        Me.txt_size.TabIndex = 97
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_add.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(494, 469)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(121, 43)
        Me.btn_add.TabIndex = 98
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'frm_insertproduct_a176252
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(938, 525)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.txt_size)
        Me.Controls.Add(Me.txt_country)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.grd_product)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_description)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.lbl_pro)
        Me.Controls.Add(Me.lbl_quantity)
        Me.Controls.Add(Me.lbl_cus)
        Me.Controls.Add(Me.lbl_stff)
        Me.Controls.Add(Me.lbl_ID)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.txt_year)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_ID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_insertproduct_a176252"
        Me.Text = "Add New Product"
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_description As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents lbl_pro As Label
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents lbl_cus As Label
    Friend WithEvents lbl_stff As Label
    Friend WithEvents lbl_ID As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents txt_year As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents grd_product As DataGridView
    Friend WithEvents txt_picture As TextBox
    Friend WithEvents btn_picture As Button
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents btn_back As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txt_country As ComboBox
    Friend WithEvents txt_size As ComboBox
    Friend WithEvents btn_add As Button
End Class
