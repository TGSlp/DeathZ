
Public Class ServerWindow

    Dim ConfigReader As New FileReaderHelper
    Public PlayMusic As Boolean


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Infos.Tick
        TextBox1.Text = Sdk1.Koordinaten
        TextBox2.Text = Sdk1.Message
        Label4.Text = Sdk1.Player
        Label6.Text = Sdk1.MaxPlayer
        Label7.Text = Sdk1.Player


    End Sub



    Private Sub ServerWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PlayMusic = False

        AudioPlayer.settings.volume = 13
        If PlayMusic = True Then
            AudioPlayer.URL = My.Computer.FileSystem.CurrentDirectory + "\Sounds\Dark Rap Beat - City of Angels.mp3"
        End If
        HackSLoad.MetroProgressbar1.Value = "10"
        Dim Reader As New FileReaderHelper
        Reader.ReadLine("Config.ini", "1")
        Sdk1.Connect(Reader.Zeileninhalt)

    End Sub




    Private Sub Bewegen_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bewegen.Tick
        If TextBox1.Text.Contains("Player1 Up") Then
            World.Skin1 = My.Resources.Girl1Up
            World.P1Up()
        End If
        If TextBox1.Text.Contains("Player1 Down") Then
            World.Skin1 = My.Resources.Girl1Down
            World.P1Down()
        End If
        If TextBox1.Text.Contains("Player1 Right") Then
            World.Skin1 = My.Resources.Girl1Right
            World.P1Right()
        End If
        If TextBox1.Text.Contains("Player1 Left") Then
            World.Skin1 = My.Resources.Girl1Left
            World.P1Left()
        End If



        If TextBox1.Text.Contains("Player2 Up") Then
            World.Skin2 = My.Resources.Girl2Up
            World.P2Up()
        End If
        If TextBox1.Text.Contains("Player2 Down") Then
            World.Skin2 = My.Resources.Girl2Down
            World.P2Down()
        End If
        If TextBox1.Text.Contains("Player2 Right") Then
            World.Skin2 = My.Resources.Girl2Right
            World.P2Right()
        End If
        If TextBox1.Text.Contains("Player2 Left") Then
            World.Skin2 = My.Resources.Girl2Left
            World.P2Left()
        End If




    End Sub

    Private Sub SetPlayer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetPlayer.Tick
        World.Player = Label4.Text
        HackSLoad.MetroProgressbar1.Value = "30"
        SetPlayer.Stop()


        'If Label6.Text = "255" Then
        'MsgBox("Server nicht verfügbar", MsgBoxStyle.Exclamation)

        'End If
    End Sub

    Private Sub Blink1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blink1.Tick
        World.Text = "DeathZ v1.0.0.0 Alpha     You are player " + World.Player + "       *It´s not 3D!*"
    End Sub

    Private Sub Blink2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blink2.Tick
        World.Text = "DeathZ v1.0.0.0 Alpha     You are player " + World.Player
    End Sub

    Private Sub Collision_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Collision.Tick

        'Wand Links
        If World.Player1.Left <= 0 Then
            World.Player1.X = 0
        End If

        'Wand Rechts
        If World.Player1.X >= 770 Then
            World.Player1.X = World.Player1.X - 10
        End If

        'Wand Oben
        If World.Player1.Y <= -1 Then
            World.Player1.Y = World.Player1.Y + 10
        End If

        'Wand Unten
        If World.Player1.Y >= 470 Then
            World.Player1.Y = World.Player1.Y - 10
        End If


        'Wand Links
        If World.Player2.Left <= 0 Then
            World.Player2.X = 0
        End If

        'Wand Rechts
        If World.Player2.X >= 770 Then
            World.Player2.X = World.Player2.X - 10
        End If

        'Wand Oben
        If World.Player2.Y <= -1 Then
            World.Player2.Y = World.Player2.Y + 10
        End If

        'Wand Unten
        If World.Player2.Y >= 470 Then
            World.Player2.Y = World.Player2.Y - 10
        End If






    End Sub

    Public RaumP1 As String = 1
    Public RaumP2 As String = 1
    Public RaumP3 As String = 1
    Public RaumP4 As String = 1
    Public RaumP5 As String = 1
    Public RaumP6 As String = 1

    Private Sub WeltenManager_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WeltenManager.Tick



        If World.Player = "1" Then
            ' If World.Player1.IntersectsWith(World.Tuer1Bakery) Then
            'World.Tuer1Bakery.Location = New Point("1232", "344245")
            'World.Tuer2Mittelalter.Location = New Point("12", "228")

            'Weitere Türen jetzt platzieren

            RaumP1 = 2



            World.Invalidate()
        End If


        If World.Player = "2" Then


            RaumP2 = 2

            World.Invalidate()
        End If







    End Sub

    Private Sub WaitToStart_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WaitToStart.Tick

        If Label7.Text = "2" Then
            WaitToStart2.Start()

        Else
            Bewegen.Stop()
        End If

    End Sub
    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label7.Text = "0" Then
            Timer1.Stop()
            World.Player1.Height = 0
            World.Player1.Width = 0

            World.Player2.Height = 0
            World.Player2.Width = 0

            World.Player3.Height = 0
            World.Player3.Width = 0

            World.Invalidate()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Label7.Text = "1" Then
            Timer2.Stop()
            World.Player1.Height = 70
            World.Player1.Width = 50

            World.Player2.Height = 0
            World.Player2.Width = 0

            World.Player3.Height = 0
            World.Player3.Width = 0


            World.Invalidate()
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Label7.Text = "2" Then
            Timer3.Stop()
            World.Player1.Height = 70
            World.Player1.Width = 50

            World.Player2.Height = 70
            World.Player2.Width = 50

            World.Player3.Height = 0
            World.Player3.Width = 0


            World.Invalidate()
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If Label7.Text = "3" Then
            Timer4.Stop()
            World.Player1.Height = 70
            World.Player1.Width = 50

            World.Player2.Height = 70
            World.Player2.Width = 50

            World.Player3.Height = 70
            World.Player3.Width = 50


            World.Invalidate()
        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick


        If Label7.Text = "4" Then
            Timer5.Stop()
            World.Player1.Height = 70
            World.Player1.Width = 50

            World.Player2.Height = 70
            World.Player2.Width = 50

            World.Player3.Height = 70
            World.Player3.Width = 50

            World.Invalidate()
        End If
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        If Label7.Text = "5" Then
            Timer6.Stop()
            World.Player1.Height = 70
            World.Player1.Width = 50

            World.Player2.Height = 70
            World.Player2.Width = 50

            World.Player3.Height = 70
            World.Player3.Width = 50


            World.Invalidate()
        End If
    End Sub

    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick

        If Label7.Text = "6" Then
            Timer7.Stop()
            World.Player1.Height = 70
            World.Player1.Width = 50

            World.Player2.Height = 70
            World.Player2.Width = 50

            World.Player3.Height = 70
            World.Player3.Width = 50


            World.Invalidate()
        End If
    End Sub



    Dim Player1Raum As String = "Aktiv"
    Dim Player2Raum As String = "Aktiv"
    Dim Player3Raum As String = "Aktiv"

    Dim Player1Raum2 As String = "Aktiv"
    Dim Player2Raum2 As String = "Aktiv"
    Dim Player3Raum2 As String = "Aktiv"


    Dim Player1Raum3 As String = "Aktiv"
    Dim Player2Raum3 As String = "Aktiv"
    Dim Player3Raum3 As String = "Aktiv"


    Dim Player1Raum4 As String = "Aktiv"
    Dim Player2Raum4 As String = "Aktiv"
    Dim Player3Raum4 As String = "Aktiv"

    Dim Player1Raum6 As String = "Aktiv"
    Dim Player2Raum6 As String = "Aktiv"
    Dim Player3Raum6 As String = "Aktiv"


    Dim Player1Raum7 As String = "Aktiv"
    Dim Player2Raum7 As String = "Aktiv"
    Dim Player3Raum7 As String = "Aktiv"


    Dim Player1Raum8 As String = "Aktiv"
    Dim Player2Raum8 As String = "Aktiv"
    Dim Player3Raum8 As String = "Aktiv"

    Private Sub Raumerkennung2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Raumerkennung2.Tick
        If RaumP1 = "2" Then
            If TextBox1.Text.Contains("Player2 Raum2") Then
                If Player1Raum = "Aktiv" Then
                    Player1Raum = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player3 Raum2") Then
                If Player3Raum = "Aktiv" Then
                    Player3Raum = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If



        End If


        ''''''''''



        If RaumP2 = "2" Then
            If TextBox1.Text.Contains("Player1 Raum2") Then
                If Player1Raum = "Aktiv" Then
                    Player1Raum = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player3 Raum2") Then
                If Player3Raum = "Aktiv" Then
                    Player3Raum = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If



        End If


        ''''''

        If RaumP3 = "2" Then
            If TextBox1.Text.Contains("Player1 Raum2") Then
                If Player1Raum = "Aktiv" Then
                    Player1Raum = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum2") Then
                If Player2Raum = "Aktiv" Then
                    Player2Raum = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If



        End If


        '''''


        If RaumP4 = "2" Then
            If TextBox1.Text.Contains("Player1 Raum2") Then
                If Player1Raum = "Aktiv" Then
                    Player1Raum = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum2") Then
                If Player2Raum = "Aktiv" Then
                    Player2Raum = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If


            If TextBox1.Text.Contains("Player3 Raum2") Then
                If Player3Raum = "Aktiv" Then
                    Player3Raum = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If


        End If


        ''''''



        If RaumP5 = "2" Then
            If TextBox1.Text.Contains("Player1 Raum2") Then
                If Player1Raum = "Aktiv" Then
                    Player1Raum = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum2") Then
                If Player2Raum = "Aktiv" Then
                    Player2Raum = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If




            If TextBox1.Text.Contains("Player3 Raum2") Then
                If Player3Raum = "Aktiv" Then
                    Player3Raum = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If

        End If

        ''''



        If RaumP6 = "2" Then
            If TextBox1.Text.Contains("Player1 Raum2") Then
                If Player1Raum = "Aktiv" Then
                    Player1Raum = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum2") Then
                If Player2Raum = "Aktiv" Then
                    Player2Raum = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player3 Raum2") Then
                If Player3Raum = "Aktiv" Then
                    Player3Raum = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If

        End If



        '''''''''''''' RAUM2



        If RaumP1 = "3" Then
            If TextBox1.Text.Contains("Player2 Raum3") Then
                If Player1Raum2 = "Aktiv" Then
                    Player1Raum2 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum2 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player3 Raum3") Then
                If Player3Raum2 = "Aktiv" Then
                    Player3Raum2 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum2 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If





        End If


        ''''''''''



        If RaumP2 = "3" Then
            If TextBox1.Text.Contains("Player1 Raum3") Then
                If Player1Raum2 = "Aktiv" Then
                    Player1Raum2 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum2 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player3 Raum3") Then
                If Player3Raum2 = "Aktiv" Then
                    Player3Raum2 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum2 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If




        End If


        ''''''

        If RaumP3 = "3" Then
            If TextBox1.Text.Contains("Player1 Raum3") Then
                If Player1Raum2 = "Aktiv" Then
                    Player1Raum2 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum2 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum3") Then
                If Player2Raum2 = "Aktiv" Then
                    Player2Raum2 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum2 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If



        End If


        '''''


        If RaumP4 = "3" Then
            If TextBox1.Text.Contains("Player1 Raum3") Then
                If Player1Raum2 = "Aktiv" Then
                    Player1Raum2 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum2 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum3") Then
                If Player2Raum2 = "Aktiv" Then
                    Player2Raum2 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum2 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If


            If TextBox1.Text.Contains("Player3 Raum3") Then
                If Player3Raum2 = "Aktiv" Then
                    Player3Raum2 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum2 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If

        End If


        ''''''



        If RaumP5 = "3" Then
            If TextBox1.Text.Contains("Player1 Raum3") Then
                If Player1Raum2 = "Aktiv" Then
                    Player1Raum2 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum2 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum3") Then
                If Player2Raum2 = "Aktiv" Then
                    Player2Raum2 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum2 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player3 Raum3") Then
                If Player3Raum2 = "Aktiv" Then
                    Player3Raum2 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum2 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If


        End If

        ''''



        If RaumP6 = "3" Then
            If TextBox1.Text.Contains("Player1 Raum3") Then
                If Player1Raum2 = "Aktiv" Then
                    Player1Raum2 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum2 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum3") Then
                If Player2Raum2 = "Aktiv" Then
                    Player2Raum2 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum2 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If




            If TextBox1.Text.Contains("Player3 Raum3") Then
                If Player3Raum2 = "Aktiv" Then
                    Player3Raum2 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum2 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If

        End If




        '''''RAUM 4
        If RaumP1 = "4" Then
            If TextBox1.Text.Contains("Player2 Raum4") Then
                If Player1Raum3 = "Aktiv" Then
                    Player1Raum3 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum3 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player3 Raum4") Then
                If Player3Raum3 = "Aktiv" Then
                    Player3Raum3 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum3 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If



        End If


        ''''''''''



        If RaumP2 = "4" Then
            If TextBox1.Text.Contains("Player1 Raum4") Then
                If Player1Raum3 = "Aktiv" Then
                    Player1Raum3 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum3 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player3 Raum4") Then
                If Player3Raum3 = "Aktiv" Then
                    Player3Raum3 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum3 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If



        End If


        ''''''

        If RaumP3 = "4" Then
            If TextBox1.Text.Contains("Player1 Raum4") Then
                If Player1Raum3 = "Aktiv" Then
                    Player1Raum3 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum3 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum4") Then
                If Player2Raum3 = "Aktiv" Then
                    Player2Raum3 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum3 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If


        End If


        '''''


        If RaumP4 = "4" Then
            If TextBox1.Text.Contains("Player1 Raum4") Then
                If Player1Raum3 = "Aktiv" Then
                    Player1Raum3 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum3 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum4") Then
                If Player2Raum3 = "Aktiv" Then
                    Player2Raum3 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum3 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If


            If TextBox1.Text.Contains("Player3 Raum4") Then
                If Player3Raum3 = "Aktiv" Then
                    Player3Raum3 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum3 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If

        End If


        ''''''



        If RaumP5 = "4" Then
            If TextBox1.Text.Contains("Player1 Raum4") Then
                If Player1Raum3 = "Aktiv" Then
                    Player1Raum3 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum3 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum4") Then
                If Player2Raum3 = "Aktiv" Then
                    Player2Raum3 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum3 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player3 Raum4") Then
                If Player3Raum3 = "Aktiv" Then
                    Player3Raum3 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum3 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If


        End If

        ''''



        If RaumP6 = "4" Then
            If TextBox1.Text.Contains("Player1 Raum4") Then
                If Player1Raum3 = "Aktiv" Then
                    Player1Raum3 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum3 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum4") Then
                If Player2Raum3 = "Aktiv" Then
                    Player2Raum3 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum3 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If




            If TextBox1.Text.Contains("Player3 Raum4") Then
                If Player3Raum3 = "Aktiv" Then
                    Player3Raum3 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum3 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If

        End If






        '''''RAUM 5
        If RaumP1 = "5" Then
            If TextBox1.Text.Contains("Player2 Raum5") Then
                If Player1Raum4 = "Aktiv" Then
                    Player1Raum4 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum4 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player3 Raum5") Then
                If Player3Raum4 = "Aktiv" Then
                    Player3Raum4 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum4 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If




        End If


        ''''''''''



        If RaumP2 = "5" Then
            If TextBox1.Text.Contains("Player1 Raum5") Then
                If Player1Raum4 = "Aktiv" Then
                    Player1Raum4 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum4 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player3 Raum5") Then
                If Player3Raum4 = "Aktiv" Then
                    Player3Raum4 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum4 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If




        End If


        ''''''

        If RaumP3 = "5" Then
            If TextBox1.Text.Contains("Player1 Raum5") Then
                If Player1Raum4 = "Aktiv" Then
                    Player1Raum4 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum4 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum5") Then
                If Player2Raum4 = "Aktiv" Then
                    Player2Raum4 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum4 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If


        End If


        '''''


        If RaumP4 = "5" Then
            If TextBox1.Text.Contains("Player1 Raum5") Then
                If Player1Raum4 = "Aktiv" Then
                    Player1Raum4 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum4 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum5") Then
                If Player2Raum4 = "Aktiv" Then
                    Player2Raum4 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum4 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If


            If TextBox1.Text.Contains("Player3 Raum5") Then
                If Player3Raum4 = "Aktiv" Then
                    Player3Raum4 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum4 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If


        End If


        ''''''



        If RaumP5 = "5" Then
            If TextBox1.Text.Contains("Player1 Raum5") Then
                If Player1Raum4 = "Aktiv" Then
                    Player1Raum4 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum4 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum5") Then
                If Player2Raum4 = "Aktiv" Then
                    Player2Raum4 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum4 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If




            If TextBox1.Text.Contains("Player3 Raum5") Then
                If Player3Raum4 = "Aktiv" Then
                    Player3Raum4 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum4 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If


        End If

        ''''



        If RaumP6 = "5" Then
            If TextBox1.Text.Contains("Player1 Raum5") Then
                If Player1Raum4 = "Aktiv" Then
                    Player1Raum4 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum4 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum5") Then
                If Player2Raum4 = "Aktiv" Then
                    Player2Raum4 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum4 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If



        End If

        If TextBox1.Text.Contains("Player3 Raum5") Then
            If Player3Raum4 = "Aktiv" Then
                Player3Raum4 = "Inaktiv"
                World.Player3.Height = 50
                World.Player3.Width = 70
                World.Invalidate()
            End If
        Else
            If Player3Raum4 = "Aktiv" Then
                World.Player3.Height = 0
                World.Player3.Width = 0
                World.Invalidate()
            End If
        End If






        '''''RAUM 6
        If RaumP1 = "6" Then
            If TextBox1.Text.Contains("Player2 Raum6") Then
                If Player1Raum6 = "Aktiv" Then
                    Player1Raum6 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum6 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player3 Raum6") Then
                If Player3Raum6 = "Aktiv" Then
                    Player3Raum6 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum6 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If




        End If


        ''''''''''



        If RaumP2 = "6" Then
            If TextBox1.Text.Contains("Player1 Raum6") Then
                If Player1Raum6 = "Aktiv" Then
                    Player1Raum6 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum6 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player3 Raum6") Then
                If Player3Raum6 = "Aktiv" Then
                    Player3Raum6 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum6 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If




        End If


        ''''''

        If RaumP3 = "6" Then
            If TextBox1.Text.Contains("Player1 Raum6") Then
                If Player1Raum6 = "Aktiv" Then
                    Player1Raum6 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum6 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum6") Then
                If Player2Raum6 = "Aktiv" Then
                    Player2Raum6 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum6 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If




        End If


        '''''


        If RaumP4 = "6" Then
            If TextBox1.Text.Contains("Player1 Raum6") Then
                If Player1Raum6 = "Aktiv" Then
                    Player1Raum6 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum6 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum6") Then
                If Player2Raum6 = "Aktiv" Then
                    Player2Raum6 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum6 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If


            If TextBox1.Text.Contains("Player3 Raum6") Then
                If Player3Raum6 = "Aktiv" Then
                    Player3Raum6 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum6 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If


        End If


        ''''''



        If RaumP5 = "6" Then
            If TextBox1.Text.Contains("Player1 Raum6") Then
                If Player1Raum6 = "Aktiv" Then
                    Player1Raum6 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum6 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum6") Then
                If Player2Raum6 = "Aktiv" Then
                    Player2Raum6 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum6 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player3 Raum6") Then
                If Player3Raum6 = "Aktiv" Then
                    Player3Raum6 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum6 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If

        End If

        ''''



        If RaumP6 = "6" Then
            If TextBox1.Text.Contains("Player1 Raum6") Then
                If Player1Raum6 = "Aktiv" Then
                    Player1Raum6 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum6 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum6") Then
                If Player2Raum6 = "Aktiv" Then
                    Player2Raum6 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum6 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If




            If TextBox1.Text.Contains("Player3 Raum6") Then
                If Player3Raum6 = "Aktiv" Then
                    Player3Raum6 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum6 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If


        End If












        '''''RAUM 7
        If RaumP1 = "7" Then
            If TextBox1.Text.Contains("Player2 Raum7") Then
                If Player1Raum7 = "Aktiv" Then
                    Player1Raum7 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum7 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player3 Raum7") Then
                If Player3Raum7 = "Aktiv" Then
                    Player3Raum7 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum7 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If



        End If


        ''''''''''



        If RaumP2 = "7" Then
            If TextBox1.Text.Contains("Player1 Raum7") Then
                If Player1Raum7 = "Aktiv" Then
                    Player1Raum7 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum7 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player3 Raum7") Then
                If Player3Raum7 = "Aktiv" Then
                    Player3Raum7 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum7 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If




        End If


        ''''''

        If RaumP3 = "7" Then
            If TextBox1.Text.Contains("Player1 Raum7") Then
                If Player1Raum7 = "Aktiv" Then
                    Player1Raum7 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum7 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum7") Then
                If Player2Raum7 = "Aktiv" Then
                    Player2Raum7 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum7 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If



        End If


        '''''


        If RaumP4 = "7" Then
            If TextBox1.Text.Contains("Player1 Raum7") Then
                If Player1Raum7 = "Aktiv" Then
                    Player1Raum7 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum7 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum7") Then
                If Player2Raum7 = "Aktiv" Then
                    Player2Raum7 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum7 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If


            If TextBox1.Text.Contains("Player3 Raum7") Then
                If Player3Raum7 = "Aktiv" Then
                    Player3Raum7 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum7 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If

        End If


        ''''''



        If RaumP5 = "7" Then
            If TextBox1.Text.Contains("Player1 Raum7") Then
                If Player1Raum7 = "Aktiv" Then
                    Player1Raum7 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum7 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum7") Then
                If Player2Raum7 = "Aktiv" Then
                    Player2Raum7 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum7 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player3 Raum7") Then
                If Player3Raum7 = "Aktiv" Then
                    Player3Raum7 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum7 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If


        End If

        ''''



        If RaumP6 = "7" Then
            If TextBox1.Text.Contains("Player1 Raum7") Then
                If Player1Raum7 = "Aktiv" Then
                    Player1Raum7 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum7 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum7") Then
                If Player2Raum7 = "Aktiv" Then
                    Player2Raum7 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum7 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player3 Raum7") Then
                If Player3Raum7 = "Aktiv" Then
                    Player3Raum7 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum7 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If


        End If









        '''''RAUM 7
        If RaumP1 = "7" Then
            If TextBox1.Text.Contains("Player2 Raum8") Then
                If Player1Raum8 = "Aktiv" Then
                    Player1Raum8 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum8 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player3 Raum8") Then
                If Player3Raum8 = "Aktiv" Then
                    Player3Raum8 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum8 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If





        End If


        ''''''''''



        If RaumP2 = "7" Then
            If TextBox1.Text.Contains("Player1 Raum8") Then
                If Player1Raum8 = "Aktiv" Then
                    Player1Raum8 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum8 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player3 Raum8") Then
                If Player3Raum8 = "Aktiv" Then
                    Player3Raum8 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum8 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If




        End If


        ''''''

        If RaumP3 = "7" Then
            If TextBox1.Text.Contains("Player1 Raum8") Then
                If Player1Raum8 = "Aktiv" Then
                    Player1Raum8 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum8 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum8") Then
                If Player2Raum8 = "Aktiv" Then
                    Player2Raum8 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum8 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If




            '''''


            If RaumP4 = "7" Then
                If TextBox1.Text.Contains("Player1 Raum8") Then
                    If Player1Raum8 = "Aktiv" Then
                        Player1Raum8 = "Inaktiv"
                        World.Player1.Height = 50
                        World.Player1.Width = 70
                        World.Invalidate()
                    End If

                Else
                    If Player1Raum8 = "Aktiv" Then
                        World.Player1.Height = 0
                        World.Player1.Width = 0
                        World.Invalidate()
                    End If
                End If



                If TextBox1.Text.Contains("Player2 Raum8") Then
                    If Player2Raum8 = "Aktiv" Then
                        Player2Raum8 = "Inaktiv"
                        World.Player2.Height = 50
                        World.Player2.Width = 70
                        World.Invalidate()
                    End If
                Else
                    If Player2Raum8 = "Aktiv" Then
                        World.Player2.Height = 0
                        World.Player2.Width = 0
                        World.Invalidate()
                    End If
                End If


                If TextBox1.Text.Contains("Player3 Raum8") Then
                    If Player3Raum8 = "Aktiv" Then
                        Player3Raum8 = "Inaktiv"
                        World.Player3.Height = 50
                        World.Player3.Width = 70
                        World.Invalidate()
                    End If
                Else
                    If Player3Raum8 = "Aktiv" Then
                        World.Player3.Height = 0
                        World.Player3.Width = 0
                        World.Invalidate()
                    End If
                End If


            End If


            ''''''



            If RaumP5 = "7" Then
                If TextBox1.Text.Contains("Player1 Raum8") Then
                    If Player1Raum8 = "Aktiv" Then
                        Player1Raum8 = "Inaktiv"
                        World.Player1.Height = 50
                        World.Player1.Width = 70
                        World.Invalidate()
                    End If

                Else
                    If Player1Raum8 = "Aktiv" Then
                        World.Player1.Height = 0
                        World.Player1.Width = 0
                        World.Invalidate()
                    End If
                End If



                If TextBox1.Text.Contains("Player2 Raum8") Then
                    If Player2Raum8 = "Aktiv" Then
                        Player2Raum8 = "Inaktiv"
                        World.Player2.Height = 50
                        World.Player2.Width = 70
                        World.Invalidate()
                    End If
                Else
                    If Player2Raum8 = "Aktiv" Then
                        World.Player2.Height = 0
                        World.Player2.Width = 0
                        World.Invalidate()
                    End If
                End If



            End If

            If TextBox1.Text.Contains("Player3 Raum8") Then
                If Player3Raum8 = "Aktiv" Then
                    Player3Raum8 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum8 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If

        End If



        ''''



        If RaumP6 = "7" Then
            If TextBox1.Text.Contains("Player1 Raum8") Then
                If Player1Raum8 = "Aktiv" Then
                    Player1Raum8 = "Inaktiv"
                    World.Player1.Height = 50
                    World.Player1.Width = 70
                    World.Invalidate()
                End If

            Else
                If Player1Raum8 = "Aktiv" Then
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player2 Raum8") Then
                If Player2Raum8 = "Aktiv" Then
                    Player2Raum8 = "Inaktiv"
                    World.Player2.Height = 50
                    World.Player2.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player2Raum8 = "Aktiv" Then
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If
            End If



            If TextBox1.Text.Contains("Player3 Raum8") Then
                If Player3Raum8 = "Aktiv" Then
                    Player3Raum8 = "Inaktiv"
                    World.Player3.Height = 50
                    World.Player3.Width = 70
                    World.Invalidate()
                End If
            Else
                If Player3Raum8 = "Aktiv" Then
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If
            End If


        End If


    End Sub


    Private Sub SpawnRaum_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpawnRaum.Tick
        If RaumP1 = "1" Then
            SpawnRaum.Stop()
            World.BackgroundImage = System.Drawing.Image.FromFile(My.Computer.FileSystem.CurrentDirectory + "\Graphics\City.jpg")
        ElseIf RaumP2 = "1" Then
            SpawnRaum.Stop()
            World.BackgroundImage = System.Drawing.Image.FromFile(My.Computer.FileSystem.CurrentDirectory + "\Graphics\City.jpg")
        ElseIf RaumP3 = "1" Then
            SpawnRaum.Stop()
            World.BackgroundImage = System.Drawing.Image.FromFile(My.Computer.FileSystem.CurrentDirectory + "\Graphics\City.jpg")
        ElseIf RaumP4 = "1" Then
            SpawnRaum.Stop()
            World.BackgroundImage = System.Drawing.Image.FromFile(My.Computer.FileSystem.CurrentDirectory + "\Graphics\City.jpg")
        ElseIf RaumP5 = "1" Then
            SpawnRaum.Stop()
            World.BackgroundImage = System.Drawing.Image.FromFile(My.Computer.FileSystem.CurrentDirectory + "\Graphics\City.jpg")
        ElseIf RaumP6 = "1" Then
            SpawnRaum.Stop()
            World.BackgroundImage = System.Drawing.Image.FromFile(My.Computer.FileSystem.CurrentDirectory + "\Graphics\City.jpg")
        End If
    End Sub
    Private Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal vKey As System.Windows.Forms.Keys) As Short

    Dim UPk As Boolean
    Dim DOWNk As Boolean
    Dim LEFTk As Boolean
    Dim RIGHTk As Boolean

    Private Sub HotkeyTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HotkeyTimer.Tick
        UPk = GetAsyncKeyState(Keys.Up)
        If UPk = True Then
            If World.Player = 1 Then
                Sdk1.SendKoordinates("Player1 Up")
            End If

            If World.Player = 2 Then
                Sdk1.SendKoordinates("Player2 Up")
            End If
            If World.Player = 3 Then
                Sdk1.SendKoordinates("Player3 Up")
            End If



        End If


        DOWNk = GetAsyncKeyState(Keys.Down)
        If DOWNk = True Then
            If World.Player = 1 Then
                Sdk1.SendKoordinates("Player1 Down")
            End If

            If World.Player = 2 Then
                Sdk1.SendKoordinates("Player2 Down")
            End If

            If World.Player = 3 Then
                Sdk1.SendKoordinates("Player3 Down")
            End If



        End If


        RIGHTk = GetAsyncKeyState(Keys.Right)
        If RIGHTk = True Then

            If World.Player = 1 Then
                Sdk1.SendKoordinates("Player1 Right")
            End If

            If World.Player = 2 Then
                Sdk1.SendKoordinates("Player2 Right")
            End If

            If World.Player = 3 Then
                Sdk1.SendKoordinates("Player3 Right")
            End If

        End If

        LEFTk = GetAsyncKeyState(Keys.Left)
        If LEFTk = True Then
            If World.Player = 1 Then
                Sdk1.SendKoordinates("Player1 Left")
            End If

            If World.Player = 2 Then
                Sdk1.SendKoordinates("Player2 Left")
            End If

            If World.Player = 3 Then
                Sdk1.SendKoordinates("Player3 Left")
            End If

        End If


    End Sub

    Private Sub Timer8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Focusser.Tick
        CommandWindow.Focus()
        CommandWindow.TopMost = True
    End Sub

