<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pGameTimer = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bClear = New System.Windows.Forms.Button()
        Me.bAll = New System.Windows.Forms.Button()
        Me.ddLimitto = New System.Windows.Forms.ComboBox()
        Me.cbL16 = New System.Windows.Forms.CheckBox()
        Me.cbL15 = New System.Windows.Forms.CheckBox()
        Me.cbL14 = New System.Windows.Forms.CheckBox()
        Me.cbL13 = New System.Windows.Forms.CheckBox()
        Me.cbL12 = New System.Windows.Forms.CheckBox()
        Me.cbL11 = New System.Windows.Forms.CheckBox()
        Me.cbL10 = New System.Windows.Forms.CheckBox()
        Me.cbL9 = New System.Windows.Forms.CheckBox()
        Me.cbL8 = New System.Windows.Forms.CheckBox()
        Me.cbL7 = New System.Windows.Forms.CheckBox()
        Me.cbL6 = New System.Windows.Forms.CheckBox()
        Me.cbL5 = New System.Windows.Forms.CheckBox()
        Me.cbL4 = New System.Windows.Forms.CheckBox()
        Me.cbL3 = New System.Windows.Forms.CheckBox()
        Me.cbL2 = New System.Windows.Forms.CheckBox()
        Me.cbL1 = New System.Windows.Forms.CheckBox()
        Me.cbLimitTo = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbDivide = New System.Windows.Forms.CheckBox()
        Me.cbMultiply = New System.Windows.Forms.CheckBox()
        Me.cbSubtract = New System.Windows.Forms.CheckBox()
        Me.cbAdd = New System.Windows.Forms.CheckBox()
        Me.tbQuestion = New System.Windows.Forms.TextBox()
        Me.tbAnswer = New System.Windows.Forms.TextBox()
        Me.bStart = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbScore = New System.Windows.Forms.TextBox()
        Me.lCount = New System.Windows.Forms.Label()
        Me.lMsg1 = New System.Windows.Forms.Label()
        Me.lMsg2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rtbLeaderBoard = New System.Windows.Forms.RichTextBox()
        Me.bClearLB = New System.Windows.Forms.Button()
        Me.flashTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lmsg3 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(553, 283)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Answer here"
        '
        'pGameTimer
        '
        Me.pGameTimer.BackColor = System.Drawing.Color.Red
        Me.pGameTimer.Location = New System.Drawing.Point(213, 146)
        Me.pGameTimer.Name = "pGameTimer"
        Me.pGameTimer.Size = New System.Drawing.Size(465, 25)
        Me.pGameTimer.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox1.Controls.Add(Me.bClear)
        Me.GroupBox1.Controls.Add(Me.bAll)
        Me.GroupBox1.Controls.Add(Me.ddLimitto)
        Me.GroupBox1.Controls.Add(Me.cbL16)
        Me.GroupBox1.Controls.Add(Me.cbL15)
        Me.GroupBox1.Controls.Add(Me.cbL14)
        Me.GroupBox1.Controls.Add(Me.cbL13)
        Me.GroupBox1.Controls.Add(Me.cbL12)
        Me.GroupBox1.Controls.Add(Me.cbL11)
        Me.GroupBox1.Controls.Add(Me.cbL10)
        Me.GroupBox1.Controls.Add(Me.cbL9)
        Me.GroupBox1.Controls.Add(Me.cbL8)
        Me.GroupBox1.Controls.Add(Me.cbL7)
        Me.GroupBox1.Controls.Add(Me.cbL6)
        Me.GroupBox1.Controls.Add(Me.cbL5)
        Me.GroupBox1.Controls.Add(Me.cbL4)
        Me.GroupBox1.Controls.Add(Me.cbL3)
        Me.GroupBox1.Controls.Add(Me.cbL2)
        Me.GroupBox1.Controls.Add(Me.cbL1)
        Me.GroupBox1.Controls.Add(Me.cbLimitTo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 171)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 399)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Level"
        '
        'bClear
        '
        Me.bClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bClear.Location = New System.Drawing.Point(121, 326)
        Me.bClear.Name = "bClear"
        Me.bClear.Size = New System.Drawing.Size(49, 23)
        Me.bClear.TabIndex = 37
        Me.bClear.Text = "Clear"
        Me.bClear.UseVisualStyleBackColor = True
        '
        'bAll
        '
        Me.bAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAll.Location = New System.Drawing.Point(76, 327)
        Me.bAll.Name = "bAll"
        Me.bAll.Size = New System.Drawing.Size(39, 22)
        Me.bAll.TabIndex = 36
        Me.bAll.Text = "All"
        Me.bAll.UseVisualStyleBackColor = True
        '
        'ddLimitto
        '
        Me.ddLimitto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddLimitto.FormattingEnabled = True
        Me.ddLimitto.Location = New System.Drawing.Point(99, 359)
        Me.ddLimitto.Name = "ddLimitto"
        Me.ddLimitto.Size = New System.Drawing.Size(50, 24)
        Me.ddLimitto.TabIndex = 35
        '
        'cbL16
        '
        Me.cbL16.AutoSize = True
        Me.cbL16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL16.Location = New System.Drawing.Point(17, 329)
        Me.cbL16.Name = "cbL16"
        Me.cbL16.Size = New System.Drawing.Size(40, 19)
        Me.cbL16.TabIndex = 34
        Me.cbL16.Text = "16"
        Me.cbL16.UseVisualStyleBackColor = True
        '
        'cbL15
        '
        Me.cbL15.AutoSize = True
        Me.cbL15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL15.Location = New System.Drawing.Point(17, 309)
        Me.cbL15.Name = "cbL15"
        Me.cbL15.Size = New System.Drawing.Size(40, 19)
        Me.cbL15.TabIndex = 33
        Me.cbL15.Text = "15"
        Me.cbL15.UseVisualStyleBackColor = True
        '
        'cbL14
        '
        Me.cbL14.AutoSize = True
        Me.cbL14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL14.Location = New System.Drawing.Point(17, 289)
        Me.cbL14.Name = "cbL14"
        Me.cbL14.Size = New System.Drawing.Size(40, 19)
        Me.cbL14.TabIndex = 32
        Me.cbL14.Text = "14"
        Me.cbL14.UseVisualStyleBackColor = True
        '
        'cbL13
        '
        Me.cbL13.AutoSize = True
        Me.cbL13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL13.Location = New System.Drawing.Point(17, 269)
        Me.cbL13.Name = "cbL13"
        Me.cbL13.Size = New System.Drawing.Size(40, 19)
        Me.cbL13.TabIndex = 31
        Me.cbL13.Text = "13"
        Me.cbL13.UseVisualStyleBackColor = True
        '
        'cbL12
        '
        Me.cbL12.AutoSize = True
        Me.cbL12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL12.Location = New System.Drawing.Point(17, 249)
        Me.cbL12.Name = "cbL12"
        Me.cbL12.Size = New System.Drawing.Size(40, 19)
        Me.cbL12.TabIndex = 30
        Me.cbL12.Text = "12"
        Me.cbL12.UseVisualStyleBackColor = True
        '
        'cbL11
        '
        Me.cbL11.AutoSize = True
        Me.cbL11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL11.Location = New System.Drawing.Point(17, 229)
        Me.cbL11.Name = "cbL11"
        Me.cbL11.Size = New System.Drawing.Size(40, 19)
        Me.cbL11.TabIndex = 29
        Me.cbL11.Text = "11"
        Me.cbL11.UseVisualStyleBackColor = True
        '
        'cbL10
        '
        Me.cbL10.AutoSize = True
        Me.cbL10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL10.Location = New System.Drawing.Point(17, 209)
        Me.cbL10.Name = "cbL10"
        Me.cbL10.Size = New System.Drawing.Size(40, 19)
        Me.cbL10.TabIndex = 28
        Me.cbL10.Text = "10"
        Me.cbL10.UseVisualStyleBackColor = True
        '
        'cbL9
        '
        Me.cbL9.AutoSize = True
        Me.cbL9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL9.Location = New System.Drawing.Point(17, 189)
        Me.cbL9.Name = "cbL9"
        Me.cbL9.Size = New System.Drawing.Size(33, 19)
        Me.cbL9.TabIndex = 27
        Me.cbL9.Text = "9"
        Me.cbL9.UseVisualStyleBackColor = True
        '
        'cbL8
        '
        Me.cbL8.AutoSize = True
        Me.cbL8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL8.Location = New System.Drawing.Point(17, 169)
        Me.cbL8.Name = "cbL8"
        Me.cbL8.Size = New System.Drawing.Size(33, 19)
        Me.cbL8.TabIndex = 26
        Me.cbL8.Text = "8"
        Me.cbL8.UseVisualStyleBackColor = True
        '
        'cbL7
        '
        Me.cbL7.AutoSize = True
        Me.cbL7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL7.Location = New System.Drawing.Point(17, 149)
        Me.cbL7.Name = "cbL7"
        Me.cbL7.Size = New System.Drawing.Size(33, 19)
        Me.cbL7.TabIndex = 25
        Me.cbL7.Text = "7"
        Me.cbL7.UseVisualStyleBackColor = True
        '
        'cbL6
        '
        Me.cbL6.AutoSize = True
        Me.cbL6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL6.Location = New System.Drawing.Point(17, 129)
        Me.cbL6.Name = "cbL6"
        Me.cbL6.Size = New System.Drawing.Size(33, 19)
        Me.cbL6.TabIndex = 24
        Me.cbL6.Text = "6"
        Me.cbL6.UseVisualStyleBackColor = True
        '
        'cbL5
        '
        Me.cbL5.AutoSize = True
        Me.cbL5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL5.Location = New System.Drawing.Point(17, 109)
        Me.cbL5.Name = "cbL5"
        Me.cbL5.Size = New System.Drawing.Size(33, 19)
        Me.cbL5.TabIndex = 23
        Me.cbL5.Text = "5"
        Me.cbL5.UseVisualStyleBackColor = True
        '
        'cbL4
        '
        Me.cbL4.AutoSize = True
        Me.cbL4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL4.Location = New System.Drawing.Point(17, 89)
        Me.cbL4.Name = "cbL4"
        Me.cbL4.Size = New System.Drawing.Size(33, 19)
        Me.cbL4.TabIndex = 22
        Me.cbL4.Text = "4"
        Me.cbL4.UseVisualStyleBackColor = True
        '
        'cbL3
        '
        Me.cbL3.AutoSize = True
        Me.cbL3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL3.Location = New System.Drawing.Point(17, 69)
        Me.cbL3.Name = "cbL3"
        Me.cbL3.Size = New System.Drawing.Size(33, 19)
        Me.cbL3.TabIndex = 21
        Me.cbL3.Text = "3"
        Me.cbL3.UseVisualStyleBackColor = True
        '
        'cbL2
        '
        Me.cbL2.AutoSize = True
        Me.cbL2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL2.Location = New System.Drawing.Point(17, 49)
        Me.cbL2.Name = "cbL2"
        Me.cbL2.Size = New System.Drawing.Size(33, 19)
        Me.cbL2.TabIndex = 20
        Me.cbL2.Text = "2"
        Me.cbL2.UseVisualStyleBackColor = True
        '
        'cbL1
        '
        Me.cbL1.AutoSize = True
        Me.cbL1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbL1.Location = New System.Drawing.Point(17, 29)
        Me.cbL1.Name = "cbL1"
        Me.cbL1.Size = New System.Drawing.Size(33, 19)
        Me.cbL1.TabIndex = 19
        Me.cbL1.Text = "1"
        Me.cbL1.UseVisualStyleBackColor = True
        '
        'cbLimitTo
        '
        Me.cbLimitTo.AutoSize = True
        Me.cbLimitTo.Checked = True
        Me.cbLimitTo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbLimitTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLimitTo.Location = New System.Drawing.Point(17, 361)
        Me.cbLimitTo.Name = "cbLimitTo"
        Me.cbLimitTo.Size = New System.Drawing.Size(80, 20)
        Me.cbLimitTo.TabIndex = 18
        Me.cbLimitTo.Text = "Limit Y to"
        Me.cbLimitTo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox2.Controls.Add(Me.cbDivide)
        Me.GroupBox2.Controls.Add(Me.cbMultiply)
        Me.GroupBox2.Controls.Add(Me.cbSubtract)
        Me.GroupBox2.Controls.Add(Me.cbAdd)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 134)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operation"
        '
        'cbDivide
        '
        Me.cbDivide.AutoSize = True
        Me.cbDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDivide.Location = New System.Drawing.Point(18, 103)
        Me.cbDivide.Name = "cbDivide"
        Me.cbDivide.Size = New System.Drawing.Size(66, 20)
        Me.cbDivide.TabIndex = 19
        Me.cbDivide.Text = "Divide"
        Me.cbDivide.UseVisualStyleBackColor = True
        '
        'cbMultiply
        '
        Me.cbMultiply.AutoSize = True
        Me.cbMultiply.Checked = True
        Me.cbMultiply.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMultiply.Location = New System.Drawing.Point(18, 77)
        Me.cbMultiply.Name = "cbMultiply"
        Me.cbMultiply.Size = New System.Drawing.Size(72, 20)
        Me.cbMultiply.TabIndex = 18
        Me.cbMultiply.Text = "Multiply"
        Me.cbMultiply.UseVisualStyleBackColor = True
        '
        'cbSubtract
        '
        Me.cbSubtract.AutoSize = True
        Me.cbSubtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSubtract.Location = New System.Drawing.Point(18, 51)
        Me.cbSubtract.Name = "cbSubtract"
        Me.cbSubtract.Size = New System.Drawing.Size(76, 20)
        Me.cbSubtract.TabIndex = 17
        Me.cbSubtract.Text = "Subtract"
        Me.cbSubtract.UseVisualStyleBackColor = True
        '
        'cbAdd
        '
        Me.cbAdd.AutoSize = True
        Me.cbAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAdd.Location = New System.Drawing.Point(18, 25)
        Me.cbAdd.Name = "cbAdd"
        Me.cbAdd.Size = New System.Drawing.Size(52, 20)
        Me.cbAdd.TabIndex = 16
        Me.cbAdd.Text = "Add"
        Me.cbAdd.UseVisualStyleBackColor = True
        '
        'tbQuestion
        '
        Me.tbQuestion.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.tbQuestion.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQuestion.Location = New System.Drawing.Point(215, 207)
        Me.tbQuestion.Name = "tbQuestion"
        Me.tbQuestion.Size = New System.Drawing.Size(323, 74)
        Me.tbQuestion.TabIndex = 7
        Me.tbQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbAnswer
        '
        Me.tbAnswer.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.tbAnswer.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAnswer.Location = New System.Drawing.Point(544, 207)
        Me.tbAnswer.Name = "tbAnswer"
        Me.tbAnswer.Size = New System.Drawing.Size(108, 74)
        Me.tbAnswer.TabIndex = 8
        Me.tbAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bStart
        '
        Me.bStart.BackColor = System.Drawing.Color.LightBlue
        Me.bStart.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bStart.Location = New System.Drawing.Point(213, 520)
        Me.bStart.Name = "bStart"
        Me.bStart.Size = New System.Drawing.Size(146, 50)
        Me.bStart.TabIndex = 9
        Me.bStart.Text = "Start"
        Me.bStart.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(220, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 67)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Score:"
        '
        'tbScore
        '
        Me.tbScore.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.tbScore.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbScore.Location = New System.Drawing.Point(378, 36)
        Me.tbScore.Name = "tbScore"
        Me.tbScore.Size = New System.Drawing.Size(177, 74)
        Me.tbScore.TabIndex = 11
        Me.tbScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lCount
        '
        Me.lCount.AutoSize = True
        Me.lCount.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCount.Location = New System.Drawing.Point(572, 59)
        Me.lCount.Name = "lCount"
        Me.lCount.Size = New System.Drawing.Size(62, 29)
        Me.lCount.TabIndex = 12
        Me.lCount.Text = "0 / 0"
        '
        'lMsg1
        '
        Me.lMsg1.AutoSize = True
        Me.lMsg1.BackColor = System.Drawing.Color.Teal
        Me.lMsg1.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMsg1.Location = New System.Drawing.Point(218, 292)
        Me.lMsg1.Name = "lMsg1"
        Me.lMsg1.Size = New System.Drawing.Size(43, 67)
        Me.lMsg1.TabIndex = 13
        Me.lMsg1.Text = " "
        '
        'lMsg2
        '
        Me.lMsg2.AutoSize = True
        Me.lMsg2.BackColor = System.Drawing.Color.Teal
        Me.lMsg2.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMsg2.Location = New System.Drawing.Point(217, 347)
        Me.lMsg2.Name = "lMsg2"
        Me.lMsg2.Size = New System.Drawing.Size(26, 40)
        Me.lMsg2.TabIndex = 14
        Me.lMsg2.Text = " "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(741, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 45)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Leader Board"
        '
        'rtbLeaderBoard
        '
        Me.rtbLeaderBoard.BackColor = System.Drawing.Color.Teal
        Me.rtbLeaderBoard.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbLeaderBoard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbLeaderBoard.Location = New System.Drawing.Point(738, 61)
        Me.rtbLeaderBoard.Name = "rtbLeaderBoard"
        Me.rtbLeaderBoard.ReadOnly = True
        Me.rtbLeaderBoard.Size = New System.Drawing.Size(244, 473)
        Me.rtbLeaderBoard.TabIndex = 16
        Me.rtbLeaderBoard.Text = ""
        '
        'bClearLB
        '
        Me.bClearLB.BackColor = System.Drawing.Color.Teal
        Me.bClearLB.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.bClearLB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bClearLB.Location = New System.Drawing.Point(959, 12)
        Me.bClearLB.Name = "bClearLB"
        Me.bClearLB.Size = New System.Drawing.Size(23, 19)
        Me.bClearLB.TabIndex = 17
        Me.bClearLB.UseVisualStyleBackColor = False
        '
        'flashTimer
        '
        Me.flashTimer.Interval = 200
        '
        'lmsg3
        '
        Me.lmsg3.AutoSize = True
        Me.lmsg3.BackColor = System.Drawing.Color.Teal
        Me.lmsg3.Font = New System.Drawing.Font("Comic Sans MS", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lmsg3.Location = New System.Drawing.Point(398, 388)
        Me.lmsg3.Name = "lmsg3"
        Me.lmsg3.Size = New System.Drawing.Size(86, 135)
        Me.lmsg3.TabIndex = 18
        Me.lmsg3.Text = " "
        '
        'tbName
        '
        Me.tbName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbName.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.tbName.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.Location = New System.Drawing.Point(815, 513)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(167, 34)
        Me.tbName.TabIndex = 19
        Me.tbName.Text = "Your Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(994, 582)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.lmsg3)
        Me.Controls.Add(Me.bClearLB)
        Me.Controls.Add(Me.rtbLeaderBoard)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lMsg2)
        Me.Controls.Add(Me.lMsg1)
        Me.Controls.Add(Me.lCount)
        Me.Controls.Add(Me.tbScore)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bStart)
        Me.Controls.Add(Me.tbAnswer)
        Me.Controls.Add(Me.tbQuestion)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pGameTimer)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pGameTimer As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbDivide As System.Windows.Forms.CheckBox
    Friend WithEvents cbMultiply As System.Windows.Forms.CheckBox
    Friend WithEvents cbSubtract As System.Windows.Forms.CheckBox
    Friend WithEvents cbAdd As System.Windows.Forms.CheckBox
    Friend WithEvents tbQuestion As System.Windows.Forms.TextBox
    Friend WithEvents tbAnswer As System.Windows.Forms.TextBox
    Friend WithEvents bStart As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbScore As System.Windows.Forms.TextBox
    Friend WithEvents lCount As System.Windows.Forms.Label
    Friend WithEvents cbLimitTo As System.Windows.Forms.CheckBox
    Friend WithEvents lMsg1 As System.Windows.Forms.Label
    Friend WithEvents lMsg2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rtbLeaderBoard As System.Windows.Forms.RichTextBox
    Friend WithEvents bClearLB As System.Windows.Forms.Button
    Friend WithEvents cbL16 As System.Windows.Forms.CheckBox
    Friend WithEvents cbL15 As System.Windows.Forms.CheckBox
    Friend WithEvents cbL14 As System.Windows.Forms.CheckBox
    Friend WithEvents cbL13 As System.Windows.Forms.CheckBox
    Friend WithEvents cbL12 As System.Windows.Forms.CheckBox
    Friend WithEvents cbL11 As System.Windows.Forms.CheckBox
    Friend WithEvents cbL10 As System.Windows.Forms.CheckBox
    Friend WithEvents cbL9 As System.Windows.Forms.CheckBox
    Friend WithEvents cbL8 As System.Windows.Forms.CheckBox
    Friend WithEvents cbL7 As System.Windows.Forms.CheckBox
    Friend WithEvents cbL6 As System.Windows.Forms.CheckBox
    Friend WithEvents cbL5 As System.Windows.Forms.CheckBox
    Friend WithEvents cbL4 As System.Windows.Forms.CheckBox
    Friend WithEvents cbL3 As System.Windows.Forms.CheckBox
    Friend WithEvents cbL2 As System.Windows.Forms.CheckBox
    Friend WithEvents cbL1 As System.Windows.Forms.CheckBox
    Friend WithEvents ddLimitto As System.Windows.Forms.ComboBox
    Friend WithEvents bClear As System.Windows.Forms.Button
    Friend WithEvents bAll As System.Windows.Forms.Button
    Friend WithEvents flashTimer As System.Windows.Forms.Timer
    Friend WithEvents lmsg3 As System.Windows.Forms.Label
    Friend WithEvents tbName As System.Windows.Forms.TextBox

End Class
