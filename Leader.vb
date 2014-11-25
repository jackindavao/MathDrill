Imports System.Text.RegularExpressions
Public Class Leader
    Public name As String
    Public score As Integer
    Dim namerx As New Regex("\W", RegexOptions.Compiled)
    Sub New(name_ As String, score_ As Integer)
        name = namerx.Replace(name_, "")
        If name.Length > 15 Then name = name.Substring(0, 15)
        score = score_
    End Sub
    Sub New(lstr As String)
        Dim xldr() As String = lstr.Split(":")
        name = xldr(0)
        Integer.TryParse(xldr(1), score)
    End Sub
    Function toRecordString() As String
        Return name & ":" & score
    End Function
    Function toDisplayString() As String
        Return "" & score & "   " & name
    End Function
End Class
