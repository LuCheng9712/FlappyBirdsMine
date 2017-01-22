Public Class Form1

    ' Lucy Cheng
    ' Flappy Birds (Own)
    ' May 2015

    Dim intYSpeed As Integer = 0
    Dim intGravity As Integer = 2
    Dim shtXSpeed As Short = 5
    Dim shtScore As Short = 0
    Dim shtGap As Short = 115
    Dim shtHighScore As Short

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then
            intYSpeed = -15
        End If
    End Sub

    'Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Me.tmrGravity.Enabled = True
    '    Me.tmrXSpeed.Enabled = True
    '    Me.tmrLevel.Enabled = True
    '    RandomizePipeSize()
    'End Sub

    Private Sub tmrGravity_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGravity.Tick
        intYSpeed += intGravity
        Me.pbxBird.Top += intYSpeed
        Me.lblScore.Text = shtScore.ToString
    End Sub

    Private Sub tmrLevel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLevel.Tick
        shtXSpeed += 1
    End Sub

    Private Sub tmrXSpeed_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrXSpeed.Tick
        MovePipeLeft()
        LoopPipe()
        Collision()
    End Sub

    Private Sub LoopPipe()
        If pbxPU1.Left < -45 Then
            pbxPU1.Left += 1195
            pbxPD1.Left += 1195
            Me.pbxPU1.Height = (250 - 50 + 1) * Rnd() + 50
            Me.pbxPD1.Top = Me.pbxPU1.Height + shtGap
            shtScore += 1
        End If
        If pbxPU2.Left < -45 Then
            pbxPU2.Left += 1195
            pbxPD2.Left += 1195
            Me.pbxPU2.Height = (250 - 50 + 1) * Rnd() + 50
            Me.pbxPD2.Top = Me.pbxPU2.Height + shtGap
            shtScore += 1
        End If
        If pbxPU3.Left < -45 Then
            pbxPU3.Left += 1195
            pbxPD3.Left += 1195
            Me.pbxPU3.Height = (250 - 50 + 1) * Rnd() + 50
            Me.pbxPD3.Top = Me.pbxPU3.Height + shtGap
            shtScore += 1
        End If
        If pbxPU4.Left < -45 Then
            pbxPU4.Left += 1195
            pbxPD4.Left += 1195
            Me.pbxPU4.Height = (250 - 50 + 1) * Rnd() + 50
            Me.pbxPD4.Top = Me.pbxPU4.Height + shtGap
            shtScore += 1
        End If
        If pbxPU5.Left < -45 Then
            pbxPU5.Left += 1195
            pbxPD5.Left += 1195
            Me.pbxPU5.Height = (250 - 50 + 1) * Rnd() + 50
            Me.pbxPD5.Top = Me.pbxPU5.Height + shtGap
            shtScore += 1
        End If
        If pbxPU6.Left < -45 Then
            pbxPU6.Left += 1195
            pbxPD6.Left += 1195
            Me.pbxPU6.Height = (250 - 50 + 1) * Rnd() + 50
            Me.pbxPD6.Top = Me.pbxPU6.Height + shtGap
            shtScore += 1
        End If
        If pbxPU7.Left < -45 Then
            pbxPU7.Left += 1195
            pbxPD7.Left += 1195
            Me.pbxPU7.Height = (250 - 50 + 1) * Rnd() + 50
            Me.pbxPD7.Top = Me.pbxPU7.Height + shtGap
            shtScore += 1
        End If
    End Sub

    Private Sub RandomizePipeSize()
        Randomize()
        Me.pbxPU1.Height = (250 - 50 + 1) * Rnd() + 50
        Me.pbxPU2.Height = (250 - 50 + 1) * Rnd() + 50
        Me.pbxPU3.Height = (250 - 50 + 1) * Rnd() + 50
        Me.pbxPU4.Height = (250 - 50 + 1) * Rnd() + 50
        Me.pbxPU5.Height = (250 - 50 + 1) * Rnd() + 50
        Me.pbxPU6.Height = (250 - 50 + 1) * Rnd() + 50
        Me.pbxPU7.Height = (250 - 50 + 1) * Rnd() + 50
        Me.pbxPD1.Top = Me.pbxPU1.Height + shtGap
        Me.pbxPD2.Top = Me.pbxPU2.Height + shtGap
        Me.pbxPD3.Top = Me.pbxPU3.Height + shtGap
        Me.pbxPD4.Top = Me.pbxPU4.Height + shtGap
        Me.pbxPD5.Top = Me.pbxPU5.Height + shtGap
        Me.pbxPD6.Top = Me.pbxPU6.Height + shtGap
        Me.pbxPD7.Top = Me.pbxPU7.Height + shtGap
    End Sub

    Private Sub MovePipeLeft()
        Me.pbxPU1.Left -= shtXSpeed
        Me.pbxPU2.Left -= shtXSpeed
        Me.pbxPU3.Left -= shtXSpeed
        Me.pbxPU4.Left -= shtXSpeed
        Me.pbxPU5.Left -= shtXSpeed
        Me.pbxPU6.Left -= shtXSpeed
        Me.pbxPU7.Left -= shtXSpeed
        Me.pbxPD1.Left -= shtXSpeed
        Me.pbxPD2.Left -= shtXSpeed
        Me.pbxPD3.Left -= shtXSpeed
        Me.pbxPD4.Left -= shtXSpeed
        Me.pbxPD5.Left -= shtXSpeed
        Me.pbxPD6.Left -= shtXSpeed
        Me.pbxPD7.Left -= shtXSpeed
    End Sub

    Private Sub Collision()
        If pbxBird.Bounds.IntersectsWith(pbxPU1.Bounds) _
            Or pbxBird.Bounds.IntersectsWith(pbxPU2.Bounds) _
            Or pbxBird.Bounds.IntersectsWith(pbxPU3.Bounds) _
            Or pbxBird.Bounds.IntersectsWith(pbxPU4.Bounds) _
            Or pbxBird.Bounds.IntersectsWith(pbxPU5.Bounds) _
            Or pbxBird.Bounds.IntersectsWith(pbxPU6.Bounds) _
            Or pbxBird.Bounds.IntersectsWith(pbxPU7.Bounds) _
            Or pbxBird.Bounds.IntersectsWith(pbxPD1.Bounds) _
            Or pbxBird.Bounds.IntersectsWith(pbxPD2.Bounds) _
            Or pbxBird.Bounds.IntersectsWith(pbxPD3.Bounds) _
            Or pbxBird.Bounds.IntersectsWith(pbxPD4.Bounds) _
            Or pbxBird.Bounds.IntersectsWith(pbxPD5.Bounds) _
            Or pbxBird.Bounds.IntersectsWith(pbxPD6.Bounds) _
            Or pbxBird.Bounds.IntersectsWith(pbxPD7.Bounds) _
            Then
            Me.tmrGravity.Enabled = False
            Me.tmrXSpeed.Enabled = False
            Me.tmrLevel.Enabled = True
            MessageBox.Show("You Died")
            If shtScore > shtHighScore Then
                shtHighScore = shtScore
                MessageBox.Show("You beat your high score! Your new High Score is: " + shtHighScore.ToString)
                'ElseIf shtScore = shtHighScore Then
                '    MessageBox.Show("Need just one more pipe! Your High Score is: " + shtHighScore.ToString)
                'ElseIf shtScore < shtHighScore Then
                '    MessageBox.Show("Needs More work! Your High Score is: " + shtHighScore.ToString)
            End If
        End If
        If pbxBird.Top > 450 Then
            Me.pbxBird.Top = 450
            Me.tmrGravity.Enabled = False
            Me.tmrXSpeed.Enabled = False
            Me.tmrLevel.Enabled = True
            MessageBox.Show("You Died")
            If shtScore > shtHighScore Then
                shtHighScore = shtScore
                MessageBox.Show("You beat your high score! Your new High Score is: " + shtHighScore.ToString)
                'ElseIf shtScore = shtHighScore Then
                '    MessageBox.Show("Need just one more pipe! Your High Score is: " + shtHighScore.ToString)
                'ElseIf shtScore < shtHighScore Then
                '    MessageBox.Show("Needs More work! Your High Score is: " + shtHighScore.ToString)
            End If
        End If
        If pbxBird.Top < 0 Then
            Me.pbxBird.Top = 0
            Me.tmrGravity.Enabled = False
            Me.tmrXSpeed.Enabled = False
            Me.tmrLevel.Enabled = True
            MessageBox.Show("You Died")
            If shtScore > shtHighScore Then
                shtHighScore = shtScore
                MessageBox.Show("You beat your high score! Your new High Score is: " + shtHighScore.ToString)
                'ElseIf shtScore = shtHighScore Then
                '    MessageBox.Show("Need just one more pipe! Your High Score is: " + shtHighScore.ToString)
                'ElseIf shtScore < shtHighScore Then
                '    MessageBox.Show("Needs More work! Your High Score is: " + shtHighScore.ToString)
            End If
        End If
    End Sub

    Private Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.Click
        Me.pbxBird.Left = 20
        Me.pbxBird.Top = 230
        Me.pbxPU1.Left = 635
        Me.pbxPU1.Top = 25
        Me.pbxPU2.Left = 805
        Me.pbxPU2.Top = 25
        Me.pbxPU3.Left = 975
        Me.pbxPU3.Top = 25
        Me.pbxPU4.Left = 1145
        Me.pbxPU4.Top = 25
        Me.pbxPU5.Left = 1315
        Me.pbxPU5.Top = 25
        Me.pbxPU6.Left = 1485
        Me.pbxPU6.Top = 25
        Me.pbxPU7.Left = 1655
        Me.pbxPU7.Top = 25
        Me.pbxPD1.Left = 635
        Me.pbxPD1.Top = 12
        Me.pbxPD2.Left = 805
        Me.pbxPD2.Top = 12
        Me.pbxPD3.Left = 975
        Me.pbxPD3.Top = 12
        Me.pbxPD4.Left = 1145
        Me.pbxPD4.Top = 12
        Me.pbxPD5.Left = 1315
        Me.pbxPD5.Top = 12
        Me.pbxPD6.Left = 1485
        Me.pbxPD6.Top = 12
        Me.pbxPD7.Left = 1655
        Me.pbxPD7.Top = 12
        intYSpeed = 0
        intGravity = 2
        shtGap = 115
        shtXSpeed = 5
        shtScore = 0
        Me.tmrGravity.Enabled = True
        Me.tmrXSpeed.Enabled = True
        Me.tmrLevel.Enabled = True
        RandomizePipeSize()
    End Sub

    Private Sub EndToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndToolStripMenuItem.Click
        End
    End Sub

    Private Sub HighScoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HighScoreToolStripMenuItem.Click
        MessageBox.Show("Your High Score is: " + shtHighScore.ToString)
    End Sub
End Class
