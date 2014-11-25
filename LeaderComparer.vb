Imports System.Collections
Public Class LeaderComparer
    Implements IComparer
    Public Function Compare(ByVal ldr1 As Object, ByVal ldr2 As Object) As Integer Implements System.Collections.IComparer.Compare
        Return ldr1.score > ldr2.score
    End Function
End Class