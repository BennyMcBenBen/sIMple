Public Class ChangeStatusForm

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        BuddyList.UpdateB1Caption()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim status As String
        If RadioButton1.Checked Then
            status = "available"
        ElseIf RadioButton2.Checked Then
            status = "away"
        Else
            status = "offline"
        End If
        BuddyList.Myself.Status = status
        BuddyList.Myself.Message = RichTextBox1.Text
        BuddyList.UpdateB1Caption()
        Me.Close()
    End Sub



    Private Sub StatusForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Select Case BuddyList.Myself.Status
            Case "available"
                RadioButton1.Checked = True
            Case "away"
                RadioButton2.Checked = True
            Case "offline"
                RadioButton3.Checked = True
        End Select
        RichTextBox1.Text = BuddyList.Myself.Message

    End Sub


End Class