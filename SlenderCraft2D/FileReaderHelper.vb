Imports System.IO

Public Class FileReaderHelper

#Region "ZeilenLeser"
    Public Zeileninhalt As String
    Public Function ReadLine(ByVal File As String, ByVal Zeile As String)

        Try
            Dim Textfile As TextReader = New StreamReader(File)
            Dim cnt As Integer = 0
            Do Until cnt = Zeile
                Textfile.ReadLine()
                cnt += 1
            Loop
            Zeileninhalt = Textfile.ReadLine()
            Textfile.Close()
        Catch
        End Try
    End Function


    'USAGE
    '  Dim Reader As New FileReaderHelper
    '  Reader.ReadLine("Datei.txt", "1")
    '  MsgBox(Reader.Zeileninhalt)
#End Region

End Class
