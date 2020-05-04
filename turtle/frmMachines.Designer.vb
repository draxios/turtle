<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMachines
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMachines))
        Me.lstMachines = New System.Windows.Forms.ListView()
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colLastSeen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colLabel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.menuMachines = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearMachineListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RemoveMachineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddMachinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddMachineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RunPeekToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuMachines.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstMachines
        '
        Me.lstMachines.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colName, Me.colStatus, Me.colLastSeen, Me.colLabel})
        Me.lstMachines.ContextMenuStrip = Me.menuMachines
        Me.lstMachines.Location = New System.Drawing.Point(0, 0)
        Me.lstMachines.Name = "lstMachines"
        Me.lstMachines.Size = New System.Drawing.Size(373, 270)
        Me.lstMachines.TabIndex = 0
        Me.lstMachines.UseCompatibleStateImageBehavior = False
        Me.lstMachines.View = System.Windows.Forms.View.Details
        '
        'colName
        '
        Me.colName.Text = "Name"
        Me.colName.Width = 89
        '
        'colStatus
        '
        Me.colStatus.Text = "Status"
        Me.colStatus.Width = 93
        '
        'colLastSeen
        '
        Me.colLastSeen.Text = "Last Seen"
        Me.colLastSeen.Width = 103
        '
        'colLabel
        '
        Me.colLabel.Text = "Label"
        Me.colLabel.Width = 84
        '
        'menuMachines
        '
        Me.menuMachines.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearMachineListToolStripMenuItem, Me.ToolStripMenuItem1, Me.RemoveMachineToolStripMenuItem, Me.ToolStripMenuItem2, Me.AddMachinesToolStripMenuItem, Me.AddMachineToolStripMenuItem, Me.ToolStripMenuItem3, Me.RunPeekToolStripMenuItem})
        Me.menuMachines.Name = "menuMachines"
        Me.menuMachines.Size = New System.Drawing.Size(172, 132)
        '
        'ClearMachineListToolStripMenuItem
        '
        Me.ClearMachineListToolStripMenuItem.Name = "ClearMachineListToolStripMenuItem"
        Me.ClearMachineListToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ClearMachineListToolStripMenuItem.Text = "Clear Machine List"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(168, 6)
        '
        'RemoveMachineToolStripMenuItem
        '
        Me.RemoveMachineToolStripMenuItem.Name = "RemoveMachineToolStripMenuItem"
        Me.RemoveMachineToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.RemoveMachineToolStripMenuItem.Text = "Remove Machine"
        Me.RemoveMachineToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(168, 6)
        Me.ToolStripMenuItem2.Visible = False
        '
        'AddMachinesToolStripMenuItem
        '
        Me.AddMachinesToolStripMenuItem.Name = "AddMachinesToolStripMenuItem"
        Me.AddMachinesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AddMachinesToolStripMenuItem.Text = "Add Machines..."
        '
        'AddMachineToolStripMenuItem
        '
        Me.AddMachineToolStripMenuItem.Name = "AddMachineToolStripMenuItem"
        Me.AddMachineToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AddMachineToolStripMenuItem.Text = "Add Machine"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(168, 6)
        '
        'RunPeekToolStripMenuItem
        '
        Me.RunPeekToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunPeekToolStripMenuItem.Name = "RunPeekToolStripMenuItem"
        Me.RunPeekToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.RunPeekToolStripMenuItem.Text = "Run Peek"
        '
        'frmMachines
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 270)
        Me.Controls.Add(Me.lstMachines)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMachines"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Turtle"
        Me.menuMachines.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstMachines As System.Windows.Forms.ListView
    Friend WithEvents menuMachines As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ClearMachineListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RemoveMachineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddMachinesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddMachineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RunPeekToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colLastSeen As System.Windows.Forms.ColumnHeader
    Friend WithEvents colLabel As System.Windows.Forms.ColumnHeader
End Class
