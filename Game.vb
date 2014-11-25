Public Class Game
    Const bonuslevel As Integer = 12
    Dim pg As ProblemGen
    Dim p As Problem
    Public score As Integer = 0
    Dim tbq, tba, tbs As TextBox
    Dim lrw, lmsg1, lmsg2 As Label
    Dim mainform As Form1
    Dim gameonQ As Boolean = False
    Dim nright As Integer = 0
    Dim nwrong As Integer = 0
    Dim nrightinarow As Integer = 0
    Sub New(pg_ As ProblemGen, tbq_ As TextBox, tba_ As TextBox, tbs_ As TextBox, lrw_ As Label, lmsg1_ As Label, lmsg2_ As Label, mainform_ As Form1)
        pg = pg_
        tbq = tbq_
        tba = tba_
        tbs = tbs_
        lrw = lrw_
        lmsg1 = lmsg1_
        lmsg2 = lmsg2_
        mainform = mainform_
    End Sub
    Public Sub startGame()
        gameonQ = True
        nright = 0
        nwrong = 0
        nrightinarow = 0
        lrw.Text = "0 / 0"
        lmsg1.Text = ""
        lmsg2.Text = ""
        showProblem()
    End Sub
    Public Sub gameOver()
        gameonQ = False
        lmsg1.Text = "Press start to play"
    End Sub
    Public Sub showProblem()
        If Not gameonQ Then Return
        p = pg.getProblem
        tbq.Text = p.q & " = "
        tbs.Text = score
        tba.Text = ""
        tba.Focus()
    End Sub
    Public Sub checkAnswer()
        If Not gameonQ Then Return
        lmsg1.Text = ""
        lmsg2.Text = ""
        Dim ansgiven As Single
        Single.TryParse(tba.Text, ansgiven)
        If ansgiven <> p.aval Then
            nwrong += 1
            nrightinarow = 0
            lmsg1.Text = tbq.Text & p.a
            lmsg2.Text = "Enter correct answer to continue"
            score -= p.score
            tba.Text = ""
            tba.Focus()
            Return
        End If
        score += p.score
        nright += 1
        nrightinarow += 1
        score += checkbonus(nrightinarow, p.score)
        lmsg1.Text = ""
        lmsg2.Text = ""
        tbs.Text = score
        lrw.Text = nright & " / " & (nright + nwrong)
        showProblem()
    End Sub
    Function checkbonus(nb As Integer, sc As Integer) As Integer
        Dim rcomp As Integer = ProblemGen.r.Next(bonuslevel \ 2, bonuslevel)
        If rcomp > nb Then
            Return 0
        Else
            Dim bonus As Integer = sc * ProblemGen.r.Next(2, 6)
            mainform.flash("+" & bonus & "!", Nothing, 3, 600)
            nrightinarow = 0
            Return bonus
        End If
    End Function

End Class