#Region "MenuBackground"
    Private Sub Menu1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu1.Tick
        If Sdk1.Player = "1" Then
            World.Menu.Image = My.Resources.Join1
            Menu1.Stop()
            Menu2.Start()


        ElseIf Sdk1.Player = "0" Then
            World.Menu.Image = My.Resources.Join1
            Menu1.Stop()
            Menu2.Start()
        End If


    End Sub

    Private Sub Menu2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu2.Tick
        If Sdk1.Player = "2" Then
            World.Menu.Image = My.Resources.Join2
            Menu2.Stop()

        End If
    End Sub


#End Region

    Private Sub WaitToStart2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WaitToStart2.Tick
        Bewegen.Start()
        World.Panel1.Hide()
        FadeOUT.Start()
        WaitToStart2.Stop()
    End Sub

    Private Sub FadeOUT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FadeOUT.Tick
        Dim volume As String
        volume = AudioPlayer.settings.volume - 2
        AudioPlayer.settings.volume = volume
        If AudioPlayer.settings.volume = "0" Then
            FadeOUT.Stop()
            AudioPlayer.settings.volume = 5

            If PlayMusic = True Then

                AudioPlayer.URL = My.Computer.FileSystem.CurrentDirectory + "\Sounds\Dark Underground Rap Beat - No Peace.mp3"
            End If
            FadeOUT.Stop()
        End If
    End Sub



    Private Sub Raumerkennung_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Raumerkennung.Tick

        If World.Player = 1 Then
            If TextBox1.Text.Contains("Player2 Raum2") Then
                If RaumP1 = 2 Then
                    World.Player2.Height = 70
                    World.Player2.Width = 50
                    World.Invalidate()
                Else
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If

            End If

            If TextBox1.Text.Contains("Player3 Raum2") Then
                If RaumP1 = 2 Then
                    World.Player3.Height = 70
                    World.Player3.Width = 50
                    World.Invalidate()
                Else
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If

            End If



            '''''

            If World.Player = 2 Then
                If TextBox1.Text.Contains("Player1 Raum2") Then
                    If RaumP2 = 2 Then
                        World.Player1.Height = 70
                        World.Player1.Width = 50
                        World.Invalidate()
                    Else
                        World.Player1.Height = 0
                        World.Player1.Width = 0
                        World.Invalidate()
                    End If
                End If
                If TextBox1.Text.Contains("Player3 Raum2") Then
                    If RaumP2 = 2 Then
                        World.Player3.Height = 70
                        World.Player3.Width = 50
                        World.Invalidate()
                    Else
                        World.Player3.Height = 0
                        World.Player3.Width = 0
                        World.Invalidate()
                    End If

                End If



            End If




            '''''''

            If World.Player = 3 Then
                If TextBox1.Text.Contains("Player1 Raum2") Then
                    If RaumP3 = 2 Then
                        World.Player1.Height = 70
                        World.Player1.Width = 50
                        World.Invalidate()
                    Else
                        World.Player1.Height = 0
                        World.Player1.Width = 0
                        World.Invalidate()
                    End If
                End If
                If TextBox1.Text.Contains("Player2 Raum2") Then
                    If RaumP3 = 2 Then
                        World.Player2.Height = 70
                        World.Player2.Width = 50
                        World.Invalidate()
                    Else
                        World.Player2.Height = 0
                        World.Player2.Width = 0
                        World.Invalidate()
                    End If

                End If


            End If

            ''''
            If World.Player = 4 Then
                If TextBox1.Text.Contains("Player1 Raum2") Then
                    If RaumP4 = 2 Then
                        World.Player1.Height = 70
                        World.Player1.Width = 50
                        World.Invalidate()
                    Else
                        World.Player1.Height = 0
                        World.Player1.Width = 0
                        World.Invalidate()
                    End If
                End If
                If TextBox1.Text.Contains("Player2 Raum2") Then
                    If RaumP4 = 2 Then
                        World.Player2.Height = 70
                        World.Player2.Width = 50
                        World.Invalidate()
                    Else
                        World.Player2.Height = 0
                        World.Player2.Width = 0
                        World.Invalidate()
                    End If

                End If

                If TextBox1.Text.Contains("Player3 Raum2") Then
                    If RaumP4 = 2 Then
                        World.Player3.Height = 70
                        World.Player3.Width = 50
                        World.Invalidate()
                    Else
                        World.Player3.Height = 0
                        World.Player3.Width = 0
                        World.Invalidate()
                    End If

                End If


            End If
            ''''
            If World.Player = 5 Then
                If TextBox1.Text.Contains("Player1 Raum2") Then
                    If RaumP5 = 2 Then
                        World.Player1.Height = 70
                        World.Player1.Width = 50
                        World.Invalidate()
                    Else
                        World.Player1.Height = 0
                        World.Player1.Width = 0
                        World.Invalidate()
                    End If
                End If
                If TextBox1.Text.Contains("Player2 Raum2") Then
                    If RaumP5 = 2 Then
                        World.Player2.Height = 70
                        World.Player2.Width = 50
                        World.Invalidate()
                    Else
                        World.Player2.Height = 0
                        World.Player2.Width = 0
                        World.Invalidate()
                    End If

                End If

                If TextBox1.Text.Contains("Player3 Raum2") Then
                    If RaumP5 = 2 Then
                        World.Player3.Height = 70
                        World.Player3.Width = 50
                        World.Invalidate()
                    Else
                        World.Player3.Height = 0
                        World.Player3.Width = 0
                        World.Invalidate()
                    End If

                End If

            End If

            ''''
            If World.Player = 6 Then
                If TextBox1.Text.Contains("Player1 Raum2") Then
                    If RaumP6 = 2 Then
                        World.Player1.Height = 70
                        World.Player1.Width = 50
                        World.Invalidate()
                    Else
                        World.Player1.Height = 0
                        World.Player1.Width = 0
                        World.Invalidate()
                    End If
                End If
                If TextBox1.Text.Contains("Player2 Raum2") Then
                    If RaumP6 = 2 Then
                        World.Player2.Height = 70
                        World.Player2.Width = 50
                        World.Invalidate()
                    Else
                        World.Player2.Height = 0
                        World.Player2.Width = 0
                        World.Invalidate()
                    End If

                End If

                If TextBox1.Text.Contains("Player3 Raum2") Then
                    If RaumP6 = 2 Then
                        World.Player3.Height = 70
                        World.Player3.Width = 50
                        World.Invalidate()
                    Else
                        World.Player3.Height = 0
                        World.Player3.Width = 0
                        World.Invalidate()
                    End If

                End If




                '''''''











                If World.Player = 1 Then
                    If TextBox1.Text.Contains("Player2 Raum3") Then
                        If RaumP1 = 3 Then
                            World.Player2.Height = 70
                            World.Player2.Width = 50
                            World.Invalidate()
                        Else
                            World.Player2.Height = 0
                            World.Player2.Width = 0
                            World.Invalidate()
                        End If

                    End If

                    If TextBox1.Text.Contains("Player3 Raum3") Then
                        If RaumP1 = 3 Then
                            World.Player3.Height = 70
                            World.Player3.Width = 50
                            World.Invalidate()
                        Else
                            World.Player3.Height = 0
                            World.Player3.Width = 0
                            World.Invalidate()
                        End If

                    End If

                End If

                '''''

                If World.Player = 2 Then
                    If TextBox1.Text.Contains("Player1 Raum3") Then
                        If RaumP2 = 3 Then
                            World.Player1.Height = 70
                            World.Player1.Width = 50
                            World.Invalidate()
                        Else
                            World.Player1.Height = 0
                            World.Player1.Width = 0
                            World.Invalidate()
                        End If
                    End If
                    If TextBox1.Text.Contains("Player3 Raum3") Then
                        If RaumP2 = 3 Then
                            World.Player3.Height = 70
                            World.Player3.Width = 50
                            World.Invalidate()
                        Else
                            World.Player3.Height = 0
                            World.Player3.Width = 0
                            World.Invalidate()
                        End If

                    End If


                End If


                '''''''

                If World.Player = 3 Then
                    If TextBox1.Text.Contains("Player1 Raum3") Then
                        If RaumP3 = 3 Then
                            World.Player1.Height = 70
                            World.Player1.Width = 50
                            World.Invalidate()
                        Else
                            World.Player1.Height = 0
                            World.Player1.Width = 0
                            World.Invalidate()
                        End If
                    End If
                    If TextBox1.Text.Contains("Player2 Raum3") Then
                        If RaumP3 = 3 Then
                            World.Player2.Height = 70
                            World.Player2.Width = 50
                            World.Invalidate()
                        Else
                            World.Player2.Height = 0
                            World.Player2.Width = 0
                            World.Invalidate()
                        End If

                    End If


                End If

                ''''
                If World.Player = 4 Then
                    If TextBox1.Text.Contains("Player1 Raum3") Then
                        If RaumP4 = 3 Then
                            World.Player1.Height = 70
                            World.Player1.Width = 50
                            World.Invalidate()
                        Else
                            World.Player1.Height = 0
                            World.Player1.Width = 0
                            World.Invalidate()
                        End If
                    End If
                    If TextBox1.Text.Contains("Player2 Raum3") Then
                        If RaumP4 = 3 Then
                            World.Player2.Height = 70
                            World.Player2.Width = 50
                            World.Invalidate()
                        Else
                            World.Player2.Height = 0
                            World.Player2.Width = 0
                            World.Invalidate()
                        End If

                    End If

                    If TextBox1.Text.Contains("Player3 Raum3") Then
                        If RaumP4 = 3 Then
                            World.Player3.Height = 70
                            World.Player3.Width = 50
                            World.Invalidate()
                        Else
                            World.Player3.Height = 0
                            World.Player3.Width = 0
                            World.Invalidate()
                        End If

                    End If



                End If
            End If
            ''''
            If World.Player = 5 Then
                If TextBox1.Text.Contains("Player1 Raum3") Then
                    If RaumP5 = 3 Then
                        World.Player1.Height = 70
                        World.Player1.Width = 50
                        World.Invalidate()
                    Else
                        World.Player1.Height = 0
                        World.Player1.Width = 0
                        World.Invalidate()
                    End If
                End If
                If TextBox1.Text.Contains("Player2 Raum3") Then
                    If RaumP5 = 3 Then
                        World.Player2.Height = 70
                        World.Player2.Width = 50
                        World.Invalidate()
                    Else
                        World.Player2.Height = 0
                        World.Player2.Width = 0
                        World.Invalidate()
                    End If

                End If

                If TextBox1.Text.Contains("Player3 Raum3") Then
                    If RaumP5 = 3 Then
                        World.Player3.Height = 70
                        World.Player3.Width = 50
                        World.Invalidate()
                    Else
                        World.Player3.Height = 0
                        World.Player3.Width = 0
                        World.Invalidate()
                    End If

                End If



            End If
        End If
        ''''
        If World.Player = 6 Then
            If TextBox1.Text.Contains("Player1 Raum3") Then
                If RaumP6 = 3 Then
                    World.Player1.Height = 70
                    World.Player1.Width = 50
                    World.Invalidate()
                Else
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If
            If TextBox1.Text.Contains("Player2 Raum3") Then
                If RaumP6 = 3 Then
                    World.Player2.Height = 70
                    World.Player2.Width = 50
                    World.Invalidate()
                Else
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If

            End If

            If TextBox1.Text.Contains("Player3 Raum3") Then
                If RaumP6 = 3 Then
                    World.Player3.Height = 70
                    World.Player3.Width = 50
                    World.Invalidate()
                Else
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If

            End If


        End If












        '''''''

        If World.Player = 1 Then
            If TextBox1.Text.Contains("Player2 Raum4") Then
                If RaumP1 = 4 Then
                    World.Player2.Height = 70
                    World.Player2.Width = 50
                    World.Invalidate()
                Else
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If

            End If

            If TextBox1.Text.Contains("Player3 Raum4") Then
                If RaumP1 = 4 Then
                    World.Player3.Height = 70
                    World.Player3.Width = 50
                    World.Invalidate()
                Else
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If

            End If


        End If

        '''''

        If World.Player = 2 Then
            If TextBox1.Text.Contains("Player1 Raum4") Then
                If RaumP2 = 4 Then
                    World.Player1.Height = 70
                    World.Player1.Width = 50
                    World.Invalidate()
                Else
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If
            If TextBox1.Text.Contains("Player3 Raum4") Then
                If RaumP2 = 4 Then
                    World.Player3.Height = 70
                    World.Player3.Width = 50
                    World.Invalidate()
                Else
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If

            End If

        End If


        '''''''

        If World.Player = 3 Then
            If TextBox1.Text.Contains("Player1 Raum4") Then
                If RaumP3 = 4 Then
                    World.Player1.Height = 70
                    World.Player1.Width = 50
                    World.Invalidate()
                Else
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If
            If TextBox1.Text.Contains("Player2 Raum4") Then
                If RaumP3 = 4 Then
                    World.Player2.Height = 70
                    World.Player2.Width = 50
                    World.Invalidate()
                Else
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If

            End If


        End If

        ''''
        If World.Player = 4 Then
            If TextBox1.Text.Contains("Player1 Raum4") Then
                If RaumP4 = 4 Then
                    World.Player1.Height = 70
                    World.Player1.Width = 50
                    World.Invalidate()
                Else
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If
            If TextBox1.Text.Contains("Player2 Raum4") Then
                If RaumP4 = 4 Then
                    World.Player2.Height = 70
                    World.Player2.Width = 50
                    World.Invalidate()
                Else
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If

            End If

            If TextBox1.Text.Contains("Player3 Raum4") Then
                If RaumP4 = 4 Then
                    World.Player3.Height = 70
                    World.Player3.Width = 50
                    World.Invalidate()
                Else
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If

            End If


        End If
        ''''
        If World.Player = 5 Then
            If TextBox1.Text.Contains("Player1 Raum4") Then
                If RaumP5 = 4 Then
                    World.Player1.Height = 70
                    World.Player1.Width = 50
                    World.Invalidate()
                Else
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If
            If TextBox1.Text.Contains("Player2 Raum4") Then
                If RaumP5 = 4 Then
                    World.Player2.Height = 70
                    World.Player2.Width = 50
                    World.Invalidate()
                Else
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If

            End If

            If TextBox1.Text.Contains("Player3 Raum4") Then
                If RaumP5 = 4 Then
                    World.Player3.Height = 70
                    World.Player3.Width = 50
                    World.Invalidate()
                Else
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If

            End If



        End If
        ''''
        If World.Player = 6 Then
            If TextBox1.Text.Contains("Player1 Raum4") Then
                If RaumP6 = 4 Then
                    World.Player1.Height = 70
                    World.Player1.Width = 50
                    World.Invalidate()
                Else
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If
            If TextBox1.Text.Contains("Player2 Raum4") Then
                If RaumP6 = 4 Then
                    World.Player2.Height = 70
                    World.Player2.Width = 50
                    World.Invalidate()
                Else
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If

            End If

            If TextBox1.Text.Contains("Player3 Raum4") Then
                If RaumP6 = 4 Then
                    World.Player3.Height = 70
                    World.Player3.Width = 50
                    World.Invalidate()
                Else
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If

            End If



        End If


















        '''''''

        If World.Player = 1 Then
            If TextBox1.Text.Contains("Player2 Raum5") Then
                If RaumP1 = 5 Then
                    World.Player2.Height = 70
                    World.Player2.Width = 50
                    World.Invalidate()
                Else
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If

            End If

            If TextBox1.Text.Contains("Player3 Raum5") Then
                If RaumP1 = 5 Then
                    World.Player3.Height = 70
                    World.Player3.Width = 50
                    World.Invalidate()
                Else
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If

            End If


        End If

        '''''

        If World.Player = 2 Then
            If TextBox1.Text.Contains("Player1 Raum5") Then
                If RaumP2 = 5 Then
                    World.Player1.Height = 70
                    World.Player1.Width = 50
                    World.Invalidate()
                Else
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If
            If TextBox1.Text.Contains("Player3 Raum5") Then
                If RaumP2 = 5 Then
                    World.Player3.Height = 70
                    World.Player3.Width = 50
                    World.Invalidate()
                Else
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If

            End If


        End If


        '''''''

        If World.Player = 3 Then
            If TextBox1.Text.Contains("Player1 Raum5") Then
                If RaumP3 = 5 Then
                    World.Player1.Height = 70
                    World.Player1.Width = 50
                    World.Invalidate()
                Else
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If
            If TextBox1.Text.Contains("Player2 Raum5") Then
                If RaumP3 = 5 Then
                    World.Player2.Height = 70
                    World.Player2.Width = 50
                    World.Invalidate()
                Else
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If

            End If

        End If

        ''''
        If World.Player = 4 Then
            If TextBox1.Text.Contains("Player1 Raum5") Then
                If RaumP4 = 5 Then
                    World.Player1.Height = 70
                    World.Player1.Width = 50
                    World.Invalidate()
                Else
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If
            If TextBox1.Text.Contains("Player2 Raum5") Then
                If RaumP4 = 5 Then
                    World.Player2.Height = 70
                    World.Player2.Width = 50
                    World.Invalidate()
                Else
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If

            End If

            If TextBox1.Text.Contains("Player3 Raum5") Then
                If RaumP4 = 5 Then
                    World.Player3.Height = 70
                    World.Player3.Width = 50
                    World.Invalidate()
                Else
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If

            End If



        End If
        ''''
        If World.Player = 5 Then
            If TextBox1.Text.Contains("Player1 Raum5") Then
                If RaumP5 = 5 Then
                    World.Player1.Height = 70
                    World.Player1.Width = 50
                    World.Invalidate()
                Else
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If
            If TextBox1.Text.Contains("Player2 Raum5") Then
                If RaumP5 = 5 Then
                    World.Player2.Height = 70
                    World.Player2.Width = 50
                    World.Invalidate()
                Else
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If

            End If

            If TextBox1.Text.Contains("Player3 Raum5") Then
                If RaumP5 = 5 Then
                    World.Player3.Height = 70
                    World.Player3.Width = 50
                    World.Invalidate()
                Else
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If

            End If



        End If
        ''''
        If World.Player = 6 Then
            If TextBox1.Text.Contains("Player1 Raum5") Then
                If RaumP6 = 5 Then
                    World.Player1.Height = 70
                    World.Player1.Width = 50
                    World.Invalidate()
                Else
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If
            If TextBox1.Text.Contains("Player2 Raum5") Then
                If RaumP6 = 5 Then
                    World.Player2.Height = 70
                    World.Player2.Width = 50
                    World.Invalidate()
                Else
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If

            End If

            If TextBox1.Text.Contains("Player3 Raum5") Then
                If RaumP6 = 5 Then
                    World.Player3.Height = 70
                    World.Player3.Width = 50
                    World.Invalidate()
                Else
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If

            End If



        End If

























        '''''''

        If World.Player = 1 Then
            If TextBox1.Text.Contains("Player2 Raum6") Then
                If RaumP1 = 6 Then
                    World.Player2.Height = 70
                    World.Player2.Width = 50
                    World.Invalidate()
                Else
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If

            End If

            If TextBox1.Text.Contains("Player3 Raum6") Then
                If RaumP1 = 6 Then
                    World.Player3.Height = 70
                    World.Player3.Width = 50
                    World.Invalidate()
                Else
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If

            End If


        End If

        '''''

        If World.Player = 2 Then
            If TextBox1.Text.Contains("Player1 Raum6") Then
                If RaumP2 = 6 Then
                    World.Player1.Height = 70
                    World.Player1.Width = 50
                    World.Invalidate()
                Else
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If
            If TextBox1.Text.Contains("Player3 Raum6") Then
                If RaumP2 = 6 Then
                    World.Player3.Height = 70
                    World.Player3.Width = 50
                    World.Invalidate()
                Else
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If

            End If




            '''''''

            If World.Player = 3 Then
                If TextBox1.Text.Contains("Player1 Raum6") Then
                    If RaumP3 = 6 Then
                        World.Player1.Height = 70
                        World.Player1.Width = 50
                        World.Invalidate()
                    Else
                        World.Player1.Height = 0
                        World.Player1.Width = 0
                        World.Invalidate()
                    End If
                End If
                If TextBox1.Text.Contains("Player2 Raum6") Then
                    If RaumP3 = 6 Then
                        World.Player2.Height = 70
                        World.Player2.Width = 50
                        World.Invalidate()
                    Else
                        World.Player2.Height = 0
                        World.Player2.Width = 0
                        World.Invalidate()
                    End If

                End If


            End If

            ''''
            If World.Player = 4 Then
                If TextBox1.Text.Contains("Player1 Raum6") Then
                    If RaumP4 = 6 Then
                        World.Player1.Height = 70
                        World.Player1.Width = 50
                        World.Invalidate()
                    Else
                        World.Player1.Height = 0
                        World.Player1.Width = 0
                        World.Invalidate()
                    End If
                End If
                If TextBox1.Text.Contains("Player2 Raum6") Then
                    If RaumP4 = 6 Then
                        World.Player2.Height = 70
                        World.Player2.Width = 50
                        World.Invalidate()
                    Else
                        World.Player2.Height = 0
                        World.Player2.Width = 0
                        World.Invalidate()
                    End If

                End If

                If TextBox1.Text.Contains("Player3 Raum6") Then
                    If RaumP4 = 6 Then
                        World.Player3.Height = 70
                        World.Player3.Width = 50
                        World.Invalidate()
                    Else
                        World.Player3.Height = 0
                        World.Player3.Width = 0
                        World.Invalidate()
                    End If

                End If



            End If
            ''''
            If World.Player = 5 Then
                If TextBox1.Text.Contains("Player1 Raum6") Then
                    If RaumP5 = 6 Then
                        World.Player1.Height = 70
                        World.Player1.Width = 50
                        World.Invalidate()
                    Else
                        World.Player1.Height = 0
                        World.Player1.Width = 0
                        World.Invalidate()
                    End If
                End If
                If TextBox1.Text.Contains("Player2 Raum6") Then
                    If RaumP5 = 6 Then
                        World.Player2.Height = 70
                        World.Player2.Width = 50
                        World.Invalidate()
                    Else
                        World.Player2.Height = 0
                        World.Player2.Width = 0
                        World.Invalidate()
                    End If

                End If

                If TextBox1.Text.Contains("Player3 Raum6") Then
                    If RaumP5 = 6 Then
                        World.Player3.Height = 70
                        World.Player3.Width = 50
                        World.Invalidate()
                    Else
                        World.Player3.Height = 0
                        World.Player3.Width = 0
                        World.Invalidate()
                    End If

                End If


            End If
            ''''
            If World.Player = 6 Then
                If TextBox1.Text.Contains("Player1 Raum6") Then
                    If RaumP6 = 6 Then
                        World.Player1.Height = 70
                        World.Player1.Width = 50
                        World.Invalidate()
                    Else
                        World.Player1.Height = 0
                        World.Player1.Width = 0
                        World.Invalidate()
                    End If
                End If
                If TextBox1.Text.Contains("Player2 Raum6") Then
                    If RaumP6 = 6 Then
                        World.Player2.Height = 70
                        World.Player2.Width = 50
                        World.Invalidate()
                    Else
                        World.Player2.Height = 0
                        World.Player2.Width = 0
                        World.Invalidate()
                    End If

                End If

                If TextBox1.Text.Contains("Player3 Raum6") Then
                    If RaumP6 = 6 Then
                        World.Player3.Height = 70
                        World.Player3.Width = 50
                        World.Invalidate()
                    Else
                        World.Player3.Height = 0
                        World.Player3.Width = 0
                        World.Invalidate()
                    End If

                End If



            End If

























            '''''''

            If World.Player = 1 Then
                If TextBox1.Text.Contains("Player2 Raum7") Then
                    If RaumP1 = 7 Then
                        World.Player2.Height = 70
                        World.Player2.Width = 50
                        World.Invalidate()
                    Else
                        World.Player2.Height = 0
                        World.Player2.Width = 0
                        World.Invalidate()
                    End If

                End If

                If TextBox1.Text.Contains("Player3 Raum7") Then
                    If RaumP1 = 7 Then
                        World.Player3.Height = 70
                        World.Player3.Width = 50
                        World.Invalidate()
                    Else
                        World.Player3.Height = 0
                        World.Player3.Width = 0
                        World.Invalidate()
                    End If

                End If

            End If

            '''''

            If World.Player = 2 Then
                If TextBox1.Text.Contains("Player1 Raum7") Then
                    If RaumP2 = 7 Then
                        World.Player1.Height = 70
                        World.Player1.Width = 50
                        World.Invalidate()
                    Else
                        World.Player1.Height = 0
                        World.Player1.Width = 0
                        World.Invalidate()
                    End If
                End If
                If TextBox1.Text.Contains("Player3 Raum7") Then
                    If RaumP2 = 7 Then
                        World.Player3.Height = 70
                        World.Player3.Width = 50
                        World.Invalidate()
                    Else
                        World.Player3.Height = 0
                        World.Player3.Width = 0
                        World.Invalidate()
                    End If

                End If


            End If


            '''''''

            If World.Player = 3 Then
                If TextBox1.Text.Contains("Player1 Raum7") Then
                    If RaumP3 = 7 Then
                        World.Player1.Height = 70
                        World.Player1.Width = 50
                        World.Invalidate()
                    Else
                        World.Player1.Height = 0
                        World.Player1.Width = 0
                        World.Invalidate()
                    End If
                End If
                If TextBox1.Text.Contains("Player2 Raum7") Then
                    If RaumP3 = 7 Then
                        World.Player2.Height = 70
                        World.Player2.Width = 50
                        World.Invalidate()
                    Else
                        World.Player2.Height = 0
                        World.Player2.Width = 0
                        World.Invalidate()
                    End If

                End If

            End If


        End If

        ''''
        If World.Player = 4 Then
            If TextBox1.Text.Contains("Player1 Raum7") Then
                If RaumP4 = 7 Then
                    World.Player1.Height = 70
                    World.Player1.Width = 50
                    World.Invalidate()
                Else
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If
            If TextBox1.Text.Contains("Player2 Raum7") Then
                If RaumP4 = 7 Then
                    World.Player2.Height = 70
                    World.Player2.Width = 50
                    World.Invalidate()
                Else
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If

            End If

            If TextBox1.Text.Contains("Player3 Raum7") Then
                If RaumP4 = 7 Then
                    World.Player3.Height = 70
                    World.Player3.Width = 50
                    World.Invalidate()
                Else
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If

            End If



        End If
        ''''
        If World.Player = 5 Then
            If TextBox1.Text.Contains("Player1 Raum7") Then
                If RaumP5 = 7 Then
                    World.Player1.Height = 70
                    World.Player1.Width = 50
                    World.Invalidate()
                Else
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If
            If TextBox1.Text.Contains("Player2 Raum7") Then
                If RaumP5 = 7 Then
                    World.Player2.Height = 70
                    World.Player2.Width = 50
                    World.Invalidate()
                Else
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If

            End If

            If TextBox1.Text.Contains("Player3 Raum7") Then
                If RaumP5 = 7 Then
                    World.Player3.Height = 70
                    World.Player3.Width = 50
                    World.Invalidate()
                Else
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If

            End If



        End If
        ''''
        If World.Player = 7 Then
            If TextBox1.Text.Contains("Player1 Raum7") Then
                If RaumP6 = 7 Then
                    World.Player1.Height = 70
                    World.Player1.Width = 50
                    World.Invalidate()
                Else
                    World.Player1.Height = 0
                    World.Player1.Width = 0
                    World.Invalidate()
                End If
            End If
            If TextBox1.Text.Contains("Player2 Raum7") Then
                If RaumP6 = 7 Then
                    World.Player2.Height = 70
                    World.Player2.Width = 50
                    World.Invalidate()
                Else
                    World.Player2.Height = 0
                    World.Player2.Width = 0
                    World.Invalidate()
                End If

            End If

            If TextBox1.Text.Contains("Player3 Raum7") Then
                If RaumP6 = 7 Then
                    World.Player3.Height = 70
                    World.Player3.Width = 50
                    World.Invalidate()
                Else
                    World.Player3.Height = 0
                    World.Player3.Width = 0
                    World.Invalidate()
                End If

            End If



        End If

    End Sub


    Private Sub Raumsender_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Raumsender.Tick
        If World.Player = "1" Then
            Sdk1.SendKoordinates("Player1 Raum" + RaumP1)
        End If
        If World.Player = "2" Then
            Sdk1.SendKoordinates("Player2 Raum" + RaumP2)
        End If
        If World.Player = "3" Then
            Sdk1.SendKoordinates("Player3 Raum" + RaumP3)
        End If
        If World.Player = "4" Then
            Sdk1.SendKoordinates("Player4 Raum" + RaumP4)
        End If
        If World.Player = "5" Then
            Sdk1.SendKoordinates("Player5 Raum" + RaumP5)
        End If
        If World.Player = "6" Then
            Sdk1.SendKoordinates("Player6 Raum" + RaumP6)
        End If
    End Sub

    Private Sub Befehle_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Befehle.Tick
        If TextBox1.Text.Contains("Drake Kick") Then
            If World.Player = "1" Then
                Befehle.Stop()
                MsgBox("Kicked")
                Me.Close()
            End If
        End If
        If TextBox1.Text.Contains("Yasur Kick") Then
            If World.Player = "2" Then
                Befehle.Stop()
                MsgBox("Kicked")
                Me.Close()
            End If
        End If
    End Sub

End Class