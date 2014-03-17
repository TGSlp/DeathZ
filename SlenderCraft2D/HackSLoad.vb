Public Class HackSLoad

    Private Sub HackSLoad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim x As Integer = My.Computer.Screen.WorkingArea.Width
        Dim y As Integer = My.Computer.Screen.WorkingArea.Height
        Me.Left = x - Me.Width
        Me.Top = y - Me.Height
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If MetroProgressbar1.Value = "100" Then
            Timer1.Stop()
            Timer2.Stop()
            Me.Hide()
            World.Opacity = 100
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        MetroProgressbar1.Value = MetroProgressbar1.Value + 10
    End Sub

End Class