Public Class ProblemGen
    Public op() As Boolean = {True, False, False, False}    'by position, on if set, off if not:  0: add 1: subtract 2: multiply 3: divide
    Public max2 As Integer = 16
    Public min2 As Integer = 0
    Dim lastx1 As Integer = 0
    Dim lastx2 As Integer = 0
    Dim lastopx As Integer = 0
    Public xs As ArrayList
    Public Shared r As Random
    Sub New()
        r = New Random
    End Sub
    Function getProblem() As Problem
        Dim x1 As Integer
        Dim x2 As Integer
        Dim opx As Integer
        Dim nopschecked As Integer = 0
        For Each opq As Boolean In op
            If opq Then nopschecked += 1
        Next
        Do   'avoid showing same problem twice in a row
            x1 = getX1()
            x2 = r.Next(min2, max2 + 1)
            opx = r.Next(0, 4)
            While op(opx) = False
                opx = r.Next(0, 4)
            End While
        Loop While x1 = lastx1 AndAlso x2 = lastx2 AndAlso opx = lastopx
        lastx1 = x1
        lastx2 = x2
        lastopx = opx
        Dim score As Single = (3 + (4 * x1 / 16) + nopschecked) * (1.0 + opx / 8.0)
        '  Sub New(q_ As String, a_ As String, x1_ As Single, x2_ As Single, op_ As Integer, aval_ As Single, score_ As Integer)
        Select Case opx
            Case 0
                If r.Next(0, 10) > 4 Then swap(x1, x2) '50-50 chance to swap
                Return New Problem(x1 & " + " & x2, "" & x1 + x2, x1, x2, opx, x1 + x2, score)

            Case 1
                If x1 < x2 Then swap(x1, x2)
                Return New Problem(x1 & " - " & x2, "" & x1 - x2, x1, x2, opx, x1 - x2, score)
            Case 2
                If r.Next(0, 10) > 4 Then swap(x1, x2) '50-50 chance to swap
                Return New Problem(x1 & " X " & x2, "" & x1 * x2, x1, x2, opx, x1 * x2, score)
            Case 3
                While CInt(x1) = 0
                    x1 = getX1()
                End While
                Return New Problem(x1 * x2 & " ÷ " & x1, "" & x2, x1 * x2, x1, opx, x2, score)
            Case Else
                Return Nothing
        End Select
    End Function
    Function getX1() As Integer
        Dim idx As Integer = r.Next(0, xs.Count)
        Return xs(idx)
    End Function

    Shared Sub swap(ByRef x1, ByRef x2)  'must be byref
        Dim temp As Integer = x1
        x1 = x2
        x2 = temp
    End Sub
 

End Class