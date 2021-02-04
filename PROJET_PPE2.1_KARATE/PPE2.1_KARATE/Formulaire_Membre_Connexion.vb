Public Class Formulaire_Membre_Connexion

    'Au chargement de la page cette fonction permet de ce connecter à la base de donnée donnée
    'Paramètre en entrée : bdKarate.accdb
    Private Sub Formulaire_Membre_Connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connexion("bdKarate.accdb")
    End Sub

    'La fonction de ce bouton est d'afficher la page Form_Membre_AJ
    Private Sub Cmd_Creer_Click(sender As Object, e As EventArgs) Handles Cmd_Creer.Click
        Form_Membre_AJ.Show()
        Me.Hide()
    End Sub

    'La fonction de ce bouton permet d'afficher la page Form_Membre_Rechercher
    Private Sub Cmd_Consulter_Click(sender As Object, e As EventArgs) Handles Cmd_Consulter.Click
        Form_Membre_Rechercher.Show()
        Me.Hide()
    End Sub

    'La fonction de ce bouton permet de fermer l'application 
    Private Sub Cmd_Back_Click(sender As Object, e As EventArgs) Handles Cmd_Back.Click
        Me.Close()
    End Sub
End Class