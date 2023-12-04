'Amyliana Dara (20DDT21F2006) -DDT4A
'Siti Nur Ain (20DDT21F2003)-DDT4A
'Nur Mahirah (20DDT21F2002)-DDT4A


Imports System.Data.SqlClient

Public Class AdminDataGridView
    Dim connection As New SqlConnection("Server=localhost;Database=ScienceLaboratory_Inventory;User ID=mell;Password=passw0rd")

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Home.Show() 'will go to home form
        Me.Hide()
    End Sub


    Private Sub TextBoxSearchAdmin_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearchAdmin.TextChanged
        Dim connectionString As String = "Server=localhost;Database=ScienceLaboratory_Inventory;User ID=mell;Password=passw0rd"
        Dim connection As SqlConnection = New SqlConnection(connectionString)

        connection.Open()

        Dim command As New SqlCommand("SELECT * FROM [item] 
                                    WHERE item_name LIKE '%" + TextBoxSearchAdmin.Text + "%'", connection) 'select data from item table based on item_name column in database
        Dim da As New SqlDataAdapter

        Dim dt As New DataTable()

        da.SelectCommand = command
        dt.Clear()
        da.Fill(dt)

        'Will display the colum of the database at the  DataGridView
        DataGridViewAdmin.DataSource = dt
        DataGridViewAdmin.Columns(0).HeaderText = "id_item"
        DataGridViewAdmin.Columns(0).HeaderText = "item_name"
        DataGridViewAdmin.Columns(0).HeaderText = "type"
        DataGridViewAdmin.Columns(0).HeaderText = "unit"
        DataGridViewAdmin.Columns(0).HeaderText = "arrived"
        DataGridViewAdmin.Columns(0).HeaderText = "expired"
        DataGridViewAdmin.Columns(0).HeaderText = "vendor"


        connection.Close()
    End Sub


    Private Sub AddItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddItemsToolStripMenuItem.Click
        admin.Show() 'will go to admin form
        Me.Hide()

    End Sub

    Private Sub ViewAvailableItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAvailableItemToolStripMenuItem.Click
        View.Show() ' will go to view form
        Me.Hide()
    End Sub

    Private Sub ViewStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewStaffToolStripMenuItem.Click
        StaffDataGridView.Show() ' admin will able to view staff order
        Me.Hide()

    End Sub

    Private Sub LinkLabelAbout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelAbout.LinkClicked
        AboutBox1.Show() ' will go to About Us form

    End Sub

    Private Sub LinkLabelContact_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelContact.LinkClicked
        ContactUs.Show() ' will go to Contact Us form

    End Sub

    Private Sub ButtonDeleteAdmin_Click(sender As Object, e As EventArgs)
        Dim confirmsg = MessageBox.Show("Are you sure to delete?", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error) 'Message Box will popup after deleting the selected data 
        If confirmsg = DialogResult.Yes Then 'if user click Yes the data will completely deleted
            Dim connectionString As String = "Server=localhost;Database=ScienceLaboratory_Inventory;User ID=mell;Password=passw0rd"
            Dim connection As SqlConnection = New SqlConnection(connectionString)
            Dim query As String = "DELETE FROM item WHERE id_item= @id_item " 'Delete data from item table using id_item
            Dim command As New SqlCommand(query, connection)

            command.Parameters.AddWithValue("@id_item", TextBoxSearchAdmin.Text) 'set the values  to the query

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()

        End If
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Login.Show() 'go to login
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit() 'exit app

    End Sub

    Private Sub AdminDataGridView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim connectionString As String = "Server=localhost;Database=ScienceLaboratory_Inventory;User ID=mell;Password=passw0rd"
            Dim connection As SqlConnection = New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM item ORDER BY id_item"
            Dim command As New SqlCommand(query, connection)
            Dim da As New SqlDataAdapter(command)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridViewAdmin.DataSource = dt
            DataGridViewAdmin.AllowUserToAddRows = False

            'add update btn column
            Dim updatebtncolumn As New DataGridViewButtonColumn
            updatebtncolumn.UseColumnTextForButtonValue = True
            updatebtncolumn.HeaderText = "Update Data"
            updatebtncolumn.Width = 100
            updatebtncolumn.Text = "Update"
            updatebtncolumn.DefaultCellStyle.BackColor = Color.Green
            updatebtncolumn.DefaultCellStyle.ForeColor = Color.White
            updatebtncolumn.FlatStyle = FlatStyle.Flat
            DataGridViewAdmin.Columns.Insert(8, updatebtncolumn)

            'add delete btn column
            Dim deletebtncolumn As New DataGridViewButtonColumn
            deletebtncolumn.UseColumnTextForButtonValue = True
            deletebtncolumn.HeaderText = "Delete Row"
            deletebtncolumn.Width = 100
            deletebtncolumn.Text = "Delete"
            deletebtncolumn.DefaultCellStyle.BackColor = Color.Red
            deletebtncolumn.DefaultCellStyle.ForeColor = Color.White
            deletebtncolumn.FlatStyle = FlatStyle.Flat
            DataGridViewAdmin.Columns.Insert(9, deletebtncolumn)
        Catch
        End Try
    End Sub

    Private Sub DataGridViewAdmin_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAdmin.CellContentClick
        'update button is selected
        If e.ColumnIndex = 8 Then
            Dim confirmsg = MessageBox.Show("Are you sure to update the data?", "Update Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmsg = DialogResult.Yes Then
                Dim r1 As DataGridViewRow = DataGridViewAdmin.Rows(e.RowIndex)
                'update query
                Dim cmd2 As New SqlCommand("UPDATE item SET item_name=@item_name, quantity=@quantity ,type=@type ,unit=@unit , arrived =@arrived, expired=@expired , vendor=@vendor WHERE id_item=@id_item", connection)
                cmd2.Parameters.AddWithValue("@item_name", r1.Cells("item_name").Value)
                cmd2.Parameters.AddWithValue("@quantity", r1.Cells("quantity").Value)
                cmd2.Parameters.AddWithValue("@type", r1.Cells("type").Value)
                cmd2.Parameters.AddWithValue("@unit", r1.Cells("unit").Value)
                cmd2.Parameters.AddWithValue("@arrived", r1.Cells("arrived").Value)
                cmd2.Parameters.AddWithValue("@expired", r1.Cells("expired").Value)
                cmd2.Parameters.AddWithValue("@vendor", r1.Cells("vendor").Value)
                cmd2.Parameters.AddWithValue("@id_item", r1.Cells("id_item").Value)
                connection.Open()
                cmd2.ExecuteNonQuery()
                connection.Close()

            End If
            'delete button selected
        ElseIf e.ColumnIndex = 9 Then
            Dim confirmsg = MessageBox.Show("Are you sure you want to delete the data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmsg = DialogResult.Yes Then
                Dim r1 As DataGridViewRow = DataGridViewAdmin.Rows(e.RowIndex)

                'delete from db
                Dim cmd2 As New SqlCommand("DELETE FROM item WHERE id_item=@id_item", connection)
                cmd2.Parameters.AddWithValue("@id_item", r1.Cells("id_item").Value)
                connection.Open()
                cmd2.ExecuteNonQuery()
                connection.Close()

                'refresh the datagridview to reflect the updated data
                DataGridViewAdmin.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub
End Class