﻿Imports System.Data.OleDb

Public Class Form_Membre_CA
    Public prenom As String
    Public nom As String
    Public id As String
    Public club As Integer
    Public naissance As Date
    Public cp As String
    Public rue As String
    Public ville As String
    Private Sub Form_Comp_CA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prenom = Form_Membre_Rechercher.prenom
        nom = Form_Membre_Rechercher.nom
        Dim req As String
        req = "select * from MEMBRE where NOM_MEMBRE=@nom AND PRENOM_MEMBRE=@prenom"
        'On déclare une variable de type objet "Command" qui exécute une commande (requête SQL) sur la base de données
        Dim cmdRech As New OleDbCommand(req, maConnexion)
        cmdRech.Parameters.AddWithValue("@nom", nom)
        cmdRech.Parameters.AddWithValue("@prenom", prenom)


        'On déclare une variable de type objet "DataReader" qui récupère les enregistrements de la requête de type SELECT
        Dim rdrRech As OleDbDataReader = cmdRech.ExecuteReader()
        rdrRech.Read()


        Label_Nom.Text = rdrRech.Item("NOM_MEMBRE")
        Label_Prenom.Text = rdrRech.Item("PRENOM_MEMBRE")
        Txt_Licence.Text = rdrRech.Item("NUM_LICENCE")
        Txt_Club.Text = rdrRech.Item("NUM_CLUB")
        Txt_Nom.Text = rdrRech.Item("NOM_MEMBRE")
        Txt_Prenom.Text = rdrRech.Item("PRENOM_MEMBRE")
        DateTimeNaissance_Membre.Text = rdrRech.Item("DATE_NAISSANCE")
        Txt_cp.Text = rdrRech.Item("CODE_POST_MEMBRE")
        Txt_Rue.Text = rdrRech.Item("ADR_RUE_MEMBRE")
        Txt_Ville.Text = rdrRech.Item("ADR_VILLE_MEMBRE")

        id = Txt_Licence.Text
        club = Txt_Club.Text
        naissance = DateTimeNaissance_Membre.Text
        cp = Txt_cp.Text
        rue = Txt_Rue.Text
        ville = Txt_Ville.Text

    End Sub

    Private Sub Cmd_Modifier_Click(sender As Object, e As EventArgs) Handles Cmd_Modifier.Click
        Me.Hide()
        Form_Membre_Modif.Show()

    End Sub

    Private Sub Cmd_Retour_Click(sender As Object, e As EventArgs) Handles Cmd_Retour.Click
        Me.Close()
        Form_Membre_Rechercher.Show()

    End Sub

    Private Sub Cmd_Suppr_Click(sender As Object, e As EventArgs) Handles Cmd_Suppr.Click

        Dim res As Boolean

        If MsgBox("Voulez vous vraiment supprimer ce membre ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim reqdelinscription As String = "delete from INSCRIPTION WHERE NUM_LICENCE=(Select NUM_LICENCE FROM MEMBRE WHERE NOM_MEMBRE=@nom AND PRENOM_MEMBRE=@prenom)"
            Dim cmdDeleteInscription As New OleDbCommand(reqdelinscription, maConnexion)
            cmdDeleteInscription.Parameters.AddWithValue("@nom", nom)
            cmdDeleteInscription.Parameters.AddWithValue("@prenom", prenom)
            cmdDeleteInscription.ExecuteNonQuery()

            Dim rqtest As String = "Delete FROM NOTE1 n WHERE NUM_LICENCE=(Select NUM_LICENCE FROM MEMBRE WHERE NOM_MEMBRE=@nom AND PRENOM_MEMBRE=@prenom)"
            Dim cmdDeleteNote As New OleDbCommand(rqtest, maConnexion)
            cmdDeleteNote.Parameters.AddWithValue("@nom", nom)
            cmdDeleteNote.Parameters.AddWithValue("@prenom", prenom)
            cmdDeleteNote.ExecuteNonQuery()

            Dim reqdelmembre As String = "delete from membre where NOM_MEMBRE=@nom AND PRENOM_MEMBRE=@prenom"
            Dim cmdDeleteMembre As New OleDbCommand(reqdelmembre, maConnexion)
            cmdDeleteMembre.Parameters.AddWithValue("@nom", nom)
            cmdDeleteMembre.Parameters.AddWithValue("@prenom", prenom)
            cmdDeleteMembre.ExecuteNonQuery()

            MsgBox("Membre suprimée")
            Form_Membre_Rechercher.Show()
            Me.Close()
        Else

        End If


    End Sub

End Class