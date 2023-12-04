'Amyliana Dara (20DDT21F2006) -DDT4A
'Siti Nur Ain (20DDT21F2003)-DDT4A
'Nur Mahirah (20DDT21F2002)-DDT4A



Imports System.Data.SqlClient

Public Class Login
    Private Sub btnLoginStaff_Click(sender As Object, e As EventArgs) Handles btnLoginStaff.Click
        Try
            Dim connectionString As String = "Server=localhost;Database=ScienceLaboratory_Inventory;User ID=mell;Password=passw0rd"
            Dim connection As SqlConnection = New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM login_staff WHERE username=@nama AND password=@katalaluan" 'will select data from table login_staff for username and password
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@nama", txtUser.Text)
            command.Parameters.AddWithValue("@katalaluan", txtPass.Text) ' set the values for query 
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                MsgBox("You're logged on the system", MessageBoxIcon.Information) 'show the message box that u logged in
                Me.Hide()
                Home.Show() 'will show home form after successfully logged in
                Dim form1 As Home = CType(Application.OpenForms("Home"), Home)

                form1.btnOrderHome.Visible = True
                form1.PictureBox1.Visible = True 'when staff login it will visible btnorder and picture box 

                form1.btnViewHome.Visible = True 'when staff login it will visible btnView and picture box 
                form1.PictureBox3.Visible = True

                form1.btnAddItemH.Visible = False 'it will hide a button for administrator
                form1.PictureBox4.Visible = False
            Else
                MsgBox("Unauthorized User !!", MessageBoxIcon.Warning) ' if staff got the wrong password, username or havent register it will show this message box
            End If
            txtUser.Clear()
            txtPass.Clear()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub btnLoginAdmin_Click(sender As Object, e As EventArgs) Handles btnLoginAdmin.Click
        Try ' try and catch
            Dim connectionString As String = "Server=localhost;Database=ScienceLaboratory_Inventory;User ID=mell;Password=passw0rd"
            Dim connection As SqlConnection = New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM login_admin WHERE username=@username AND password=@password" 'will select data from table login_admin for username and password
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@username", txtUserAdmin.Text)
            command.Parameters.AddWithValue("@password", txtPassAdmin.Text) ' set the values for query 
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                MsgBox("You're logged on the system", MessageBoxIcon.Information) 'show the message box that ypu are successfully logged in
                Me.Hide()
                Home.Show() 'show the home form that you are successfully logged in
                Dim form1 As Home = CType(Application.OpenForms("Home"), Home)

                form1.btnOrderHome.Visible = False
                form1.PictureBox1.Visible = False ' when admin logged in it will NOT show btnorder and picture box that are for staff

                form1.btnViewHome.Visible = True
                form1.PictureBox3.Visible = True 'it will visible buttonview, buttonadd and 2 picture box for administrator

                form1.btnAddItemH.Visible = True
                form1.PictureBox4.Visible = True
            Else
                MsgBox("Unauthorized User !!", MessageBoxIcon.Warning) ' if admin got the wrong password, username or havent register it will show this message box
            End If
            txtUserAdmin.Clear()
            txtPassAdmin.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnRegisterAdmin_Click(sender As Object, e As EventArgs) Handles btnRegisterAdmin.Click
        Register.Show()
        Me.Hide() 'this will show to register form
    End Sub

    Private Sub CheckBoxPass1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPass1.CheckedChanged
        If CheckBoxPass1.Checked = True Then 'checkbox password for admin 
            txtPassAdmin.UseSystemPasswordChar = True 'if the checkbox is checked, the password will not be hide
        Else
            txtPassAdmin.UseSystemPasswordChar = False 'if the checkbox is NOT checked, the password will be hide
        End If
    End Sub

    Private Sub CheckBoxPass2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPass2.CheckedChanged
        If CheckBoxPass2.Checked = True Then 'checkbox password for staff
            txtPass.UseSystemPasswordChar = True 'if the checkbox is checked, the password will not be hide
        Else
            txtPass.UseSystemPasswordChar = False 'if the checkbox is NOT checked, the password will be hide
        End If
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub
End Class
