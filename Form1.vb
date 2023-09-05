Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtFirstNumber.TextChanged, txtSecondNumber.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblFirstNumber.Click, lblSecondNumber.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click



        Dim FirstNumber As Integer
        Dim SecondNumber As Integer
        Dim Answer As Integer

        FirstNumber = txtFirstNumber.Text
        SecondNumber = txtSecondNumber.Text

        'Addition
        Answer = FirstNumber + SecondNumber
        MessageBox.Show(FirstNumber & "+" & SecondNumber & "=" & "" & Answer)

        'Subtration
        Answer = FirstNumber - SecondNumber
        MessageBox.Show(FirstNumber & "-" & SecondNumber & "=" & "" & Answer)

        'Multiplication
        Answer = FirstNumber * SecondNumber
        MessageBox.Show(FirstNumber & "*" & SecondNumber & "=" & "" & Answer)

        'Division
        Answer = FirstNumber / SecondNumber
        MessageBox.Show(FirstNumber & "/" & SecondNumber & "=" & "" & Answer)

        'Power
        Answer = FirstNumber ^ SecondNumber
        MessageBox.Show(FirstNumber & "^" & SecondNumber & "=" & "" & Answer)

        'Integer Division
        Answer = FirstNumber \ SecondNumber
        MessageBox.Show(FirstNumber & "\" & SecondNumber & "=" & "" & Answer)



    End Sub
End Class
