'Amyliana Dara (20DDT21F2006) -DDT4A
'Siti Nur Ain (20DDT21F2003)-DDT4A
'Nur Mahirah (20DDT21F2002)-DDT4A



Imports System.Data.SqlClient

Public Class Register
    Private Sub ComboBoxRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRole.SelectedIndexChanged
        If (ComboBoxRole.Text = "Admin") Then ' if "Admin" is selected, make btnRegAd,btnRegStaff visible
            btnRegAd.Visible = True
            btnRegStaff.Visible = False

        ElseIf (ComboBoxRole.Text = "Staff") Then ' if "Staff" is selected, make btnRegStaff,btnRegAd visible
            btnRegStaff.Visible = True
            btnRegAd.Visible = False
        Else
            btnRegAd.Visible = False 'if the user not selected anything nothing will show
            btnRegStaff.Visible = False
        End If
    End Sub

    Private Sub btnRegStaff_Click(sender As Object, e As EventArgs) Handles btnRegStaff.Click
        Try
            Dim connectionString As String = "Server=localhost;Database=ScienceLaboratory_Inventory;User ID=mell;Password=passw0rd"
            Dim connection As SqlConnection = New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO login_staff (username,password) VALUES (@nama,@katalaluan)" 'insert data from table login_staff
            connection.Open()
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@nama", TextBoxREGUser.Text)
            command.Parameters.AddWithValue("@katalaluan", TextBoxREGPass.Text)
            command.ExecuteNonQuery()
            MsgBox(" Data Successfully Inserted!", MessageBoxIcon.Information)

            TextBoxREGUser.Clear() ' clear the TextBoxREGUser,TextBoxREGPass textbox after user key in
            TextBoxREGUser.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnRegAd_Click(sender As Object, e As EventArgs) Handles btnRegAd.Click
        Try
            Dim connectionString As String = "Server=localhost;Database=ScienceLaboratory_Inventory;User ID=mell;Password=passw0rd"
            Dim connection As SqlConnection = New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO login_admin (username,password) VALUES (@nama,@katalaluan)" 'insert data to table login_admin
            connection.Open()
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@nama", TextBoxREGUser.Text)
            command.Parameters.AddWithValue("@katalaluan", TextBoxREGPass.Text)
            command.ExecuteNonQuery()
            MsgBox(" Data Successfully Inserted!", MessageBoxIcon.Information)

            TextBoxREGUser.Clear() ' clear the TextBoxREGUser,TextBoxREGPass textbox after user key in 
            TextBoxREGPass.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CheckBoxPass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPass.CheckedChanged
        If CheckBoxPass.Checked = True Then
            TextBoxREGPass.UseSystemPasswordChar = True 'if the checkbox is checked, the password will not be hide
        Else
            TextBoxREGPass.UseSystemPasswordChar = False 'if the checkbox is NOT checked, the password will be hide
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class