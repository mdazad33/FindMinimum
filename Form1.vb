Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Begining of error message
        If IsNumeric(txtNum1.Text) = False Then
            txtNum1.Clear()
            MessageBox.Show("First input is Not a Number, Please enter a Number!!!")
            Return
        End If

        If IsNumeric(txtNum2.Text) = False Then
            txtNum2.Clear()
            MessageBox.Show("Second input is Not a Number, Please enter a Number!!!")
            Return
        End If

        If IsNumeric(txtNum3.Text) = False Then
            txtNum3.Clear()
            MessageBox.Show("Third input is Not a Number, Please enter a Number!!!")
            Return
        End If        'ENDING OF ERROR MESSAGE


        'INPUTS of numbers
        Dim first As Double = txtNum1.Text
        Dim second As Double = txtNum2.Text
        Dim third As Double = txtNum3.Text

        'Calling the funtion 'minimum'
        txtMinNum.Text = minimum(first, second, third)
    End Sub
    'This is funtion "minimum", which finds the minimum number among 3 inputs
    Function minimum(first As Double, second As Double, third As Double) As Double
        Dim min As Double
        min = first

        If second < min Then
            min = second
        End If
        If third < min Then
            min = third
        End If
        Return min    'returning minimum number

    End Function
    'Clearing all the input data once the minimum number is found and displayed
    Private Sub txtMinNum_TextChanged(sender As Object, e As EventArgs) Handles txtMinNum.TextChanged
        txtNum1.Clear()
        txtNum2.Clear()
        txtNum3.Clear()
    End Sub

End Class
