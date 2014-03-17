<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServerWindow
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServerWindow))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Infos = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Bewegen = New System.Windows.Forms.Timer(Me.components)
        Me.SetPlayer = New System.Windows.Forms.Timer(Me.components)
        Me.Blink1 = New System.Windows.Forms.Timer(Me.components)
        Me.Blink2 = New System.Windows.Forms.Timer(Me.components)
        Me.Collision = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.WeltenManager = New System.Windows.Forms.Timer(Me.components)
        Me.WaitToStart = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.Raumsender = New System.Windows.Forms.Timer(Me.components)
        Me.Raumerkennung2 = New System.Windows.Forms.Timer(Me.components)
        Me.SpawnRaum = New System.Windows.Forms.Timer(Me.components)
        Me.HotkeyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Focusser = New System.Windows.Forms.Timer(Me.components)
        Me.Sdk1 = New TGSEngine.SDK()
        Me.Menu1 = New System.Windows.Forms.Timer(Me.components)
        Me.Menu2 = New System.Windows.Forms.Timer(Me.components)
        Me.WaitToStart2 = New System.Windows.Forms.Timer(Me.components)
        Me.FadeOUT = New System.Windows.Forms.Timer(Me.components)
        Me.AudioPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Raumerkennung = New System.Windows.Forms.Timer(Me.components)
        Me.Befehle = New System.Windows.Forms.Timer(Me.components)
        CType(Me.AudioPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nachrichten:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(26, 201)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(378, 142)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(26, 24)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(378, 142)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Befehle:"
        '
        'Infos
        '
        Me.Infos.Enabled = True
        Me.Infos.Interval = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 346)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Player:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 359)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Min. Player:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(91, 359)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "0"
        '
        'Bewegen
        '
        Me.Bewegen.Enabled = True
        Me.Bewegen.Interval = 1
        '
        'SetPlayer
        '
        Me.SetPlayer.Enabled = True
        Me.SetPlayer.Interval = 3500
        '
        'Blink1
        '
        Me.Blink1.Enabled = True
        Me.Blink1.Interval = 700
        '
        'Blink2
        '
        Me.Blink2.Enabled = True
        Me.Blink2.Interval = 1300
        '
        'Collision
        '
        Me.Collision.Enabled = True
        Me.Collision.Interval = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(202, 346)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(157, 346)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Player:"
        '
        'WeltenManager
        '
        Me.WeltenManager.Enabled = True
        Me.WeltenManager.Interval = 1
        '
        'WaitToStart
        '
        Me.WaitToStart.Enabled = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        '
        'Timer5
        '
        Me.Timer5.Enabled = True
        '
        'Timer6
        '
        Me.Timer6.Enabled = True
        '
        'Timer7
        '
        Me.Timer7.Enabled = True
        '
        'Raumsender
        '
        Me.Raumsender.Enabled = True
        Me.Raumsender.Interval = 1000
        '
        'Raumerkennung2
        '
        Me.Raumerkennung2.Enabled = True
        '
        'SpawnRaum
        '
        Me.SpawnRaum.Enabled = True
        Me.SpawnRaum.Interval = 1000
        '
        'HotkeyTimer
        '
        Me.HotkeyTimer.Enabled = True
        Me.HotkeyTimer.Interval = 1
        '
        'Focusser
        '
        Me.Focusser.Enabled = True
        Me.Focusser.Interval = 1
        '
        'Sdk1
        '
        Me.Sdk1.Location = New System.Drawing.Point(410, 66)
        Me.Sdk1.MaximumSize = New System.Drawing.Size(197, 105)
        Me.Sdk1.Name = "Sdk1"
        Me.Sdk1.Size = New System.Drawing.Size(197, 105)
        Me.Sdk1.TabIndex = 11
        '
        'Menu1
        '
        Me.Menu1.Enabled = True
        Me.Menu1.Interval = 500
        '
        'Menu2
        '
        Me.Menu2.Enabled = True
        Me.Menu2.Interval = 500
        '
        'WaitToStart2
        '
        Me.WaitToStart2.Interval = 8000
        '
        'FadeOUT
        '
        '
        'AudioPlayer
        '
        Me.AudioPlayer.Enabled = True
        Me.AudioPlayer.Location = New System.Drawing.Point(410, 177)
        Me.AudioPlayer.Name = "AudioPlayer"
        Me.AudioPlayer.OcxState = CType(resources.GetObject("AudioPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AudioPlayer.Size = New System.Drawing.Size(197, 136)
        Me.AudioPlayer.TabIndex = 12
        '
        'Raumerkennung
        '
        '
        'Befehle
        '
        Me.Befehle.Enabled = True
        '
        'ServerWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 379)
        Me.Controls.Add(Me.AudioPlayer)
        Me.Controls.Add(Me.Sdk1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ServerWindow"
        Me.Opacity = 0.0R
        Me.Text = "ServerWindow"
        CType(Me.AudioPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Infos As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Bewegen As System.Windows.Forms.Timer
    Friend WithEvents SetPlayer As System.Windows.Forms.Timer
    Friend WithEvents Blink1 As System.Windows.Forms.Timer
    Friend WithEvents Blink2 As System.Windows.Forms.Timer
    Friend WithEvents Collision As System.Windows.Forms.Timer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents WeltenManager As System.Windows.Forms.Timer
    Friend WithEvents WaitToStart As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents Timer6 As System.Windows.Forms.Timer
    Friend WithEvents Timer7 As System.Windows.Forms.Timer
    Friend WithEvents Raumsender As System.Windows.Forms.Timer
    Friend WithEvents Raumerkennung2 As System.Windows.Forms.Timer
    Friend WithEvents SpawnRaum As System.Windows.Forms.Timer
    Friend WithEvents HotkeyTimer As System.Windows.Forms.Timer
    Friend WithEvents Focusser As System.Windows.Forms.Timer
    Friend WithEvents Sdk1 As TGSEngine.SDK
    Friend WithEvents Menu1 As System.Windows.Forms.Timer
    Friend WithEvents Menu2 As System.Windows.Forms.Timer
    Friend WithEvents WaitToStart2 As System.Windows.Forms.Timer
    Friend WithEvents FadeOUT As System.Windows.Forms.Timer
    Friend WithEvents AudioPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Raumerkennung As System.Windows.Forms.Timer
    Friend WithEvents Befehle As System.Windows.Forms.Timer
End Class
