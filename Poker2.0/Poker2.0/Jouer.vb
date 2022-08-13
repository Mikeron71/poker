Partial Public Class Jouer

    Public paquet As New List(Of Carte)
    Dim joueurs As New List(Of Player)
    Dim msgWin As String
    Dim mise As Integer
    Dim credits As Integer = 20
    Dim resultat As String = ""
    Dim winner As Boolean = False
    Dim valeurBase As Integer

    Public Sub Jouer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModeMise()
        UpdateCredits()
        paquet = CreerPaquet()
        CreerJoueurs(Form1.nbJoueurs)
        tb_win.Text = "Pour débuter, placez votre mise"

    End Sub

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





    Public Sub CreerJoueurs(combien As Integer)

        For n As Integer = 0 To combien
            Dim player As New Player()
            joueurs.Add(player)
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
        Return paquet

    End Function

    Public Sub btn_jouer_Click(sender As Object, e As EventArgs) Handles btn_jouer.Click
        paquet = CreerPaquet()
        tb_win.Visible = False
        btn_jouer.Enabled = False
        btn_remplacer.Enabled = True
        pan_mise.Enabled = False

        For index As Integer = 0 To Form1.nbJoueurs
            Dim mainACreer As New List(Of Carte)

            For i As Integer = 0 To 4
                Dim carte = paquet(0)
                mainACreer.Add(carte)
                paquet.RemoveAt(0)
            Next
            joueurs(index).main = mainACreer
        Next



        AfficherMain(joueurs(0).main)
        btn_remplacer.Enabled = True
        pan_remplacer.Visible = True
        btn_verifier.Enabled = True

    End Sub


    Public Sub ValiderMain(joueur)

        joueur.points = 0
        Dim main As List(Of Carte) = joueur.main

        '' VERIFIER FLUSH 
        Dim flush As Boolean = False

        If main(0).categorie = main(1).categorie And main(1).categorie = main(2).categorie And main(2).categorie = main(3).categorie And main(3).categorie = main(4).categorie Then
            flush = True
            joueur.points = 60
            joueur.typeMain = "flush"
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

            joueur.typeMain = "quinte"
            joueur.points = 50
        End If



        'STRAIGHT FLUSH
        If straight = True And flush = True Then
            straightflush = True
            joueur.typeMain = "quinte flush"

            joueur.points = 90
        End If

        'ROYAL FLUSH
        If straightflush = True And cartestries(4).id = 14 And cartestries(3).id = 13 And flush = True Then
            royalflush = True
            joueur.typeMain = "quinte flush royale"

            joueur.points = 100

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
                joueur.typeMain = "carré"
                joueur.points = 80
            ElseIf byGroup = 3 Then
                joueur.typeMain = "brelan"
                joueur.points = 40
                threeoak = True
            ElseIf byGroup = 2 Then
                pairCount = pairCount + 1
            End If

        Next
        If pairCount = 2 Then
            joueur.typeMain = "deux paires"
            joueur.points = 30
        ElseIf pairCount = 1 Then
            joueur.typeMain = "paire"
            pair = True
            joueur.points = 20
        End If


        'FULLHOUSE 
        If threeoak = True And pair = True Then
            joueur.typeMain = "full"
            joueur.points = 70
        End If


        If joueur.points = 0 Then
            joueur.points = cartestries(4).id
            joueur.typeMain = "carte haute"
        End If



    End Sub

    Private Sub btn_remplacer_Click(sender As Object, e As EventArgs) Handles btn_remplacer.Click
        If cb_carte1.Checked = True Then
            joueurs(0).main(0) = paquet(0)
            paquet.RemoveAt(0)
            AfficherMain(joueurs(0).main)
        End If

        If cb_carte2.Checked = True Then
            joueurs(0).main(1) = paquet(0)
            paquet.RemoveAt(0)
            AfficherMain(joueurs(0).main)
        End If
        If cb_carte3.Checked = True Then
            joueurs(0).main(2) = paquet(0)
            paquet.RemoveAt(0)
            AfficherMain(joueurs(0).main)
        End If
        If cb_carte4.Checked = True Then
            joueurs(0).main(3) = paquet(0)
            paquet.RemoveAt(0)
            AfficherMain(joueurs(0).main)
        End If
        If cb_carte5.Checked = True Then
            joueurs(0).main(4) = paquet(0)
            paquet.RemoveAt(0)
            AfficherMain(joueurs(0).main)
        End If
        btn_remplacer.Enabled = False
    End Sub

    Private Sub btn_verifier_Click(sender As Object, e As EventArgs) Handles btn_verifier.Click

        winner = False
        Dim pointsAdversaires As New List(Of Integer)
        clearTb()

        '' TEMPORAIRE >>> VERIFICATION MAIN ET SCORE

        For Each joueur In joueurs

            ValiderMain(joueur)
            Debug.Write(joueur.main(0).categorie)
            Debug.WriteLine(joueur.main(0).id)
            Debug.Write(joueur.main(1).categorie)
            Debug.WriteLine(joueur.main(1).id)
            Debug.Write(joueur.main(2).categorie)
            Debug.WriteLine(joueur.main(2).id)
            Debug.Write(joueur.main(3).categorie)
            Debug.WriteLine(joueur.main(3).id)
            Debug.Write(joueur.main(4).categorie)
            Debug.WriteLine(joueur.main(4).id)


            Debug.WriteLine(joueur.points)
            Debug.WriteLine(joueur.typeMain)


        Next




        btn_jouer.Enabled = True
        VerifierGagnant()
        ModeMise()
    End Sub

    Public Sub clearTb()
        tb_pc1.Clear()
        tb_pc2.Clear()
        tb_pc3.Clear()
    End Sub




    Private Sub ModeMise()
        nud_mise.Value = 1
        pan_mise.Enabled = True
        tb_win.Visible = True
        btn_jouer.Enabled = False
        btn_remplacer.Enabled = False
        btn_verifier.Enabled = False
        btn_miser.Enabled = True
        nud_mise.Enabled = True
        btn_modifier.Enabled = False

    End Sub

    Private Sub UpdateCredits()

        lb_creditData.Text = credits.ToString()
    End Sub

    Private Function btn_miser_Click(sender As Object, e As EventArgs) Handles btn_miser.Click
        tb_win.Text = ""
        mise = nud_mise.Value
        If mise > credits Then
            MessageBox.Show("vous ne pouvez pas miser plus que votre nombre de crédits")
            Return Nothing
        Else

            nud_mise.Enabled = False
            btn_miser.Enabled = False
            credits = credits - mise
            btn_modifier.Enabled = True
            btn_jouer.Enabled = True
            UpdateCredits()
        End If



    End Function

    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click
        nud_mise.Enabled = False
        nud_mise.Enabled = True
        btn_modifier.Enabled = False
        btn_miser.Enabled = True
        btn_jouer.Enabled = False
        credits = credits + mise
        UpdateCredits()
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



    Public Sub VerifierGagnant()

        Dim listPoints As New List(Of Integer)
        Dim pt1 = joueurs(0).points

        For i As Integer = 1 To Form1.nbJoueurs
            listPoints.Add(joueurs(i).points)
        Next

        listPoints.Sort()

        If pt1 > listPoints.Last() Then
            resultat = "Gagnant"
            winner = True
        ElseIf pt1 = listPoints.Last Then
            resultat = "Partie nulle"
            credits = credits + mise
        Else
            resultat = "Partie perdue"
        End If

        tb_win.Text = resultat
        tb_win.Visible = True
        CalculerPoint()
        AfficherResultats()
        UpdateCredits()

        If credits = 0 Then

            MessageBox.Show("TES PAUVRE")

        End If



    End Sub

    Public Sub CalculerPoint()
        If winner = True Then
            Dim type = joueurs(0).typeMain


            Select Case type
                Case "carte haute"
                    credits = credits + (mise * 2)
                Case "paire"
                    credits = credits + (mise * 3)
                Case "deux paires"
                    credits = credits + (mise * 5)
                Case "brelan"
                    credits = credits + (mise * 10)
                Case "quinte"
                    credits = credits + (mise * 15)
                Case "couleur"
                    credits = credits + (mise * 20)
                Case "full"
                    credits = credits + (mise * 25)
                Case "carré"
                    credits = credits + (mise * 50)
                Case "quinte flush"
                    credits = credits + (mise * 75)
                Case "quinte flush royale"
                    credits = credits + (mise * 100)
            End Select


            UpdateCredits()



        End If
    End Sub


    Private Sub AfficherResultats()
        tb_pc1.Text = "Adversaire 1: " + joueurs(1).typeMain
        tb_pc1.Visible = True
        If Form1.nbJoueurs > 1 Then
            tb_pc2.Visible = True
            tb_pc2.Text = "Adversaire 2: " + joueurs(2).typeMain
        End If
        If Form1.nbJoueurs > 2 Then
            tb_pc3.Visible = True
            tb_pc3.Text = "Adversaire 3: " + joueurs(3).typeMain
        End If

        tb_votreMain.Text = "Votre main :" + joueurs(0).typeMain

        Debug.WriteLine("Points du joueur 1 ==")
        Debug.WriteLine(joueurs(0).points)
    End Sub
End Class