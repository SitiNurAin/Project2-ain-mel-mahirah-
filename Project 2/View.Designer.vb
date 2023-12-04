<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(View))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinkLabelContact = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelAbout = New System.Windows.Forms.LinkLabel()
        Me.DataGridViewItem = New System.Windows.Forms.DataGridView()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridViewItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(24, 160)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(250, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.MenuToolStripMenuItem.Text = "Home"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'LinkLabelContact
        '
        Me.LinkLabelContact.AutoSize = True
        Me.LinkLabelContact.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelContact.Location = New System.Drawing.Point(744, 74)
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
        Me.LinkLabelAbout.Location = New System.Drawing.Point(681, 74)
        Me.LinkLabelAbout.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabelAbout.Name = "LinkLabelAbout"
        Me.LinkLabelAbout.Size = New System.Drawing.Size(66, 17)
        Me.LinkLabelAbout.TabIndex = 20
        Me.LinkLabelAbout.TabStop = True
        Me.LinkLabelAbout.Text = "About Us"
        '
        'DataGridViewItem
        '
        Me.DataGridViewItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewItem.Location = New System.Drawing.Point(34, 193)
        Me.DataGridViewItem.Name = "DataGridViewItem"
        Me.DataGridViewItem.Size = New System.Drawing.Size(806, 273)
        Me.DataGridViewItem.TabIndex = 21
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project_2.My.Resources.Resources._54654644
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(873, 502)
        Me.Controls.Add(Me.DataGridViewItem)
        Me.Controls.Add(Me.LinkLabelContact)
        Me.Controls.Add(Me.LinkLabelAbout)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "View"
        Me.Text = "View"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridViewItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LinkLabelContact As LinkLabel
    Friend WithEvents LinkLabelAbout As LinkLabel
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridViewItem As DataGridView
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
End Class
