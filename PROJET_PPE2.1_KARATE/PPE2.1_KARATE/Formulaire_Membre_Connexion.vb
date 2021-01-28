Public Class Formulaire_Membre_Connexion
    Private Sub Formulaire_Membre_Connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connexion("bdKarate.accdb")
    End Sub

    Private Sub Cmd_Creer_Click(sender As Object, e As EventArgs) Handles Cmd_Creer.Click
        Form_Membre_AJ.Show()
        Me.Hide()
    End Sub

    Private Sub Cmd_Consulter_Click(sender As Object, e As EventArgs) Handles Cmd_Consulter.Click
        Form_Membre_Rechercher.Show()
        Me.Hide()
    End Sub

    Private Sub Cmd_Back_Click(sender As Object, e As EventArgs) Handles Cmd_Back.Click
        Me.Close()
    End Sub
End Class