Public Class Form1
    Dim assign_input As Double = 0
    Dim operation As String
    Dim found_expression As Boolean = False
    Dim secondNum As String

    Private Sub numbers_Click(sender As Object, e As EventArgs) Handles ButtonComma.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click, Button0.Click
        Dim b As Button = sender

        If ((txtDisplay.Text = "0") Or (found_expression)) Then
            txtDisplay.Clear()
            txtDisplay.Text = b.Text
            found_expression = False
        ElseIf (b.Text = ",") Then

            If (Not txtDisplay.Text.Contains(",")) Then
                txtDisplay.Text = txtDisplay.Text + b.Text
            End If
        Else
            txtDisplay.Text = txtDisplay.Text + b.Text
        End If

    End Sub

    Private Sub buttonEquals_Click(sender As Object, e As EventArgs) Handles ButtonEquals.Click
        secondNum = txtDisplay.Text
        lblEquation.Text = ""
        Select Case operation
            Case "+"
                txtDisplay.Text = (assign_input + Double.Parse(txtDisplay.Text)).ToString
            Case "-"
                txtDisplay.Text = (assign_input - Double.Parse(txtDisplay.Text)).ToString
            Case "×"
                txtDisplay.Text = (assign_input * Double.Parse(txtDisplay.Text)).ToString
            Case "÷"
                txtDisplay.Text = (assign_input / Double.Parse(txtDisplay.Text)).ToString

        End Select
        assign_input = Double.Parse(txtDisplay.Text)
        operation = ""


    End Sub

    Private Sub buttonPlusMinus_Click(sender As Object, e As EventArgs) Handles ButtonPlusMinus.Click
        If (txtDisplay.Text.Contains("-")) Then
            txtDisplay.Text = txtDisplay.Text.Remove(0, 1)
        Else
            txtDisplay.Text = "-" + txtDisplay.Text
        End If
    End Sub

    Private Sub buttonC_Click(sender As Object, e As EventArgs) Handles buttonC.Click
        txtDisplay.Text = "0"
        lblEquation.Text = ""
        txtDisplay.Text = "0"
    End Sub

    Private Sub buttonCE_Click(sender As Object, e As EventArgs) Handles buttonCE.Click
        txtDisplay.Text = "0"
    End Sub

    Private Sub buttonPercent_Click(sender As Object, e As EventArgs) Handles buttonPercent.Click
        Dim a As Double
        a = Convert.ToDouble(txtDisplay.Text) / Convert.ToDouble(100)
        txtDisplay.Text = System.Convert.ToString(a)
    End Sub

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles buttonPower.Click
        Dim a As Double
        Dim b As Button = sender
        operation = b.Text
        assign_input = Double.Parse(txtDisplay.Text)
        found_expression = True
        lblEquation.Text = "sqr(" & assign_input & ")"
        a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text)
        txtDisplay.Text = System.Convert.ToString(a)
    End Sub

    Private Sub btnMultiplicateInverse_Click(sender As Object, e As EventArgs) Handles buttonMultiplicateInverse.Click
        Dim a As Double
        Dim b As Button = sender
        operation = b.Text
        assign_input = Double.Parse(txtDisplay.Text)
        found_expression = True
        lblEquation.Text = "1/" & "(" & txtDisplay.Text & ")"

        If (txtDisplay.Text = 0) Then
            txtDisplay.Text = "Sıfıra Bölünemez"
        Else
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtDisplay.Text))
            txtDisplay.Text = System.Convert.ToString(a)
        End If
    End Sub

    Private Sub buttonSquareRoot_Click(sender As Object, e As EventArgs) Handles buttonSquareRoot.Click
        Dim a As Double
        lblEquation.Text = "Sqrt(" & (txtDisplay.Text) & ")"
        a = Math.Sqrt(txtDisplay.Text)
        txtDisplay.Text = System.Convert.ToString(a)
    End Sub

    Private Sub buttonBackSpace_Click(sender As Object, e As EventArgs) Handles buttonBackspace.Click
        If (txtDisplay.Text.Length > 0) Then
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1)
        End If
        If (txtDisplay.Text = "") Then
            txtDisplay.Text = "0"
        End If
    End Sub

    Private Sub operation_Click(sender As Object, e As EventArgs) Handles ButtonSubtraction.Click, ButtonMultiplication.Click, ButtonDividing.Click, ButtonAddition.Click
        Dim b As Button = sender
        If (assign_input <> 0) Then
            ButtonEquals.PerformClick()
            found_expression = True
            operation = b.Text
            lblEquation.Text = assign_input & "   " & operation
        Else
            operation = b.Text
            assign_input = Double.Parse(txtDisplay.Text)
            found_expression = True
            lblEquation.Text = assign_input & "   " & operation

        End If

    End Sub
End Class
