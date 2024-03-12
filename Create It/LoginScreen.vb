Imports System.Data
Imports System.Data.SqlClient

Public Class LoginScreen
    Dim cmd As SqlCommand
    Dim con As SqlConnection
    Dim rdr As SqlDataReader

    Private Sub LoginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This will change the text from the txtUser and txtPassword
        txtUser.Text = "Enter your username"
        txtUser.ForeColor = Color.Gray

        txtPassword.Text = "Enter your password"
        txtPassword.ForeColor = Color.Gray

    End Sub
    Private Sub lnlblRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnlblRegister.LinkClicked
        Me.Hide()
        SignUp.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged, txtPassword.TextChanged
        If txtPassword.TextLength >= 1 And Not txtPassword.Text = "Enter your password" Then
            btnShowPass.Visible = True
        Else
            btnShowPass.Visible = False
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles pnlUser.Paint

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtUser.Text = "") Then
            MsgBox("Enter the username")
            txtUser.Focus()
            Exit Sub
        End If
        If (txtPassword.Text = "") Then
            MsgBox("Enter the Password")
            txtPassword.Focus()
            Exit Sub
        End If

        Try
            con = New SqlConnection("Data Source=LEODESKTOP;Initial Catalog=CineFlick;Integrated Security=True") ' connection string
            con.Open()
            cmd = New SqlCommand("select * from UserRegi where UserName= '" & txtUser.Text & "' and UserPassword = '" & txtPassword.Text & "'")
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            'If username and password are available then it will open the next form
            If (rdr.Read()) Then
                AvailableMovies.Show()
                Me.Hide()
            Else
                MsgBox("Invalid username or password")
                txtUser.Text = ""
                txtPassword.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtUser_LostFocus(sender As Object, e As EventArgs) Handles txtUser.LostFocus
        ' Restore the watermark text if TextBox loses focus and is empty
        If String.IsNullOrWhiteSpace(txtUser.Text) Then
            txtUser.Text = "Enter your username"
            txtUser.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtUser_GotFocus(sender As Object, e As EventArgs) Handles txtUser.GotFocus
        ' Clear the watermark text when the TextBox gets focus
        If txtUser.ForeColor = Color.Gray AndAlso txtUser.Text = "Enter your username" Then
            txtUser.Text = ""
            txtUser.ForeColor = Color.Black
        End If

    End Sub
    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        ' Restore the watermark text if TextBox loses focus and is empty
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            txtPassword.Text = "Enter your password"
            txtPassword.ForeColor = Color.Gray
            btnShowPass.Visible = False
            txtPassword.PasswordChar = ""

        End If
    End Sub

    Private Sub btnShowPass_MouseDown(sender As Object, e As EventArgs) Handles btnShowPass.MouseDown
        txtPassword.PasswordChar = ""
        btnShowPass.Image = My.Resources.Show
    End Sub

    Private Sub btnShowPass_MouseUp(sender As Object, e As EventArgs) Handles btnShowPass.MouseUp
        txtPassword.PasswordChar = "*"
        btnShowPass.Image = My.Resources.Hide

    End Sub

    Private Sub btnShowPass_Click(sender As Object, e As EventArgs) Handles btnShowPass.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        ' Clear the watermark text when the TextBox gets focus
        If txtPassword.ForeColor = Color.Gray AndAlso txtPassword.Text = "Enter your password" Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Black
            txtPassword.PasswordChar = "*"
        End If

    End Sub

    Private Sub btnShowPass_MouseDown(sender As Object, e As MouseEventArgs) Handles btnShowPass.MouseDown

    End Sub

    Private Sub btnShowPass_MouseUp(sender As Object, e As MouseEventArgs) Handles btnShowPass.MouseUp

    End Sub
End Class