Public Class World
   
    Public Player As String = "0"
   
    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Process.Start("killprocess.bat")
        ServerWindow.Close()
    End Sub



    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Me.Invalidate()
    End Sub

#Region "PlayerSkins"
    Public Skin1 As Image = My.Resources.Girl1Up
    Public Player1 As New Rectangle(120, 120, 50, 70)
    Public Skin2 As Image = My.Resources.Girl2Up
    Public Player2 As New Rectangle(120, 120, 50, 70)
    Public Skin3 As Image = My.Resources.Guy1Up
    Public Player3 As New Rectangle(120, 120, 50, 70)
    Public Skin4 As Image = My.Resources.Guy2Up
  
#End Region

#Region "CollisionObjects"


    Public BlockObject1 As New Rectangle(352, -1, 66, 46)

   

#End Region
    Private Sub World_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        With e.Graphics
            .DrawImage(Skin1, Player1)
            .DrawImage(Skin2, Player2)
            .DrawImage(Skin3, Player3)
            .SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

           

        End With

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ServerWindow.Show()
        ServerWindow.Opacity = 0
        ServerWindow.ShowInTaskbar = False
        HackSLoad.Show()
        Me.KeyPreview = True
        Me.DoubleBuffered = True
        CommandWindow.Show()
        CommandWindow.Opacity = 0
        CommandWindow.ShowInTaskbar = False
      
       

    End Sub
#Region "BewegungsSubs"

    Public Sub P1Up()
        Player1.Y -= 7
        Me.Invalidate()
    End Sub
    Public Sub P1Down()
        Player1.Y += 7
        Me.Invalidate()
    End Sub
    Public Sub P1Right()
        Player1.X += 7
        Me.Invalidate()
    End Sub
    Public Sub P1Left()
        Player1.X -= 7
        Me.Invalidate()
    End Sub


    Public Sub P2Up()
        Player2.Y -= 7
        Me.Invalidate()
    End Sub
    Public Sub P2Down()
        Player2.Y += 7
        Me.Invalidate()
    End Sub
    Public Sub P2Right()
        Player2.X += 7
        Me.Invalidate()
    End Sub
    Public Sub P2Left()
        Player2.X -= 7
        Me.Invalidate()
    End Sub


#End Region


End Class
