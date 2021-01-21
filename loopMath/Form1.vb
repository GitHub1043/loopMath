Public Class Form1

    Private Sub btnPrime_Click(sender As Object, e As EventArgs) Handles btnPrime.Click
        Dim intNumber As Integer
        Dim intDivisor As Integer = 1

        Do
            intNumber = Val(InputBox("Enter A Positive Integer"))
            If intNumber <= 0 Then
                MessageBox.Show("ERROR!")
            End If
        Loop Until intNumber > 0

        If intNumber < 2 Then
            MessageBox.Show("Not Prime")
        Else
            Do
                intDivisor = intDivisor + 1
            Loop While intNumber Mod intDivisor <> 0
            If intDivisor = intNumber Then
                MessageBox.Show("Prime Number!")
            Else
                MessageBox.Show("Not A Prime Number!")
            End If
        End If

    End Sub

    Private Sub btnGCD_Click(sender As Object, e As EventArgs) Handles btnGCD.Click
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intTemp As Integer

        intNum1 = Val(InputBox("Enter A Number 1"))
        intNum2 = Val(InputBox("Enter A Number 2"))

        Do While (intNum2 > 0)
            intTemp = intNum1 Mod intNum2
            intNum1 = intNum2
            intNum2 = intTemp
        Loop

        MessageBox.Show("GCD= " & intNum1)
    End Sub
End Class
