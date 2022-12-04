Public Class frm_customerdetails_a176252
    Private Sub frm_customerdetails_a176252_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_RARECOINAGESHOP_A176252.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMERS_A176252"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection2)
        myreader.Fill(mydatatable)
        grd_cus.DataSource = mydatatable

        lis_ID.DataSource = mydatatable
        lis_ID.DisplayMember = "FLD_CUSTOMER_ID"

        refresh_text(lis_ID.Text)
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

        Try
            pic_cus.BackgroundImage = Image.FromFile("pictures/" & txt_ID.Text & ".jpg")
        Catch ex As Exception
            pic_cus.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try

    End Sub

    Private Sub lis_ID_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lis_ID.MouseClick
        refresh_text(lis_ID.Text)
    End Sub

    Private Sub grid_cus_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_cus.CellContentClick
        refresh_text(lis_ID.Text)
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        frm_editCustomerDetails_a176252.Refresh()
        frm_editCustomerDetails_a176252.Show()
        pic_cus.BackgroundImage = Image.FromFile("pictures/empty.jpg")
        Me.Close()
    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs)
        frm_mainmenu_a176252.Show()
        Me.Close()
    End Sub

    Private Sub btn_add_Click_1(sender As Object, e As EventArgs) Handles btn_add.Click
        frm_insertcustomer_a176252.Refresh()
        frm_insertcustomer_a176252.Show()
        pic_cus.BackgroundImage = Image.FromFile("pictures/empty.jpg")
        Me.Close()
    End Sub
End Class