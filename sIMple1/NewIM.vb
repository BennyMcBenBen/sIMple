Imports System.Windows.Forms

Public Class NewIM

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        BuddyList.TempName = TextBox1.Text
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub NewIM_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        TextBox1.Text = ""
    End Sub
End Class
