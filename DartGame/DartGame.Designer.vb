<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DartGame
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
        Me.DrawingPictureBox = New System.Windows.Forms.PictureBox()
        Me.StartRoundButton = New System.Windows.Forms.Button()
        Me.ReviewButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ThrowDartButton = New System.Windows.Forms.Button()
        Me.DartsLeftTextBox = New System.Windows.Forms.TextBox()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DrawingPictureBox
        '
        Me.DrawingPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawingPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(370, 345)
        Me.DrawingPictureBox.TabIndex = 0
        Me.DrawingPictureBox.TabStop = False
        '
        'StartRoundButton
        '
        Me.StartRoundButton.Location = New System.Drawing.Point(12, 363)
        Me.StartRoundButton.Name = "StartRoundButton"
        Me.StartRoundButton.Size = New System.Drawing.Size(182, 75)
        Me.StartRoundButton.TabIndex = 1
        Me.StartRoundButton.Text = "Start Round"
        Me.StartRoundButton.UseVisualStyleBackColor = True
        '
        'ReviewButton
        '
        Me.ReviewButton.Location = New System.Drawing.Point(388, 363)
        Me.ReviewButton.Name = "ReviewButton"
        Me.ReviewButton.Size = New System.Drawing.Size(182, 75)
        Me.ReviewButton.TabIndex = 2
        Me.ReviewButton.Text = "Review Games"
        Me.ReviewButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(606, 363)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(182, 75)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit Game"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ThrowDartButton
        '
        Me.ThrowDartButton.Enabled = False
        Me.ThrowDartButton.Location = New System.Drawing.Point(200, 363)
        Me.ThrowDartButton.Name = "ThrowDartButton"
        Me.ThrowDartButton.Size = New System.Drawing.Size(182, 75)
        Me.ThrowDartButton.TabIndex = 4
        Me.ThrowDartButton.Text = "Throw Dart"
        Me.ThrowDartButton.UseVisualStyleBackColor = True
        '
        'DartsLeftTextBox
        '
        Me.DartsLeftTextBox.Location = New System.Drawing.Point(388, 12)
        Me.DartsLeftTextBox.Name = "DartsLeftTextBox"
        Me.DartsLeftTextBox.ReadOnly = True
        Me.DartsLeftTextBox.Size = New System.Drawing.Size(84, 22)
        Me.DartsLeftTextBox.TabIndex = 5
        Me.DartsLeftTextBox.Text = "Darts Left: 3"
        '
        'DartGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DartsLeftTextBox)
        Me.Controls.Add(Me.ThrowDartButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ReviewButton)
        Me.Controls.Add(Me.StartRoundButton)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.Name = "DartGame"
        Me.Text = "Form1"
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DrawingPictureBox As PictureBox
    Friend WithEvents StartRoundButton As Button
    Friend WithEvents ReviewButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ThrowDartButton As Button
    Friend WithEvents DartsLeftTextBox As TextBox
End Class
