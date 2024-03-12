
Public Class Form2
        Public totaltickets As Integer = 0

    Private Sub ToggleButtonColor(sender As Button)
        If sender.BackColor = Color.FromArgb(195, 37, 48) Then
            If totaltickets < 10 Then
                sender.BackColor = Color.FromArgb(60, 218, 207)
                sender.ForeColor = Color.Black
                totaltickets += 1
            Else
                MessageBox.Show("Maximum number of tickets reached", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            sender.BackColor = Color.FromArgb(195, 37, 48)
            sender.ForeColor = Color.White
            If totaltickets > 0 Then
                totaltickets -= 1
            End If
        End If
        lblMovieID.Text = totaltickets.ToString()
    End Sub

    Private Sub A1_Click(sender As Object, e As EventArgs) Handles A1.Click
        ToggleButtonColor(A1)
    End Sub

    Private Sub A2_Click(sender As Object, e As EventArgs) Handles A2.Click
        ToggleButtonColor(A2)
    End Sub

    Private Sub A3_Click(sender As Object, e As EventArgs) Handles A3.Click
        ToggleButtonColor(A3)
    End Sub

    Private Sub A4_Click(sender As Object, e As EventArgs) Handles A4.Click
        ToggleButtonColor(A4)
    End Sub

    Private Sub A5_Click(sender As Object, e As EventArgs) Handles A5.Click
        ToggleButtonColor(A5)
    End Sub

    Private Sub A6_Click(sender As Object, e As EventArgs) Handles A6.Click
        ToggleButtonColor(A6)
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        ToggleButtonColor(B1)
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        ToggleButtonColor(B2)
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        ToggleButtonColor(B3)
    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        ToggleButtonColor(B4)
    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        ToggleButtonColor(B5)
    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        ToggleButtonColor(B6)
    End Sub

    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
        ToggleButtonColor(B7)
    End Sub

    Private Sub C1_Click(sender As Object, e As EventArgs) Handles C1.Click
        ToggleButtonColor(C1)
    End Sub

    Private Sub C2_Click(sender As Object, e As EventArgs) Handles C2.Click
        ToggleButtonColor(C2)
    End Sub

    Private Sub C3_Click(sender As Object, e As EventArgs) Handles C3.Click
        ToggleButtonColor(C3)
    End Sub

    Private Sub C4_Click(sender As Object, e As EventArgs) Handles C4.Click
        ToggleButtonColor(C4)
    End Sub

    Private Sub C5_Click(sender As Object, e As EventArgs) Handles C5.Click
        ToggleButtonColor(C5)
    End Sub

    Private Sub C6_Click(sender As Object, e As EventArgs) Handles C6.Click
        ToggleButtonColor(C6)
    End Sub

    Private Sub C7_Click(sender As Object, e As EventArgs) Handles C7.Click
        ToggleButtonColor(C7)
    End Sub

    Private Sub D1_Click(sender As Object, e As EventArgs) Handles D1.Click
        ToggleButtonColor(D1)
    End Sub

    Private Sub D2_Click(sender As Object, e As EventArgs) Handles D2.Click
        ToggleButtonColor(D2)
    End Sub

    Private Sub D3_Click(sender As Object, e As EventArgs) Handles D3.Click
        ToggleButtonColor(D3)
    End Sub

    Private Sub D4_Click(sender As Object, e As EventArgs) Handles D4.Click
        ToggleButtonColor(D4)
    End Sub

    Private Sub D5_Click(sender As Object, e As EventArgs) Handles D5.Click
        ToggleButtonColor(D5)
    End Sub

    Private Sub D6_Click(sender As Object, e As EventArgs) Handles D6.Click
        ToggleButtonColor(D6)
    End Sub

    Private Sub D7_Click(sender As Object, e As EventArgs) Handles D7.Click
        ToggleButtonColor(D7)
    End Sub

    Private Sub E1_Click(sender As Object, e As EventArgs) Handles E1.Click
        ToggleButtonColor(E1)
    End Sub
    Private Sub E2_Click(sender As Object, e As EventArgs) Handles E2.Click
        ToggleButtonColor(E2)
    End Sub

    Private Sub E3_Click(sender As Object, e As EventArgs) Handles E3.Click
        ToggleButtonColor(E3)
    End Sub

    Private Sub E4_Click(sender As Object, e As EventArgs) Handles E4.Click
        ToggleButtonColor(E4)
    End Sub

    Private Sub E5_Click(sender As Object, e As EventArgs) Handles E5.Click
        ToggleButtonColor(E5)
    End Sub

    Private Sub E6_Click(sender As Object, e As EventArgs) Handles E6.Click
        ToggleButtonColor(E6)
    End Sub

    Private Sub E7_Click(sender As Object, e As EventArgs) Handles E7.Click
        ToggleButtonColor(E7)
    End Sub

    Private Sub E8_Click(sender As Object, e As EventArgs) Handles E8.Click
        ToggleButtonColor(E8)
    End Sub

    Private Sub F1_Click(sender As Object, e As EventArgs) Handles F1.Click
        ToggleButtonColor(F1)
    End Sub

    Private Sub F2_Click(sender As Object, e As EventArgs) Handles F2.Click
        ToggleButtonColor(F2)
    End Sub

    Private Sub F3_Click(sender As Object, e As EventArgs) Handles F3.Click
        ToggleButtonColor(F3)
    End Sub

    Private Sub F4_Click(sender As Object, e As EventArgs) Handles F4.Click
        ToggleButtonColor(F4)
    End Sub

    Private Sub F5_Click(sender As Object, e As EventArgs) Handles F5.Click
        ToggleButtonColor(F5)
    End Sub

    Private Sub F6_Click(sender As Object, e As EventArgs) Handles F6.Click
        ToggleButtonColor(F6)
    End Sub

    Private Sub F7_Click(sender As Object, e As EventArgs) Handles F7.Click
        ToggleButtonColor(F7)
    End Sub

    Private Sub F8_Click(sender As Object, e As EventArgs) Handles F8.Click
        ToggleButtonColor(F8)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        AvailableMovies.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
        Transaction.Show()

    End Sub
End Class