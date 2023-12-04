<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.TextBoxREGUser = New System.Windows.Forms.TextBox()
        Me.btnRegAd = New System.Windows.Forms.Button()
        Me.CheckBoxPass = New System.Windows.Forms.CheckBox()
        Me.ComboBoxRole = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRegStaff = New System.Windows.Forms.Button()
        Me.TextBoxREGPass = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxREGUser
        '
        Me.TextBoxREGUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxREGUser.Location = New System.Drawing.Point(331, 194)
        Me.TextBoxREGUser.Multiline = True
        Me.TextBoxREGUser.Name = "TextBoxREGUser"
        Me.TextBoxREGUser.Size = New System.Drawing.Size(352, 41)
        Me.TextBoxREGUser.TabIndex = 30
        '
        'btnRegAd
        '
        Me.btnRegAd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegAd.Location = New System.Drawing.Point(438, 434)
        Me.btnRegAd.Name = "btnRegAd"
        Me.btnRegAd.Size = New System.Drawing.Size(122, 45)
        Me.btnRegAd.TabIndex = 29
        Me.btnRegAd.Text = "SIGN UP"
        Me.btnRegAd.UseVisualStyleBackColor = True
        Me.btnRegAd.Visible = False
        '
        'CheckBoxPass
        '
        Me.CheckBoxPass.AutoSize = True
        Me.CheckBoxPass.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxPass.Font = New System.Drawing.Font("Copperplate Gothic Light", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckBoxPass.Location = New System.Drawing.Point(689, 288)
        Me.CheckBoxPass.Name = "CheckBoxPass"
        Me.CheckBoxPass.Size = New System.Drawing.Size(155, 19)
        Me.CheckBoxPass.TabIndex = 32
        Me.CheckBoxPass.Text = "Show Password"
        Me.CheckBoxPass.UseVisualStyleBackColor = False
        '
        'ComboBoxRole
        '
        Me.ComboBoxRole.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxRole.FormattingEnabled = True
        Me.ComboBoxRole.Items.AddRange(New Object() {"Admin", "Staff"})
        Me.ComboBoxRole.Location = New System.Drawing.Point(410, 360)
        Me.ComboBoxRole.Name = "ComboBoxRole"
        Me.ComboBoxRole.Size = New System.Drawing.Size(179, 24)
        Me.ComboBoxRole.TabIndex = 34
        Me.ComboBoxRole.Text = "Please Select a Role"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(325, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 34)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(325, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 34)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Username:"
        '
        'btnRegStaff
        '
        Me.btnRegStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegStaff.Location = New System.Drawing.Point(438, 421)
        Me.btnRegStaff.Name = "btnRegStaff"
        Me.btnRegStaff.Size = New System.Drawing.Size(122, 45)
        Me.btnRegStaff.TabIndex = 29
        Me.btnRegStaff.Text = "SIGN UP"
        Me.btnRegStaff.UseVisualStyleBackColor = True
        Me.btnRegStaff.Visible = False
        '
        'TextBoxREGPass
        '
        Me.TextBoxREGPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxREGPass.Location = New System.Drawing.Point(331, 275)
        Me.TextBoxREGPass.Multiline = True
        Me.TextBoxREGPass.Name = "TextBoxREGPass"
        Me.TextBoxREGPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxREGPass.Size = New System.Drawing.Size(352, 41)
        Me.TextBoxREGPass.TabIndex = 36
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(601, 421)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(108, 38)
        Me.btnLogin.TabIndex = 44
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project_2.My.Resources.Resources._455566
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1029, 565)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.TextBoxREGPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxRole)
        Me.Controls.Add(Me.TextBoxREGUser)
        Me.Controls.Add(Me.btnRegStaff)
        Me.Controls.Add(Me.btnRegAd)
        Me.Controls.Add(Me.CheckBoxPass)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxREGUser As TextBox
    Friend WithEvents btnRegAd As Button
    Friend WithEvents CheckBoxPass As CheckBox
    Friend WithEvents ComboBoxRole As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRegStaff As Button
    Friend WithEvents TextBoxREGPass As TextBox
    Friend WithEvents btnLogin As Button
End Class
