<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxIdItem = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePickerExpired = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerArrived = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxItem = New System.Windows.Forms.ComboBox()
        Me.ComboBoxUnitAdmin = New System.Windows.Forms.ComboBox()
        Me.TextBoxVendor = New System.Windows.Forms.TextBox()
        Me.TextBoxQuantity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonClearAdmin = New System.Windows.Forms.Button()
        Me.LinkLabelContact = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelAbout = New System.Windows.Forms.LinkLabel()
        Me.ViewItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBoxIdItem)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerExpired)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerArrived)
        Me.GroupBox1.Controls.Add(Me.ComboBoxItem)
        Me.GroupBox1.Controls.Add(Me.ComboBoxUnitAdmin)
        Me.GroupBox1.Controls.Add(Me.TextBoxVendor)
        Me.GroupBox1.Controls.Add(Me.TextBoxQuantity)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 175)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(461, 236)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ITEM DESCRIPTION"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"--none--", "Chemical", "Flammable", "Burner", "Glassware"})
        Me.ComboBox1.Location = New System.Drawing.Point(93, 103)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox1.TabIndex = 11
        Me.ComboBox1.Text = "Select Type"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 104)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Type: "
        '
        'TextBoxIdItem
        '
        Me.TextBoxIdItem.Location = New System.Drawing.Point(93, 29)
        Me.TextBoxIdItem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxIdItem.Name = "TextBoxIdItem"
        Me.TextBoxIdItem.Size = New System.Drawing.Size(190, 20)
        Me.TextBoxIdItem.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 53)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 32)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "ID Item: "
        '
        'DateTimePickerExpired
        '
        Me.DateTimePickerExpired.Location = New System.Drawing.Point(93, 174)
        Me.DateTimePickerExpired.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePickerExpired.Name = "DateTimePickerExpired"
        Me.DateTimePickerExpired.Size = New System.Drawing.Size(190, 20)
        Me.DateTimePickerExpired.TabIndex = 6
        '
        'DateTimePickerArrived
        '
        Me.DateTimePickerArrived.Location = New System.Drawing.Point(93, 150)
        Me.DateTimePickerArrived.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePickerArrived.Name = "DateTimePickerArrived"
        Me.DateTimePickerArrived.Size = New System.Drawing.Size(190, 20)
        Me.DateTimePickerArrived.TabIndex = 6
        '
        'ComboBoxItem
        '
        Me.ComboBoxItem.FormattingEnabled = True
        Me.ComboBoxItem.Items.AddRange(New Object() {"Microscope", "Test Tubes", "ethanol", "oxidising acids", "Flammable liquids", "Salts", "Cyanides", "Inorganic Acids", "Beakers", "Benzene", "Hydroxide", "Magnifying Glass", "Volumetric Flask", "Bunsen Burner", "Dropper", "Thermometer", "Tongs", "Brushers", "Weighing Machines", "Wash Bottles", "Spatula", "Spring Balance", "Burette", "Watch Glass", "Funnels"})
        Me.ComboBoxItem.Location = New System.Drawing.Point(93, 56)
        Me.ComboBoxItem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxItem.Name = "ComboBoxItem"
        Me.ComboBoxItem.Size = New System.Drawing.Size(92, 21)
        Me.ComboBoxItem.TabIndex = 5
        Me.ComboBoxItem.Text = "Select Item"
        '
        'ComboBoxUnitAdmin
        '
        Me.ComboBoxUnitAdmin.FormattingEnabled = True
        Me.ComboBoxUnitAdmin.Items.AddRange(New Object() {"--none--", "ml", "l", "g", "kg", "K", "km", "C/F"})
        Me.ComboBoxUnitAdmin.Location = New System.Drawing.Point(93, 125)
        Me.ComboBoxUnitAdmin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxUnitAdmin.Name = "ComboBoxUnitAdmin"
        Me.ComboBoxUnitAdmin.Size = New System.Drawing.Size(92, 21)
        Me.ComboBoxUnitAdmin.TabIndex = 5
        Me.ComboBoxUnitAdmin.Text = "Select Unit"
        '
        'TextBoxVendor
        '
        Me.TextBoxVendor.Location = New System.Drawing.Point(93, 198)
        Me.TextBoxVendor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxVendor.Multiline = True
        Me.TextBoxVendor.Name = "TextBoxVendor"
        Me.TextBoxVendor.Size = New System.Drawing.Size(190, 31)
        Me.TextBoxVendor.TabIndex = 4
        '
        'TextBoxQuantity
        '
        Me.TextBoxQuantity.Location = New System.Drawing.Point(93, 80)
        Me.TextBoxQuantity.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxQuantity.Name = "TextBoxQuantity"
        Me.TextBoxQuantity.Size = New System.Drawing.Size(190, 20)
        Me.TextBoxQuantity.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 198)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Vendor:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 176)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Expired:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 150)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Arrived:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 126)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Unit: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 83)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Quantity:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name Item: "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ViewItemToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(24, 137)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(226, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.MenuToolStripMenuItem.Text = "Home"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.LogOutToolStripMenuItem.Text = "LogOut"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.Location = New System.Drawing.Point(527, 164)
        Me.ButtonAdd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(114, 106)
        Me.ButtonAdd.TabIndex = 10
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonClearAdmin
        '
        Me.ButtonClearAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearAdmin.Location = New System.Drawing.Point(527, 288)
        Me.ButtonClearAdmin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonClearAdmin.Name = "ButtonClearAdmin"
        Me.ButtonClearAdmin.Size = New System.Drawing.Size(114, 110)
        Me.ButtonClearAdmin.TabIndex = 10
        Me.ButtonClearAdmin.Text = "Clear"
        Me.ButtonClearAdmin.UseVisualStyleBackColor = True
        '
        'LinkLabelContact
        '
        Me.LinkLabelContact.AutoSize = True
        Me.LinkLabelContact.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelContact.Location = New System.Drawing.Point(535, 51)
        Me.LinkLabelContact.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabelContact.Name = "LinkLabelContact"
        Me.LinkLabelContact.Size = New System.Drawing.Size(77, 17)
        Me.LinkLabelContact.TabIndex = 21
        Me.LinkLabelContact.TabStop = True
        Me.LinkLabelContact.Text = "Contact Us"
        '
        'LinkLabelAbout
        '
        Me.LinkLabelAbout.AutoSize = True
        Me.LinkLabelAbout.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelAbout.Location = New System.Drawing.Point(472, 51)
        Me.LinkLabelAbout.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabelAbout.Name = "LinkLabelAbout"
        Me.LinkLabelAbout.Size = New System.Drawing.Size(66, 17)
        Me.LinkLabelAbout.TabIndex = 22
        Me.LinkLabelAbout.TabStop = True
        Me.LinkLabelAbout.Text = "About Us"
        '
        'ViewItemToolStripMenuItem
        '
        Me.ViewItemToolStripMenuItem.Name = "ViewItemToolStripMenuItem"
        Me.ViewItemToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ViewItemToolStripMenuItem.Text = "View Item"
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project_2.My.Resources.Resources.GSRGHB
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(673, 440)
        Me.Controls.Add(Me.LinkLabelContact)
        Me.Controls.Add(Me.LinkLabelAbout)
        Me.Controls.Add(Me.ButtonClearAdmin)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "admin"
        Me.Text = "admin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxUnitAdmin As ComboBox
    Friend WithEvents TextBoxQuantity As TextBox
    Friend WithEvents DateTimePickerExpired As DateTimePicker
    Friend WithEvents DateTimePickerArrived As DateTimePicker
    Friend WithEvents TextBoxVendor As TextBox
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonClearAdmin As Button
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LinkLabelContact As LinkLabel
    Friend WithEvents LinkLabelAbout As LinkLabel
    Friend WithEvents TextBoxIdItem As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBoxItem As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewItemToolStripMenuItem As ToolStripMenuItem
End Class
