Public Class frm_invoicedetails_a176252
    Private Sub frm_invoicedetails_a176252_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT SUM(o.FLD_ORDER_QUANTITY * p.FLD_PRODUCT_PRICE) AS TotalPrice FROM TBL_ORDER_A176252 o, TBL_PRODUCTS_A176252 p WHERE p.FLD_PRODUCT_ID = o.FLD_PRODUCT_ID AND FLD_ORDER_ID ='" & Order_ID & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection2)
        myreader.Fill(mydatatable)
        Try
            txt_total.Text = mydatatable.Rows(0).Item("TotalPrice")
            grd_order.DataSource = run_sql_query("SELECT TBL_PRODUCTS_A176252.FLD_PRODUCT_NAME, TBL_ORDER_A176252.FLD_ORDER_QUANTITY, TBL_PRODUCTS_A176252.FLD_PRODUCT_PRICE, [FLD_ORDER_QUANTITY]*[FLD_PRODUCT_PRICE] AS [Total Price] FROM TBL_PRODUCTS_A176252 INNER JOIN TBL_ORDER_A176252 ON TBL_PRODUCTS_A176252.[FLD_PRODUCT_ID] = TBL_ORDER_A176252.[FLD_PRODUCT_ID] WHERE TBL_ORDER_A176252.FLD_ORDER_ID ='" & Order_ID & "'")
            grd_order.Columns(0).HeaderText = "Product Name"
            grd_order.Columns(0).Width = 350
            grd_order.Columns(1).HeaderText = "Quantity"
            grd_order.Columns(1).Width = 50
            grd_order.Columns(2).HeaderText = "Unit Price($)"
            grd_order.Columns(2).Width = 100
            grd_order.Columns(3).HeaderText = "Total Price($)"
            grd_order.Columns(3).Width = 100
            txt_ID.Text = Order_ID
            txt_date.Text = Order_Date
            txt_tax.Text = txt_total.Text * 0.06
            txt_overall.Text = txt_total.Text + +txt_tax.Text
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        frm_order_a176252.Show()
        Me.Close()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_history_a176252.Show()
        Me.Close()
    End Sub

End Class