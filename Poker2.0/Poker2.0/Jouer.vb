Partial Public Class Jouer

    Public nomJoueur As String
    Public nbJoueurs As Integer
    Public credits As Integer



    Private rnd As New Random()

    Public Sub Shuffle(carte As Carte())
        Dim rando As Integer
        Dim temp As Carte

        For n As Integer = carte.Length - 1 To 0 Step -1
            rando = rnd.Next(0, n + 1)
            temp = carte(n)
            carte(n) = carte(rando)
            carte(rando) = temp
        Next n
    End Sub



    Public Function CreerPaquet()

        Dim paquet(51) As Carte

        Dim chiffreIncremente As Integer = 0


        For index As Integer = 2 To 14
            Dim carte = New Carte(0, "")

            carte.id = index
            carte.categorie = "C"
            paquet(chiffreIncremente) = carte
            chiffreIncremente = chiffreIncremente + 1

        Next

        For index As Integer = 2 To 14
            Dim carte = New Carte(0, "")

            carte.id = index
            carte.categorie = "K"
            paquet(chiffreIncremente) = carte
            chiffreIncremente = chiffreIncremente + 1



        Next

        For index As Integer = 2 To 14
            Dim carte = New Carte(0, "")

            carte.id = index
            carte.categorie = "T"
            paquet(chiffreIncremente) = carte
            chiffreIncremente = chiffreIncremente + 1
        Next

        For index As Integer = 2 To 14
            Dim carte = New Carte(0, "")

            carte.id = index
            carte.categorie = "P"
            paquet(chiffreIncremente) = carte
            chiffreIncremente = chiffreIncremente + 1

        Next



        Shuffle(paquet)


        For Each carte In paquet
            Debug.Write(carte.id)
            Debug.WriteLine(carte.categorie)
        Next


        Return paquet

    End Function

    Private Sub btn_jouer_Click(sender As Object, e As EventArgs) Handles btn_jouer.Click
        Dim paquet = CreerPaquet()




    End Sub
End Class