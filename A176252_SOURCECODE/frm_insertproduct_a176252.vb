Public Class frm_insertproduct_a176252
    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"
    Private Sub frm_insertstaff_A176252_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        txt_ID.Text = generate_matric()
        txt_picture.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)
        txt_price.Text = ""
    End Sub
    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A176252"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection2)
        myreader.Fill(mydatatable)
        grd_product.DataSource = mydatatable
        grd_product.Columns(0).HeaderText = "ID"
        grd_product.Columns(1).HeaderText = "NAME"
        grd_product.Columns(2).HeaderText = "PRICE($)"
        grd_product.Columns(3).HeaderText = "YEAR"
        grd_product.Columns(4).HeaderText = "COUNTRY"
        grd_product.Columns(5).HeaderText = "SIZE"
        grd_product.Columns(6).HeaderText = "QUANTITY"
        grd_product.Columns(7).HeaderText = "DESCRIPTION"
    End Sub
    Private Sub clear_fields()
        txt_name.Text = ""
        txt_price.Text = ""
        txt_year.Text = ""
        txt_country.Text = ""
        txt_size.Text = ""
        txt_quantity.Text = ""
        txt_description.Text = ""
    End Sub
    Private Function generate_matric() As String
        Dim lastmatric As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTMATRIC FROM TBL_PRODUCTS_A176252").Rows(0).Item("LASTMATRIC")
        Dim newmatric As String = "MA" & Mid(lastmatric, 3) + 1
        Return newmatric
    End Function
    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()
        Try
            pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            txt_picture.Text = OpenFileDialog1.FileName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim sql As String = "SELECT * FROM TBL_PRODUCTS_A176252 WHERE FLD_PRODUCT_ID='" & txt_ID.Text & "'"
        Dim myreader As New OleDb.OleDbDataAdapter(sql, myconnection2)
        Dim mydatatable As New DataTable
        myreader.Fill(mydatatable)
        Dim confirmation = MsgBox("Are you sure you want to add this?", MsgBoxStyle.YesNo)
        If confirmation = MsgBoxResult.Yes Then
            If mydatatable.Rows.Count.Equals(0) And txt_ID.Text.Substring(0, 1).Equals("M") And Char.IsLetter(txt_ID.Text.Substring(1, 2)) Then
                Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A176252 VALUES ('" & txt_ID.Text & "', '" & txt_name.Text & "', '" & txt_price.Text & "', '" & txt_year.Text & "', '" & txt_country.Text & "', '" & txt_size.Text & "', '" & txt_quantity.Text & "', '" & txt_description.Text & "')"
                Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
                Try
                    mywriter.Connection.Open()
                    mywriter.ExecuteNonQuery()
                    mywriter.Connection.Close()
                    If System.IO.File.Exists("pictures/" & txt_ID.Text & ".jpg") Then
                        System.IO.File.Delete("pictures/" & txt_ID.Text & ".jpg")
                    End If
                    My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_ID.Text & ".jpg")
                    grd_product.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A176252")
                    txt_ID.Text = generate_matric()
                    clear_fields()
                    pic_product.BackgroundImage = Image.FromFile(defaultpicture)
                Catch ex As Exception
                    Beep()
                    MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)
                    mywriter.Connection.Close()
                End Try
            Else
                Beep()
                MsgBox("Error: Duplicate ID is not allowed")
            End If
        End If
    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_product_a176252.Show()
        pic_product.BackgroundImage = Image.FromFile("pictures/empty.jpg")
        Me.Close()
    End Sub
End Class