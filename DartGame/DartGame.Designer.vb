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
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ModeTextBox = New System.Windows.Forms.TextBox()
        Me.RoundTextBox = New System.Windows.Forms.TextBox()
        Me.ReviewGroupBox = New System.Windows.Forms.GroupBox()
        Me.RoundComboBox = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
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
        Me.StartRoundButton.UseVisualStyleBackColor = True
        '
        'ReviewButton
        '
        Me.ReviewButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReviewButton.Location = New System.Drawing.Point(392, 299)
        Me.ReviewButton.Name = "ReviewButton"
        Me.ReviewButton.Size = New System.Drawing.Size(80, 58)
        Me.ReviewButton.TabIndex = 3
        Me.ReviewButton.Text = "Review Games"
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
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "E&xit Game"
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
        Me.DartsLeftTextBox.Size = New System.Drawing.Size(108, 22)
        Me.DartsLeftTextBox.TabIndex = 8
        Me.DartsLeftTextBox.Text = "Darts Left: 0"
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearButton.Location = New System.Drawing.Point(490, 299)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(80, 58)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "Clear Data"
        Me.ClearButton.UseVisualStyleBackColor = True
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
        Me.ModeTextBox.Size = New System.Drawing.Size(108, 22)
        Me.ModeTextBox.TabIndex = 6
        Me.ModeTextBox.Text = "Mode: Review"
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
        Me.RoundTextBox.Size = New System.Drawing.Size(108, 22)
        Me.RoundTextBox.TabIndex = 7
        Me.RoundTextBox.Text = "Round: 0"
        '
        'ReviewGroupBox
        '
        Me.ReviewGroupBox.Controls.Add(Me.ListBox1)
        Me.ReviewGroupBox.Controls.Add(Me.RoundComboBox)
        Me.ReviewGroupBox.Location = New System.Drawing.Point(576, 12)
        Me.ReviewGroupBox.Name = "ReviewGroupBox"
        Me.ReviewGroupBox.Size = New System.Drawing.Size(212, 426)
        Me.ReviewGroupBox.TabIndex = 9
        Me.ReviewGroupBox.TabStop = False
        Me.ReviewGroupBox.Text = "ReviewGroupBox"
        '
        'RoundComboBox
        '
        Me.RoundComboBox.FormattingEnabled = True
        Me.RoundComboBox.Location = New System.Drawing.Point(6, 21)
        Me.RoundComboBox.Name = "RoundComboBox"
        Me.RoundComboBox.Size = New System.Drawing.Size(200, 24)
        Me.RoundComboBox.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(6, 288)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(200, 132)
        Me.ListBox1.TabIndex = 1
        '
        'DartGame
        '
        Me.AcceptButton = Me.ThrowDartButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReviewGroupBox)
        Me.Controls.Add(Me.RoundTextBox)
        Me.Controls.Add(Me.ModeTextBox)
        Me.Controls.Add(Me.ClearButton)
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
    Friend WithEvents ClearButton As Button
    Friend WithEvents ModeTextBox As TextBox
    Friend WithEvents RoundTextBox As TextBox
    Friend WithEvents ReviewGroupBox As GroupBox
    Friend WithEvents RoundComboBox As ComboBox
    Friend WithEvents ListBox1 As ListBox
End Class
