Public Class frm_mainmenu_a176252
    Private Sub frm_mainmenu_a176252_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            pic_main.BackgroundImage = Image.FromFile("pictures/rarecoinshop.jpg")
            pic_contact.BackgroundImage = Image.FromFile("pictures/contact.jpg")

        Catch ex As Exception
            pic_main.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
            pic_contact.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try
    End Sub

    Private Sub btn_cus_Click(sender As Object, e As EventArgs) Handles btn_cus.Click
        frm_customerdetails_a176252.Show()
        Me.Hide()
    End Sub

    Private Sub btn_stff_Click(sender As Object, e As EventArgs) Handles btn_stff.Click
        frm_staffdetails_a176252.Show()
        Me.Hide()
    End Sub

    Private Sub btn_pro_Click(sender As Object, e As EventArgs) Handles btn_pro.Click
        frm_product_a176252.Show()
        Me.Hide()
    End Sub

    Private Sub btn_his_Click(sender As Object, e As EventArgs) Handles btn_his.Click
        frm_history_a176252.Show()
        Me.Hide()
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        frm_order_a176252.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub btn_aboutus_Click(sender As Object, e As EventArgs) Handles btn_aboutus.Click
        frm_aboutus_A176252.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class