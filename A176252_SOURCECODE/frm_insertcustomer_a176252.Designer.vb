<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_insertcustomer_a176252
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertcustomer_a176252))
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.pic_cus = New System.Windows.Forms.PictureBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.lbl_contact = New System.Windows.Forms.Label()
        Me.lbl_salary = New System.Windows.Forms.Label()
        Me.lbl_pos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_contact = New System.Windows.Forms.TextBox()
        Me.txt_IC = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txt_gender = New System.Windows.Forms.ComboBox()
        CType(Me.pic_cus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_back.Font = New System.Drawing.Font("Lemon", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(623, 371)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(121, 43)
        Me.btn_back.TabIndex = 59
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'lbl_title
        '
        Me.lbl_title.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_title.Font = New System.Drawing.Font("Bernard MT Condensed", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(197, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(400, 40)
        Me.lbl_title.TabIndex = 58
        Me.lbl_title.Text = "ADD NEW CUSTOMER"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_picture
        '
        Me.txt_picture.Location = New System.Drawing.Point(595, 269)
        Me.txt_picture.Multiline = True
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.Size = New System.Drawing.Size(177, 39)
        Me.txt_picture.TabIndex = 57
        '
        'btn_picture
        '
        Me.btn_picture.Location = New System.Drawing.Point(606, 320)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(162, 23)
        Me.btn_picture.TabIndex = 56
        Me.btn_picture.Text = "Select Picture"
        Me.btn_picture.UseVisualStyleBackColor = True
        '
        'pic_cus
        '
        Me.pic_cus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_cus.Location = New System.Drawing.Point(595, 63)
        Me.pic_cus.Name = "pic_cus"
        Me.pic_cus.Size = New System.Drawing.Size(177, 198)
        Me.pic_cus.TabIndex = 55
        Me.pic_cus.TabStop = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_add.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(412, 325)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(121, 43)
        Me.btn_add.TabIndex = 54
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'lbl_contact
        '
        Me.lbl_contact.AutoSize = True
        Me.lbl_contact.Location = New System.Drawing.Point(42, 395)
        Me.lbl_contact.Name = "lbl_contact"
        Me.lbl_contact.Size = New System.Drawing.Size(137, 17)
        Me.lbl_contact.TabIndex = 53
        Me.lbl_contact.Text = "CONTACT NUMBER"
        '
        'lbl_salary
        '
        Me.lbl_salary.AutoSize = True
        Me.lbl_salary.Location = New System.Drawing.Point(42, 364)
        Me.lbl_salary.Name = "lbl_salary"
        Me.lbl_salary.Size = New System.Drawing.Size(67, 17)
        Me.lbl_salary.TabIndex = 52
        Me.lbl_salary.Text = "GENDER"
        '
        'lbl_pos
        '
        Me.lbl_pos.AutoSize = True
        Me.lbl_pos.Location = New System.Drawing.Point(42, 336)
        Me.lbl_pos.Name = "lbl_pos"
        Me.lbl_pos.Size = New System.Drawing.Size(20, 17)
        Me.lbl_pos.TabIndex = 51
        Me.lbl_pos.Text = "IC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "NAME"
        '
        'txt_contact
        '
        Me.txt_contact.Location = New System.Drawing.Point(189, 392)
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.Size = New System.Drawing.Size(175, 22)
        Me.txt_contact.TabIndex = 49
        '
        'txt_IC
        '
        Me.txt_IC.Location = New System.Drawing.Point(189, 336)
        Me.txt_IC.Name = "txt_IC"
        Me.txt_IC.Size = New System.Drawing.Size(175, 22)
        Me.txt_IC.TabIndex = 47
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(189, 308)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(175, 22)
        Me.txt_name.TabIndex = 46
        '
        'txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(189, 279)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(175, 22)
        Me.txt_ID.TabIndex = 45
        '
        'grd_customer
        '
        Me.grd_customer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.Location = New System.Drawing.Point(31, 63)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.RowHeadersWidth = 51
        Me.grd_customer.RowTemplate.Height = 24
        Me.grd_customer.Size = New System.Drawing.Size(546, 198)
        Me.grd_customer.TabIndex = 44
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Location = New System.Drawing.Point(42, 282)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(21, 17)
        Me.lbl_ID.TabIndex = 60
        Me.lbl_ID.Text = "ID"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txt_gender
        '
        Me.txt_gender.FormattingEnabled = True
        Me.txt_gender.Items.AddRange(New Object() {"M", "F"})
        Me.txt_gender.Location = New System.Drawing.Point(189, 364)
        Me.txt_gender.Name = "txt_gender"
        Me.txt_gender.Size = New System.Drawing.Size(175, 24)
        Me.txt_gender.TabIndex = 61
        '
        'frm_insertcustomer_a176252
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_gender)
        Me.Controls.Add(Me.lbl_ID)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.pic_cus)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.lbl_contact)
        Me.Controls.Add(Me.lbl_salary)
        Me.Controls.Add(Me.lbl_pos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_contact)
        Me.Controls.Add(Me.txt_IC)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.grd_customer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_insertcustomer_a176252"
        Me.Text = "Add New Customer"
        CType(Me.pic_cus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back As Button
    Friend WithEvents lbl_title As Label
    Friend WithEvents txt_picture As TextBox
    Friend WithEvents btn_picture As Button
    Friend WithEvents pic_cus As PictureBox
    Friend WithEvents btn_add As Button
    Friend WithEvents lbl_contact As Label
    Friend WithEvents lbl_salary As Label
    Friend WithEvents lbl_pos As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_contact As TextBox
    Friend WithEvents txt_IC As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents lbl_ID As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txt_gender As ComboBox
End Class
