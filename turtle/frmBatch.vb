Public Class frmBatch

    Private Sub btnAddBatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddBatch.Click

        Dim blnAnswer = MsgBox("Do you want to add labels?", MsgBoxStyle.YesNo, "Turtle v" & Application.ProductVersion)
        Dim buffer() As String = {}
        Dim temper As String = ""



        Dim item As New ListViewItem
        item.SubItems.Add("0")
        item.SubItems.Add("1")
        item.SubItems.Add("2")
        item.SubItems.Add("3")

        buffer = Split(txtBatchAdd.Text, vbCrLf)

        For Each temper In buffer

            If temper <> "" Then
                arrMachines.Add(temper)
                With item
                    .SubItems(0).Text = temper
                    .SubItems(1).Text = "Yet to be found."
                    .SubItems(2).Text = "Never."
                    If blnAnswer = vbYes Then
                        .SubItems(3).Text = InputBox("Enter a label/name:")
                        arrLabels.Add(.SubItems(3).Text)
                    Else
                        .SubItems(3).Text = "None"
                        arrLabels.Add("None")
                    End If
                End With
                frmMachines.lstMachines.Items.Add(item)
                My.Settings.ListBoxCollection.Add(temper & "$" & item.SubItems(3).Text)
            End If

        Next

        txtBatchAdd.Text = ""
        Me.Close()
    End Sub
End Class