'Amyliana Dara (20DDT21F2006) -DDT4A
'Siti Nur Ain (20DDT21F2003)-DDT4A
'Nur Mahirah (20DDT21F2002)-DDT4A

Public Class Home

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hide the btnAddItemH button
        btnAddItemH.Visible = False
        'Hide the PictureBox Picture
        PictureBox1.Visible = False
    End Sub

    Private Sub btnOrderHome_Click(sender As Object, e As EventArgs) Handles btnOrderHome.Click
        staff.Show() 'show staff form
        Me.Hide()
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Application.Exit() 'exit the whole application
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Login.Show() 'If user click the menu Log Out it will go to Log In form
        Me.Hide()
    End Sub

    Private Sub btnViewHome_Click(sender As Object, e As EventArgs) Handles btnViewHome.Click
        View.Show() 'will go to view form
        Me.Hide()
    End Sub

    Private Sub btnAddItemH_Click(sender As Object, e As EventArgs) Handles btnAddItemH.Click
        admin.Show() 'will go to staff form 
        Me.Hide()
    End Sub

    Private Sub LinkLabelAbout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelAbout.LinkClicked
        AboutBox1.Show() ' will go About Us form

    End Sub

    Private Sub LinkLabeContact_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelContact.LinkClicked
        ContactUs.Show() ' will go Contact Us form

    End Sub
End Class