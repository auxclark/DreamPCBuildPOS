Public Class Admin_Dashboard_1stPanel
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
        Sign_In.Close()



    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)
        AdminDashboard_Panel_tab1.Show()


    End Sub

    Private Sub BtnRight_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnLeft_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Admin_Dashboard_1stPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub BtnSales_MouseHover(sender As Object, e As EventArgs) Handles BtnSales.MouseHover



    End Sub

    Private Sub Sales_Panel_Hover_MouseLeave(sender As Object, e As EventArgs)


    End Sub

    Private Sub BtnSales_Click(sender As Object, e As EventArgs) Handles BtnSales.Click
        Sales.Show()


    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click


    End Sub

    Sub switchPanel(ByVal panel As Form)
        AdminDashboard_Panel_tab1.Controls.Clear()
        panel.TopLevel = False
        AdminDashboard_Panel_tab1.Controls.Add(panel)


    End Sub

    Private Sub BtnHRM_Click(sender As Object, e As EventArgs) Handles BtnHRM.Click
        HRM.Show()
    End Sub

    Private Sub BtnStocks_Click(sender As Object, e As EventArgs) Handles BtnStocks.Click
        Stocks.Show()
    End Sub
End Class