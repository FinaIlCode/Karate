<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Membre_AJ
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
        Me.Txt_Creer = New System.Windows.Forms.Label()
        Me.Txt_LicenceMembre = New System.Windows.Forms.Label()
        Me.Txt_NumClubMembre = New System.Windows.Forms.Label()
        Me.Txt_NomMembre = New System.Windows.Forms.Label()
        Me.Txt_PrenomMembre = New System.Windows.Forms.Label()
        Me.Txt_DateNaissanceMembre = New System.Windows.Forms.Label()
        Me.Txt_NumRueMembre = New System.Windows.Forms.Label()
        Me.Txt_VilleMembre = New System.Windows.Forms.Label()
        Me.Txt_Licence = New System.Windows.Forms.TextBox()
        Me.Txt_Club = New System.Windows.Forms.TextBox()
        Me.Txt_Nom = New System.Windows.Forms.TextBox()
        Me.Txt_Prenom = New System.Windows.Forms.TextBox()
        Me.Txt_Rue = New System.Windows.Forms.TextBox()
        Me.Txt_Ville = New System.Windows.Forms.TextBox()
        Me.DateTimeNaissance_Membre = New System.Windows.Forms.DateTimePicker()
        Me.Cmd_Ajouter = New System.Windows.Forms.Button()
        Me.Cmd_Annuler = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_CP = New System.Windows.Forms.Label()
        Me.Txt_CP = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt_Creer
        '
        Me.Txt_Creer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Creer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Creer.Location = New System.Drawing.Point(12, 9)
        Me.Txt_Creer.Name = "Txt_Creer"
        Me.Txt_Creer.Size = New System.Drawing.Size(775, 45)
        Me.Txt_Creer.TabIndex = 0
        Me.Txt_Creer.Text = "Creer un Membre"
        Me.Txt_Creer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_LicenceMembre
        '
        Me.Txt_LicenceMembre.AutoSize = True
        Me.Txt_LicenceMembre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_LicenceMembre.Location = New System.Drawing.Point(187, 9)
        Me.Txt_LicenceMembre.Name = "Txt_LicenceMembre"
        Me.Txt_LicenceMembre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_LicenceMembre.Size = New System.Drawing.Size(86, 20)
        Me.Txt_LicenceMembre.TabIndex = 1
        Me.Txt_LicenceMembre.Text = "N° licence"
        '
        'Txt_NumClubMembre
        '
        Me.Txt_NumClubMembre.AutoSize = True
        Me.Txt_NumClubMembre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NumClubMembre.Location = New System.Drawing.Point(187, 47)
        Me.Txt_NumClubMembre.Name = "Txt_NumClubMembre"
        Me.Txt_NumClubMembre.Size = New System.Drawing.Size(64, 20)
        Me.Txt_NumClubMembre.TabIndex = 2
        Me.Txt_NumClubMembre.Text = "N° club"
        '
        'Txt_NomMembre
        '
        Me.Txt_NomMembre.AutoSize = True
        Me.Txt_NomMembre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NomMembre.Location = New System.Drawing.Point(187, 82)
        Me.Txt_NomMembre.Name = "Txt_NomMembre"
        Me.Txt_NomMembre.Size = New System.Drawing.Size(44, 20)
        Me.Txt_NomMembre.TabIndex = 3
        Me.Txt_NomMembre.Text = "Nom"
        '
        'Txt_PrenomMembre
        '
        Me.Txt_PrenomMembre.AutoSize = True
        Me.Txt_PrenomMembre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PrenomMembre.Location = New System.Drawing.Point(187, 116)
        Me.Txt_PrenomMembre.Name = "Txt_PrenomMembre"
        Me.Txt_PrenomMembre.Size = New System.Drawing.Size(67, 20)
        Me.Txt_PrenomMembre.TabIndex = 6
        Me.Txt_PrenomMembre.Text = "Prénom"
        '
        'Txt_DateNaissanceMembre
        '
        Me.Txt_DateNaissanceMembre.AutoSize = True
        Me.Txt_DateNaissanceMembre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DateNaissanceMembre.Location = New System.Drawing.Point(187, 156)
        Me.Txt_DateNaissanceMembre.Name = "Txt_DateNaissanceMembre"
        Me.Txt_DateNaissanceMembre.Size = New System.Drawing.Size(149, 20)
        Me.Txt_DateNaissanceMembre.TabIndex = 5
        Me.Txt_DateNaissanceMembre.Text = "Date de naissance"
        '
        'Txt_NumRueMembre
        '
        Me.Txt_NumRueMembre.AutoSize = True
        Me.Txt_NumRueMembre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NumRueMembre.Location = New System.Drawing.Point(187, 198)
        Me.Txt_NumRueMembre.Name = "Txt_NumRueMembre"
        Me.Txt_NumRueMembre.Size = New System.Drawing.Size(113, 20)
        Me.Txt_NumRueMembre.TabIndex = 4
        Me.Txt_NumRueMembre.Text = "N° et nom rue"
        '
        'Txt_VilleMembre
        '
        Me.Txt_VilleMembre.AutoSize = True
        Me.Txt_VilleMembre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_VilleMembre.Location = New System.Drawing.Point(189, 232)
        Me.Txt_VilleMembre.Name = "Txt_VilleMembre"
        Me.Txt_VilleMembre.Size = New System.Drawing.Size(41, 20)
        Me.Txt_VilleMembre.TabIndex = 7
        Me.Txt_VilleMembre.Text = "Ville"
        '
        'Txt_Licence
        '
        Me.Txt_Licence.Location = New System.Drawing.Point(397, 9)
        Me.Txt_Licence.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Licence.Name = "Txt_Licence"
        Me.Txt_Licence.Size = New System.Drawing.Size(200, 22)
        Me.Txt_Licence.TabIndex = 8
        '
        'Txt_Club
        '
        Me.Txt_Club.Location = New System.Drawing.Point(397, 47)
        Me.Txt_Club.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Club.Name = "Txt_Club"
        Me.Txt_Club.Size = New System.Drawing.Size(200, 22)
        Me.Txt_Club.TabIndex = 9
        '
        'Txt_Nom
        '
        Me.Txt_Nom.Location = New System.Drawing.Point(397, 82)
        Me.Txt_Nom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Nom.Name = "Txt_Nom"
        Me.Txt_Nom.Size = New System.Drawing.Size(200, 22)
        Me.Txt_Nom.TabIndex = 10
        '
        'Txt_Prenom
        '
        Me.Txt_Prenom.Location = New System.Drawing.Point(397, 116)
        Me.Txt_Prenom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Prenom.Name = "Txt_Prenom"
        Me.Txt_Prenom.Size = New System.Drawing.Size(200, 22)
        Me.Txt_Prenom.TabIndex = 11
        '
        'Txt_Rue
        '
        Me.Txt_Rue.Location = New System.Drawing.Point(397, 195)
        Me.Txt_Rue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Rue.Name = "Txt_Rue"
        Me.Txt_Rue.Size = New System.Drawing.Size(200, 22)
        Me.Txt_Rue.TabIndex = 12
        '
        'Txt_Ville
        '
        Me.Txt_Ville.Location = New System.Drawing.Point(397, 232)
        Me.Txt_Ville.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Ville.Name = "Txt_Ville"
        Me.Txt_Ville.Size = New System.Drawing.Size(200, 22)
        Me.Txt_Ville.TabIndex = 13
        '
        'DateTimeNaissance_Membre
        '
        Me.DateTimeNaissance_Membre.CustomFormat = "21/01/2021"
        Me.DateTimeNaissance_Membre.Location = New System.Drawing.Point(397, 156)
        Me.DateTimeNaissance_Membre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimeNaissance_Membre.Name = "DateTimeNaissance_Membre"
        Me.DateTimeNaissance_Membre.Size = New System.Drawing.Size(200, 22)
        Me.DateTimeNaissance_Membre.TabIndex = 14
        Me.DateTimeNaissance_Membre.Value = New Date(2021, 1, 21, 0, 0, 0, 0)
        '
        'Cmd_Ajouter
        '
        Me.Cmd_Ajouter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Ajouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Ajouter.Location = New System.Drawing.Point(195, 316)
        Me.Cmd_Ajouter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmd_Ajouter.Name = "Cmd_Ajouter"
        Me.Cmd_Ajouter.Size = New System.Drawing.Size(132, 38)
        Me.Cmd_Ajouter.TabIndex = 15
        Me.Cmd_Ajouter.Text = "Créer"
        Me.Cmd_Ajouter.UseVisualStyleBackColor = True
        '
        'Cmd_Annuler
        '
        Me.Cmd_Annuler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Annuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Annuler.Location = New System.Drawing.Point(465, 316)
        Me.Cmd_Annuler.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmd_Annuler.Name = "Cmd_Annuler"
        Me.Cmd_Annuler.Size = New System.Drawing.Size(132, 38)
        Me.Cmd_Annuler.TabIndex = 16
        Me.Cmd_Annuler.Text = "Annuler"
        Me.Cmd_Annuler.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label_CP)
        Me.Panel1.Controls.Add(Me.Txt_CP)
        Me.Panel1.Controls.Add(Me.Cmd_Annuler)
        Me.Panel1.Controls.Add(Me.Cmd_Ajouter)
        Me.Panel1.Controls.Add(Me.DateTimeNaissance_Membre)
        Me.Panel1.Controls.Add(Me.Txt_Ville)
        Me.Panel1.Controls.Add(Me.Txt_Rue)
        Me.Panel1.Controls.Add(Me.Txt_Prenom)
        Me.Panel1.Controls.Add(Me.Txt_Nom)
        Me.Panel1.Controls.Add(Me.Txt_Club)
        Me.Panel1.Controls.Add(Me.Txt_Licence)
        Me.Panel1.Controls.Add(Me.Txt_VilleMembre)
        Me.Panel1.Controls.Add(Me.Txt_PrenomMembre)
        Me.Panel1.Controls.Add(Me.Txt_DateNaissanceMembre)
        Me.Panel1.Controls.Add(Me.Txt_NumRueMembre)
        Me.Panel1.Controls.Add(Me.Txt_NomMembre)
        Me.Panel1.Controls.Add(Me.Txt_NumClubMembre)
        Me.Panel1.Controls.Add(Me.Txt_LicenceMembre)
        Me.Panel1.Location = New System.Drawing.Point(12, 74)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(775, 371)
        Me.Panel1.TabIndex = 17
        '
        'Label_CP
        '
        Me.Label_CP.AutoSize = True
        Me.Label_CP.Location = New System.Drawing.Point(192, 273)
        Me.Label_CP.Name = "Label_CP"
        Me.Label_CP.Size = New System.Drawing.Size(84, 17)
        Me.Label_CP.TabIndex = 18
        Me.Label_CP.Text = "Code Postal"
        '
        'Txt_CP
        '
        Me.Txt_CP.Location = New System.Drawing.Point(397, 270)
        Me.Txt_CP.Name = "Txt_CP"
        Me.Txt_CP.Size = New System.Drawing.Size(200, 22)
        Me.Txt_CP.TabIndex = 17
        '
        'Form_Membre_AJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Txt_Creer)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form_Membre_AJ"
        Me.Text = "Form_Comp_AJ"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Txt_Creer As Label
    Friend WithEvents Txt_LicenceMembre As Label
    Friend WithEvents Txt_NumClubMembre As Label
    Friend WithEvents Txt_NomMembre As Label
    Friend WithEvents Txt_PrenomMembre As Label
    Friend WithEvents Txt_DateNaissanceMembre As Label
    Friend WithEvents Txt_NumRueMembre As Label
    Friend WithEvents Txt_VilleMembre As Label
    Friend WithEvents Txt_Licence As TextBox
    Friend WithEvents Txt_Club As TextBox
    Friend WithEvents Txt_Nom As TextBox
    Friend WithEvents Txt_Prenom As TextBox
    Friend WithEvents Txt_Rue As TextBox
    Friend WithEvents Txt_Ville As TextBox
    Friend WithEvents DateTimeNaissance_Membre As DateTimePicker
    Friend WithEvents Cmd_Ajouter As Button
    Friend WithEvents Cmd_Annuler As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label_CP As Label
    Friend WithEvents Txt_CP As TextBox
End Class
