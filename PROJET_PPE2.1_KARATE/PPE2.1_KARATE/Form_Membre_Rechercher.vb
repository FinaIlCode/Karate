Imports System.Data.OleDb

Public Class Form_Membre_Rechercher
    Public prenom As String
    Public nom As String

    Private Sub Cmd_Rechercher_Click(sender As Object, e As EventArgs) Handles Cmd_Rechercher.Click
        nom = Txt_NomRechercher.Text
        prenom = Txt_PrenomRechercher.Text
        Dim req As String
        req = "select * from MEMBRE where NOM_MEMBRE=@nom AND PRENOM_MEMBRE=@prenom"

        Dim cmdRech As New OleDbCommand(req, maConnexion)
        cmdRech.Parameters.AddWithValue("@nom", nom)
        cmdRech.Parameters.AddWithValue("@prenom", prenom)


        Dim rdrRech As OleDbDataReader = cmdRech.ExecuteReader()

        If rdrRech.Read() Then
            Form_Membre_CA.Show()
            Me.Hide()
        Else
            MsgBox("Le Membre recherché n'existe pas, veuillez réessayer ! ")
            Txt_NomRechercher.Clear()
            Txt_PrenomRechercher.Clear()
        End If

    End Sub

    Private Sub Cmd_Retour_Click(sender As Object, e As EventArgs) Handles Cmd_Retour.Click
        Me.Close()
        Formulaire_Membre_Connexion.Show()
    End Sub

End Class