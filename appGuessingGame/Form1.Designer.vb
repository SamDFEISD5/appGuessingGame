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
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtGuess = New System.Windows.Forms.TextBox()
        Me.lblGuessCounter = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClap = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGuess
        '
        Me.btnGuess.BackColor = System.Drawing.Color.Red
        Me.btnGuess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuess.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuess.Location = New System.Drawing.Point(79, 56)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(98, 45)
        Me.btnGuess.TabIndex = 0
        Me.btnGuess.Text = "Guess"
        Me.btnGuess.UseVisualStyleBackColor = False
        Me.btnGuess.Visible = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Red
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnStart.Location = New System.Drawing.Point(79, 56)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(98, 45)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'txtGuess
        '
        Me.txtGuess.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!)
        Me.txtGuess.Location = New System.Drawing.Point(59, 107)
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(139, 75)
        Me.txtGuess.TabIndex = 2
        Me.txtGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtGuess.Visible = False
        '
        'lblGuessCounter
        '
        Me.lblGuessCounter.AutoSize = True
        Me.lblGuessCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuessCounter.Location = New System.Drawing.Point(262, 126)
        Me.lblGuessCounter.Name = "lblGuessCounter"
        Me.lblGuessCounter.Size = New System.Drawing.Size(24, 25)
        Me.lblGuessCounter.TabIndex = 3
        Me.lblGuessCounter.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(227, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 40)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Number of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Guesses"
        '
        'btnClap
        '
        Me.btnClap.Image = Global.appGuessingGame.My.Resources.Resources.clap
        Me.btnClap.Location = New System.Drawing.Point(0, -3)
        Me.btnClap.Name = "btnClap"
        Me.btnClap.Size = New System.Drawing.Size(352, 240)
        Me.btnClap.TabIndex = 5
        Me.btnClap.UseVisualStyleBackColor = True
        Me.btnClap.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(351, 237)
        Me.Controls.Add(Me.btnClap)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblGuessCounter)
        Me.Controls.Add(Me.txtGuess)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnGuess)
        Me.Name = "Form1"
        Me.Text = "Guessing Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGuess As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents txtGuess As TextBox
    Friend WithEvents lblGuessCounter As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClap As Button
End Class
