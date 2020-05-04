Module modMain
    Public arrMachines As New ArrayList
    Public arrLabels As New ArrayList
    Public logPath As String = "C:\Temp\turtleLog.log"
    Public TimeBreak As Double = 3600000     'one hour
    Public TimeStart As Double = 0
    Public TimeEnd As Double = 0
    Public PeekRunning As Boolean = False
    Public MinCounter As Integer = 0
    Public HowManyMinutesToWait As Integer = 60
    Public UseLog As Boolean = True



    Public Sub RunPeek()


        Dim strComputer As String = ""
        Dim counter As Integer = 0

        'Clear them
        'frmMachines.lstMachines.Items.Clear()
        'Dim item As New ListViewItem
        'item.SubItems.Add("0")
        'item.SubItems.Add("1")
        'With item
        ' .SubItems(0).Text = strComputer
        ' .SubItems(1).Text = "Computer last seen @ " & Now
        ' End With

        'frmMachines.lstMachines.Items.Add(item)
        Dim strThing As ListViewItem

        For Each strThing In frmMachines.lstMachines.Items

            'MsgBox(strThing.Text)

            Try

                If My.Computer.Network.Ping(strThing.Text) Then
                    frmMachines.lstMachines.Items(counter).SubItems(1).Text = "Active."
                    frmMachines.lstMachines.Items(counter).SubItems(2).Text = Now
                    MrLogger.log(strThing.Text & " found at " & Now)
                Else
                    frmMachines.lstMachines.Items(counter).SubItems(1).Text = "Inactive."
                End If

            Catch ex As Exception
                frmMachines.lstMachines.Items(counter).SubItems(1).Text = "Not found."

            Finally
                counter = counter + 1
            End Try

            Threading.Thread.Sleep(100)
        Next


    End Sub

End Module
