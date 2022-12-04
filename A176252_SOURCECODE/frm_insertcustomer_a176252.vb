Public Class frm_insertcustomer_a176252
    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"
    Private Sub frm_insertcustomer_A176252_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        txt_ID.Text = generate_matric()
        txt_picture.Text = defaultpicture
        pic_cus.BackgroundImage = Image.FromFile(defaultpicture)
    End Sub
    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMERS_A176252"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection2)
        myreader.Fill(mydatatable)
        grd_customer.DataSource = mydatatable
    End Sub
    Private Sub clear_fields()
        txt_name.Text = ""
        txt_IC.Text = ""
        txt_gender.Text = ""
        txt_contact.Text = ""
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim sql As String = "SELECT * FROM TBL_CUSTOMERS_A176252 WHERE FLD_CUSTOMER_ID='" & txt_ID.Text & "'"
        Dim myreader As New OleDb.OleDbDataAdapter(sql, myconnection2)
        Dim mydatatable As New DataTable
        myreader.Fill(mydatatable)
        Dim confirmation = MsgBox("Are you sure you want to add this?", MsgBoxStyle.YesNo)
        If confirmation = MsgBoxResult.Yes Then
            If mydatatable.Rows.Count.Equals(0) And txt_ID.Text.Substring(0, 1).Equals("C") Then
                Dim mysql As String = "INSERT INTO TBL_CUSTOMERS_A176252 VALUES ('" & txt_ID.Text & "', '" & txt_name.Text & "', '" & txt_IC.Text & "', '" & txt_gender.Text & "', '" & txt_contact.Text & "')"
                Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
                Try
                    mywriter.Connection.Open()
                    mywriter.ExecuteNonQuery()
                    mywriter.Connection.Close()
                    If System.IO.File.Exists("pictures/" & txt_ID.Text & ".jpg") Then
                        System.IO.File.Delete("pictures/" & txt_ID.Text & ".jpg")
                    End If
                    My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_ID.Text & ".jpg")
                    grd_customer.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMERS_A176252")
                    txt_ID.Text = generate_matric()
                    clear_fields()
                    pic_cus.BackgroundImage = Image.FromFile(defaultpicture)
                Catch ex As Exception
                    Beep()
                    MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)
                    mywriter.Connection.Close()
                End Try
            Else
                Beep()
                MsgBox("Error: Duplicate and Wrong ID is not allowed")
            End If
        End If

    End Sub
    Private Function generate_matric() As String
        Dim lastmatric As String = run_sql_query("SELECT MAX(FLD_CUSTOMER_ID) AS LASTMATRIC FROM TBL_CUSTOMERS_A176252").Rows(0).Item("LASTMATRIC")
        Dim newmatric As String = "C" & Mid(lastmatric, 2) + 1
        Return newmatric
    End Function
    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()
        Try
            pic_cus.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            txt_picture.Text = OpenFileDialog1.FileName
        Catch ex As Exception

        End Try
    End Sub
    Private Sub grd_customer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customer.CellContentClick
        refresh_text(txt_ID.Text)
    End Sub
    Private Sub refresh_text(ID As String)
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMERS_A176252 WHERE FLD_CUSTOMER_ID='" & ID & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection2)
        myreader.Fill(mydatatable)
        Try
            txt_ID.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_ID")
            txt_name.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_NAME")
            txt_IC.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_IC")
            txt_gender.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_GENDER")
            txt_contact.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_CONTACTNUM")
            grd_customer.Columns(0).HeaderText = "Customer ID"
            grd_customer.Columns(1).HeaderText = "Name"
            grd_customer.Columns(2).HeaderText = "IC"
            grd_customer.Columns(3).HeaderText = "Gender"
            grd_customer.Columns(4).HeaderText = "Contact Number"
        Catch ex As Exception

        End Try

        Try
            pic_cus.BackgroundImage = Image.FromFile("pictures/" & txt_ID.Text & ".jpg")
        Catch ex As Exception
            pic_cus.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try

    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_customerdetails_a176252.Show()
        pic_cus.BackgroundImage = Image.FromFile("pictures/empty.jpg")
        Me.Close()
    End Sub
End Class