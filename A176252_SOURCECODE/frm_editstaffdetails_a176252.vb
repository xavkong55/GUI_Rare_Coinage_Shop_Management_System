Public Class frm_editstaffdetails_a176252
    Private Sub frm_editstaffdetails_a176252_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM TBL_STAFFS_A176252"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection2)
        myreader.Fill(mydatatable)
        grd_staff.DataSource = mydatatable
        lis_ID.DataSource = mydatatable
        lis_ID.DisplayMember = "FLD_STAFF_ID"
        refresh_text(lis_ID.Text)
    End Sub
    Private Sub refresh_grd()
        Dim mysql2 As String = "SELECT * FROM TBL_STAFFS_A176252"
        Dim mydatatable2 As New DataTable
        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection2)
        myreader2.Fill(mydatatable2)
        grd_staff.DataSource = mydatatable2
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
    End Sub
    Private Sub lis_ID_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lis_ID.MouseClick
        refresh_text(lis_ID.Text)
    End Sub
    Private Sub grid_staff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellContentClick
        refresh_text(lis_ID.Text)
    End Sub
    Private Sub btn_up_Click(sender As Object, e As EventArgs) Handles btn_up.Click
        Dim update_confirmation = MsgBox("Are you sure you would like to update the staff details with the """ & lis_ID.Text & """?", MsgBoxStyle.YesNo)
        If update_confirmation = MsgBoxResult.Yes Then
            If txt_pic.Text IsNot "" Then
                If System.IO.File.Exists("pictures/" & lis_ID.Text & ".jpg") Then
                    System.IO.File.Delete("pictures/" & lis_ID.Text & ".jpg")
                End If
                My.Computer.FileSystem.CopyFile(txt_pic.Text, "pictures\" & lis_ID.Text & ".jpg")
            End If
            run_sql_command("UPDATE TBL_STAFFS_A176252 SET FLD_STAFF_NAME='" & txt_name.Text & "', FLD_STAFF_POSITION='" & txt_post.Text & "', FLD_STAFF_SALARY='" & txt_salary.Text & "', FLD_STAFF_CONTACTNUM='" & txt_contact.Text & "' WHERE FLD_STAFF_ID='" & lis_ID.Text & "'")
            If message = "Yes" Then
                Beep()
                MsgBox("You have successfully updated the staff details with ID """ & lis_ID.Text & """.")
                refresh_grd()
            End If
        End If

    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()
        Try
            pic_staff.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            txt_pic.Text = OpenFileDialog1.FileName
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the staff with ID """ & lis_ID.Text & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_STAFFS_A176252 WHERE FLD_STAFF_ID='" & lis_ID.Text & "'")
            If System.IO.File.Exists("pictures/" & lis_ID.Text & ".jpg") Then
                System.IO.File.Delete("pictures/" & lis_ID.Text & ".jpg")
            End If
            If message = "Yes" Then
                Beep()
                MsgBox("You have successfully deleted the staff with ID """ & lis_ID.Text & """.")
                refresh_grd()
            End If
        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_staffdetails_a176252.Show()
        pic_staff.BackgroundImage = Image.FromFile("pictures/empty.jpg")
        Me.Close()
    End Sub

End Class