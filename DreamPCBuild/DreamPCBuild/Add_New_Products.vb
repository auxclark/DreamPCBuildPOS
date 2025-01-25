Imports Guna.UI2.WinForms
Imports System.IO


Public Class Add_New_Products
    Private buttonPanelMap As New Dictionary(Of Guna2CircleButton, Panel)
    Private clickedButton As Guna2CircleButton = Nothing
    Private txtFilePath As New Guna2PictureBox

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub Add_New_Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buttonPanelMap.Add(Next_Tab, AddNewProductsPanel2)
        buttonPanelMap.Add(Previous_Tab, AddNewProductsPanel1)
        For Each panel In buttonPanelMap.Values
            panel.Visible = False
        Next
        AddNewProductsPanel1.Visible = True
        clickedButton = Previous_Tab

        SerialPoductPanel.Visible = False
        ProductVariationPanel.Visible = False
        WarehousePanel.Visible = False
    End Sub

    Private Sub Next_Tab_Click(sender As Object, e As EventArgs) Handles Next_Tab.Click, Previous_Tab.Click
        Dim button As Guna2CircleButton = DirectCast(sender, Guna2CircleButton)
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

    Private Sub AddNewProductsPanel2_MouseLeave(sender As Object, e As EventArgs) Handles AddNewProductsPanel2.MouseLeave, AddNewProductsPanel1.MouseLeave
        Dim panel As Panel = DirectCast(sender, Panel)
        If clickedButton Is Nothing OrElse buttonPanelMap(clickedButton) IsNot panel Then
            panel.Visible = False
        End If
    End Sub

    Private Sub Next_Tab_MouseLeave(sender As Object, e As EventArgs) Handles Next_Tab.MouseLeave, Previous_Tab.MouseLeave
        Dim button As Guna2CircleButton = DirectCast(sender, Guna2CircleButton)
        Dim panel As Panel = buttonPanelMap(button)
        If clickedButton IsNot button Then
            panel.Visible = False
        End If
    End Sub

    Private Sub Next_Tab_MouseHover(sender As Object, e As EventArgs) Handles Next_Tab.MouseHover, Previous_Tab.MouseHover
        Dim button As Guna2CircleButton = DirectCast(sender, Guna2CircleButton)
        Dim panel As Panel = buttonPanelMap(button)
        panel.Visible = True
    End Sub

    Private Sub Choose_file_Click(sender As Object, e As EventArgs) Handles Choose_file.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image Files (*.gif;*.jpeg;*.png)|*.gif;*.jpeg;*.png"
        ofd.Title = "Select an Image"
        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                txtFilePath.Text = ofd.FileName
                DisplayPicture.Image = Image.FromFile(ofd.FileName)
                DisplayPicture.SizeMode = PictureBoxSizeMode.StretchImage
            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub SerialRow_Click(sender As Object, e As EventArgs) Handles SerialRow.Click
        SerialPoductPanel.Visible = True
    End Sub

    Private Sub ProductVariation_Click(sender As Object, e As EventArgs) Handles ProductVariation.Click
        ProductVariationPanel.Visible = True
    End Sub

    Private Sub AddProductsWarehouse_Click(sender As Object, e As EventArgs) Handles AddProductsWarehouse.Click
        WarehousePanel.Visible = True
    End Sub

    Private Sub SerialRowDelete_Click(sender As Object, e As EventArgs) Handles SerialRowDelete.Click
        SerialPoductPanel.Dispose()
    End Sub

    Private Sub ProductVariationDelete_Click(sender As Object, e As EventArgs) Handles ProductVariationDelete.Click
        ProductVariationPanel.Dispose()
    End Sub

    Private Sub ProductWarehouseDelete_Click(sender As Object, e As EventArgs) Handles ProductWarehouseDelete.Click
        WarehousePanel.Dispose()
    End Sub
End Class