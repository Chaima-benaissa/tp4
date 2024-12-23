<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btn_ajout = New Button()
        btn_aff = New Button()
        txt_is = New TextBox()
        txt_titre = New TextBox()
        txt_auteur = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 10.2F, FontStyle.Bold)
        Label1.Location = New Point(67, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 0
        Label1.Text = "ISBN:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 10.2F, FontStyle.Bold)
        Label2.Location = New Point(67, 155)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 20)
        Label2.TabIndex = 1
        Label2.Text = "TITRE:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(67, 218)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 20)
        Label3.TabIndex = 2
        Label3.Text = "Auteur:"
        ' 
        ' btn_ajout
        ' 
        btn_ajout.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btn_ajout.Location = New Point(74, 319)
        btn_ajout.Name = "btn_ajout"
        btn_ajout.Size = New Size(125, 58)
        btn_ajout.TabIndex = 3
        btn_ajout.Text = "Ajouter "
        btn_ajout.UseVisualStyleBackColor = True
        ' 
        ' btn_aff
        ' 
        btn_aff.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btn_aff.Location = New Point(279, 319)
        btn_aff.Name = "btn_aff"
        btn_aff.Size = New Size(129, 58)
        btn_aff.TabIndex = 4
        btn_aff.Text = "Afficher"
        btn_aff.UseVisualStyleBackColor = True
        ' 
        ' txt_is
        ' 
        txt_is.Location = New Point(162, 90)
        txt_is.Name = "txt_is"
        txt_is.Size = New Size(125, 27)
        txt_is.TabIndex = 5
        ' 
        ' txt_titre
        ' 
        txt_titre.Location = New Point(162, 153)
        txt_titre.Name = "txt_titre"
        txt_titre.Size = New Size(125, 27)
        txt_titre.TabIndex = 6
        ' 
        ' txt_auteur
        ' 
        txt_auteur.Location = New Point(162, 211)
        txt_auteur.Name = "txt_auteur"
        txt_auteur.Size = New Size(125, 27)
        txt_auteur.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        ClientSize = New Size(555, 450)
        Controls.Add(txt_auteur)
        Controls.Add(txt_titre)
        Controls.Add(txt_is)
        Controls.Add(btn_aff)
        Controls.Add(btn_ajout)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "livre"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_ajout As Button
    Friend WithEvents btn_aff As Button
    Friend WithEvents txt_is As TextBox
    Friend WithEvents txt_titre As TextBox
    Friend WithEvents txt_auteur As TextBox

End Class
