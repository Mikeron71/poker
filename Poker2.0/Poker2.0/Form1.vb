Public Class Form1

    Public nomJoueur As String
    Public nbJoueurs As Integer



    Private Sub btn_lancer_Click(sender As Object, e As EventArgs) Handles btn_lancer.Click
        Jouer.Show()
        nbJoueurs = nud_nbJoueurs.Value
        nomJoueur = tb_nom.Text
        Me.Hide()

    End Sub
End Class
