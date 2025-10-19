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

    'Event Handlers--------------------------------------------------------------------------
    Private Sub DartGame_Load(sender As Object, e As EventArgs) Handles Me.Load
        DrawingPictureBox.BackColor = Color.BlanchedAlmond
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub StartRoundButton_Click(sender As Object, e As EventArgs) Handles StartRoundButton.Click
        ThrowDart()
    End Sub
End Class
