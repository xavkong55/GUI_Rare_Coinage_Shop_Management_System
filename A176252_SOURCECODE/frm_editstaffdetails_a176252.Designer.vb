<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_editstaffdetails_a176252
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_editstaffdetails_a176252))
        Me.lis_ID = New System.Windows.Forms.ListBox()
        Me.txt_pic = New System.Windows.Forms.TextBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_details = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_up = New System.Windows.Forms.Button()
        Me.grd_staff = New System.Windows.Forms.DataGridView()
        Me.pic_staff = New System.Windows.Forms.PictureBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lbl_contact = New System.Windows.Forms.Label()
        Me.lbl_salary = New System.Windows.Forms.Label()
        Me.lbl_pos = New System.Windows.Forms.Label()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_contact = New System.Windows.Forms.TextBox()
        Me.txt_salary = New System.Windows.Forms.TextBox()
        Me.txt_post = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lis_ID
        '
        Me.lis_ID.FormattingEnabled = True
        Me.lis_ID.ItemHeight = 16
        Me.lis_ID.Location = New System.Drawing.Point(374, 283)
        Me.lis_ID.Name = "lis_ID"
        Me.lis_ID.Size = New System.Drawing.Size(144, 132)
        Me.lis_ID.TabIndex = 89
        '
        'txt_pic
        '
        Me.txt_pic.Location = New System.Drawing.Point(588, 271)
        Me.txt_pic.Multiline = True
        Me.txt_pic.Name = "txt_pic"
        Me.txt_pic.Size = New System.Drawing.Size(177, 27)
        Me.txt_pic.TabIndex = 88
        '
        'lbl_title
        '
        Me.lbl_title.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_title.Font = New System.Drawing.Font("Bernard MT Condensed", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(203, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(400, 40)
        Me.lbl_title.TabIndex = 84
        Me.lbl_title.Text = "STAFF DETAILS"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_details
        '
        Me.lbl_details.AutoSize = True
        Me.lbl_details.Location = New System.Drawing.Point(334, 34)
        Me.lbl_details.Name = "lbl_details"
        Me.lbl_details.Size = New System.Drawing.Size(0, 17)
        Me.lbl_details.TabIndex = 83
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_picture
        '
        Me.btn_picture.Location = New System.Drawing.Point(609, 304)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(139, 23)
        Me.btn_picture.TabIndex = 87
        Me.btn_picture.Text = "Select Picture"
        Me.btn_picture.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.Red
        Me.btn_del.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del.Location = New System.Drawing.Point(657, 337)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(121, 43)
        Me.btn_del.TabIndex = 86
        Me.btn_del.Text = "DELETE"
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'btn_up
        '
        Me.btn_up.BackColor = System.Drawing.Color.Gold
        Me.btn_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_up.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_up.Location = New System.Drawing.Point(530, 337)
        Me.btn_up.Name = "btn_up"
        Me.btn_up.Size = New System.Drawing.Size(121, 43)
        Me.btn_up.TabIndex = 85
        Me.btn_up.Text = "UPDATE"
        Me.btn_up.UseVisualStyleBackColor = False
        '
        'grd_staff
        '
        Me.grd_staff.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grd_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staff.Location = New System.Drawing.Point(23, 67)
        Me.grd_staff.Name = "grd_staff"
        Me.grd_staff.RowHeadersWidth = 51
        Me.grd_staff.RowTemplate.Height = 24
        Me.grd_staff.Size = New System.Drawing.Size(546, 198)
        Me.grd_staff.TabIndex = 72
        '
        'pic_staff
        '
        Me.pic_staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_staff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_staff.Location = New System.Drawing.Point(588, 67)
        Me.pic_staff.Name = "pic_staff"
        Me.pic_staff.Size = New System.Drawing.Size(177, 198)
        Me.pic_staff.TabIndex = 71
        Me.pic_staff.TabStop = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_back.Font = New System.Drawing.Font("Lemon", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(598, 393)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(121, 43)
        Me.btn_back.TabIndex = 70
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'lbl_contact
        '
        Me.lbl_contact.AutoSize = True
        Me.lbl_contact.Location = New System.Drawing.Point(33, 398)
        Me.lbl_contact.Name = "lbl_contact"
        Me.lbl_contact.Size = New System.Drawing.Size(137, 17)
        Me.lbl_contact.TabIndex = 99
        Me.lbl_contact.Text = "CONTACT NUMBER"
        '
        'lbl_salary
        '
        Me.lbl_salary.AutoSize = True
        Me.lbl_salary.Location = New System.Drawing.Point(33, 367)
        Me.lbl_salary.Name = "lbl_salary"
        Me.lbl_salary.Size = New System.Drawing.Size(62, 17)
        Me.lbl_salary.TabIndex = 98
        Me.lbl_salary.Text = "SALARY"
        '
        'lbl_pos
        '
        Me.lbl_pos.AutoSize = True
        Me.lbl_pos.Location = New System.Drawing.Point(33, 339)
        Me.lbl_pos.Name = "lbl_pos"
        Me.lbl_pos.Size = New System.Drawing.Size(73, 17)
        Me.lbl_pos.TabIndex = 97
        Me.lbl_pos.Text = "POSITION"
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Location = New System.Drawing.Point(33, 283)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(21, 17)
        Me.lbl_ID.TabIndex = 96
        Me.lbl_ID.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "NAME"
        '
        'txt_contact
        '
        Me.txt_contact.Location = New System.Drawing.Point(180, 395)
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.Size = New System.Drawing.Size(175, 22)
        Me.txt_contact.TabIndex = 94
        '
        'txt_salary
        '
        Me.txt_salary.Location = New System.Drawing.Point(180, 367)
        Me.txt_salary.Name = "txt_salary"
        Me.txt_salary.Size = New System.Drawing.Size(175, 22)
        Me.txt_salary.TabIndex = 93
        '
        'txt_post
        '
        Me.txt_post.Location = New System.Drawing.Point(180, 339)
        Me.txt_post.Name = "txt_post"
        Me.txt_post.Size = New System.Drawing.Size(175, 22)
        Me.txt_post.TabIndex = 92
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(180, 311)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(175, 22)
        Me.txt_name.TabIndex = 91
        '
        'txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(180, 283)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(175, 22)
        Me.txt_ID.TabIndex = 90
        '
        'frm_editstaffdetails_a176252
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_contact)
        Me.Controls.Add(Me.lbl_salary)
        Me.Controls.Add(Me.lbl_pos)
        Me.Controls.Add(Me.lbl_ID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_contact)
        Me.Controls.Add(Me.txt_salary)
        Me.Controls.Add(Me.txt_post)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.lis_ID)
        Me.Controls.Add(Me.txt_pic)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lbl_details)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_up)
        Me.Controls.Add(Me.grd_staff)
        Me.Controls.Add(Me.pic_staff)
        Me.Controls.Add(Me.btn_back)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_editstaffdetails_a176252"
        Me.Text = "Edit Staff Details"
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lis_ID As ListBox
    Friend WithEvents txt_pic As TextBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_details As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_picture As Button
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_up As Button
    Friend WithEvents grd_staff As DataGridView
    Friend WithEvents pic_staff As PictureBox
    Friend WithEvents btn_back As Button
    Friend WithEvents lbl_contact As Label
    Friend WithEvents lbl_salary As Label
    Friend WithEvents lbl_pos As Label
    Friend WithEvents lbl_ID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_contact As TextBox
    Friend WithEvents txt_salary As TextBox
    Friend WithEvents txt_post As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_ID As TextBox
End Class
