Imports System.Data.OleDb

Public Class Form_Membre_AJ

    Private Sub Cmd_Annuler_Click(sender As Object, e As EventArgs) Handles Cmd_Annuler.Click
        Me.Close()
        Formulaire_Membre_Connexion.Show()
    End Sub

    Private Sub Cmd_Ajouter_Click(sender As Object, e As EventArgs) Handles Cmd_Ajouter.Click
        Dim err As Boolean
        If Txt_Licence.Text.Length <> 10 Or IsNumeric(Int(Txt_Licence.Text)) = False Then
            err = True
            MsgBox("Le numéro de Licence doit être au format : '0123456789' ")
            Txt_Licence.Clear()
        End If

        If Txt_CP.Text.Length <> 5 Or IsNumeric(Int(Txt_CP.Text)) = False Then
            err = True
            MsgBox("Le code postal n'est pas valide")
            Txt_CP.Clear()
        End If


        If err = False Then
            Dim insertion As String
            insertion = "insert into MEMBRE values (@licence, @club, @nom, @prenom, @naissance, @rue,@cp, @ville)"

            Dim cmdInsert As New OleDbCommand(insertion, maConnexion)

            cmdInsert.Parameters.AddWithValue("@licence", Txt_Licence.Text)
            cmdInsert.Parameters.AddWithValue("@club", Txt_Club.Text)
            cmdInsert.Parameters.AddWithValue("@nom", Txt_Nom.Text)
            cmdInsert.Parameters.AddWithValue("@prenom", Txt_Prenom.Text)
            cmdInsert.Parameters.AddWithValue("@naissance", DateTimeNaissance_Membre.Value)
            cmdInsert.Parameters.AddWithValue("@rue", Txt_Rue.Text)
            cmdInsert.Parameters.AddWithValue("@cp", Txt_CP.Text)
            cmdInsert.Parameters.AddWithValue("@ville", Txt_Ville.Text)

            cmdInsert.ExecuteNonQuery()

            MsgBox("Membre créé ! ")
            Formulaire_Membre_Connexion.Show()
            Me.Close()
        End If
    End Sub

End Class