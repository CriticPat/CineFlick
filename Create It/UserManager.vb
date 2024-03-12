Public Class UserManager
    Private Sub UserRegiBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UserRegiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserRegiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CineFlickDataSet)

    End Sub

    Private Sub UserManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CineFlickDataSet.UserRegi' table. You can move, or remove it, as needed.
        Me.UserRegiTableAdapter.Fill(Me.CineFlickDataSet.UserRegi)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
        LoginScreen.Show()
    End Sub
End Class