'Amyliana Dara (20DDT21F2006) -DDT4A
'Siti Nur Ain (20DDT21F2003)-DDT4A
'Nur Mahirah (20DDT21F2002)-DDT4A



Imports System.Data.SqlClient

Public Class View
    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Home.Show() 'will show home form
        Me.Hide()
    End Sub

    Private Sub View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListItem() 'panggil public sub listitem() 

    End Sub
    Public Sub ListItem()
        Dim connectionString As String = "Server=localhost;Database=ScienceLaboratory_Inventory;User ID=mell;Password=passw0rd"
        Dim connection As SqlConnection = New SqlConnection(connectionString)
        Dim query As String = "SELECT [order].Item_Name , item.id_item, item.item_name, item.quantity, item.type, item.expired  FROM  [order]
                                    INNER JOIN item ON [order].Item_Name =item.item_name" 'Inner Join item_name from table table item and TableOrder 
        Dim command As New SqlCommand(query, connection)
        Dim da As New SqlDataAdapter()
        da.SelectCommand = command
        Dim dt As New DataTable()
        da.Fill(dt) 'isi data dalam Data Grid View
        DataGridViewItem.DataSource = dt
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit() 'exit from the system
    End Sub


    Private Sub LinkLabelAbout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelAbout.LinkClicked
        AboutBox1.Show() 'go to About Us form

    End Sub

    Private Sub LinkLabelContact_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelContact.LinkClicked
        ContactUs.Show() ' go to Contact Us form

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Login.Show() ' go to login form
        Me.Hide()

    End Sub
End Class