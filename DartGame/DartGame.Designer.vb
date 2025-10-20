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
        Me.components = New System.ComponentModel.Container()
        Me.DrawingPictureBox = New System.Windows.Forms.PictureBox()
        Me.StartRoundButton = New System.Windows.Forms.Button()
        Me.ReviewButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ThrowDartButton = New System.Windows.Forms.Button()
        Me.DartsLeftTextBox = New System.Windows.Forms.TextBox()
        Me.ModeTextBox = New System.Windows.Forms.TextBox()
        Me.RoundTextBox = New System.Windows.Forms.TextBox()
        Me.ReviewGroupBox = New System.Windows.Forms.GroupBox()
        Me.RoundComboBox = New System.Windows.Forms.ComboBox()
        Me.Dart1TextBox = New System.Windows.Forms.TextBox()
        Me.Dart2TextBox = New System.Windows.Forms.TextBox()
        Me.Dart3TextBox = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReviewGroupBox.SuspendLayout()
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
        Me.ToolTip1.SetToolTip(Me.DrawingPictureBox, "The dart board")
        '
        'StartRoundButton
        '
        Me.StartRoundButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartRoundButton.Location = New System.Drawing.Point(12, 363)
        Me.StartRoundButton.Name = "StartRoundButton"
        Me.StartRoundButton.Size = New System.Drawing.Size(182, 75)
        Me.StartRoundButton.TabIndex = 1
        Me.StartRoundButton.Text = "Start Round"
        Me.ToolTip1.SetToolTip(Me.StartRoundButton, "Starts the game and enters ""Play"" Mode")
        Me.StartRoundButton.UseVisualStyleBackColor = True
        '
        'ReviewButton
        '
        Me.ReviewButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReviewButton.Location = New System.Drawing.Point(388, 282)
        Me.ReviewButton.Name = "ReviewButton"
        Me.ReviewButton.Size = New System.Drawing.Size(182, 75)
        Me.ReviewButton.TabIndex = 6
        Me.ReviewButton.Text = "Review Games"
        Me.ToolTip1.SetToolTip(Me.ReviewButton, "Allows you to review the selected round")
        Me.ReviewButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(388, 363)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(182, 75)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "E&xit Game"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Closes the game")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ThrowDartButton
        '
        Me.ThrowDartButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ThrowDartButton.Enabled = False
        Me.ThrowDartButton.Location = New System.Drawing.Point(200, 363)
        Me.ThrowDartButton.Name = "ThrowDartButton"
        Me.ThrowDartButton.Size = New System.Drawing.Size(182, 75)
        Me.ThrowDartButton.TabIndex = 2
        Me.ThrowDartButton.Text = "Throw& Dart"
        Me.ToolTip1.SetToolTip(Me.ThrowDartButton, "Throws a dart on the picture box")
        Me.ThrowDartButton.UseVisualStyleBackColor = True
        '
        'DartsLeftTextBox
        '
        Me.DartsLeftTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DartsLeftTextBox.Enabled = False
        Me.DartsLeftTextBox.Location = New System.Drawing.Point(388, 68)
        Me.DartsLeftTextBox.Name = "DartsLeftTextBox"
        Me.DartsLeftTextBox.ReadOnly = True
        Me.DartsLeftTextBox.Size = New System.Drawing.Size(182, 22)
        Me.DartsLeftTextBox.TabIndex = 8
        Me.DartsLeftTextBox.Text = "Darts Left: 0"
        Me.ToolTip1.SetToolTip(Me.DartsLeftTextBox, "The amount of darts you have left")
        '
        'ModeTextBox
        '
        Me.ModeTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModeTextBox.Enabled = False
        Me.ModeTextBox.Location = New System.Drawing.Point(388, 12)
        Me.ModeTextBox.Name = "ModeTextBox"
        Me.ModeTextBox.ReadOnly = True
        Me.ModeTextBox.Size = New System.Drawing.Size(182, 22)
        Me.ModeTextBox.TabIndex = 6
        Me.ModeTextBox.Text = "Mode: Review"
        Me.ToolTip1.SetToolTip(Me.ModeTextBox, "The current mode")
        '
        'RoundTextBox
        '
        Me.RoundTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RoundTextBox.Enabled = False
        Me.RoundTextBox.Location = New System.Drawing.Point(388, 40)
        Me.RoundTextBox.Name = "RoundTextBox"
        Me.RoundTextBox.ReadOnly = True
        Me.RoundTextBox.Size = New System.Drawing.Size(182, 22)
        Me.RoundTextBox.TabIndex = 7
        Me.RoundTextBox.Text = "Round: 0"
        Me.ToolTip1.SetToolTip(Me.RoundTextBox, "Round number")
        '
        'ReviewGroupBox
        '
        Me.ReviewGroupBox.Controls.Add(Me.RoundComboBox)
        Me.ReviewGroupBox.Location = New System.Drawing.Point(388, 226)
        Me.ReviewGroupBox.Name = "ReviewGroupBox"
        Me.ReviewGroupBox.Size = New System.Drawing.Size(182, 50)
        Me.ReviewGroupBox.TabIndex = 4
        Me.ReviewGroupBox.TabStop = False
        Me.ReviewGroupBox.Text = "Select A Round"
        Me.ToolTip1.SetToolTip(Me.ReviewGroupBox, "Selects a round to review")
        '
        'RoundComboBox
        '
        Me.RoundComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RoundComboBox.FormattingEnabled = True
        Me.RoundComboBox.Location = New System.Drawing.Point(6, 21)
        Me.RoundComboBox.Name = "RoundComboBox"
        Me.RoundComboBox.Size = New System.Drawing.Size(172, 24)
        Me.RoundComboBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.RoundComboBox, "Selects a Round to Review")
        '
        'Dart1TextBox
        '
        Me.Dart1TextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dart1TextBox.Enabled = False
        Me.Dart1TextBox.Location = New System.Drawing.Point(388, 96)
        Me.Dart1TextBox.Name = "Dart1TextBox"
        Me.Dart1TextBox.ReadOnly = True
        Me.Dart1TextBox.Size = New System.Drawing.Size(182, 22)
        Me.Dart1TextBox.TabIndex = 10
        Me.Dart1TextBox.Text = "Dart1's Position: "
        Me.ToolTip1.SetToolTip(Me.Dart1TextBox, "The position of dart 1")
        '
        'Dart2TextBox
        '
        Me.Dart2TextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dart2TextBox.Enabled = False
        Me.Dart2TextBox.Location = New System.Drawing.Point(388, 124)
        Me.Dart2TextBox.Name = "Dart2TextBox"
        Me.Dart2TextBox.ReadOnly = True
        Me.Dart2TextBox.Size = New System.Drawing.Size(182, 22)
        Me.Dart2TextBox.TabIndex = 11
        Me.Dart2TextBox.Text = "Dart2's Position:"
        Me.ToolTip1.SetToolTip(Me.Dart2TextBox, "The position of dart 2")
        '
        'Dart3TextBox
        '
        Me.Dart3TextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dart3TextBox.Enabled = False
        Me.Dart3TextBox.Location = New System.Drawing.Point(388, 152)
        Me.Dart3TextBox.Name = "Dart3TextBox"
        Me.Dart3TextBox.ReadOnly = True
        Me.Dart3TextBox.Size = New System.Drawing.Size(182, 22)
        Me.Dart3TextBox.TabIndex = 12
        Me.Dart3TextBox.Text = "Dart3's Position:"
        Me.ToolTip1.SetToolTip(Me.Dart3TextBox, "The position of dart 3")
        '
        'DartGame
        '
        Me.AcceptButton = Me.ThrowDartButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Dart3TextBox)
        Me.Controls.Add(Me.Dart2TextBox)
        Me.Controls.Add(Me.Dart1TextBox)
        Me.Controls.Add(Me.ReviewGroupBox)
        Me.Controls.Add(Me.RoundTextBox)
        Me.Controls.Add(Me.ModeTextBox)
        Me.Controls.Add(Me.DartsLeftTextBox)
        Me.Controls.Add(Me.ThrowDartButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ReviewButton)
        Me.Controls.Add(Me.StartRoundButton)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.Name = "DartGame"
        Me.Text = "DartGame"
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReviewGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DrawingPictureBox As PictureBox
    Friend WithEvents StartRoundButton As Button
    Friend WithEvents ReviewButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ThrowDartButton As Button
    Friend WithEvents DartsLeftTextBox As TextBox
    Friend WithEvents ModeTextBox As TextBox
    Friend WithEvents RoundTextBox As TextBox
    Friend WithEvents ReviewGroupBox As GroupBox
    Friend WithEvents RoundComboBox As ComboBox
    Friend WithEvents Dart1TextBox As TextBox
    Friend WithEvents Dart2TextBox As TextBox
    Friend WithEvents Dart3TextBox As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
