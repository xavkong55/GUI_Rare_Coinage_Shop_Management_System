Public Class frm_product_a176252
    Private Sub frm_product_a176252_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Try
            pic_coin.BackgroundImage = Image.FromFile("pictures/" & txt_ID.Text & ".jpg")
        Catch ex As Exception
            pic_coin.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
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

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        frm_insertproduct_a176252.Show()
        pic_coin.BackgroundImage = Image.FromFile("pictures/empty.jpg")
        Me.Close()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        frm_editproductdetails_a176252.Show()
        pic_coin.BackgroundImage = Image.FromFile("pictures/empty.jpg")
        Me.Close()

    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a176252.Show()
        Me.Close()
    End Sub
End Class