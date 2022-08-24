Public Class Form1
    Public nbJoueurs As Integer

    Private Sub btn_lancer_Click(sender As Object, e As EventArgs) Handles btn_lancer.Click
        Jouer.Show()
        Me.Hide()
    End Sub

    Private Sub nud_nbJoueurs_ValueChanged(sender As Object, e As EventArgs) Handles nud_nbJoueurs.ValueChanged
        nbJoueurs = nud_nbJoueurs.Value
    End Sub
End Class
