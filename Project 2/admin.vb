'Amyliana Dara (20DDT21F2006) -DDT4A
'Siti Nur Ain (20DDT21F2003)-DDT4A
'Nur Mahirah (20DDT21F2002)-DDT4A



Imports System.Data.SqlClient


Public Class admin
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim connectionString As String = "Server=localhost;Database=ScienceLaboratory_Inventory;User ID=mell;Password=passw0rd"
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim query As String = "INSERT INTO [item] (id_item,item_name,quantity,type,unit,arrived,expired,vendor) 
                                VALUES (@id_item,@item_name,@quantity,@type,@unit,@arrived,@expired,@vendor)" 'set data into table item

        Dim command As New SqlCommand(query, connection)

        'set the parameter values for query
        command.Parameters.AddWithValue("@id_item", TextBoxIdItem.Text)
        command.Parameters.AddWithValue("@item_name", ComboBoxItem.Text)
        command.Parameters.AddWithValue("@quantity", TextBoxQuantity.Text)
        command.Parameters.AddWithValue("@type", ComboBox1.Text)
        command.Parameters.AddWithValue("@unit", ComboBoxUnitAdmin.Text)
        command.Parameters.AddWithValue("@arrived", DateTimePickerArrived.Value)
        command.Parameters.AddWithValue("@expired", DateTimePickerExpired.Value)
        command.Parameters.AddWithValue("@vendor", TextBoxVendor.Text)

        connection.Open()
        command.ExecuteNonQuery() 'execute the query 
        connection.Close()
        MsgBox("Item is Successful Add!", MsgBoxStyle.Information, "Science Laboratory Inventory") 'Display a success message box

        TextBoxIdItem.Clear() 'will clear all id item,quantity and vendor textbox
        TextBoxQuantity.Clear()
        TextBoxVendor.Clear()

        AdminDataGridView.Show()
        Me.Hide()

    End Sub

    Private Sub ButtonClearAdmin_Click(sender As Object, e As EventArgs) Handles ButtonClearAdmin.Click
        TextBoxIdItem.Clear() 'will clear all id item,quantity and vendor textbox
        TextBoxQuantity.Clear()
        TextBoxVendor.Clear()
    End Sub


    Private Sub LinkLabelAbout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelAbout.LinkClicked
        AboutBox1.Show() 'will go to About Us form

    End Sub

    Private Sub LinkLabelContact_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelContact.LinkClicked
        ContactUs.Show() 'will go to Contact Us form 

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit() 'will exit the system

    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Home.Show()
        Me.Hide()

    End Sub

    Private Sub ViewItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewItemToolStripMenuItem.Click
        AdminDataGridView.Show()
        Me.Hide()

    End Sub
End Class