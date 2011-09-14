Public Class SignOn

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text <> "") Then
            BuddyList.Myself.NameAlias = TextBox1.Text
            BuddyList.Show()
            Me.Hide()
        End If
    End Sub
End Class