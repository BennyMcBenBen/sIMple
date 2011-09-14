Public Class ViewProfileForm

    Dim buddy As Buddy

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Public Sub SetBuddy(ByVal value As Buddy)
        buddy = value
    End Sub

    Private Sub ViewProfileForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = buddy.NameAlias & "'s Profile"
        RichTextBox1.Text = buddy.Info
    End Sub
End Class