Public Class Problem
    Public q As String
    Public a As String
    Public x1 As Single
    Public x2 As Single
    Public op As Integer
    Public aval As Single
    Public score As Integer
    Sub New()

    End Sub
    Sub New(q_ As String, a_ As String, x1_ As Single, x2_ As Single, op_ As Integer, aval_ As Single, score_ As Integer)
        q = q_
        a = a_
        x1 = x1_
        x2 = x2_
        op = op_
        aval = aval_
        score = score_
    End Sub
    Function getScore(ansgiven As Integer)
        If aval = ansgiven Then
            Return score
        Else
            Return 0
        End If
    End Function
End Class
