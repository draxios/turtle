<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Icon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.IconMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UseLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetCheckTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeekToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ForcePeekNowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IconMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Icon
        '
        Me.Icon.ContextMenuStrip = Me.IconMenu
        Me.Icon.Icon = CType(resources.GetObject("Icon.Icon"), System.Drawing.Icon)
        Me.Icon.Text = "Turtle"
        Me.Icon.Visible = True
        '
        'IconMenu
        '
        Me.IconMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PeekToolStripMenuItem, Me.ToolStripMenuItem2, Me.ForcePeekNowToolStripMenuItem, Me.StatusToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.IconMenu.Name = "IconMenu"
        Me.IconMenu.Size = New System.Drawing.Size(160, 148)
        '
        'StatusToolStripMenuItem
        '
        Me.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem"
        Me.StatusToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.StatusToolStripMenuItem.Text = "Status..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(156, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UseLogToolStripMenuItem, Me.SetCheckTimeToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(156, 6)
        '
        'UseLogToolStripMenuItem
        '
        Me.UseLogToolStripMenuItem.Checked = True
        Me.UseLogToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.UseLogToolStripMenuItem.Name = "UseLogToolStripMenuItem"
        Me.UseLogToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.UseLogToolStripMenuItem.Text = "Use Log"
        '
        'SetCheckTimeToolStripMenuItem
        '
        Me.SetCheckTimeToolStripMenuItem.Name = "SetCheckTimeToolStripMenuItem"
        Me.SetCheckTimeToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.SetCheckTimeToolStripMenuItem.Text = "Set Check Time..."
        '
        'PeekToolStripMenuItem
        '
        Me.PeekToolStripMenuItem.Name = "PeekToolStripMenuItem"
        Me.PeekToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.PeekToolStripMenuItem.Text = "Peek"
        '
        'tTimer
        '
        Me.tTimer.Interval = 60000
        '
        'ForcePeekNowToolStripMenuItem
        '
        Me.ForcePeekNowToolStripMenuItem.Name = "ForcePeekNowToolStripMenuItem"
        Me.ForcePeekNowToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ForcePeekNowToolStripMenuItem.Text = "Force Peek Now"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(191, 116)
        Me.Name = "frmMain"
        Me.Opacity = 0.0R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "frmMain"
        Me.IconMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Icon As System.Windows.Forms.NotifyIcon
    Friend WithEvents IconMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UseLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetCheckTimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PeekToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tTimer As System.Windows.Forms.Timer
    Friend WithEvents ForcePeekNowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
