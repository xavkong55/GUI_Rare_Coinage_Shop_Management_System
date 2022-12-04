<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_customerdetails_a176252
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
        Dim btn_back As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_customerdetails_a176252))
        Me.pic_cus = New System.Windows.Forms.PictureBox()
        Me.grd_cus = New System.Windows.Forms.DataGridView()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_IC = New System.Windows.Forms.TextBox()
        Me.txt_gender = New System.Windows.Forms.TextBox()
        Me.txt_contact = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_gender = New System.Windows.Forms.Label()
        Me.lbl_contact = New System.Windows.Forms.Label()
        Me.lbl_details = New System.Windows.Forms.Label()
        Me.lis_ID = New System.Windows.Forms.ListBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        btn_back = New System.Windows.Forms.Button()
        CType(Me.pic_cus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_cus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        btn_back.BackColor = System.Drawing.SystemColors.InactiveCaption
        btn_back.Font = New System.Drawing.Font("Lemon", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btn_back.Location = New System.Drawing.Point(607, 384)
        btn_back.Name = "btn_back"
        btn_back.Size = New System.Drawing.Size(121, 43)
        btn_back.TabIndex = 0
        btn_back.Text = "BACK"
        btn_back.UseVisualStyleBackColor = False
        AddHandler btn_back.Click, AddressOf Me.btn_back_Click
        '
        'pic_cus
        '
        Me.pic_cus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_cus.Location = New System.Drawing.Point(593, 64)
        Me.pic_cus.Name = "pic_cus"
        Me.pic_cus.Size = New System.Drawing.Size(177, 198)
        Me.pic_cus.TabIndex = 1
        Me.pic_cus.TabStop = False
        '
        'grd_cus
        '
        Me.grd_cus.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grd_cus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_cus.Location = New System.Drawing.Point(28, 64)
        Me.grd_cus.Name = "grd_cus"
        Me.grd_cus.RowHeadersWidth = 51
        Me.grd_cus.RowTemplate.Height = 24
        Me.grd_cus.Size = New System.Drawing.Size(546, 198)
        Me.grd_cus.TabIndex = 2
        '
        'txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(183, 280)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(175, 22)
        Me.txt_ID.TabIndex = 3
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(183, 308)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(175, 22)
        Me.txt_name.TabIndex = 4
        '
        'txt_IC
        '
        Me.txt_IC.Location = New System.Drawing.Point(183, 336)
        Me.txt_IC.Name = "txt_IC"
        Me.txt_IC.Size = New System.Drawing.Size(175, 22)
        Me.txt_IC.TabIndex = 5
        '
        'txt_gender
        '
        Me.txt_gender.Location = New System.Drawing.Point(183, 364)
        Me.txt_gender.Name = "txt_gender"
        Me.txt_gender.Size = New System.Drawing.Size(175, 22)
        Me.txt_gender.TabIndex = 6
        '
        'txt_contact
        '
        Me.txt_contact.Location = New System.Drawing.Point(183, 392)
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.Size = New System.Drawing.Size(175, 22)
        Me.txt_contact.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "NAME"
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Location = New System.Drawing.Point(35, 280)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(21, 17)
        Me.lbl_ID.TabIndex = 10
        Me.lbl_ID.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "IC"
        '
        'lbl_gender
        '
        Me.lbl_gender.AutoSize = True
        Me.lbl_gender.Location = New System.Drawing.Point(34, 364)
        Me.lbl_gender.Name = "lbl_gender"
        Me.lbl_gender.Size = New System.Drawing.Size(67, 17)
        Me.lbl_gender.TabIndex = 12
        Me.lbl_gender.Text = "GENDER"
        '
        'lbl_contact
        '
        Me.lbl_contact.AutoSize = True
        Me.lbl_contact.Location = New System.Drawing.Point(34, 395)
        Me.lbl_contact.Name = "lbl_contact"
        Me.lbl_contact.Size = New System.Drawing.Size(137, 17)
        Me.lbl_contact.TabIndex = 13
        Me.lbl_contact.Text = "CONTACT NUMBER"
        '
        'lbl_details
        '
        Me.lbl_details.AutoSize = True
        Me.lbl_details.Location = New System.Drawing.Point(343, 9)
        Me.lbl_details.Name = "lbl_details"
        Me.lbl_details.Size = New System.Drawing.Size(0, 17)
        Me.lbl_details.TabIndex = 32
        '
        'lis_ID
        '
        Me.lis_ID.FormattingEnabled = True
        Me.lis_ID.ItemHeight = 16
        Me.lis_ID.Location = New System.Drawing.Point(377, 280)
        Me.lis_ID.Name = "lis_ID"
        Me.lis_ID.Size = New System.Drawing.Size(144, 132)
        Me.lis_ID.TabIndex = 33
        '
        'lbl_title
        '
        Me.lbl_title.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_title.Font = New System.Drawing.Font("Bernard MT Condensed", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(203, 11)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(400, 40)
        Me.lbl_title.TabIndex = 34
        Me.lbl_title.Text = "CUSTOMER DETAILS"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_edit.Font = New System.Drawing.Font("Lemon", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(541, 325)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(121, 43)
        Me.btn_edit.TabIndex = 64
        Me.btn_edit.Text = "EDIT"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btn_add.Font = New System.Drawing.Font("Lemon", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(668, 325)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(121, 43)
        Me.btn_add.TabIndex = 65
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'frm_customerdetails_a176252
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lis_ID)
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
        Me.Controls.Add(btn_back)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_customerdetails_a176252"
        Me.Text = "Customer Details"
        CType(Me.pic_cus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_cus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frm_editCustomerDetails_a176252.Show()
        Me.Hide()
    End Sub

    Friend WithEvents pic_cus As PictureBox
    Friend WithEvents grd_cus As DataGridView
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_IC As TextBox
    Friend WithEvents txt_gender As TextBox
    Friend WithEvents txt_contact As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_ID As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_gender As Label
    Friend WithEvents lbl_contact As Label
    Friend WithEvents lbl_details As Label
    Friend WithEvents lis_ID As ListBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_add As Button
End Class
