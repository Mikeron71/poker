Public Class Player


    Public numero As Integer

    Public main As New List(Of Carte)

    Public typeMain As String






    Public Sub New(nb As Integer)
        numero = nb
        For index As Integer = 0 To 4
            Dim carte = Jouer.paquet(0)
            main.Add(carte)
            Jouer.paquet.RemoveAt(0)
        Next
    End Sub





End Class
