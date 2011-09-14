Public Class TimerControl

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            BuddyList.RandomIMTimer.Enabled = True
        Else
            BuddyList.RandomIMTimer.Enabled = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            BuddyList.RandomStatusChangeTimer.Enabled = True
        Else
            BuddyList.RandomStatusChangeTimer.Enabled = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            BuddyList.FacebookTestTimer.Enabled = True
        Else
            BuddyList.FacebookTestTimer.Enabled = False
        End If
    End Sub
End Class