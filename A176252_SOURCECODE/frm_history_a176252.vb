Public Class frm_history_a176252
    Private Sub frm_history_a176252_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
    End Sub
    Private Sub refresh_grid()
        Try
            Dim mysql As String = "SELECT * FROM TBL_ORDER_A176252"
            Dim mydatatable As New DataTable
            Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection2)
            myreader.Fill(mydatatable)
            grd_order.DataSource = mydatatable
            grd_order.Columns(0).HeaderText = "ORDER ID"
            grd_order.Columns(1).HeaderText = "DATE"
            grd_order.Columns(2).HeaderText = "PRODUCT ID"
            grd_order.Columns(3).HeaderText = "STAFF ID"
            grd_order.Columns(4).HeaderText = "CUSTOMER ID"
            grd_order.Columns(5).HeaderText = "QUANTITY"
            grd_order.Columns(3).Width() = 80
            grd_order.Columns(4).Width() = 120
            grd_order.Columns(5).Width() = 70
            lis_ID.DataSource = mydatatable
            lis_ID.DisplayMember = "FLD_ORDER_ID"
            Order_ID = mydatatable.Rows(0).Item("FLD_ORDER_ID")
        Catch e As Exception
        End Try
    End Sub

    Private Sub refresh_text()
        Order_ID = lis_ID.Text
    End Sub
    Private Sub lis_ID_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lis_ID.MouseClick
        refresh_text()
    End Sub

    Private Sub txt_invoice_Click(sender As Object, e As EventArgs) Handles txt_invoice.Click
        If Order_ID <> "" Then
            Dim mysql As String = "SELECT * FROM TBL_ORDER_A176252 WHERE FLD_ORDER_ID ='" & Order_ID & "'"
            Dim mydatatable As New DataTable
            Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection2)
            Try
                myreader.Fill(mydatatable)
                Order_Date = mydatatable.Rows(0).Item("FLD_ORDER_DATE")
                frm_invoicedetails_a176252.Show()
                Me.Close()
            Catch ex As Exception
            End Try
        Else
            MsgBox("Nothing to show")
        End If
    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a176252.Show()
        Me.Close()
    End Sub
End Class