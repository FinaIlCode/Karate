Imports System.Data.OleDb

Public Class Form_Membre_Modif
    Public nom As String
    Public prenom As String

    'La fonction de ce bouton récupère les informations dun membre en fonction de son nom et de son prénom et qui les affichent 
    'Paramètres en entrée : @nom et @prenom qui proviennent de Form_Membre_CA
    'Renvoie les informations du membre
    Private Sub Form_Membre_Modif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nom = Form_Membre_CA.nom
        prenom = Form_Membre_CA.prenom

        Dim req As String
        req = "select * from MEMBRE where NOM_MEMBRE=@nom AND PRENOM_MEMBRE=@prenom"

        Dim cmdModif1 As New OleDbCommand(req, maConnexion)
        cmdModif1.Parameters.AddWithValue("@nom", nom)
        cmdModif1.Parameters.AddWithValue("@prenom", prenom)

        Dim rdrModif1 As OleDbDataReader = cmdModif1.ExecuteReader()
        rdrModif1.Read()

        Label_Nom_Modif.Text = rdrModif1.Item("NOM_MEMBRE")
        Label_Prenom_Modif.Text = rdrModif1.Item("PRENOM_MEMBRE")
        Txt_Licence_Modif.Text = rdrModif1.Item("NUM_LICENCE")
        Txt_Club_Modif.Text = rdrModif1.Item("NUM_CLUB")
        Txt_Nom_Modif.Text = rdrModif1.Item("NOM_MEMBRE")
        Txt_Prenom_Modif.Text = rdrModif1.Item("PRENOM_MEMBRE")
        DateTimeNaissance_Membre_Modif.Text = rdrModif1.Item("DATE_NAISSANCE")
        Txt_cp_Modif.Text = rdrModif1.Item("CODE_POST_MEMBRE")
        Txt_Rue_Modif.Text = rdrModif1.Item("ADR_RUE_MEMBRE")
        Txt_Ville_Modif.Text = rdrModif1.Item("ADR_VILLE_MEMBRE")
    End Sub

    'La fonction de ce bouton renvoie sur la page : Form_Membre_CA'
    Private Sub Cmd_Retour2_Click(sender As Object, e As EventArgs) Handles Cmd_Retour2.Click
        Me.Close()
        Form_Membre_CA.Show()
    End Sub

    'La fonction de ce bouton récupère les informations dun membre en fonction de son nom et de son prénom les affichent puis les modifications sont sauvegardé grâce a la requete update
    '
    'Paramètres en entrer pour rechercher le Membre : @nom : provenant de la page : Form_Membre_Rechercher et @prenom : provenant de la page : Form_Membre_Rechercher
    'Retour de la requete : renvoie le numéro de licence d'un membre 
    '
    'Paramètres en entrer pour modifier le Membre :  @newid , @newclub, @newnom, @newprenom, @newnaissance, @newrue, @newcp, @newville qui proviennent du formulaire et @resultat qui provient de la requete select précédemment décrite
    Private Sub Cmd_Enregistrer_Click(sender As Object, e As EventArgs) Handles Cmd_Enregistrer.Click
        Dim id As String
        id = "select NUM_LICENCE from MEMBRE where NOM_MEMBRE=@nom AND PRENOM_MEMBRE=@prenom"
        'On déclare une variable de type objet "Command" qui exécute une commande (requête SQL) sur la base de données
        Dim cmdId As New OleDbCommand(id, maConnexion)
        cmdId.Parameters.AddWithValue("@nom", nom)
        cmdId.Parameters.AddWithValue("@prenom", prenom)
        Dim resultat As Object = cmdId.ExecuteScalar
        resultat = resultat.ToString

        Dim err As Boolean

        Dim newcp As String
        newcp = Txt_cp_Modif.Text
        err = False
        If Txt_cp_Modif.Text.Length <> 5 Or IsNumeric(Int(Txt_cp_Modif.Text)) = False Then
            err = True
            MsgBox("Le code postal doit être au format : '12345' ")
        End If

        If Txt_Licence_Modif.Text.Length <> 10 Or IsNumeric(Int(Txt_Licence_Modif.Text)) = False Then
            err = True
            MsgBox("Le numéro de Licence doit être au format : '0123456789' ")
        End If

        If err = False Then

            Dim update As String = "UPDATE MEMBRE SET NUM_LICENCE = @newid, NUM_CLUB=@newclub, NOM_MEMBRE=@newnom, PRENOM_MEMBRE=@newprenom, DATE_NAISSANCE=@newnaissance, ADR_RUE_MEMBRE=@newrue, CODE_POST_MEMBRE=@newcp, ADR_VILLE_MEMBRE=@newville WHERE NUM_LICENCE=@resultat"
            Dim cmdModif As New OleDbCommand(update, maConnexion)

            cmdModif.Parameters.AddWithValue("@newid", Txt_Licence_Modif.Text)
            cmdModif.Parameters.AddWithValue("@newclub", Txt_Club_Modif.Text)
            cmdModif.Parameters.AddWithValue("@newnom", Txt_Nom_Modif.Text)
            cmdModif.Parameters.AddWithValue("@newprenom", Txt_Prenom_Modif.Text)
            cmdModif.Parameters.AddWithValue("@newnaissance", DateTimeNaissance_Membre_Modif.Value)
            cmdModif.Parameters.AddWithValue("@newrue", Txt_Rue_Modif.Text)
            cmdModif.Parameters.AddWithValue("@newcp", Txt_cp_Modif.Text)
            cmdModif.Parameters.AddWithValue("@newville", Txt_Ville_Modif.Text)
            cmdModif.Parameters.AddWithValue("@id", resultat)
            cmdModif.ExecuteNonQuery()

            MsgBox("Membre modifiée !")
            Me.Close()
            Form_Membre_Rechercher.Show()
        End If


    End Sub

End Class