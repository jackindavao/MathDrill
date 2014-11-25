Imports System.Threading
Public Class Form1
    Dim pg As ProblemGen
    Dim cblevel() As CheckBox
    Dim WithEvents tbGame As TimerBar
    Dim g As Game
    Dim lb As LeaderBoard
    Dim gamecolor As Color
    Private Sub tbGame_GameOverEvent() Handles tbGame.GameOverEvent
        g.gameOver()
        Dim lname As String = tbName.Text.Trim
        If Not lname = "" AndAlso lb.scoreQualifies(g.score) Then
            lb.addLeader(New Leader(lname, g.score))
            rtbLeaderBoard.Text = lb.getLeaderDisplay
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        tbGame = New TimerBar(pGameTimer)
        cblevel = {cbL1, cbL2, cbL3, cbL4, cbL5, cbL6, cbL7, cbL8, cbL9, cbL10, cbL11, cbL12, cbL13, cbL14, cbL15, cbL16}
        For i As Integer = 1 To 16
            ddLimitto.Items.Add(i)
        Next
        ddLimitto.SelectedItem = ddLimitto.Items(11)
        cblevel(9).Checked = True  'default
        lMsg1.Text = "Press start to play"
        gamecolor = Me.BackColor
        lb = New LeaderBoard()
        rtbLeaderBoard.Text = lb.getLeaderDisplay
    End Sub
    Private Sub bStart_Click(sender As System.Object, e As System.EventArgs) Handles bStart.Click
        pg = New ProblemGen()
        pg.op = {cbAdd.Checked, cbSubtract.Checked, cbMultiply.Checked, cbDivide.Checked}
        pg.xs = checkedIdxs()
        Dim limitto As Integer
        limitto = ddLimitto.SelectedIndex + 1
        If limitto <> 0 AndAlso cbLimitTo.Checked Then pg.max2 = limitto
        g = New Game(pg, tbQuestion, tbAnswer, tbScore, lCount, lMsg1, lMsg2, Me)
        tbGame.start()
        g.startGame()
    End Sub
    Function checkedIdxs() As ArrayList
        Dim xs As New ArrayList
        For i As Integer = 0 To 15
            If cblevel(i).Checked = True Then xs.Add(i + 1)
        Next
        Return xs
    End Function
    Private Sub tbAnswer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbAnswer.KeyDown
        If e.KeyCode = Keys.Enter Then
            g.checkAnswer()
            e.Handled = True
        End If
    End Sub

    Private Sub bClearLB_Click(sender As System.Object, e As System.EventArgs) Handles bClearLB.Click
        lb.clearSetting()
        lb = New LeaderBoard()
        rtbLeaderBoard.Text = lb.getLeaderDisplay
    End Sub
    Dim flashcolors() As Color = {Color.Red, Color.Green, Color.Yellow, Color.Purple, Color.Magenta}
    Dim flashcolor As Color

    Public Sub flash(msg As String, c_ As Color, nflash As Integer, msperflash As Integer)
        lmsg3.Text = msg
        lmsg3.Update()
        flashcolor = c_
        If flashcolor = Nothing Then flashcolor = flashcolors(ProblemGen.r.Next(0, 5))
        flashTimer.Start()
    End Sub

    Private Sub flashTimer_Tick(sender As Object, e As EventArgs) Handles flashTimer.Tick
        Static flashcount As Integer
        Dim tempc As Color = Me.BackColor
        If flashcount > 7 Then
            flashTimer.Stop()
            Me.BackColor = gamecolor
            lmsg3.Text = ""
            Me.Update()
            flashcount = 0
            Return
        ElseIf flashcount Mod 2 = 1 Then
            Me.BackColor = flashcolor
        Else
            Me.BackColor = gamecolor
        End If
        Me.Update()
        flashcount += 1
    End Sub
    Private Sub bAll_Click(sender As Object, e As EventArgs) Handles bAll.Click
        For i As Integer = 0 To highestLevelChecked() - 2
            cblevel(i).Checked = True
        Next
    End Sub
    Private Sub bClear_Click(sender As Object, e As EventArgs) Handles bClear.Click
        For Each cb As CheckBox In cblevel
            cb.Checked = False
        Next
    End Sub
    Function highestLevelChecked() As Integer
        For i As Integer = cblevel.Count To 1 Step -1
            If cblevel(i - 1).Checked Then Return i
        Next
        cblevel(9).Checked = True  'default if none checked
        Return 10
    End Function
    'ensure at least one box checked
    Private Sub cbL1_CheckedChanged(sender As Object, e As EventArgs) Handles cbL1.CheckedChanged, cbL2.CheckedChanged, cbL3.CheckedChanged, _
        cbL4.CheckedChanged, cbL5.CheckedChanged, cbL6.CheckedChanged, cbL7.CheckedChanged, cbL8.CheckedChanged, cbL9.CheckedChanged, _
        cbL10.CheckedChanged, cbL11.CheckedChanged, cbL12.CheckedChanged, cbL13.CheckedChanged, cbL14.CheckedChanged, cbL15.CheckedChanged, _
        cbL16.CheckedChanged
        For i As Integer = cblevel.Count To 1 Step -1
            If cblevel(i - 1).Checked Then Return
        Next
        Dim cb As CheckBox = sender
        cb.Checked = True
    End Sub
    Private Sub cbAdd_CheckedChanged(sender As Object, e As EventArgs) Handles cbAdd.CheckedChanged, cbSubtract.CheckedChanged, _
        cbMultiply.CheckedChanged, cbDivide.CheckedChanged
        If cbAdd.Checked = True Then Return
        If cbSubtract.Checked = True Then Return
        If cbMultiply.Checked = True Then Return
        If cbDivide.Checked = True Then Return
        Dim cb As CheckBox = sender
        cb.Checked = True
    End Sub


End Class
