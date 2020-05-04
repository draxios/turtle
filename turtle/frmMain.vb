Imports System.IO
Imports System.Reflection

Public Class frmMain

    Public Sub LoadSettings()



        tTimer.Enabled = False
        frmMachines.lstMachines.Items.Clear()
        arrMachines.Clear()
        arrLabels.Clear()
        MinCounter = 0

        HowManyMinutesToWait = My.Settings.WaitTime
        UseLog = My.Settings.UseLog

        Dim buffer() As String = {}
        'Dim temper As String = ""

        ' Try

        For Each item As String In My.Settings.ListBoxCollection
            'ListBox1.Items.Add(item)

            If item <> "" Or item <> " " Then

                buffer = Split(item, "$")

                'For Each temper In buffer

                Dim item2 As New ListViewItem
                item2.SubItems.Add("0")
                item2.SubItems.Add("1")
                item2.SubItems.Add("2")
                item2.SubItems.Add("3")

                With item2
                    .SubItems(0).Text = buffer(0)
                    .SubItems(1).Text = "Yet to be found."
                    .SubItems(2).Text = "Never."
                    .SubItems(3).Text = buffer(1)

                End With

                arrMachines.Add(buffer(0))
                arrLabels.Add(buffer(1))
                frmMachines.lstMachines.Items.Add(item2)

            End If
        Next

        'Catch ex As Exception
        'MrLogger.log("Error loading settings, perhaps list is null.")
        'End Try

        My.Settings.Save()

    End Sub


    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Save()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon.Text = "Turtle v" & Application.ProductVersion
        frmMachines.Opacity = 0
        frmMachines.Show()
        frmMachines.Hide()
        frmMachines.Opacity = 100
        Me.Visible = False
        Threading.Thread.Sleep(200)
        MrLogger.log("Turtle v" & Application.ProductVersion & " loaded successfully.")
        LoadSettings()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Icon.Visible = False
        MrLogger.log("Turtle v" & Application.ProductVersion & " closed successfully.")
        My.Settings.Save()
        Threading.Thread.Sleep(500)
        End
    End Sub

    Private Sub UseLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UseLogToolStripMenuItem.Click
        If UseLogToolStripMenuItem.Checked = True Then
            MrLogger.log("Turning off the logging.")
            UseLogToolStripMenuItem.Checked = False
            UseLog = False
            My.Settings.UseLog = False
        Else
            UseLogToolStripMenuItem.Checked = True
            UseLog = True
            My.Settings.UseLog = True
            MrLogger.log("Turning on the logging.")
        End If
    End Sub

    Private Sub StatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatusToolStripMenuItem.Click
        frmMachines.Show()
    End Sub

    Private Sub PeekToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeekToolStripMenuItem.Click
        If PeekToolStripMenuItem.Checked = True Then
            PeekToolStripMenuItem.Text = "Peek"
            PeekToolStripMenuItem.Checked = False
            PeekRunning = False
            tTimer.Enabled = False
            MinCounter = 0
        Else
            PeekToolStripMenuItem.Text = "Peeking"
            PeekToolStripMenuItem.Checked = True
            PeekRunning = True
            tTimer.Enabled = True
            MinCounter = 0
        End If
    End Sub

    Private Sub tTimer_Tick(sender As Object, e As EventArgs) Handles tTimer.Tick
        If MinCounter >= HowManyMinutesToWait Then
            'RunCheck
            RunPeek()
            MinCounter = 0
        Else
            MinCounter = MinCounter + 1
        End If
    End Sub

    Private Sub SetCheckTimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetCheckTimeToolStripMenuItem.Click
        HowManyMinutesToWait = CInt(InputBox("Enter how many minute between peeks (currently " & HowManyMinutesToWait & "):", "Turtle Peek Time"))
        MrLogger.log("Peek time changed to " & HowManyMinutesToWait)
        My.Settings.WaitTime = HowManyMinutesToWait
    End Sub

    Private Sub ForcePeekNowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForcePeekNowToolStripMenuItem.Click
        RunPeek()
    End Sub
End Class
