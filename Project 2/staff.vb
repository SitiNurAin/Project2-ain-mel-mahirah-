'Amyliana Dara (20DDT21F2006) -DDT4A
'Siti Nur Ain (20DDT21F2003)-DDT4A
'Nur Mahirah (20DDT21F2002)-DDT4A



Imports System.Data.SqlClient

Public Class staff

    Private Sub ViewItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewItemToolStripMenuItem.Click
        View.Show()

    End Sub

    Private Sub ButtonClearStaff_Click(sender As Object, e As EventArgs) Handles ButtonClearStaff.Click
        TextBoxId.Clear() 'will clear all TextBoxId,TextBoxStaffName,TextBoxQuantity,TextBoxItemInRoom from the textbox
        TextBoxStaffName.Clear()
        TextBoxQuantity.Clear()
        TextBoxItemInRoom.Clear()
    End Sub

    Private Sub ButtonOrder_Click(sender As Object, e As EventArgs) Handles ButtonOrder.Click
        Dim connectionString As String = "Server=localhost;Database=ScienceLaboratory_Inventory;User ID=mell;Password=passw0rd"
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim query As String = "INSERT INTO [order] (OrderID,StaffName,Item_Name,Quantity,ItemInRoom,Experiment) 
                                VALUES (@OrderID,@StaffName,@Item_Name,@Quantity,@itemInRoom,@Experiment)" 'insert data into order table
        Dim command As New SqlCommand(query, connection)

        'this parameter will set value for query
        command.Parameters.AddWithValue("@OrderID", TextBoxId.Text)
        command.Parameters.AddWithValue("@StaffName", TextBoxStaffName.Text)
        command.Parameters.AddWithValue("@Item_Name", ComboBoxItem.Text)
        command.Parameters.AddWithValue("@Quantity", TextBoxQuantity.Text)
        command.Parameters.AddWithValue("@itemInRoom", TextBoxItemInRoom.Text)
        ' Determine the value for the Experiment parameter
        If ComboBoxExp.SelectedItem IsNot Nothing Then
            command.Parameters.AddWithValue("@Experiment", ComboBoxExp.SelectedItem.ToString())
        ElseIf Not String.IsNullOrWhiteSpace(txtExperiment.Text) Then
            command.Parameters.AddWithValue("@Experiment", txtExperiment.Text)
        Else
            command.Parameters.AddWithValue("@Experiment", DBNull.Value)
        End If

        connection.Open()
        command.ExecuteNonQuery() 'exit the query
        connection.Close()
        MsgBox("Successful Place Order!", MsgBoxStyle.Information) 'display a message box when staff successfully place order 
        TextBoxId.Clear() 'will clear all TextBoxId,TextBoxStaffName,TextBoxQuantity,TextBoxItemInRoom from the textbox
        TextBoxStaffName.Clear()
        TextBoxQuantity.Clear()
        TextBoxItemInRoom.Clear()
        txtExperiment.Clear()
        StaffDataGridView.Show() 'form StaffDataGridView will show
        Me.Hide()
        ' Refresh the DataGridView with the updated data

    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Home.Show() 'form home will show
        Me.Hide()

    End Sub

    Private Sub LinkLabelAbout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelAbout.LinkClicked
        AboutBox1.Show() 'go to About Us form 

    End Sub

    Private Sub LinkLabelContact_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelContact.LinkClicked
        ContactUs.Show() 'go to Contact Us form

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Login.Show() 'Go to login Forn
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit() 'will exit the application completely
    End Sub

    Private Sub ViewOrderDetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewOrderDetailToolStripMenuItem.Click
        StaffDataGridView.Show() 'go to StaffDataGridView
        Me.Hide()

    End Sub


End Class
