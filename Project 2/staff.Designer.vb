<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class staff
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(staff))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewOrderDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxExp = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxItem = New System.Windows.Forms.ComboBox()
        Me.TextBoxQuantity = New System.Windows.Forms.TextBox()
        Me.TextBoxItemInRoom = New System.Windows.Forms.TextBox()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.TextBoxStaffName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonOrder = New System.Windows.Forms.Button()
        Me.ButtonClearStaff = New System.Windows.Forms.Button()
        Me.LinkLabelContact = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelAbout = New System.Windows.Forms.LinkLabel()
        Me.txtExperiment = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ViewItemToolStripMenuItem, Me.ViewOrderDetailToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(19, 137)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(398, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.MenuToolStripMenuItem.Text = "Home"
        '
        'ViewItemToolStripMenuItem
        '
        Me.ViewItemToolStripMenuItem.Name = "ViewItemToolStripMenuItem"
        Me.ViewItemToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.ViewItemToolStripMenuItem.Text = "View Available Item "
        '
        'ViewOrderDetailToolStripMenuItem
        '
        Me.ViewOrderDetailToolStripMenuItem.Name = "ViewOrderDetailToolStripMenuItem"
        Me.ViewOrderDetailToolStripMenuItem.Size = New System.Drawing.Size(115, 20)
        Me.ViewOrderDetailToolStripMenuItem.Text = "View Order Details"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(748, 80)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(51, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "About Us"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(802, 80)
        Me.LinkLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(60, 13)
        Me.LinkLabel2.TabIndex = 2
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Contact Us"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtExperiment)
        Me.GroupBox1.Controls.Add(Me.ComboBoxExp)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBoxItem)
        Me.GroupBox1.Controls.Add(Me.TextBoxQuantity)
        Me.GroupBox1.Controls.Add(Me.TextBoxItemInRoom)
        Me.GroupBox1.Controls.Add(Me.TextBoxId)
        Me.GroupBox1.Controls.Add(Me.TextBoxStaffName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 171)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(458, 230)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ORDER DETAILS"
        '
        'ComboBoxExp
        '
        Me.ComboBoxExp.FormattingEnabled = True
        Me.ComboBoxExp.Items.AddRange(New Object() {"Synthesis", "Extraction", "Steam Distillation", "Hydrolysis", "-none-"})
        Me.ComboBoxExp.Location = New System.Drawing.Point(104, 121)
        Me.ComboBoxExp.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxExp.Name = "ComboBoxExp"
        Me.ComboBoxExp.Size = New System.Drawing.Size(113, 21)
        Me.ComboBoxExp.TabIndex = 7
        Me.ComboBoxExp.Text = "Select Experiment"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 121)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Experiment: "
        '
        'ComboBoxItem
        '
        Me.ComboBoxItem.FormattingEnabled = True
        Me.ComboBoxItem.Items.AddRange(New Object() {"Microscope", "Test Tubes", "ethanol", "oxidising acids", "Flammable liquids", "Salts", "Cyanides", "Inorganic Acids", "Beakers", "Benzene", "Hydroxide", "Magnifying Glass", "Volumetric Flask", "Bunsen Burner", "Dropper", "Thermometer", "Tongs", "Brushers", "Weighing Machines", "Wash Bottles", "Spatula", "Spring Balance", "Burette", "Watch Glass", "Funnels"})
        Me.ComboBoxItem.Location = New System.Drawing.Point(104, 92)
        Me.ComboBoxItem.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxItem.Name = "ComboBoxItem"
        Me.ComboBoxItem.Size = New System.Drawing.Size(92, 21)
        Me.ComboBoxItem.TabIndex = 5
        Me.ComboBoxItem.Text = "Select Item"
        '
        'TextBoxQuantity
        '
        Me.TextBoxQuantity.Location = New System.Drawing.Point(104, 151)
        Me.TextBoxQuantity.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxQuantity.Name = "TextBoxQuantity"
        Me.TextBoxQuantity.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxQuantity.TabIndex = 4
        '
        'TextBoxItemInRoom
        '
        Me.TextBoxItemInRoom.Location = New System.Drawing.Point(104, 184)
        Me.TextBoxItemInRoom.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxItemInRoom.Name = "TextBoxItemInRoom"
        Me.TextBoxItemInRoom.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxItemInRoom.TabIndex = 4
        '
        'TextBoxId
        '
        Me.TextBoxId.Location = New System.Drawing.Point(104, 35)
        Me.TextBoxId.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxId.TabIndex = 4
        '
        'TextBoxStaffName
        '
        Me.TextBoxStaffName.Location = New System.Drawing.Point(104, 63)
        Me.TextBoxStaffName.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxStaffName.Name = "TextBoxStaffName"
        Me.TextBoxStaffName.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxStaffName.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 187)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Item In Room:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 35)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Id Items: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 151)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Quantity:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 63)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Staff Name: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name Item: "
        '
        'ButtonOrder
        '
        Me.ButtonOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOrder.Location = New System.Drawing.Point(525, 171)
        Me.ButtonOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonOrder.Name = "ButtonOrder"
        Me.ButtonOrder.Size = New System.Drawing.Size(114, 106)
        Me.ButtonOrder.TabIndex = 16
        Me.ButtonOrder.Text = "Place Order"
        Me.ButtonOrder.UseVisualStyleBackColor = True
        '
        'ButtonClearStaff
        '
        Me.ButtonClearStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearStaff.Location = New System.Drawing.Point(525, 288)
        Me.ButtonClearStaff.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonClearStaff.Name = "ButtonClearStaff"
        Me.ButtonClearStaff.Size = New System.Drawing.Size(114, 106)
        Me.ButtonClearStaff.TabIndex = 7
        Me.ButtonClearStaff.Text = "Clear"
        Me.ButtonClearStaff.UseVisualStyleBackColor = True
        '
        'LinkLabelContact
        '
        Me.LinkLabelContact.AutoSize = True
        Me.LinkLabelContact.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelContact.Location = New System.Drawing.Point(568, 50)
        Me.LinkLabelContact.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabelContact.Name = "LinkLabelContact"
        Me.LinkLabelContact.Size = New System.Drawing.Size(77, 17)
        Me.LinkLabelContact.TabIndex = 19
        Me.LinkLabelContact.TabStop = True
        Me.LinkLabelContact.Text = "Contact Us"
        '
        'LinkLabelAbout
        '
        Me.LinkLabelAbout.AutoSize = True
        Me.LinkLabelAbout.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelAbout.Location = New System.Drawing.Point(506, 50)
        Me.LinkLabelAbout.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabelAbout.Name = "LinkLabelAbout"
        Me.LinkLabelAbout.Size = New System.Drawing.Size(66, 17)
        Me.LinkLabelAbout.TabIndex = 20
        Me.LinkLabelAbout.TabStop = True
        Me.LinkLabelAbout.Text = "About Us"
        '
        'txtExperiment
        '
        Me.txtExperiment.Location = New System.Drawing.Point(301, 126)
        Me.txtExperiment.Margin = New System.Windows.Forms.Padding(2)
        Me.txtExperiment.Name = "txtExperiment"
        Me.txtExperiment.Size = New System.Drawing.Size(142, 20)
        Me.txtExperiment.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(244, 126)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Others: "
        '
        'staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project_2.My.Resources.Resources._758u67i87i
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(673, 440)
        Me.Controls.Add(Me.LinkLabelContact)
        Me.Controls.Add(Me.LinkLabelAbout)
        Me.Controls.Add(Me.ButtonClearStaff)
        Me.Controls.Add(Me.ButtonOrder)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "staff"
        Me.Text = "Staff "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxItemInRoom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ViewItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBoxStaffName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonOrder As Button
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ButtonClearStaff As Button
    Friend WithEvents ComboBoxItem As ComboBox
    Friend WithEvents TextBoxQuantity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabelContact As LinkLabel
    Friend WithEvents LinkLabelAbout As LinkLabel
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewOrderDetailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBoxExp As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtExperiment As TextBox
End Class
