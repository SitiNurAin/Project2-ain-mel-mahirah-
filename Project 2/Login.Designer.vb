<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.CheckBoxPass2 = New System.Windows.Forms.CheckBox()
        Me.btnLoginStaff = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnRegisterAdmin = New System.Windows.Forms.Button()
        Me.CheckBoxPass1 = New System.Windows.Forms.CheckBox()
        Me.btnLoginAdmin = New System.Windows.Forms.Button()
        Me.txtPassAdmin = New System.Windows.Forms.TextBox()
        Me.txtUserAdmin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(44, 102)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(865, 439)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = Global.Project_2.My.Resources.Resources._5
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.btnRegister)
        Me.TabPage1.Controls.Add(Me.CheckBoxPass2)
        Me.TabPage1.Controls.Add(Me.btnLoginStaff)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtPass)
        Me.TabPage1.Controls.Add(Me.txtUser)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.ForeColor = System.Drawing.Color.Green
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(857, 410)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "STAFF"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Ivory
        Me.Label4.Location = New System.Drawing.Point(429, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 27)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "or"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(275, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 24)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Dont have Account?"
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(475, 307)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(163, 41)
        Me.btnRegister.TabIndex = 19
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'CheckBoxPass2
        '
        Me.CheckBoxPass2.AutoSize = True
        Me.CheckBoxPass2.ForeColor = System.Drawing.Color.Ivory
        Me.CheckBoxPass2.Location = New System.Drawing.Point(586, 167)
        Me.CheckBoxPass2.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxPass2.Name = "CheckBoxPass2"
        Me.CheckBoxPass2.Size = New System.Drawing.Size(129, 21)
        Me.CheckBoxPass2.TabIndex = 18
        Me.CheckBoxPass2.Text = "Show Password"
        Me.CheckBoxPass2.UseVisualStyleBackColor = True
        '
        'btnLoginStaff
        '
        Me.btnLoginStaff.Location = New System.Drawing.Point(365, 226)
        Me.btnLoginStaff.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLoginStaff.Name = "btnLoginStaff"
        Me.btnLoginStaff.Size = New System.Drawing.Size(163, 41)
        Me.btnLoginStaff.TabIndex = 17
        Me.btnLoginStaff.Text = "Login"
        Me.btnLoginStaff.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(152, 164)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 37)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(146, 113)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(159, 37)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Username"
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(313, 165)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass.Multiline = True
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(265, 40)
        Me.txtPass.TabIndex = 14
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(313, 113)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUser.Multiline = True
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(265, 40)
        Me.txtUser.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MADE Soulmaze", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(49, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Staff Login"
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = Global.Project_2.My.Resources.Resources._4
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.btnRegisterAdmin)
        Me.TabPage2.Controls.Add(Me.CheckBoxPass1)
        Me.TabPage2.Controls.Add(Me.btnLoginAdmin)
        Me.TabPage2.Controls.Add(Me.txtPassAdmin)
        Me.TabPage2.Controls.Add(Me.txtUserAdmin)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(857, 410)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ADMINISTRATOR"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Ivory
        Me.Label6.Location = New System.Drawing.Point(458, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 27)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "or"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(304, 317)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 24)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Dont have Account?"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(163, 166)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 37)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Password"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(156, 106)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 37)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Username"
        '
        'btnRegisterAdmin
        '
        Me.btnRegisterAdmin.Location = New System.Drawing.Point(511, 310)
        Me.btnRegisterAdmin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegisterAdmin.Name = "btnRegisterAdmin"
        Me.btnRegisterAdmin.Size = New System.Drawing.Size(163, 41)
        Me.btnRegisterAdmin.TabIndex = 18
        Me.btnRegisterAdmin.Text = "Register"
        Me.btnRegisterAdmin.UseVisualStyleBackColor = True
        '
        'CheckBoxPass1
        '
        Me.CheckBoxPass1.AutoSize = True
        Me.CheckBoxPass1.Location = New System.Drawing.Point(607, 181)
        Me.CheckBoxPass1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxPass1.Name = "CheckBoxPass1"
        Me.CheckBoxPass1.Size = New System.Drawing.Size(129, 21)
        Me.CheckBoxPass1.TabIndex = 17
        Me.CheckBoxPass1.Text = "Show Password"
        Me.CheckBoxPass1.UseVisualStyleBackColor = True
        '
        'btnLoginAdmin
        '
        Me.btnLoginAdmin.Location = New System.Drawing.Point(387, 226)
        Me.btnLoginAdmin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLoginAdmin.Name = "btnLoginAdmin"
        Me.btnLoginAdmin.Size = New System.Drawing.Size(163, 41)
        Me.btnLoginAdmin.TabIndex = 16
        Me.btnLoginAdmin.Text = "Login"
        Me.btnLoginAdmin.UseVisualStyleBackColor = True
        '
        'txtPassAdmin
        '
        Me.txtPassAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassAdmin.Location = New System.Drawing.Point(334, 164)
        Me.txtPassAdmin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassAdmin.Multiline = True
        Me.txtPassAdmin.Name = "txtPassAdmin"
        Me.txtPassAdmin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassAdmin.Size = New System.Drawing.Size(265, 40)
        Me.txtPassAdmin.TabIndex = 13
        '
        'txtUserAdmin
        '
        Me.txtUserAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserAdmin.Location = New System.Drawing.Point(334, 103)
        Me.txtUserAdmin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserAdmin.Multiline = True
        Me.txtUserAdmin.Name = "txtUserAdmin"
        Me.txtUserAdmin.Size = New System.Drawing.Size(265, 40)
        Me.txtUserAdmin.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MADE Soulmaze", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(35, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(313, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Administrator Login"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project_2.My.Resources.Resources._3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(974, 578)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents CheckBoxPass2 As CheckBox
    Friend WithEvents btnLoginStaff As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents btnRegisterAdmin As Button
    Friend WithEvents CheckBoxPass1 As CheckBox
    Friend WithEvents btnLoginAdmin As Button
    Friend WithEvents txtPassAdmin As TextBox
    Friend WithEvents txtUserAdmin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
