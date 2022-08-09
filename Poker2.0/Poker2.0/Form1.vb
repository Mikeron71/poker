Public Class Form1
    Private Sub btn_lancer_Click(sender As Object, e As EventArgs) Handles btn_lancer.Click
        Jouer.Show()
        Jouer.nbJoueurs = nud_nbJoueurs.Value
        Jouer.nomJoueur = tb_nom.Text
        Jouer.CreerPaquet()
        Me.Hide()

    End Sub
End Class
