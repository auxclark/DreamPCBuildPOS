Imports Guna.UI2.WinForms
Public Class Stocks
    Private buttonPanelMap As New Dictionary(Of Guna2Button, Panel)
    Private clickedButton As Guna2Button = Nothing

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub Item_Manager_Click(sender As Object, e As EventArgs) Handles Item_Manager.Click, Purchase_Order.Click, Stock_Return.Click, Suppliers.Click, Product_Label.Click

        Dim button As Guna2Button = DirectCast(sender, Guna2Button)
        Dim panel As Panel = buttonPanelMap(button)

        If clickedButton Is button Then
            panel.Visible = Not panel.Visible
            clickedButton = If(panel.Visible, button, Nothing)
        Else

            If clickedButton IsNot Nothing Then
                buttonPanelMap(clickedButton).Visible = False
            End If
            panel.Visible = True
            clickedButton = button
        End If
    End Sub
    Private Sub stockspanel2_MouseLeave(sender As Object, e As EventArgs) Handles stockspanel2.MouseLeave, stockspanel3.MouseLeave, stockspanel4.MouseLeave, stockspanel4.MouseLeave, stockspanel5.MouseLeave, stockspanel6.MouseLeave
        Dim panel As Panel = DirectCast(sender, Panel)
        If clickedButton Is Nothing OrElse buttonPanelMap(clickedButton) IsNot panel Then
            panel.Visible = False
        End If
    End Sub

    Private Sub Item_Manager_MouseLeave(sender As Object, e As EventArgs) Handles Item_Manager.MouseLeave, Purchase_Order.MouseLeave, Stock_Return.MouseLeave, Suppliers.MouseLeave, Product_Label.MouseLeave
        Dim button As Guna2Button = DirectCast(sender, Guna2Button)
        Dim panel As Panel = buttonPanelMap(button)
        If clickedButton IsNot button Then
            panel.Visible = False
        End If
    End Sub

    Private Sub Item_Manager_MouseHover(sender As Object, e As EventArgs) Handles Item_Manager.MouseHover, Purchase_Order.MouseHover, Stock_Return.MouseHover, Suppliers.MouseHover, Product_Label.MouseHover
        Dim button As Guna2Button = DirectCast(sender, Guna2Button)
        Dim panel As Panel = buttonPanelMap(button)
        panel.Visible = True
    End Sub

    Private Sub Stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        buttonPanelMap.Add(Item_Manager, stockspanel2)
        buttonPanelMap.Add(Purchase_Order, stockspanel3)
        buttonPanelMap.Add(Stock_Return, stockspanel4)
        buttonPanelMap.Add(Suppliers, stockspanel5)
        buttonPanelMap.Add(Product_Label, stockspanel6)


        For Each panel In buttonPanelMap.Values
            panel.Visible = False
        Next
    End Sub

    Private Sub New_Products_Click(sender As Object, e As EventArgs) Handles New_Products.Click
        ' Create a new instance of Add_New_Products
        Dim addNewProductsForm As New Add_New_Products()

        ' Set the Add_New_Products form's parent to the StockMainPanel
        addNewProductsForm.TopLevel = False
        addNewProductsForm.Parent = StockMainPanel

        ' Dock the form to fill the parent panel
        addNewProductsForm.Dock = DockStyle.Fill

        ' Set the size of the Add_New_Products form to match the panel's size
        addNewProductsForm.ClientSize = StockMainPanel.ClientSize

        ' Show the form inside the StockMainPanel
        addNewProductsForm.Show()
    End Sub
End Class