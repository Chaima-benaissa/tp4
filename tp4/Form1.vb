Public Class Form1
    Private Sub txt_is_TextChanged(sender As Object, e As EventArgs) Handles txt_is.TextChanged

    End Sub

    Private Sub btn_ajout_Click(sender As Object, e As EventArgs) Handles btn_ajout.Click
        Dim l As livre
        l.ISBN = txt_is.Text
        l.TITRE = txt_titre.Text
        l.Auteur = txt_auteur.Text

        If ajouterlivre(l) Then
            MessageBox.Show("ajouter du livre avec succes")
        Else
            MessageBox.Show("le tableau bibliotheque est saturé")
        End If

    End Sub

    Private Sub btn_aff_Click(sender As Object, e As EventArgs) Handles btn_aff.Click
        liste_des_livres.Show()
        frm_afficher3.Show()
    End Sub
End Class
