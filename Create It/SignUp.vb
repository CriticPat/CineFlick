Imports System.Data
Imports System.Data.SqlClient

Public Class SignUp


    Private Sub Sign_Up_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs)
        Me.Hide()
        LoginScreen.Show()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=LEODESKTOP;Initial Catalog=CineFlick;Integrated Security=True"
        con.Open()
        If (txtUsername.Text = "" Or txtPassword.Text = "" Or txtEmail.Text = "" Or txtFName.Text = "" Or txtLName.Text = "" Or txtPhone.Text = "") Then
            MessageBox.Show("Please Enter All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO UserRegi values(@username, @password, @email, @fname, @lname, @gender, @phone)"
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)
            cmd.Parameters.AddWithValue("@email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@fname", txtFName.Text)
            cmd.Parameters.AddWithValue("@lname", txtLName.Text)
            cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Registered", MsgBoxStyle.Information, "Success")
            Me.Hide()
            LoginScreen.Show()

            txtUsername.Clear()
            txtPassword.Clear()
            txtEmail.Clear()
            txtFName.Clear()
            txtLName.Clear()
            txtPhone.Clear()
        End If
        con.Close()
    End Sub

    Private Sub AboutAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutAppToolStripMenuItem.Click
        About_App.Show()
    End Sub

    Private Sub AboutDeveloperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutDeveloperToolStripMenuItem.Click
        AboutDeveloper.Show()
    End Sub

    Private Sub ClearFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearFormToolStripMenuItem.Click
        txtUsername.Clear()
        txtPassword.Clear()
        txtEmail.Clear()
        txtFName.Clear()
        txtLName.Clear()
        txtPhone.Clear()
        cmbGender.SelectedIndex = -1
    End Sub

    Private Sub BackToLoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToLoginToolStripMenuItem.Click
        Me.Hide()
        LoginScreen.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class