Partial Public Class Jouer

    Public paquet = CreerPaquet()
    Dim adversaires As New List(Of Player)
    Dim mainJoueur As New List(Of Carte)


    Public Sub AfficherMain(main)

        Dim carte1 As String = main(0).categorie.ToString() + main(0).id.ToString
        Dim carte2 As String = main(1).categorie.ToString() + main(1).id.ToString
        Dim carte3 As String = main(2).categorie.ToString() + main(2).id.ToString
        Dim carte4 As String = main(3).categorie.ToString() + main(3).id.ToString
        Dim carte5 As String = main(4).categorie.ToString() + main(4).id.ToString
        pb_carte1.Image = Image.FromFile("..\..\..\images\" + carte1 + ".jpg")
        pb_carte2.Image = Image.FromFile("..\..\..\images\" + carte2 + ".jpg")
        pb_carte3.Image = Image.FromFile("..\..\..\images\" + carte3 + ".jpg")
        pb_carte4.Image = Image.FromFile("..\..\..\images\" + carte4 + ".jpg")
        pb_carte5.Image = Image.FromFile("..\..\..\images\" + carte5 + ".jpg")
    End Sub



    Public Shared Sub Shuffle(carte As List(Of Carte))
        Dim rnd As New Random()
        Dim rando As Integer
        Dim temp As Carte

        For n As Integer = 52 - 1 To 0 Step -1
            rando = rnd.Next(0, n + 1)
            temp = carte(n)
            carte(n) = carte(rando)
            carte(rando) = temp
        Next n
    End Sub

    Public Sub CreerJoueurs(nb As Integer)

        For n As Integer = 1 To nb
            Dim player As New Player(nb)
            adversaires.Add(player)
        Next



    End Sub


    Public Function CreerPaquet()

        Dim paquet = New List(Of Carte)


        For index As Integer = 2 To 14
            Dim carte = New Carte(0, "")

            carte.id = index
            carte.categorie = "C"
            paquet.Add(carte)


        Next

        For index As Integer = 2 To 14
            Dim carte = New Carte(0, "")

            carte.id = index
            carte.categorie = "K"
            paquet.Add(carte)


        Next

        For index As Integer = 2 To 14
            Dim carte = New Carte(0, "")

            carte.id = index
            carte.categorie = "T"
            paquet.Add(carte)

        Next

        For index As Integer = 2 To 14
            Dim carte = New Carte(0, "")

            carte.id = index
            carte.categorie = "P"
            paquet.Add(carte)


        Next


        Shuffle(paquet)



        'For Each carte In paquet
        '    Debug.Write(carte.id)
        '    Debug.WriteLine(carte.categorie)
        'Next


        Return paquet

    End Function

    Public Sub btn_jouer_Click(sender As Object, e As EventArgs) Handles btn_jouer.Click

        mainJoueur.Clear()
        paquet = CreerPaquet()
        CreerJoueurs(Form1.nbJoueurs)



        'MainTEST-----------------------------------

        Dim mainTest As New List(Of Carte)
        Dim ctest1 = New Carte(10, "T")
        Dim ctest2 = New Carte(10, "k")
        Dim ctest3 = New Carte(10, "T")
        Dim ctest4 = New Carte(9, "T")
        Dim ctest5 = New Carte(9, "T")

        mainTest.Add(ctest1)
        mainTest.Add(ctest2)
        mainTest.Add(ctest3)
        mainTest.Add(ctest4)
        mainTest.Add(ctest5)

        'Valider(mainTest)



        For index As Integer = 0 To 4
            Dim carte = paquet(0)
            mainJoueur.Add(carte)
            paquet.RemoveAt(0)
        Next


        'For Each carte In mainJoueur
        '    Debug.Write(carte.id)
        '    Debug.WriteLine(carte.categorie)
        'Next
        'AfficherMain(mainJoueur)




        For index As Integer = 0 To Form1.nbJoueurs - 1
            Dim mainPc As New List(Of Carte)

            For i As Integer = 0 To 4
                Dim carte = paquet(0)
                'Debug.Write(carte.id)
                'Debug.Write(carte.categorie)
                mainPc.Add(carte)
                paquet.RemoveAt(0)
            Next
            adversaires(index).main = mainPc
        Next



        AfficherMain(mainJoueur)

    End Sub


    Public Function Valider(main As List(Of Carte)) As Integer

        Dim points As Integer = 0

        '' VERIFIER FLUSH 
        Dim flush As Boolean = False

        If main(0).categorie = main(1).categorie And main(1).categorie = main(2).categorie And main(2).categorie = main(3).categorie And main(3).categorie = main(4).categorie Then
            flush = True
            Debug.WriteLine("flushhhhhhh")
            points = 50
        End If



        '' VERIFIER STRAIGHT 
        Dim straight As Boolean = False
        Dim straightflush As Boolean = False
        Dim royalflush As Boolean = False

        Dim queryresults = From carte In main
                           Order By carte.id

        Dim cartestries() As Carte = queryresults.ToArray

        For Each carte In cartestries
            'Debug.WriteLine(carte.id)
        Next


        If cartestries(0).id = cartestries(1).id - 1 And cartestries(1).id = cartestries(2).id - 1 And cartestries(2).id = cartestries(3).id - 1 And cartestries(3).id = cartestries(4).id - 1 Or
            cartestries(4).id = 14 And cartestries(0).id = 2 And cartestries(1).id = 3 And cartestries(2).id = 4 And cartestries(3).id = 5 Then
            straight = True

            'Debug.WriteLine("STRAIGHT")
            points = 50
        End If



        'STRAIGHT FLUSH
        If straight = True And flush = True Then
            straightflush = True
            'Debug.WriteLine("STRAIGHTFLUSHHHH")
            points = 90
        End If

        'ROYAL FLUSH
        If straightflush = True And cartestries(4).id = 14 And cartestries(3).id = 13 And flush = True Then
            royalflush = True
            'Debug.WriteLine("ROYAL")
            points = 100

        End If

        ''VERIFIER LES PAIRES 

        Dim pair As Boolean = False
        Dim threeoak As Boolean = False
        Dim i As Integer = 2
        Dim pairCount As Integer = 0
        For index As Integer = 2 To 14
            Dim byGroup = Aggregate carte In main
                      Where carte.id = i
                          Into Count()
            i = i + 1

            If byGroup = 4 Then
                'Debug.WriteLine("4 OF A KIND")
                points = 80
            ElseIf byGroup = 3 Then
                'Debug.WriteLine("3 OF A KIND")
                points = 40
                threeoak = True
            ElseIf byGroup = 2 Then
                pairCount = pairCount + 1
            End If

        Next
        If pairCount = 2 Then
            'Debug.WriteLine("Double Pair")
            points = 30

        ElseIf pairCount = 1 Then
            'Debug.WriteLine("Pair")
            pair = True
            points = 20
        End If


        'FULLHOUSE 
        If threeoak = True And pair = True Then

            'Debug.WriteLine("FULL HOUSE")
            points = 70
        End If


        If points = 0 Then
            points = cartestries(4).id
        End If

        Return points

    End Function

    Private Sub btn_remplacer_Click(sender As Object, e As EventArgs) Handles btn_remplacer.Click
        If cb_carte1.Checked = True Then
            mainJoueur(0) = paquet(0)
            paquet.RemoveAt(0)
            AfficherMain(mainJoueur)
        End If

        If cb_carte2.Checked = True Then
            mainJoueur(1) = paquet(0)
            paquet.RemoveAt(0)
            AfficherMain(mainJoueur)
        End If
        If cb_carte3.Checked = True Then
            mainJoueur(2) = paquet(0)
            paquet.RemoveAt(0)
            AfficherMain(mainJoueur)
        End If
        If cb_carte4.Checked = True Then
            mainJoueur(3) = paquet(0)
            paquet.RemoveAt(0)
            AfficherMain(mainJoueur)
        End If
        If cb_carte5.Checked = True Then
            mainJoueur(4) = paquet(0)
            paquet.RemoveAt(0)
            AfficherMain(mainJoueur)
        End If
    End Sub

    Private Sub btn_verifier_Click(sender As Object, e As EventArgs) Handles btn_verifier.Click
        Dim ptsPlayer As Integer = Valider(mainJoueur)
        Dim pointsAdversaires As New List(Of Integer)




        '' TEMPORAIRE >>> VERIFICATION MAIN ET SCORE

        For Each pc In adversaires
            Debug.Write(pc.main(0).categorie)
            Debug.WriteLine(pc.main(0).id)
            Debug.Write(pc.main(1).categorie)
            Debug.WriteLine(pc.main(1).id)
            Debug.Write(pc.main(2).categorie)
            Debug.WriteLine(pc.main(2).id)
            Debug.Write(pc.main(3).categorie)
            Debug.WriteLine(pc.main(3).id)
            Debug.Write(pc.main(4).categorie)
            Debug.WriteLine(pc.main(4).id)


            Dim score = Valider(pc.main)
            pointsAdversaires.Add(score)
            Debug.Write("score ==")
            Debug.WriteLine(score)
            Debug.WriteLine("")

        Next





        Debug.WriteLine("Points du joueur 1 ==")
        Debug.WriteLine(ptsPlayer)

        pointsAdversaires.Sort()
        Dim highScore = pointsAdversaires(Form1.nbJoueurs - 1)
        Debug.Write("high score = ")
        Debug.WriteLine(highScore)

        If ptsPlayer > highScore Then
            Debug.WriteLine("PLAYER WIN")
        ElseIf ptsPlayer = highScore Then
            Debug.WriteLine("Egalite")
        Else
            Debug.WriteLine("PERDU")

        End If
    End Sub
End Class