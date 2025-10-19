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

    Sub ClearDrawingBox()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.BlueViolet)

    End Sub

    Function GetRandomNumber(max As Integer) As Integer
        Randomize()
        Return CInt(System.Math.Floor(CDbl(Rnd() * max))) + 1
    End Function

    Sub ThrowDart()
        Dim x As Integer
        Dim y As Integer

        x = GetRandomNumber(DrawingPictureBox.Width)
        y = GetRandomNumber(DrawingPictureBox.Height)

        FileOpen(1, $"Dart Data-{ DateTime.Now.ToString("yyMMddhh")}.log", OpenMode.Append)
        Write(1, x)
        Write(1, y)
        FileClose(1)

        DrawDart(x, y)
    End Sub


    Sub LogToFile(round%, dart1X%, dart1Y%, dart2X%, dart2Y%, dart3X%, dart3Y%)

        FileOpen(1, $"Dart Data-{ DateTime.Now.ToString("yyMMddhh")}.log", OpenMode.Append)

        Write(1, DateTime.Now.ToString("yy:MM:dd:hh:mm:ss:fff"))
        Write(1, round)
        Write(1, dart1X)
        Write(1, dart1Y)
        Write(1, dart2X)
        Write(1, dart2Y)
        Write(1, dart3X)
        Write(1, dart3Y)
        Write(1, "End of Round")
        WriteLine(1)

        FileClose(1)
    End Sub

    Sub RoundEnd()
        MsgBox("Game Is over")

        'LogToFile(1, 2, 2, 3, 3, 4, 4)

        ThrowDartButton.Enabled = False
        StartRoundButton.Enabled = True
        ReviewButton.Enabled = True
        ClearButton.Enabled = True
        ExitButton.Enabled = True
        ReviewGroupBox.Enabled = True
        ModeTextBox.Text = "Mode: Review"
        StartRoundButton.Focus()
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
        Me.Refresh()

        DartsLeftTextBox.Text = "Darts Left: 3"
        ThrowDartButton.Enabled = True
        StartRoundButton.Enabled = False
        ReviewButton.Enabled = False
        ClearButton.Enabled = False
        ExitButton.Enabled = False
        ReviewGroupBox.Enabled = False

        ModeTextBox.Text = "Mode: Play"
        round = SeperateNumberFromLabel(RoundTextBox.Text) + 1
        RoundTextBox.Text = "Round: " + CStr(round)
    End Sub

    Private Sub ThrowDartButton_Click(sender As Object, e As EventArgs) Handles ThrowDartButton.Click
        Dim dartsLeft As Integer

        Dim roundData As Integer
        Dim dart1XData As Integer
        Dim dart1YData As Integer
        Dim dart2XData As Integer
        Dim dart2YData As Integer
        Dim dart3XData As Integer
        Dim dart3YData As Integer

        roundData = SeperateNumberFromLabel(RoundTextBox.Text)
        dartsLeft = SeperateNumberFromLabel(DartsLeftTextBox.Text)

        If dartsLeft = 3 Then
            dart1XData = GetRandomNumber(DrawingPictureBox.Width)
            dart1YData = GetRandomNumber(DrawingPictureBox.Height)

            DrawDart(dart1XData, dart1YData)
            dartsLeft = dartsLeft - 1
            DartsLeftTextBox.Text = "Darts Left: " + CStr(dartsLeft)

        ElseIf dartsLeft = 2 Then
            dart2XData = GetRandomNumber(DrawingPictureBox.Width)
            dart2YData = GetRandomNumber(DrawingPictureBox.Height)

            DrawDart(dart2XData, dart2YData)
            dartsLeft = dartsLeft - 1
            DartsLeftTextBox.Text = "Darts Left: " + CStr(dartsLeft)

        Else
            dart3XData = GetRandomNumber(DrawingPictureBox.Width)
            dart3YData = GetRandomNumber(DrawingPictureBox.Height)

            DrawDart(dart3XData, dart3YData)
            dartsLeft = dartsLeft - 1
            DartsLeftTextBox.Text = "Darts Left: " + CStr(dartsLeft)
            LogToFile(roundData, dart1XData, dart1YData, dart2XData, dart2YData, dart3XData, dart3YData)
            RoundComboBox.Items.Add("Round: " + CStr(roundData))
            RoundEnd()
        End If

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        FileOpen(1, $"Dart Data-{ DateTime.Now.ToString("yyMMddhh")}.log", OpenMode.Output)
        Write(1, "")
        FileClose(1)
    End Sub

    Private Sub ReviewButton_Click(sender As Object, e As EventArgs) Handles ReviewButton.Click

    End Sub
End Class
