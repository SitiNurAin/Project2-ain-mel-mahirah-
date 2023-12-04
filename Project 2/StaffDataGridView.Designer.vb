<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffDataGridView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffDataGridView))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBoxSearchStaff = New System.Windows.Forms.TextBox()
        Me.DataGridViewStaff = New System.Windows.Forms.DataGridView()
        Me.LinkLabelContactUs = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelAbout = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridViewStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.OrderItemsToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(52, 176)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(245, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.HomeToolStripMenuItem.Text = "Home "
        '
        'OrderItemsToolStripMenuItem
        '
        Me.OrderItemsToolStripMenuItem.Name = "OrderItemsToolStripMenuItem"
        Me.OrderItemsToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.OrderItemsToolStripMenuItem.Text = "Order Items"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.LogOutToolStripMenuItem.Text = "Log Out "
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TextBoxSearchStaff
        '
        Me.TextBoxSearchStaff.Location = New System.Drawing.Point(195, 136)
        Me.TextBoxSearchStaff.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxSearchStaff.Multiline = True
        Me.TextBoxSearchStaff.Name = "TextBoxSearchStaff"
        Me.TextBoxSearchStaff.Size = New System.Drawing.Size(244, 22)
        Me.TextBoxSearchStaff.TabIndex = 18
        '
        'DataGridViewStaff
        '
        Me.DataGridViewStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewStaff.Location = New System.Drawing.Point(52, 224)
        Me.DataGridViewStaff.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewStaff.Name = "DataGridViewStaff"
        Me.DataGridViewStaff.RowTemplate.Height = 24
        Me.DataGridViewStaff.Size = New System.Drawing.Size(798, 187)
        Me.DataGridViewStaff.TabIndex = 19
        '
        'LinkLabelContactUs
        '
        Me.LinkLabelContactUs.AutoSize = True
        Me.LinkLabelContactUs.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelContactUs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelContactUs.Location = New System.Drawing.Point(821, 47)
        Me.LinkLabelContactUs.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabelContactUs.Name = "LinkLabelContactUs"
        Me.LinkLabelContactUs.Size = New System.Drawing.Size(77, 17)
        Me.LinkLabelContactUs.TabIndex = 25
        Me.LinkLabelContactUs.TabStop = True
        Me.LinkLabelContactUs.Text = "Contact Us"
        '
        'LinkLabelAbout
        '
        Me.LinkLabelAbout.AutoSize = True
        Me.LinkLabelAbout.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelAbout.Location = New System.Drawing.Point(758, 47)
        Me.LinkLabelAbout.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabelAbout.Name = "LinkLabelAbout"
        Me.LinkLabelAbout.Size = New System.Drawing.Size(66, 17)
        Me.LinkLabelAbout.TabIndex = 26
        Me.LinkLabelAbout.TabStop = True
        Me.LinkLabelAbout.Text = "About Us"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 136)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 26)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Search :"
        '
        'StaffDataGridView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project_2.My.Resources.Resources.ukmiyk_ui
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(920, 484)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabelContactUs)
        Me.Controls.Add(Me.LinkLabelAbout)
        Me.Controls.Add(Me.DataGridViewStaff)
        Me.Controls.Add(Me.TextBoxSearchStaff)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "StaffDataGridView"
        Me.Text = "StaffDataGridView"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridViewStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TextBoxSearchStaff As TextBox
    Friend WithEvents DataGridViewStaff As DataGridView
    Friend WithEvents LinkLabelContactUs As LinkLabel
    Friend WithEvents LinkLabelAbout As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrderItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
