Imports System.Text
Public Class LeaderBoard
    Const LDRSIZE As Integer = 15
    Dim ldrs As ArrayList
    Public currlow As Integer = 1000000
    Sub New()
        Dim ldrstr As String = GetSetting("FastMath", "Settings", "Leaders", "No Leaders Yet:0")
        ldrs = New ArrayList
        Dim sldrs() As String = ldrstr.Split(vbTab)
        For Each sldr In sldrs
            Dim ldr As New Leader(sldr)
            If ldr.score < currlow Then currlow = ldr.score
            ldrs.Add(ldr)
        Next
    End Sub
    Sub clearSetting()
        DeleteSetting("FastMath", "Settings", "Leaders")
    End Sub
    Sub addLeader(ldr As Leader)
        If ldr.score < currlow Then currlow = ldr.score
        ldrs.Add(ldr)
        ldrs.Sort(New LeaderComparer)
        If ldrs.Count > LDRSIZE Then
            ldrs = ldrs.GetRange(0, LDRSIZE)
        End If
        Dim sb As New StringBuilder
        For Each xldr As Leader In ldrs
            sb.Append(xldr.toRecordString & vbTab)
        Next
        SaveSetting("FastMath", "Settings", "Leaders", sb.ToString.Trim)
    End Sub
    Function getLeaderDisplay() As String
        Dim sb As New StringBuilder
        sb.AppendLine("Score      Name")
        For Each ldr As Leader In ldrs
            If ldrs.Count > 1 AndAlso ldr.score = 0 Then Continue For
            sb.AppendLine(ldr.toDisplayString)
        Next
        Return sb.ToString
    End Function
    Function scoreQualifies(score As Integer) As Boolean
        If ldrs.Count < LDRSIZE Then Return True
        If score > currlow Then Return True
        Return False
    End Function
End Class
