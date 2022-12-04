<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_staffdetails_a176252
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_staffdetails_a176252))
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
        Me.grd_staff = New System.Windows.Forms.DataGridView()
        Me.pic_staff = New System.Windows.Forms.PictureBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lis_ID = New System.Windows.Forms.ListBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_contact
        '
        Me.lbl_contact.AutoSize = True
        Me.lbl_contact.Location = New System.Drawing.Point(28, 391)
        Me.lbl_contact.Name = "lbl_contact"
        Me.lbl_contact.Size = New System.Drawing.Size(137, 17)
        Me.lbl_contact.TabIndex = 26
        Me.lbl_contact.Text = "CONTACT NUMBER"
        '
        'lbl_salary
        '
        Me.lbl_salary.AutoSize = True
        Me.lbl_salary.Location = New System.Drawing.Point(28, 360)
        Me.lbl_salary.Name = "lbl_salary"
        Me.lbl_salary.Size = New System.Drawing.Size(62, 17)
        Me.lbl_salary.TabIndex = 25
        Me.lbl_salary.Text = "SALARY"
        '
        'lbl_pos
        '
        Me.lbl_pos.AutoSize = True
        Me.lbl_pos.Location = New System.Drawing.Point(28, 332)
        Me.lbl_pos.Name = "lbl_pos"
        Me.lbl_pos.Size = New System.Drawing.Size(73, 17)
        Me.lbl_pos.TabIndex = 24
        Me.lbl_pos.Text = "POSITION"
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Location = New System.Drawing.Point(28, 276)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(21, 17)
        Me.lbl_ID.TabIndex = 23
        Me.lbl_ID.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 304)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "NAME"
        '
        'txt_contact
        '
        Me.txt_contact.Location = New System.Drawing.Point(175, 388)
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.Size = New System.Drawing.Size(175, 22)
        Me.txt_contact.TabIndex = 21
        '
        'txt_salary
        '
        Me.txt_salary.Location = New System.Drawing.Point(175, 360)
        Me.txt_salary.Name = "txt_salary"
        Me.txt_salary.Size = New System.Drawing.Size(175, 22)
        Me.txt_salary.TabIndex = 20
        '
        'txt_post
        '
        Me.txt_post.Location = New System.Drawing.Point(175, 332)
        Me.txt_post.Name = "txt_post"
        Me.txt_post.Size = New System.Drawing.Size(175, 22)
        Me.txt_post.TabIndex = 19
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(175, 304)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(175, 22)
        Me.txt_name.TabIndex = 18
        '
        'txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(175, 276)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(175, 22)
        Me.txt_ID.TabIndex = 17
        '
        'grd_staff
        '
        Me.grd_staff.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grd_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staff.Location = New System.Drawing.Point(21, 64)
        Me.grd_staff.Name = "grd_staff"
        Me.grd_staff.RowHeadersWidth = 51
        Me.grd_staff.RowTemplate.Height = 24
        Me.grd_staff.Size = New System.Drawing.Size(544, 196)
        Me.grd_staff.TabIndex = 16
        '
        'pic_staff
        '
        Me.pic_staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_staff.Location = New System.Drawing.Point(582, 65)
        Me.pic_staff.Name = "pic_staff"
        Me.pic_staff.Size = New System.Drawing.Size(176, 195)
        Me.pic_staff.TabIndex = 15
        Me.pic_staff.TabStop = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_back.Font = New System.Drawing.Font("Lemon", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(610, 388)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(121, 43)
        Me.btn_back.TabIndex = 14
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'lis_ID
        '
        Me.lis_ID.FormattingEnabled = True
        Me.lis_ID.ItemHeight = 16
        Me.lis_ID.Location = New System.Drawing.Point(381, 276)
        Me.lis_ID.Name = "lis_ID"
        Me.lis_ID.Size = New System.Drawing.Size(144, 132)
        Me.lis_ID.TabIndex = 34
        '
        'lbl_title
        '
        Me.lbl_title.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_title.Font = New System.Drawing.Font("Bernard MT Condensed", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(197, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(400, 40)
        Me.lbl_title.TabIndex = 35
        Me.lbl_title.Text = "STAFF DETAILS"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_add.Font = New System.Drawing.Font("Lemon", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(667, 318)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(121, 43)
        Me.btn_add.TabIndex = 67
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_edit.Font = New System.Drawing.Font("Lemon", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(539, 318)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(121, 43)
        Me.btn_edit.TabIndex = 66
        Me.btn_edit.Text = "EDIT"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'frm_staffdetails_a176252
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lis_ID)
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
        Me.Controls.Add(Me.grd_staff)
        Me.Controls.Add(Me.pic_staff)
        Me.Controls.Add(Me.btn_back)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_staffdetails_a176252"
        Me.Text = " Staff Details"
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents grd_staff As DataGridView
    Friend WithEvents pic_staff As PictureBox
    Friend WithEvents btn_back As Button
    Friend WithEvents lis_ID As ListBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_edit As Button
End Class
