Public Class Form1
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        txtName.Text = "Hello " & txtName.Text
    End Sub

    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click

        MessageBox.Show("Hello " & txtName.Text,
                        "Hello " & txtName.Text)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddValues_Click(sender As Object, e As EventArgs) Handles btnAddValues.Click

        Try
            Dim firstNum As Integer = CInt(txtAddValue1.Text)
            Dim secondNum As Integer = CInt(txtAddValue2.Text)
            Dim sum = firstNum + secondNum
            txtAnswer.Text = CStr(sum)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Please enter valid numbers to sum", "Error")
        Catch ex As Exception
            MessageBox.Show("An unknown error occured", "Error")
        End Try
    End Sub

End Class
