Partial Public Class Jouer

    Public nomJoueur As String
    Public nbJoueurs As Integer
    Public credits As Integer



    Private rnd As New Random()

    Public Sub Shuffle(carte As List(Of Carte))
        Dim rando As Integer
        Dim temp As Carte

        For n As Integer = 52 - 1 To 0 Step -1
            rando = rnd.Next(0, n + 1)
            temp = carte(n)
            carte(n) = carte(rando)
            carte(rando) = temp
        Next n
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

    Private Sub btn_jouer_Click(sender As Object, e As EventArgs) Handles btn_jouer.Click
        Dim paquet = CreerPaquet()


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

        Valider(mainTest)

        Dim mainJoueur As New List(Of Carte)

        For index As Integer = 0 To 4
            Dim carte = paquet(0)
            mainJoueur.Add(carte)
            paquet.RemoveAt(0)
        Next


        For Each carte In mainJoueur
            Debug.Write(carte.id)
            Debug.WriteLine(carte.categorie)
        Next



        'Debug.WriteLine("")
        'Debug.WriteLine("")


        'Debug.Write(Carte1.id)
        'Debug.WriteLine(Carte1.categorie)
        'Debug.Write(Carte2.id)
        'Debug.WriteLine(Carte2.categorie)
        'Debug.Write(Carte3.id)
        'Debug.WriteLine(Carte3.categorie)
        'Debug.Write(Carte4.id)
        'Debug.WriteLine(Carte4.categorie)
        'Debug.Write(Carte5.id)
        'Debug.WriteLine(Carte5.categorie)

    End Sub


    Public Sub Valider(main As List(Of Carte))

        '' VERIFIER FLUSH 
        Dim flush As Boolean = False
        If main(0).categorie = main(1).categorie And main(1).categorie = main(2).categorie And main(2).categorie = main(3).categorie And main(3).categorie = main(4).categorie Then
            flush = True
            Debug.WriteLine("flushhhhhhh")


        End If



        '' VERIFIER STRAIGHT 
        Dim straight As Boolean = False
        Dim straightflush As Boolean = False
        Dim royalflush As Boolean = False

        Dim queryresults = From carte In main
                           Order By carte.id

        Dim cartestries() As Carte = queryresults.ToArray

        For Each carte In cartestries
            Debug.WriteLine(carte.id)
        Next


        If cartestries(0).id = cartestries(1).id - 1 And cartestries(1).id = cartestries(2).id - 1 And cartestries(2).id = cartestries(3).id - 1 And cartestries(3).id = cartestries(4).id - 1 Or
            cartestries(4).id = 14 And cartestries(0).id = 2 And cartestries(1).id = 3 And cartestries(2).id = 4 And cartestries(3).id = 5 Then
            straight = True

            Debug.WriteLine("STRAIGHT")
        End If



        'STRAIGHT FLUSH
        If straight = True And flush = True Then
            straightflush = True
            Debug.WriteLine("STRAIGHTFLUSHHHH")
        End If

        'ROYAL FLUSH
        If straightflush = True And cartestries(4).id = 14 And cartestries(3).id = 13 Then
            royalflush = True
            Debug.WriteLine("ROYAL")

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
                Debug.WriteLine("4 OF A KIND")
            ElseIf byGroup = 3 Then
                Debug.WriteLine("3 OF A KIND")
                threeoak = True
            ElseIf byGroup = 2 Then
                pairCount = pairCount + 1
            End If

        Next
        If pairCount = 2 Then
            Debug.WriteLine("Double Pair")

        ElseIf pairCount = 1 Then
            Debug.WriteLine("Pair")
            pair = True
        End If


        'FULLHOUSE 
        If threeoak = True And pair = True Then

            Debug.WriteLine("FULL HOUSE")
        End If



    End Sub







End Class