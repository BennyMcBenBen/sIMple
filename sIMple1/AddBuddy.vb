Public Class AddBuddy

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Correct() Then
            Dim buddy As New Buddy(TextBox1.Text, TextBox2.Text, "available", "", "")
            BuddyList.AddNewBuddy(ComboBox1.Text, buddy)
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub AddBuddy_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim group As String
        For Each group In BuddyList.GetGroups
            ComboBox1.Items.Add(group)
        Next
    End Sub

    Private Function Correct() As Boolean
        If TextBox1.Text.CompareTo("") = 0 Then
            MessageBox.Show("You need to enter in a screen name")
            Return False
        End If

        If TextBox2.Text.CompareTo("") = 0 Then
            MessageBox.Show("You need to enter in an alias")
            Return False
        End If

        If ComboBox1.Text.CompareTo("") = 0 Then
            MessageBox.Show("You need to enter in a group")
            Return False
        End If

        Return True
    End Function
End Class