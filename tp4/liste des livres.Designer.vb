<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class liste_des_livres
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lst_isbn = New ListBox()
        Lst_titre = New ListBox()
        Lst_auteur = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe Print", 10.2F, FontStyle.Bold)
        Label1.Location = New Point(91, 73)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 30)
        Label1.TabIndex = 0
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe Print", 10.2F, FontStyle.Bold)
        Label2.Location = New Point(317, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 30)
        Label2.TabIndex = 1
        Label2.Text = "Titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe Print", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(572, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 30)
        Label3.TabIndex = 2
        Label3.Text = "Auteur"
        ' 
        ' lst_isbn
        ' 
        lst_isbn.BackColor = Color.OldLace
        lst_isbn.FormattingEnabled = True
        lst_isbn.Location = New Point(52, 119)
        lst_isbn.Name = "lst_isbn"
        lst_isbn.Size = New Size(150, 244)
        lst_isbn.TabIndex = 3
        ' 
        ' Lst_titre
        ' 
        Lst_titre.BackColor = Color.OldLace
        Lst_titre.FormattingEnabled = True
        Lst_titre.Location = New Point(294, 119)
        Lst_titre.Name = "Lst_titre"
        Lst_titre.Size = New Size(150, 244)
        Lst_titre.TabIndex = 4
        ' 
        ' Lst_auteur
        ' 
        Lst_auteur.BackColor = Color.OldLace
        Lst_auteur.FormattingEnabled = True
        Lst_auteur.Location = New Point(549, 119)
        Lst_auteur.Name = "Lst_auteur"
        Lst_auteur.Size = New Size(150, 244)
        Lst_auteur.TabIndex = 5
        ' 
        ' liste_des_livres
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.BlanchedAlmond
        ClientSize = New Size(800, 560)
        Controls.Add(Lst_auteur)
        Controls.Add(Lst_titre)
        Controls.Add(lst_isbn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "liste_des_livres"
        Text = "liste des livres"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lst_isbn As ListBox
    Friend WithEvents Lst_titre As ListBox
    Friend WithEvents Lst_auteur As ListBox
End Class
