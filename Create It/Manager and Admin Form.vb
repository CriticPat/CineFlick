Public Class Manager_and_Admin_Form
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub BackToLoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToLoginToolStripMenuItem.Click
        Me.Hide()
        LoginScreen.Show()

    End Sub

    Private Sub AboutAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutAppToolStripMenuItem.Click
        About_App.Show()
    End Sub

    Private Sub AboutDeveloperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutDeveloperToolStripMenuItem.Click
        AboutDeveloper.Show()
    End Sub

    Private Sub btnUserManager_Click(sender As Object, e As EventArgs) Handles btnUserManager.Click
        Me.Hide()
        UserManager.Show()
    End Sub

    Private Sub btnMovieManager_Click(sender As Object, e As EventArgs) Handles btnMovieManager.Click
        MsgBox("Under Development")
    End Sub
End Class