Imports System.IO

Public Class frm_editCustomerDetails_a176252
    Private Sub frm_editCustomerDetails_a176252_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMERS_A176252"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection2)
        myreader.Fill(mydatatable)
        grd_cus.DataSource = mydatatable
        lis_ID.DataSource = mydatatable
        lis_ID.DisplayMember = "FLD_CUSTOMER_ID"
        refresh_text(lis_ID.Text)
    End Sub

    Private Sub refresh_grd()
        Dim mysql2 As String = "SELECT * FROM TBL_CUSTOMERS_A176252"
        Dim mydatatable2 As New DataTable
        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection2)
        myreader2.Fill(mydatatable2)
        grd_cus.DataSource = mydatatable2
    End Sub
    Private Sub refresh_text(ID As String)
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMERS_A176252 WHERE FLD_CUSTOMER_ID='" & ID & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        Try
            txt_ID.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_ID")
            txt_name.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_NAME")
            txt_IC.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_IC")
            txt_gender.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_GENDER")
            txt_contact.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_CONTACTNUM")
            grd_cus.Columns(0).HeaderText = "Customer ID"
            grd_cus.Columns(1).HeaderText = "Name"
            grd_cus.Columns(2).HeaderText = "IC"
            grd_cus.Columns(3).HeaderText = "Gender"
            grd_cus.Columns(4).HeaderText = "Contact Number (+60)"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lis_ID_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lis_ID.MouseClick
        refresh_text(lis_ID.Text)
    End Sub
    Private Sub grid_cus_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_cus.CellContentClick
        refresh_text(lis_ID.Text)
    End Sub
    Private Sub btn_up_Click(sender As Object, e As EventArgs) Handles btn_up.Click
        Dim update_confirmation = MsgBox("Are you sure you would like to update the customer details with """ & lis_ID.Text & """?", MsgBoxStyle.YesNo)
        If update_confirmation = MsgBoxResult.Yes Then
            If txt_pic.Text IsNot "" Then
                If System.IO.File.Exists("pictures/" & lis_ID.Text & ".jpg") Then
                    System.IO.File.Delete("pictures/" & lis_ID.Text & ".jpg")
                End If
                My.Computer.FileSystem.CopyFile(txt_pic.Text, "pictures\" & lis_ID.Text & ".jpg")
            End If
            run_sql_command("UPDATE TBL_CUSTOMERS_A176252 SET FLD_CUSTOMER_NAME='" & txt_name.Text & "', FLD_CUSTOMER_IC='" & txt_IC.Text & "', FLD_CUSTOMER_GENDER='" & txt_gender.Text & "', FLD_CUSTOMER_CONTACTNUM='" & txt_contact.Text & "' WHERE FLD_CUSTOMER_ID='" & lis_ID.Text & "'")
            If message = "Yes" Then
                Beep()
                MsgBox("You have successfully updated the customer details with ID """ & lis_ID.Text & """.")
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
            pic_cus.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            txt_pic.Text = OpenFileDialog1.FileName
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the course """ & lis_ID.Text & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_CUSTOMERS_A176252 WHERE FLD_CUSTOMER_ID='" & lis_ID.Text & "'")
            If System.IO.File.Exists("pictures/" & lis_ID.Text & ".jpg") Then
                System.IO.File.Delete("pictures/" & lis_ID.Text & ".jpg")
            End If
            If message = "Yes" Then
                Beep()
                MsgBox("You have successfully deleted the customer with ID """ & lis_ID.Text & """.")
                refresh_grd()
            End If
        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_customerdetails_a176252.Refresh()
        frm_customerdetails_a176252.Show()
        Me.Close()
    End Sub
End Class