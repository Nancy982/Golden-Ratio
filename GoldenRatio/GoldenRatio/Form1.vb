'Nancy Medina
'CS105
'Spring-2020

'I pledge that I have neither given nor received help from anyone other than the instructor and TA
'for all program components included here.

Public Class Form1

    Private Sub btnFibs_Click(sender As Object, e As EventArgs) Handles btnFibs.Click
        'declare variables for user Input, fib1, fib2, fib3, num fibs, dblDiff, dblRatio, and dblGOLDEN_RATIO
        Const dblGOLDEN_RATIO As Double = 1.6180339887
        Dim dblUserInput As Double
        Dim intFib1 As Integer
        Dim intFib2 As Integer
        Dim intFib3 As Integer
        Dim intNumFibs As Integer
        Dim dblDiff As Double
        Dim dblRatio As Double

        'declare a String variable to store all fibs gnerated
        Dim strDisplay As String
        'declare a Boolean variable to serve as loop termination condition
        Dim blnFlag As Boolean

        'collect user input from Text property of txtUserInput
        dblUserInput = CDbl(txtUserInput.Text)

        'initialize variables to prepare for entering the loop
        'set up the first three fibs; 0,1,1
        intFib1 = 0
        intFib2 = 1
        intFib3 = intFib1 + intFib2
        'assign 3 to the num fibs variable, since we have 3 fibs before entering the loop
        intNumFibs = 3

        'divide intFib3 by intFib2 to find the ratio
        dblRatio = (intFib3 / intFib2)
        'subtract the golden ratio from the ratio above
        dblDiff = Math.Abs(dblGOLDEN_RATIO - dblRatio)

        'format the String variable with the info we have now
        strDisplay = "Fibonacci numbers generated: " & vbCrLf
        strDisplay &= intFib1 & ", " & intFib2 & ", " & intFib3

        'initialize the Boolean with the correct Boolean expression so it will correctly control the loop
        blnFlag = (dblDiff >= dblUserInput)

        'impliment loop to generate remaining fibs
        Do While blnFlag
            'reassign the three fibs to get the next fib num int intFib3
            'the new fib1 is the old fib2
            intFib1 = intFib2
            'the new fib2 is the old fib3
            intFib2 = intFib3
            'the new fib3 is the sum of the new fib1 and the new fib2
            intFib3 = intFib1 + intFib2
            'update dblRatio and dblDiff
            dblRatio = (intFib3 / intFib2)
            dblDiff = Math.Abs(dblGOLDEN_RATIO - dblRatio)
            'increment intNumFibs by 1, since we now have one more fib
            intNumFibs += 1
            'APPEND the newest fib to the String variable
            strDisplay &= ", " & intFib3
            blnFlag = (dblDiff >= dblUserInput)
        Loop
        'display all fibs generated in the Text property of txtDisplayFibs
        txtDisplayFibs.Text = strDisplay
        'display how many fibs in the Text property of lblNumFibs
        lblNumFibs.Text = intNumFibs.ToString()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the TextBox controls
        txtDisplayFibs.Text = String.Empty
        txtUserInput.Text = String.Empty
        lblNumFibs.Text = String.Empty

        'Set the focus to the txtUserInput TextBox; this designates the position of the blinking cursor
        txtUserInput.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub
End Class
