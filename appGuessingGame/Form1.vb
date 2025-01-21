
'Pseudocode for Guessing Game app.

'Variables: intRandomValue , intUserGuess , intGuessCounter , rndDice
'Elements: btnStart , btnGuess , txtGuess , lblGuess

' Flowchart: User clicks btnStart ->

' intGuessCounter is set to 0, intRandomValue is generated, btnStart is hidden and btnGuess, txtGuess are revealed ->

' User enters a guess into txtGuess and clicks btnGuess -> intGuessCounter is increased by +1, intUserGuess is checked against intRandomValue, and a message is displayed to indicate if intUserGuess is higher or lower than intRandomValue. ->

' If intUserGuess is equal to intRandomValue, a victory message is shown, btnGuess txtGuess are hidden, and the btnStart is revealed to let the user play again.



Public Class Form1

    Dim intRandomValue As Integer
    Dim intGuessCounter As Integer
    Dim rndRandomvalue As Random


    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        btnStart.Visible = False
        btnGuess.Visible = True
        txtGuess.Visible = True

        intGuessCounter = 0
        rndRandomvalue = New Random
        intRandomValue = rndRandomvalue.Next(1, 101)

        lblGuessCounter.Text = intGuessCounter


    End Sub

    Private Sub btnGuess_Click_1(sender As Object, e As EventArgs) Handles btnGuess.Click

        Dim intUserGuess As Integer

        intUserGuess = Val(txtGuess.Text)
        intGuessCounter += 1

        Select Case intUserGuess
            Case <= 0, > 100
                MessageBox.Show("Please enter a value from 1 to 100")
            Case < intRandomValue
                MessageBox.Show("Too high.")
                txtGuess.Text = ""
            Case > intRandomValue
                MessageBox.Show("Too low.")
                txtGuess.Text = ""
            Case = intRandomValue
                btnClap.Visible = True
                MessageBox.Show("You guessed the number.")
                btnStart.Visible = True
                btnGuess.Visible = False
                txtGuess.Visible = False
                btnClap.Visible = False
        End Select





        lblGuessCounter.Text = intGuessCounter

    End Sub

    Private Sub btnClap_Click(sender As Object, e As EventArgs) Handles btnClap.Click

    End Sub
End Class
