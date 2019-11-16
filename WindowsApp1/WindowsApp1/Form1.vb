Public Class Form1
    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        Dim sngNum1 As Integer
        Dim sngNum2 As Integer
        Dim sngResult As Integer

        sngNum1 = Integer.Parse(num1txt.Text)
        sngNum2 = Integer.Parse(num2txt.Text)
        sngResult = sngNum1 + sngNum2
        outputtxt.Text = sngResult.ToString

    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        Dim sngNum1 As Integer
        Dim sngNum2 As Integer
        Dim sngResult As Integer

        sngNum1 = Integer.Parse(num1txt.Text)
        sngNum2 = Integer.Parse(num2txt.Text)
        sngResult = sngNum1 - sngNum2
        outputtxt.Text = sngResult.ToString
    End Sub

    Private Sub multiply_Click(sender As Object, e As EventArgs) Handles multiply.Click
        Dim sngNum1 As Integer
        Dim sngNum2 As Integer
        Dim sngResult As Integer

        sngNum1 = Integer.Parse(num1txt.Text)
        sngNum2 = Integer.Parse(num2txt.Text)
        sngResult = sngNum1 * sngNum2
        outputtxt.Text = sngResult.ToString
    End Sub

    Private Sub divide_Click(sender As Object, e As EventArgs) Handles divide.Click
        Dim sngNum1 As Integer
        Dim sngNum2 As Integer
        Dim sngResult As Integer

        sngNum1 = Integer.Parse(num1txt.Text)
        sngNum2 = Integer.Parse(num2txt.Text)
        sngResult = sngNum1 / sngNum2
        outputtxt.Text = sngResult.ToString
    End Sub

    Private Sub square_Click(sender As Object, e As EventArgs) Handles square.Click
        Dim sngNum1 As Integer
        Dim sngNum2 As Integer
        Dim sngResult As Integer

        sngNum1 = Integer.Parse(num1txt.Text)
        sngNum2 = Integer.Parse(num2txt.Text)
        sngResult = sngNum1 ^ sngNum2
        outputtxt.Text = sngResult.ToString
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        num1txt.Text = ""
        num2txt.Text = ""
        outputtxt.Text = ""
    End Sub

    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Me.Close()
    End Sub
End Class
