'Angel Nava
'Fall 2025
'RCET3371
'DartGame
'Github Link
Option Strict On
Option Explicit On

Public Class DartGame


    Sub DrawDart(x As Integer, y As Integer)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.BlueViolet)
        Dim dartWidth As Integer = 30

        g.DrawEllipse(pen, x - (dartWidth \ 2), y - (dartWidth \ 2), dartWidth, dartWidth)
        g.DrawLine(pen, x - 3, y, x + 3, y)
        g.DrawLine(pen, x, y - 3, x, y + 3)

        pen.Dispose()
        g.Dispose()
    End Sub

    Function GetRandomNumber(max As Integer) As Integer
        Randomize()
        Return CInt(System.Math.Floor(CDbl(Rnd() * max))) + 1
    End Function

    Sub ThrowDart()
        DrawDart(GetRandomNumber(DrawingPictureBox.Width), GetRandomNumber(DrawingPictureBox.Height))
    End Sub

    Sub RoundEnd()
        MsgBox("Game Is over")
        ThrowDartButton.Enabled = False
        StartRoundButton.Enabled = True
        ReviewButton.Enabled = True
        ClearButton.Enabled = True
        ExitButton.Enabled = True
        ModeTextBox.Text = "Mode: Review"
    End Sub

    Private Function SeperateNumberFromLabel(Value As String) As Integer
        Dim dartIndicator As String()
        dartIndicator = Split(Value, ": ")

        Dim Number As Integer = CInt(dartIndicator(1))
        Return Number
    End Function

    'Event Handlers--------------------------------------------------------------------------
    Private Sub DartGame_Load(sender As Object, e As EventArgs) Handles Me.Load
        DrawingPictureBox.BackColor = Color.BlanchedAlmond
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub StartRoundButton_Click(sender As Object, e As EventArgs) Handles StartRoundButton.Click
        Dim round As Integer
        DartsLeftTextBox.Text = "Darts Left: 3"
        ThrowDartButton.Enabled = True
        StartRoundButton.Enabled = False
        ReviewButton.Enabled = False
        ClearButton.Enabled = False
        ExitButton.Enabled = False

        round = SeperateNumberFromLabel(RoundTextBox.Text) + 1
        RoundTextBox.Text = "Round: " + CStr(round)

        ModeTextBox.Text = "Mode: Play"
    End Sub

    Private Sub ThrowDartButton_Click(sender As Object, e As EventArgs) Handles ThrowDartButton.Click
        Dim dartsLeft As Integer
        dartsLeft = SeperateNumberFromLabel(DartsLeftTextBox.Text)

        If dartsLeft > 1 Then
            ThrowDart()
            dartsLeft = dartsLeft - 1
            DartsLeftTextBox.Text = "Darts Left: " + CStr(dartsLeft)
        Else
            ThrowDart()
            dartsLeft = dartsLeft - 1
            DartsLeftTextBox.Text = "Darts Left: " + CStr(dartsLeft)
            RoundEnd()
        End If

    End Sub

End Class
