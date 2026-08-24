Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim.Length = 0 Then
            ToolTip1.Show("You idiot - I need some input!", TextBox1, New Point(0, -60), 3000)
        End If
    End Sub
End Class
