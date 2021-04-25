Public Class Start_View
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        process_View.Value += 1

        If process_View.Value >= 100 Then
            Timer1.Stop()
            Me.Hide()
            Form1.ShowDialog()

            Me.Close()
        End If

        Panel2.Width += 10
        If Panel2.Width >= Panel1.Width Then
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub process_View_ProgressChanged(sender As Object, e As EventArgs) Handles process_View.ProgressChanged

    End Sub
End Class