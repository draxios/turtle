<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBatch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBatch))
        Me.txtBatchAdd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddBatch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtBatchAdd
        '
        Me.txtBatchAdd.Location = New System.Drawing.Point(12, 27)
        Me.txtBatchAdd.Multiline = True
        Me.txtBatchAdd.Name = "txtBatchAdd"
        Me.txtBatchAdd.Size = New System.Drawing.Size(266, 485)
        Me.txtBatchAdd.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Workstations:"
        '
        'btnAddBatch
        '
        Me.btnAddBatch.Location = New System.Drawing.Point(167, 518)
        Me.btnAddBatch.Name = "btnAddBatch"
        Me.btnAddBatch.Size = New System.Drawing.Size(111, 31)
        Me.btnAddBatch.TabIndex = 3
        Me.btnAddBatch.Text = "Add"
        Me.btnAddBatch.UseVisualStyleBackColor = True
        '
        'frmBatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 555)
        Me.Controls.Add(Me.btnAddBatch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBatchAdd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBatch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Batch Add"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBatchAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAddBatch As System.Windows.Forms.Button
End Class
