﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_afficher3
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
        djv_livre = New DataGridView()
        ISBN = New DataGridViewTextBoxColumn()
        TITRE = New DataGridViewTextBoxColumn()
        Auteur = New DataGridViewTextBoxColumn()
        CType(djv_livre, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' djv_livre
        ' 
        djv_livre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        djv_livre.Columns.AddRange(New DataGridViewColumn() {ISBN, TITRE, Auteur})
        djv_livre.Location = New Point(24, 27)
        djv_livre.Name = "djv_livre"
        djv_livre.RowHeadersWidth = 51
        djv_livre.Size = New Size(479, 188)
        djv_livre.TabIndex = 0
        ' 
        ' ISBN
        ' 
        ISBN.HeaderText = "ISBN"
        ISBN.MinimumWidth = 6
        ISBN.Name = "ISBN"
        ISBN.Width = 125
        ' 
        ' TITRE
        ' 
        TITRE.HeaderText = "TITRE"
        TITRE.MinimumWidth = 6
        TITRE.Name = "TITRE"
        TITRE.Width = 125
        ' 
        ' Auteur
        ' 
        Auteur.HeaderText = "Auteur"
        Auteur.MinimumWidth = 6
        Auteur.Name = "Auteur"
        Auteur.Width = 125
        ' 
        ' frm_afficher3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(djv_livre)
        Name = "frm_afficher3"
        Text = "frm_afficher3"
        CType(djv_livre, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents djv_livre As DataGridView
    Friend WithEvents ISBN As DataGridViewTextBoxColumn
    Friend WithEvents TITRE As DataGridViewTextBoxColumn
    Friend WithEvents Auteur As DataGridViewTextBoxColumn
End Class
