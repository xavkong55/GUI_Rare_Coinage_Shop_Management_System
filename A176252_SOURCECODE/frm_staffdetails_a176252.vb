Public Class frm_staffdetails_a176252
    Private Sub frm_staffdetails_a176252_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM TBL_STAFFS_A176252"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection2)
        myreader.Fill(mydatatable)
        grd_staff.DataSource = mydatatable

        lis_ID.DataSource = mydatatable
        lis_ID.DisplayMember = "FLD_STAFF_ID"

        refresh_text(lis_ID.Text)
    End Sub
    Private Sub refresh_text(ID As String)
        Dim mysql As String = "SELECT * FROM TBL_STAFFS_A176252 WHERE FLD_STAFF_ID='" & ID & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        Try
            txt_ID.Text = mydatatable.Rows(0).Item("FLD_STAFF_ID")
            txt_name.Text = mydatatable.Rows(0).Item("FLD_STAFF_NAME")
            txt_post.Text = mydatatable.Rows(0).Item("FLD_STAFF_POSITION")
            txt_salary.Text = mydatatable.Rows(0).Item("FLD_STAFF_SALARY")
            txt_contact.Text = mydatatable.Rows(0).Item("FLD_STAFF_CONTACTNUM")
            grd_staff.Columns(0).HeaderText = "Staff ID"
            grd_staff.Columns(1).HeaderText = "Name"
            grd_staff.Columns(2).HeaderText = "Position"
            grd_staff.Columns(3).HeaderText = "Salary"
            grd_staff.Columns(4).HeaderText = "Contact Number (+60)"

        Catch ex As Exception
        End Try

        Try
            pic_staff.BackgroundImage = Image.FromFile("pictures/" & txt_ID.Text & ".jpg")
        Catch ex As Exception
            pic_staff.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try

    End Sub
    Private Sub lis_ID_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lis_ID.MouseClick
        refresh_text(lis_ID.Text)
    End Sub
    Private Sub grd_staff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellContentClick
        refresh_text(lis_ID.Text)
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        frm_editstaffdetails_a176252.Show()
        pic_staff.BackgroundImage = Image.FromFile("pictures/empty.jpg")
        Me.Close()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        frm_insertstaff_A176252.Show()
        pic_staff.BackgroundImage = Image.FromFile("pictures/empty.jpg")
        Me.Close()
    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a176252.Show()
        Me.Close()
    End Sub

End Class