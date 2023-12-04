'Amyliana Dara (20DDT21F2006) -DDT4A
'Siti Nur Ain (20DDT21F2003)-DDT4A
'Nur Mahirah (20DDT21F2002)-DDT4A

Imports System.Data.SqlClient

Public Class StaffDataGridView

    Dim connection As New SqlConnection("Server=localhost;Database=ScienceLaboratory_Inventory;User ID=mell;Password=passw0rd")


    Private Sub TextBoxSearchStaff_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearchStaff.TextChanged
        Dim connectionString As String = "Server=localhost;Database=ScienceLaboratory_Inventory;User ID=mell;Password=passw0rd"
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        connection.Open()

        Dim command As New SqlCommand("SELECT OrderID,StaffName,Item_Name,Quantity,ItemInRoom FROM [order] 
                                    WHERE OrderID LIKE '%" + TextBoxSearchStaff.Text + "%'", connection)
        'SELECT data from order table by using StaffName

        Dim da As New SqlDataAdapter

        Dim dt As New DataTable()

        da.SelectCommand = command
        dt.Clear()
        da.Fill(dt)

        DataGridViewStaff.DataSource = dt

        'Will display the colum of the database at the  DataGridView
        DataGridViewStaff.Columns(0).HeaderText = "OrderID"
        DataGridViewStaff.Columns(0).HeaderText = "StaffName"
        DataGridViewStaff.Columns(0).HeaderText = "Item_Name"
        DataGridViewStaff.Columns(0).HeaderText = "Quantity"
        DataGridViewStaff.Columns(0).HeaderText = "ItemInRoom"

        connection.Close()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Home.Show() 'will go to Home form
        Me.Hide()
    End Sub

    Private Sub OrderItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderItemsToolStripMenuItem.Click
        staff.Show() 'Will go to Staff form
        Me.Hide()


    End Sub

    Private Sub LinkLabelAbout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelAbout.LinkClicked
        AboutBox1.Show() ' will go About Us form

    End Sub

    Private Sub LinkLabelContactUs_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelContactUs.LinkClicked
        ContactUs.Show() 'will go Contact Us form

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Login.Show() 'If user click the menu Log Out it will go to Log In form
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit() 'Exit all the system
    End Sub

    Private Sub StaffDataGridView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim connectionString As String = "Server=localhost;Database=ScienceLaboratory_Inventory;User ID=mell;Password=passw0rd"
            Dim connection As SqlConnection = New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM [order] ORDER BY OrderID"
            Dim command As New SqlCommand(query, connection)
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridViewStaff.DataSource = dt
            DataGridViewStaff.AllowUserToAddRows = False

            'add update button column
            Dim btncolumn As New DataGridViewButtonColumn
            btncolumn.UseColumnTextForButtonValue = True
            btncolumn.HeaderText = "Update Data"
            btncolumn.Width = 60
            btncolumn.Text = "Update"
            btncolumn.DefaultCellStyle.BackColor = Color.Green
            btncolumn.DefaultCellStyle.ForeColor = Color.White
            btncolumn.FlatStyle = FlatStyle.Flat
            DataGridViewStaff.Columns.Insert(6, btncolumn)

        Catch
        End Try
    End Sub

    Private Sub DataGridViewStaff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewStaff.CellContentClick
        'update column selected
        If e.ColumnIndex = 6 Then
            Dim confirmsg = MessageBox.Show("Are you sure to update the data?", "Update Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmsg = DialogResult.Yes Then
                Dim r1 As DataGridViewRow = DataGridViewStaff.Rows(e.RowIndex)
                'update query
                Dim cmd2 As New SqlCommand("UPDATE [order] SET StaffName=@StaffName, Item_Name=@Item_Name, Quantity=@Quantity, ItemInRoom=@ItemInRoom WHERE OrderID=@OrderID", connection)
                cmd2.Parameters.AddWithValue("@StaffName", r1.Cells("StaffName").Value)
                cmd2.Parameters.AddWithValue("@Item_Name", r1.Cells("Item_Name").Value)
                cmd2.Parameters.AddWithValue("@Quantity", r1.Cells("Quantity").Value)
                cmd2.Parameters.AddWithValue("@ItemInRoom", r1.Cells("ItemInRoom").Value)
                cmd2.Parameters.AddWithValue("@OrderID", r1.Cells("OrderID").Value)
                connection.Open()
                cmd2.ExecuteNonQuery()
                connection.Close()

            End If
        End If
    End Sub
End Class