Public Class Form1
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Clear()
        PiecesTextBox.Clear()


    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Dim result As Integer =
 MessageBox.Show("Do you want to close the form?", "Exit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()



        End If
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim piecescompleted As Integer = Integer.Parse(PiecesTextBox.Text)
        Dim price As Integer

        If piecescompleted >= 1 And
            piecescompleted <= 200 Then
            price = 60

        ElseIf piecescompleted >= 201 And
               piecescompleted <= 400 Then
            price = 65

        ElseIf piecescompleted >= 401 And
                piecescompleted <= 600 Then
            price = 70
        ElseIf piecescompleted > 601 Then
            price = 75
        End If
        Dim amountearned As Integer = price * piecescompleted





        MessageBox.Show("Amount Earned:" + amountearned.ToString("C1"))












    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click

        Dim price As Decimal

        Dim piecescompleted As Integer = Integer.Parse(PiecesTextBox.Text)

        If piecescompleted >= 1 And
            piecescompleted <= 200 Then
            price = 60

        ElseIf piecescompleted >= 201 And
               piecescompleted <= 400 Then
            price = 65

        ElseIf piecescompleted >= 401 And
                piecescompleted <= 600 Then
            price = 70
        ElseIf piecescompleted > 601 Then
            price = 75
        End If
        Dim totalpay As Integer = price * piecescompleted
        Dim averagepay As Decimal = totalpay / piecescompleted


        MessageBox.Show("Total Pay is:" + totalpay.ToString("C1") + vbCrLf + "Total number of pieces are:" + piecescompleted.ToString("N") + vbCrLf + "Average Pay is:" + averagepay.ToString("C2"))




    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged

    End Sub
End Class
