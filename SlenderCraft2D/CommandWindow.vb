Public Class CommandWindow

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ServerWindow.Sdk1.SendKoordinates(TextBox1.Text)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TextBox2.Text = ServerWindow.Sdk1.Koordinaten
    End Sub

End Class