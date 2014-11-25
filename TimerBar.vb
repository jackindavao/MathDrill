Public Class TimerBar
    Dim WithEvents pbp As Panel
    Public duration As Single = 60.0   'seconds, default
    Dim WithEvents t As Timer
    Public Event GameOverEvent()
    Dim t0 As DateTime
    Dim val As Single
    Dim forebrush As New SolidBrush(Color.Red)
    Dim backbrush As New SolidBrush(Color.Yellow)
    Dim pauseQ As Boolean = False
    Dim pausetime As DateTime
    Sub New(pbp_ As Panel)
        pbp = pbp_
        val = duration
        t = New Timer
        AddHandler t.Tick, AddressOf t_Tick
        t.Interval = 100
    End Sub
    Public Sub start()
        val = duration
        pbp.Invalidate()
        t0 = Now
        pauseQ = False
        t.Start()
    End Sub
    Public Sub pause()
        pauseQ = True
    End Sub
    Public Sub unpause()
        pauseQ = False
    End Sub
    Private Sub t_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If pauseQ Then Return
        Dim ttemp As Single = val - 0.1   't.interval is 100 ms
        If ttemp <= 0 Then
            val = 0
            t.Stop()
            RaiseEvent GameOverEvent()
        Else
            val = ttemp
        End If
        pbp.Invalidate()
    End Sub

    Private Sub pbp_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles pbp.Paint
        Dim g As Graphics = e.Graphics
        Dim vpt As Single = 1 + (val / duration) * (pbp.Width - 2)
        g.FillRectangle(forebrush, New Rectangle(1, 1, vpt, pbp.Height - 2))
        g.FillRectangle(backbrush, New Rectangle(vpt, 1, pbp.Width - vpt - 1, pbp.Height - 2))
    End Sub
End Class
