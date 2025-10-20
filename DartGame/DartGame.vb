'Angel Nava
'Fall 2025
'RCET3371
'DartGame
'https://github.com/TheGoldenPorkchop/DartGame
Option Strict On
Option Explicit On

Public Class DartGame



    Sub DrawDart(x As Integer, y As Integer, dartcolor As Color)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(dartcolor)
        Dim dartWidth As Integer = 30

        g.DrawEllipse(pen, x - (dartWidth \ 2), y - (dartWidth \ 2), dartWidth, dartWidth)
        g.DrawLine(pen, x - 3, y, x + 3, y)
        g.DrawLine(pen, x, y - 3, x, y + 3)

        pen.Dispose()
        g.Dispose()
    End Sub

    Sub ClearDrawingBox()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        'Dim pen As New Pen(Color.BlueViolet)

    End Sub

    Function GetRandomNumber(max As Integer) As Integer
        Randomize()
        Return CInt(System.Math.Floor(CDbl(Rnd() * max))) + 1
    End Function

    Sub LogToFile(round%, dart1X%, dart1Y%, dart2X%, dart2Y%, dart3X%, dart3Y%)

        FileOpen(1, $"Dart Data.log", OpenMode.Append)

        'Write(1, DateTime.Now.ToString("yy:MM:dd:hh:mm:ss:fff"))
        If round > 1 Then
            Write(1, "")
        End If
        Write(1, "Round: " + CStr(round))
        Write(1, round)
        Write(1, dart1X)
        Write(1, dart1Y)
        Write(1, dart2X)
        Write(1, dart2Y)
        Write(1, dart3X)
        Write(1, dart3Y)
        WriteLine(1)

        FileClose(1)
    End Sub

    Sub DisplayLog(Optional roundToFilter As Integer = -1)
        Dim Path As String = $"Dart Data.log"
        Dim logContent As String = ""

        If System.IO.File.Exists(Path) Then
            Try
                Dim allLines() As String = System.IO.File.ReadAllLines(Path)
                Dim filteredLines As New List(Of String)

                For Each line As String In allLines
                    If line.Contains($"Round: {roundToFilter}") Then
                        filteredLines.Add(line)
                    End If
                Next

                logContent = String.Join(Environment.NewLine, filteredLines.ToArray())
            Catch ex As Exception
                MsgBox("erm...")
            End Try
        Else
            logContent = "Log file not found"
        End If

        Dim dartsData As String()
        dartsData = Split(logContent, ",")

        reviewDart1XData = CInt(dartsData(3))
        reviewDart1YData = CInt(dartsData(4))
        reviewDart2XData = CInt(dartsData(5))
        reviewDart2YData = CInt(dartsData(6))
        reviewDart3XData = CInt(dartsData(7))
        reviewDart3YData = CInt(dartsData(8))


        RoundTextBox.Text = "Round: " + CStr(dartsData(2))
        Dart1TextBox.Text = "Dart1's Position: (" + CStr(reviewDart1XData) + ", " + CStr(reviewDart1YData) + ")"
        DrawDart(reviewDart1XData, reviewDart1YData, Color.BlueViolet)
        Dart2TextBox.Text = "Dart2's Position: (" + CStr(reviewDart2XData) + ", " + CStr(reviewDart2YData) + ")"
        DrawDart(reviewDart2XData, reviewDart2YData, Color.BlueViolet)
        Dart3TextBox.Text = "Dart3's Position: (" + CStr(reviewDart3XData) + ", " + CStr(reviewDart3YData) + ")"
        DrawDart(reviewDart3XData, reviewDart3YData, Color.BlueViolet)


    End Sub


    Sub RoundEnd()
        MsgBox("Game Is over")

        ThrowDartButton.Enabled = False
        StartRoundButton.Enabled = True
        ReviewButton.Enabled = True
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
        ReviewButton.Enabled = False
        'When you close and reopen the dart game application, it will overwrite the previous savefile to prevent multiple entries of the same round
        FileOpen(1, $"Dart Data.log", OpenMode.Output)
        Write(1, "")
        FileClose(1)
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
        ExitButton.Enabled = False
        ReviewGroupBox.Enabled = False

        ModeTextBox.Text = "Mode: Play"
        round = roundData + 1
        RoundTextBox.Text = "Round: " + CStr(round)
    End Sub


    Private roundData As Integer = 0
    Private dart1XData As Integer
    Private dart1YData As Integer
    Private dart2XData As Integer
    Private dart2YData As Integer
    Private dart3XData As Integer
    Private dart3YData As Integer
    Private Sub ThrowDartButton_Click(sender As Object, e As EventArgs) Handles ThrowDartButton.Click
        Dim dartsLeft As Integer

        roundData = SeperateNumberFromLabel(RoundTextBox.Text)
        dartsLeft = SeperateNumberFromLabel(DartsLeftTextBox.Text)

        If dartsLeft = 3 Then
            dart1XData = GetRandomNumber(DrawingPictureBox.Width)
            dart1YData = GetRandomNumber(DrawingPictureBox.Height)

            DrawDart(dart1XData, dart1YData, Color.Red)
            dartsLeft = dartsLeft - 1
            DartsLeftTextBox.Text = "Darts Left: " + CStr(dartsLeft)
            Dart1TextBox.Text = "Dart1's Position: (" + CStr(dart1XData) + ", " + CStr(dart1YData) + ")"

        ElseIf dartsLeft = 2 Then
            dart2XData = GetRandomNumber(DrawingPictureBox.Width)
            dart2YData = GetRandomNumber(DrawingPictureBox.Height)

            DrawDart(dart2XData, dart2YData, Color.Red)
            dartsLeft = dartsLeft - 1
            DartsLeftTextBox.Text = "Darts Left: " + CStr(dartsLeft)
            Dart2TextBox.Text = "Dart2's Position: (" + CStr(dart2XData) + ", " + CStr(dart2YData) + ")"

        Else
            dart3XData = GetRandomNumber(DrawingPictureBox.Width)
            dart3YData = GetRandomNumber(DrawingPictureBox.Height)

            DrawDart(dart3XData, dart3YData, Color.Red)
            dartsLeft = dartsLeft - 1
            DartsLeftTextBox.Text = "Darts Left: " + CStr(dartsLeft)
            Dart3TextBox.Text = "Dart3's Position: (" + CStr(dart3XData) + ", " + CStr(dart3YData) + ")"

            LogToFile(roundData, dart1XData, dart1YData, dart2XData, dart2YData, dart3XData, dart3YData)
            RoundComboBox.Items.Add("Round: " + CStr(roundData))
            RoundEnd()
        End If

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs)
        FileOpen(1, $"Dart Data.log", OpenMode.Output)
        Write(1, "")
        FileClose(1)
    End Sub


    Private reviewRoundData As Integer = 0
    Private reviewDart1XData As Integer
    Private reviewDart1YData As Integer
    Private reviewDart2XData As Integer
    Private reviewDart2YData As Integer
    Private reviewDart3XData As Integer
    Private reviewDart3YData As Integer
    Private Sub ReviewButton_Click(sender As Object, e As EventArgs) Handles ReviewButton.Click
        Me.Refresh()
        'ReadFromFile()
        Dim selectedItem As String = CStr(RoundComboBox.SelectedItem)
        If selectedItem = "" Then
            MsgBox("Select a Round First")
        Else
            Dim roundNum As Integer = SeperateNumberFromLabel(selectedItem)
            DisplayLog(roundNum)
        End If

    End Sub
End Class
