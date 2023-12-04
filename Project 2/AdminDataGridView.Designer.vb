<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDataGridView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDataGridView))
        Me.DataGridViewAdmin = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAvailableItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxSearchAdmin = New System.Windows.Forms.TextBox()
        Me.LinkLabelContact = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelAbout = New System.Windows.Forms.LinkLabel()
        CType(Me.DataGridViewAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewAdmin
        '
        Me.DataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAdmin.Location = New System.Drawing.Point(52, 224)
        Me.DataGridViewAdmin.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewAdmin.Name = "DataGridViewAdmin"
        Me.DataGridViewAdmin.RowTemplate.Height = 24
        Me.DataGridViewAdmin.Size = New System.Drawing.Size(798, 187)
        Me.DataGridViewAdmin.TabIndex = 14
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.AddItemsToolStripMenuItem, Me.ViewStaffToolStripMenuItem, Me.ViewAvailableItemToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(52, 179)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(457, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.MenuToolStripMenuItem.Text = "Home"
        '
        'AddItemsToolStripMenuItem
        '
        Me.AddItemsToolStripMenuItem.Name = "AddItemsToolStripMenuItem"
        Me.AddItemsToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.AddItemsToolStripMenuItem.Text = "Add Items"
        '
        'ViewStaffToolStripMenuItem
        '
        Me.ViewStaffToolStripMenuItem.Name = "ViewStaffToolStripMenuItem"
        Me.ViewStaffToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.ViewStaffToolStripMenuItem.Text = "View Staff Order"
        '
        'ViewAvailableItemToolStripMenuItem
        '
        Me.ViewAvailableItemToolStripMenuItem.Name = "ViewAvailableItemToolStripMenuItem"
        Me.ViewAvailableItemToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.ViewAvailableItemToolStripMenuItem.Text = "View Available Item"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 133)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 26)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Search :"
        '
        'TextBoxSearchAdmin
        '
        Me.TextBoxSearchAdmin.Location = New System.Drawing.Point(195, 136)
        Me.TextBoxSearchAdmin.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxSearchAdmin.Multiline = True
        Me.TextBoxSearchAdmin.Name = "TextBoxSearchAdmin"
        Me.TextBoxSearchAdmin.Size = New System.Drawing.Size(246, 23)
        Me.TextBoxSearchAdmin.TabIndex = 16
        '
        'LinkLabelContact
        '
        Me.LinkLabelContact.AutoSize = True
        Me.LinkLabelContact.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelContact.Location = New System.Drawing.Point(801, 50)
        Me.LinkLabelContact.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabelContact.Name = "LinkLabelContact"
        Me.LinkLabelContact.Size = New System.Drawing.Size(77, 17)
        Me.LinkLabelContact.TabIndex = 23
        Me.LinkLabelContact.TabStop = True
        Me.LinkLabelContact.Text = "Contact Us"
        '
        'LinkLabelAbout
        '
        Me.LinkLabelAbout.AutoSize = True
        Me.LinkLabelAbout.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelAbout.Location = New System.Drawing.Point(738, 50)
        Me.LinkLabelAbout.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabelAbout.Name = "LinkLabelAbout"
        Me.LinkLabelAbout.Size = New System.Drawing.Size(66, 17)
        Me.LinkLabelAbout.TabIndex = 24
        Me.LinkLabelAbout.TabStop = True
        Me.LinkLabelAbout.Text = "About Us"
        '
        'AdminDataGridView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project_2.My.Resources.Resources.dgbthjtyjt
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(920, 484)
        Me.Controls.Add(Me.LinkLabelContact)
        Me.Controls.Add(Me.LinkLabelAbout)
        Me.Controls.Add(Me.TextBoxSearchAdmin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewAdmin)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AdminDataGridView"
        Me.Text = "AdminDataGridView"
        CType(Me.DataGridViewAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewAdmin As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxSearchAdmin As TextBox
    Friend WithEvents AddItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LinkLabelContact As LinkLabel
    Friend WithEvents LinkLabelAbout As LinkLabel
    Friend WithEvents ViewAvailableItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
