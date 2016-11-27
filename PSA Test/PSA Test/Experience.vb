Public Class Experience

    Private Sub Experience_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click
        ResultsBox.Text = TrackBar.Value.ToString()
    End Sub
    'track bar is used to track the customer experience
    Private Sub TrackBar_Scroll(sender As Object, e As EventArgs) Handles TrackBar.Scroll

    End Sub
End Class