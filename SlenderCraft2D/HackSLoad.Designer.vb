<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HackSLoad
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
        Dim MainColorScheme1 As MetroSuite.MetroProgressbar.MainColorScheme = New MetroSuite.MetroProgressbar.MainColorScheme()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HackSLoad))
        Me.MetroProgressbar1 = New MetroSuite.MetroProgressbar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'MetroProgressbar1
        '
        MainColorScheme1.BackColorHover = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        MainColorScheme1.BackColorNormal = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        MainColorScheme1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        MainColorScheme1.ValueColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MetroProgressbar1.ColorScheme = MainColorScheme1
        Me.MetroProgressbar1.DrawBorders = False
        Me.MetroProgressbar1.Location = New System.Drawing.Point(0, 115)
        Me.MetroProgressbar1.Name = "MetroProgressbar1"
        Me.MetroProgressbar1.Size = New System.Drawing.Size(210, 12)
        Me.MetroProgressbar1.Style = MetroSuite.Design.Style.Dark
        Me.MetroProgressbar1.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 500
        '
        'HackSLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(210, 127)
        Me.Controls.Add(Me.MetroProgressbar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "HackSLoad"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroProgressbar1 As MetroSuite.MetroProgressbar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
