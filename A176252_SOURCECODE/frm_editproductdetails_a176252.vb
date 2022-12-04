Public Class frm_editproductdetails_a176252
    Private Sub frm_editproductdetails_a176252_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A176252"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection2)
        myreader.Fill(mydatatable)
        lis_ID.DataSource = mydatatable
        lis_ID.DisplayMember = "FLD_PRODUCT_ID"
        countrylist()
        refresh_text(lis_ID.Text)
    End Sub
    Private Sub refresh_text(ID As String)
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A176252 WHERE FLD_PRODUCT_ID='" & ID & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        Try
            txt_ID.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
            txt_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
            txt_price.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_PRICE")
            txt_year.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_YEAR")
            txt_country.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_COUNTRY")
            txt_size.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_SIZE")
            txt_quantity.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_QUANTITY")
            txt_description.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_DESCRIPTION")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub lis_ID_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lis_ID.MouseClick
        refresh_text(lis_ID.Text)
    End Sub
    Private Sub countrylist()
        Dim mysql As String = "SELECT * FROM TBL_COUNTRY_A176252"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection2)
        myreader.Fill(mydatatable)
        grid_country.DataSource = mydatatable
        grid_country.Columns(0).HeaderText = "Country ID"
        grid_country.Columns(1).HeaderText = "Country Name"

    End Sub
    Private Sub btn_up_Click(sender As Object, e As EventArgs) Handles btn_up.Click
        Dim update_confirmation = MsgBox("Are you sure you would like to update the product details with """ & lis_ID.Text & """?", MsgBoxStyle.YesNo)
        If update_confirmation = MsgBoxResult.Yes Then
            If txt_pic.Text IsNot "" Then
                If System.IO.File.Exists("pictures/" & lis_ID.Text & ".jpg") Then
                    System.IO.File.Delete("pictures/" & lis_ID.Text & ".jpg")
                End If
                My.Computer.FileSystem.CopyFile(txt_pic.Text, "pictures\" & lis_ID.Text & ".jpg")
            End If
            run_sql_command("UPDATE TBL_PRODUCTS_A176252 SET FLD_PRODUCT_NAME='" & txt_name.Text & "', FLD_PRODUCT_PRICE='" & txt_price.Text & "', FLD_PRODUCT_YEAR='" & txt_year.Text & "', FLD_PRODUCT_COUNTRY='" & txt_country.Text & "',FLD_PRODUCT_SIZE='" & txt_size.Text & "',FLD_PRODUCT_QUANTITY='" & txt_quantity.Text & "', FLD_PRODUCT_DESCRIPTION='" & txt_description.Text & "' WHERE FLD_PRODUCT_ID='" & lis_ID.Text & "'")
            If message = "Yes" Then
                Beep()
                MsgBox("You have successfully updated the product details with ID """ & lis_ID.Text & """.")
            End If
            pic_coin.BackgroundImage.Dispose()
        End If
    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()
        Try
            pic_coin.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            txt_pic.Text = OpenFileDialog1.FileName
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product """ & lis_ID.Text & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_PRODUCTS_A176252 WHERE FLD_PRODUCT_ID='" & lis_ID.Text & "'")
            If System.IO.File.Exists("pictures/" & lis_ID.Text & ".jpg") Then
                System.IO.File.Delete("pictures/" & lis_ID.Text & ".jpg")
            End If
            If message = "Yes" Then
                Beep()
                MsgBox("You have successfully deleted the product with ID """ & lis_ID.Text & """.")
            End If
        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_product_a176252.Show()
        pic_coin.BackgroundImage = Image.FromFile("pictures/empty.jpg")
        Me.Close()
    End Sub
End Class