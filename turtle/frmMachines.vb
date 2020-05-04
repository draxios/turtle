Public Class frmMachines

    Private Sub frmMachines_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub frmMachines_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Turtle v" & Application.ProductVersion & " - Machine List"
    End Sub

    Private Sub frmMachines_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        lstMachines.Width = Me.Width - 16
        lstMachines.Height = Me.Height - 38
    End Sub

    Private Sub AddMachineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMachineToolStripMenuItem.Click
        Dim buffer As String = UCase(InputBox("Enter machine name or IP:"))
        Dim buffer2 As String = InputBox("Enter a label/name:")

        Dim item As New ListViewItem
        item.SubItems.Add("0")
        item.SubItems.Add("1")
        item.SubItems.Add("2")
        item.SubItems.Add("3")

        With item
            .SubItems(0).Text = buffer
            .SubItems(1).Text = "Yet to be found."
            .SubItems(2).Text = "Never."
            .SubItems(3).Text = buffer2
        End With

        'add to array list
        arrMachines.Add(buffer)
        arrLabels.Add(buffer2)

        'add to listbox
        lstMachines.Items.Add(item)

        Dim testing As String = buffer & "$" & buffer2
        My.Settings.ListBoxCollection.Add(testing)

    End Sub

    Private Sub ClearMachineListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearMachineListToolStripMenuItem.Click
        lstMachines.Items.Clear()
        arrMachines.Clear()
        arrLabels.Clear()
        frmMain.tTimer.Enabled = False
        MinCounter = 0
        My.Settings.ListBoxCollection.Clear()
    End Sub

    Private Sub RunPeekToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunPeekToolStripMenuItem.Click
        RunPeek()
    End Sub

    Private Sub AddMachinesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMachinesToolStripMenuItem.Click
        frmBatch.Show()
    End Sub

End Class