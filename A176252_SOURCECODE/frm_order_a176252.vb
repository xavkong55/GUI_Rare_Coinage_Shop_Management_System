Public Class frm_order_a176252
    Dim OrderID As String = ""
    Dim Count As Integer = 0
    Dim cus_ID As String
    Dim staff_ID As String
    Dim list As New Stack
    Private Sub frm_order_a176252_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A176252"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection2)
        myreader.Fill(mydatatable)
        lis_ID.DataSource = mydatatable
        lis_ID.DisplayMember = "FLD_PRODUCT_ID"
        txt_date.Text = Date.Today.ToShortDateString
        StaffID()
        CustomerID()
        generate_matric()
        refresh_text(lis_ID.Text)
        grd_order.DataSource = run_sql_query("SELECT TBL_PRODUCTS_A176252.FLD_PRODUCT_NAME, TBL_ORDER_A176252.FLD_ORDER_QUANTITY, TBL_PRODUCTS_A176252.FLD_PRODUCT_PRICE, [FLD_ORDER_QUANTITY]*[FLD_PRODUCT_PRICE] AS [Total Price] FROM TBL_PRODUCTS_A176252 INNER JOIN TBL_ORDER_A176252 ON TBL_PRODUCTS_A176252.[FLD_PRODUCT_ID] = TBL_ORDER_A176252.[FLD_PRODUCT_ID] WHERE TBL_ORDER_A176252.FLD_ORDER_ID ='" & txt_productID.Text & "'")
        grd_order.Columns(0).HeaderText = "Product Name"
        grd_order.Columns(0).Width = 200
        grd_order.Columns(1).HeaderText = "Quantity"
        grd_order.Columns(2).HeaderText = "Unit Price($)"
        grd_order.Columns(3).HeaderText = "Total Price($)"
    End Sub
    Private Sub refresh_text(ID As String)
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A176252 WHERE FLD_PRODUCT_ID='" & ID & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection2)
        myreader.Fill(mydatatable)
        Try
            txt_productID.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
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
            pic_coin.BackgroundImage = Image.FromFile("pictures/" & txt_productID.Text & ".jpg")
        Catch ex As Exception
            pic_coin.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try
    End Sub
    Private Sub lis_ID_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lis_ID.MouseClick
        refresh_text(lis_ID.Text)
    End Sub
    Private Sub StaffID()
        Dim mysql As String = "SELECT * FROM TBL_STAFFS_A176252"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection2)
        myreader.Fill(mydatatable)
        txt_staffID.DataSource = mydatatable
        txt_staffID.DisplayMember = "FLD_STAFF_ID"
    End Sub
    Private Sub CustomerID()
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMERS_A176252"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection2)
        myreader.Fill(mydatatable)
        txt_cusID.DataSource = mydatatable
        txt_cusID.DisplayMember = "FLD_CUSTOMER_ID"
    End Sub

    Private Sub generate_matric()
        Try
            Dim lastmatric As String = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTMATRIC FROM TBL_ORDER_A176252").Rows(0).Item("LASTMATRIC")
            Dim newmatric As String = "A" & Mid(lastmatric, 2) + 1
            txt_ID.Text = newmatric
        Catch ex As Exception
            txt_ID.Text = "A10001"
        End Try
    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim total As Integer
        Dim confirmation = MsgBox("Are you sure you want to add this product?", MsgBoxStyle.YesNo)
        If confirmation = MsgBoxResult.Yes Then
            Try
                If Not txt_ID.Text.Equals(OrderID) And Not OrderID.Equals("") Then
                    txt_ID.Text = OrderID
                End If
                If txt_quantity.Text >= txt_quan.Text And txt_quan.Text IsNot "" Then
                    total = (txt_quan.Text * txt_price.Text)
                    Dim quantity As Double = txt_quantity.Text - txt_quan.Text
                    Dim mysql As String = "SELECT * FROM TBL_ORDER_A176252 WHERE FLD_PRODUCT_ID = '" & txt_ID.Text & "'"
                    Dim mydatatable As New DataTable
                    Try
                        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection2)
                        myreader.Fill(mydatatable)
                        transaction(Count)
                        OrderID = txt_ID.Text
                        list.Push(txt_productID.Text)
                        list.Push(txt_quan.Text)
                        txt_quan.Text = ""
                        Dim mysql2 As String = "SELECT SUM(o.FLD_ORDER_QUANTITY * p.FLD_PRODUCT_PRICE) AS TotalPrice FROM TBL_ORDER_A176252 o, TBL_PRODUCTS_A176252 p WHERE p.FLD_PRODUCT_ID = o.FLD_PRODUCT_ID AND FLD_ORDER_ID ='" & OrderID & "'"
                        Dim mydatatable2 As New DataTable
                        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection2)
                        myreader2.Fill(mydatatable2)
                        txt_total.Text = mydatatable2.Rows(0).Item("TotalPrice")
                    Catch ex As Exception
                    End Try
                    run_sql_command("UPDATE TBL_PRODUCTS_A176252 SET FLD_PRODUCT_QUANTITY='" & quantity & "' WHERE FLD_PRODUCT_ID='" & txt_productID.Text & "'")
                    grd_order.DataSource = run_sql_query("SELECT TBL_PRODUCTS_A176252.FLD_PRODUCT_NAME, TBL_ORDER_A176252.FLD_ORDER_QUANTITY, TBL_PRODUCTS_A176252.FLD_PRODUCT_PRICE, [FLD_ORDER_QUANTITY]*[FLD_PRODUCT_PRICE] AS [Total Price] FROM TBL_PRODUCTS_A176252 INNER JOIN TBL_ORDER_A176252 ON TBL_PRODUCTS_A176252.[FLD_PRODUCT_ID] = TBL_ORDER_A176252.[FLD_PRODUCT_ID] WHERE TBL_ORDER_A176252.FLD_ORDER_ID ='" & txt_ID.Text & "'")
                    Beep()
                    MsgBox("Loading...")
                    refresh_text(lis_ID.Text)
                    If message.Equals("Yes") Then
                        Count = Count + 1
                    End If
                Else
                    MsgBox("Wrong Input")
                End If

            Catch ex As Exception
            End Try

        End If
    End Sub
    Private Sub RollBackAll()
        Try
            Dim i As Integer
            While i < Count
                Dim quantity As Integer = list.Pop.ToString
                Dim productID As String = list.Pop.ToString
                run_sql_command("UPDATE TBL_PRODUCTS_A176252 SET FLD_PRODUCT_QUANTITY = [FLD_PRODUCT_QUANTITY] +" & quantity & " WHERE FLD_PRODUCT_ID = '" & productID & "'")
                i = i + 1
            End While
            run_sql_command("DELETE FROM TBL_ORDER_A176252 WHERE FLD_ORDER_ID ='" & OrderID & "'")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub lbl_complete_Click(sender As Object, e As EventArgs) Handles lbl_complete.Click
        Dim confirmation = MsgBox("Are you sure you want to make this Order?", MsgBoxStyle.YesNo)
        If confirmation = MsgBoxResult.Yes Then
            If Count >= 1 Then
                Order_ID = OrderID
                Order_Date = txt_date.Text
                frm_invoicedetails_a176252.Show()
                Me.Close()
            Else
                Beep()
                MsgBox("Please add at least one product!")
            End If

        End If
    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim confirmation = MsgBox("Are you sure you want to cancel this order?", MsgBoxStyle.YesNo)
        If confirmation = MsgBoxResult.Yes Then
            RollBackAll()
            Order_ID = ""
            frm_mainmenu_a176252.Show()
            Me.Close()
        End If
    End Sub
    Public Sub transaction(Count As Integer)
        Dim mytransaction As OleDb.OleDbTransaction
        myconnection2.Open()
        mytransaction = myconnection2.BeginTransaction
        If Count = 0 Then
            OrderID = txt_ID.Text
            cus_ID = txt_cusID.Text
            staff_ID = txt_staffID.Text
        End If
        Try
            Dim mysql As String = "INSERT INTO TBL_ORDER_A176252 VALUES ('" & OrderID & "', '" & txt_date.Text & "', '" & txt_productID.Text & "', '" & staff_ID & "', '" & cus_ID & "', '" & txt_quan.Text & "')"
            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)
            mywriter.ExecuteNonQuery()
            mytransaction.Commit()
            myconnection2.Close()
            Beep()
            MsgBox("Transaction successful!")
        Catch ex As Exception
            mytransaction.Rollback()
            myconnection2.Close()
        End Try
    End Sub
End Class