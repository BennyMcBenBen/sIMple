Public Class ChangeProfileForm

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        BuddyList.Myself.Info = RichTextBox1.Text
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ProfileForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        RichTextBox1.Text = BuddyList.Myself.Info
    End Sub
End Class