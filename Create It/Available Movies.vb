Public Class AvailableMovies
    Private Sub AvailableTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btMovie4.Click, btnMovie8.Click, btnMovie7.Click, btnMovie6.Click, btnMovie5.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs)
        Me.Hide()
        LoginScreen.Show()

    End Sub

    Private Sub GoBackToLoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoBackToLoginToolStripMenuItem.Click
        Me.Hide()
        LoginScreen.Show()
    End Sub

    Private Sub AboutAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutAppToolStripMenuItem.Click
        About_App.Show()
    End Sub

    Private Sub AboutDeveloperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutDeveloperToolStripMenuItem.Click
        AboutDeveloper.Show()
    End Sub

    Private Sub btnMovie2_Click(sender As Object, e As EventArgs) Handles btnMovie2.Click

    End Sub

    Private Sub btnMovie3_Click(sender As Object, e As EventArgs) Handles btnMovie3.Click

    End Sub

    Private Sub btnMovie1_Click(sender As Object, e As EventArgs) Handles btnMovie1.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub
End Class