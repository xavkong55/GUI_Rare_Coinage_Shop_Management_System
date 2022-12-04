<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_product_a176252
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_product_a176252))
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.lis_ID = New System.Windows.Forms.ListBox()
        Me.pic_coin = New System.Windows.Forms.PictureBox()
        Me.grid_country = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        CType(Me.pic_coin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_country, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_pro
        '
        Me.lbl_pro.AutoSize = True
        Me.lbl_pro.Location = New System.Drawing.Point(41, 182)
        Me.lbl_pro.Name = "lbl_pro"
        Me.lbl_pro.Size = New System.Drawing.Size(76, 17)
        Me.lbl_pro.TabIndex = 61
        Me.lbl_pro.Text = "COUNTRY"
        '
        'txt_country
        '
        Me.txt_country.Location = New System.Drawing.Point(184, 179)
        Me.txt_country.Name = "txt_country"
        Me.txt_country.Size = New System.Drawing.Size(175, 22)
        Me.txt_country.TabIndex = 60
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.Location = New System.Drawing.Point(41, 212)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(38, 17)
        Me.lbl_quantity.TabIndex = 59
        Me.lbl_quantity.Text = "SIZE"
        '
        'lbl_cus
        '
        Me.lbl_cus.AutoSize = True
        Me.lbl_cus.Location = New System.Drawing.Point(41, 151)
        Me.lbl_cus.Name = "lbl_cus"
        Me.lbl_cus.Size = New System.Drawing.Size(45, 17)
        Me.lbl_cus.TabIndex = 58
        Me.lbl_cus.Text = "YEAR"
        '
        'lbl_stff
        '
        Me.lbl_stff.AutoSize = True
        Me.lbl_stff.Location = New System.Drawing.Point(41, 123)
        Me.lbl_stff.Name = "lbl_stff"
        Me.lbl_stff.Size = New System.Drawing.Size(70, 17)
        Me.lbl_stff.TabIndex = 57
        Me.lbl_stff.Text = "PRICE ($)"
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Location = New System.Drawing.Point(41, 67)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(21, 17)
        Me.lbl_ID.TabIndex = 56
        Me.lbl_ID.Text = "ID"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Location = New System.Drawing.Point(41, 95)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(47, 17)
        Me.lbl_date.TabIndex = 55
        Me.lbl_date.Text = "NAME"
        '
        'txt_size
        '
        Me.txt_size.Location = New System.Drawing.Point(184, 207)
        Me.txt_size.Name = "txt_size"
        Me.txt_size.Size = New System.Drawing.Size(175, 22)
        Me.txt_size.TabIndex = 54
        '
        'txt_year
        '
        Me.txt_year.Location = New System.Drawing.Point(184, 151)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(175, 22)
        Me.txt_year.TabIndex = 53
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(184, 123)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(175, 22)
        Me.txt_price.TabIndex = 52
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(184, 95)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(175, 22)
        Me.txt_name.TabIndex = 51
        '
        'txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(184, 67)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(175, 22)
        Me.txt_ID.TabIndex = 50
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_back.Font = New System.Drawing.Font("Lemon", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btn_back.Location = New System.Drawing.Point(788, 462)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(121, 43)
        Me.btn_back.TabIndex = 49
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 239)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "QUANTITY"
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(184, 234)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(175, 22)
        Me.txt_quantity.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "DESCRIPTION"
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(44, 290)
        Me.txt_description.Multiline = True
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Size = New System.Drawing.Size(487, 215)
        Me.txt_description.TabIndex = 66
        '
        'lis_ID
        '
        Me.lis_ID.FormattingEnabled = True
        Me.lis_ID.ItemHeight = 16
        Me.lis_ID.Location = New System.Drawing.Point(378, 100)
        Me.lis_ID.Name = "lis_ID"
        Me.lis_ID.Size = New System.Drawing.Size(144, 132)
        Me.lis_ID.TabIndex = 68
        '
        'pic_coin
        '
        Me.pic_coin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_coin.Location = New System.Drawing.Point(540, 65)
        Me.pic_coin.Name = "pic_coin"
        Me.pic_coin.Size = New System.Drawing.Size(368, 167)
        Me.pic_coin.TabIndex = 69
        Me.pic_coin.TabStop = False
        '
        'grid_country
        '
        Me.grid_country.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grid_country.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_country.Location = New System.Drawing.Point(551, 290)
        Me.grid_country.Name = "grid_country"
        Me.grid_country.RowHeadersWidth = 51
        Me.grid_country.RowTemplate.Height = 24
        Me.grid_country.Size = New System.Drawing.Size(358, 148)
        Me.grid_country.TabIndex = 70
        '
        'lbl_title
        '
        Me.lbl_title.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_title.Font = New System.Drawing.Font("Bernard MT Condensed", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(249, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(400, 40)
        Me.lbl_title.TabIndex = 71
        Me.lbl_title.Text = "PRODUCT DETAILS"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_add.Font = New System.Drawing.Font("Lemon", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(661, 462)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(121, 43)
        Me.btn_add.TabIndex = 73
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_edit.Font = New System.Drawing.Font("Lemon", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(537, 462)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(121, 43)
        Me.btn_edit.TabIndex = 72
        Me.btn_edit.Text = "EDIT"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'frm_product_a176252
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(938, 525)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.grid_country)
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
        Me.Name = "frm_product_a176252"
        Me.Text = "Product Details"
        CType(Me.pic_coin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_country, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_description As TextBox
    Friend WithEvents lis_ID As ListBox
    Friend WithEvents pic_coin As PictureBox
    Friend WithEvents grid_country As DataGridView
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_edit As Button
End Class
