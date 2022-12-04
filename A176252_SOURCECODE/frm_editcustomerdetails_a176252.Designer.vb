<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_editCustomerDetails_a176252
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_editCustomerDetails_a176252))
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_details = New System.Windows.Forms.Label()
        Me.lbl_contact = New System.Windows.Forms.Label()
        Me.lbl_gender = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_contact = New System.Windows.Forms.TextBox()
        Me.txt_gender = New System.Windows.Forms.TextBox()
        Me.txt_IC = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.grd_cus = New System.Windows.Forms.DataGridView()
        Me.pic_cus = New System.Windows.Forms.PictureBox()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_up = New System.Windows.Forms.Button()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txt_pic = New System.Windows.Forms.TextBox()
        Me.lis_ID = New System.Windows.Forms.ListBox()
        CType(Me.grd_cus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_cus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_back.Font = New System.Drawing.Font("Lemon", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(608, 387)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(121, 43)
        Me.btn_back.TabIndex = 36
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'lbl_title
        '
        Me.lbl_title.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_title.Font = New System.Drawing.Font("Bernard MT Condensed", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(215, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(400, 40)
        Me.lbl_title.TabIndex = 51
        Me.lbl_title.Text = "CUSTOMER DETAILS"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_details
        '
        Me.lbl_details.AutoSize = True
        Me.lbl_details.Location = New System.Drawing.Point(344, 28)
        Me.lbl_details.Name = "lbl_details"
        Me.lbl_details.Size = New System.Drawing.Size(0, 17)
        Me.lbl_details.TabIndex = 49
        '
        'lbl_contact
        '
        Me.lbl_contact.AutoSize = True
        Me.lbl_contact.Location = New System.Drawing.Point(43, 390)
        Me.lbl_contact.Name = "lbl_contact"
        Me.lbl_contact.Size = New System.Drawing.Size(137, 17)
        Me.lbl_contact.TabIndex = 48
        Me.lbl_contact.Text = "CONTACT NUMBER"
        '
        'lbl_gender
        '
        Me.lbl_gender.AutoSize = True
        Me.lbl_gender.Location = New System.Drawing.Point(43, 359)
        Me.lbl_gender.Name = "lbl_gender"
        Me.lbl_gender.Size = New System.Drawing.Size(67, 17)
        Me.lbl_gender.TabIndex = 47
        Me.lbl_gender.Text = "GENDER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 331)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 17)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "IC"
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Location = New System.Drawing.Point(44, 275)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(21, 17)
        Me.lbl_ID.TabIndex = 45
        Me.lbl_ID.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "NAME"
        '
        'txt_contact
        '
        Me.txt_contact.Location = New System.Drawing.Point(192, 387)
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.Size = New System.Drawing.Size(175, 22)
        Me.txt_contact.TabIndex = 43
        '
        'txt_gender
        '
        Me.txt_gender.Location = New System.Drawing.Point(192, 359)
        Me.txt_gender.Name = "txt_gender"
        Me.txt_gender.Size = New System.Drawing.Size(175, 22)
        Me.txt_gender.TabIndex = 42
        '
        'txt_IC
        '
        Me.txt_IC.Location = New System.Drawing.Point(192, 331)
        Me.txt_IC.Name = "txt_IC"
        Me.txt_IC.Size = New System.Drawing.Size(175, 22)
        Me.txt_IC.TabIndex = 41
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(192, 303)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(175, 22)
        Me.txt_name.TabIndex = 40
        '
        'txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(192, 275)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(175, 22)
        Me.txt_ID.TabIndex = 39
        '
        'grd_cus
        '
        Me.grd_cus.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grd_cus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_cus.Location = New System.Drawing.Point(33, 61)
        Me.grd_cus.Name = "grd_cus"
        Me.grd_cus.RowHeadersWidth = 51
        Me.grd_cus.RowTemplate.Height = 24
        Me.grd_cus.Size = New System.Drawing.Size(546, 198)
        Me.grd_cus.TabIndex = 38
        '
        'pic_cus
        '
        Me.pic_cus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_cus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_cus.Location = New System.Drawing.Point(598, 61)
        Me.pic_cus.Name = "pic_cus"
        Me.pic_cus.Size = New System.Drawing.Size(177, 198)
        Me.pic_cus.TabIndex = 37
        Me.pic_cus.TabStop = False
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.Red
        Me.btn_del.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del.Location = New System.Drawing.Point(667, 331)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(121, 43)
        Me.btn_del.TabIndex = 65
        Me.btn_del.Text = "DELETE"
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'btn_up
        '
        Me.btn_up.BackColor = System.Drawing.Color.Gold
        Me.btn_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_up.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_up.Location = New System.Drawing.Point(540, 331)
        Me.btn_up.Name = "btn_up"
        Me.btn_up.Size = New System.Drawing.Size(121, 43)
        Me.btn_up.TabIndex = 64
        Me.btn_up.Text = "UPDATE"
        Me.btn_up.UseVisualStyleBackColor = False
        '
        'btn_picture
        '
        Me.btn_picture.Location = New System.Drawing.Point(619, 298)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(139, 23)
        Me.btn_picture.TabIndex = 67
        Me.btn_picture.Text = "Select Picture"
        Me.btn_picture.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txt_pic
        '
        Me.txt_pic.Location = New System.Drawing.Point(598, 265)
        Me.txt_pic.Multiline = True
        Me.txt_pic.Name = "txt_pic"
        Me.txt_pic.Size = New System.Drawing.Size(177, 27)
        Me.txt_pic.TabIndex = 68
        '
        'lis_ID
        '
        Me.lis_ID.FormattingEnabled = True
        Me.lis_ID.ItemHeight = 16
        Me.lis_ID.Location = New System.Drawing.Point(384, 277)
        Me.lis_ID.Name = "lis_ID"
        Me.lis_ID.Size = New System.Drawing.Size(144, 132)
        Me.lis_ID.TabIndex = 69
        '
        'frm_editCustomerDetails_a176252
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lis_ID)
        Me.Controls.Add(Me.txt_pic)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_up)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lbl_details)
        Me.Controls.Add(Me.lbl_contact)
        Me.Controls.Add(Me.lbl_gender)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_ID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_contact)
        Me.Controls.Add(Me.txt_gender)
        Me.Controls.Add(Me.txt_IC)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.grd_cus)
        Me.Controls.Add(Me.pic_cus)
        Me.Controls.Add(Me.btn_back)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_editCustomerDetails_a176252"
        Me.Text = "Edit Customer Details"
        CType(Me.grd_cus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_cus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_details As Label
    Friend WithEvents lbl_contact As Label
    Friend WithEvents lbl_gender As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_ID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_contact As TextBox
    Friend WithEvents txt_gender As TextBox
    Friend WithEvents txt_IC As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents grd_cus As DataGridView
    Friend WithEvents pic_cus As PictureBox
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_up As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_picture As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txt_pic As TextBox
    Friend WithEvents lis_ID As ListBox
End Class
