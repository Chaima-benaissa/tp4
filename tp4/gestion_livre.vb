Module gestion_livre
    Public Structure livre
        Dim ISBN As Integer
        Dim TITRE As String
        Dim Auteur As String
    End Structure
    Public bibliotheque(100) As livre
    Dim nb As Integer = 0

    Function ajouterlivre(l As livre) As Boolean
        If nb < bibliotheque.Length Then
            bibliotheque(nb) = l
            nb += 1
            Return True
        Else
            Return False
        End If
    End Function
    Sub afficher_livre(l1 As ListBox, l2 As ListBox, l3 As ListBox)
        For i As Integer = 0 To nb - 1
            l1.Items.Add(bibliotheque(i).ISBN)
            l2.Items.Add(bibliotheque(i).TITRE)
            l3.Items.Add(bibliotheque(i).Auteur)

        Next
    End Sub
    Sub afficher3_livre(djv_livre As DataGridView)
        For i As Integer = 0 To nb - 1
            Dim livre As livre = bibliotheque(i)
            djv_livre.Rows.Add(livre.ISBN, livre.TITRE, livre.Auteur)
        Next

    End Sub




End Module
