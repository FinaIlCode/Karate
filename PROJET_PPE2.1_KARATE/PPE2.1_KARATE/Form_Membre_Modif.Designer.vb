<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Membre_Modif
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label_Prenom_Modif = New System.Windows.Forms.Label()
        Me.Label_Nom_Modif = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txt_cp_Modif = New System.Windows.Forms.TextBox()
        Me.Label_cp = New System.Windows.Forms.Label()
        Me.Cmd_Enregistrer = New System.Windows.Forms.Button()
        Me.Photo_Membre = New System.Windows.Forms.PictureBox()
        Me.Cmd_Retour2 = New System.Windows.Forms.Button()
        Me.DateTimeNaissance_Membre_Modif = New System.Windows.Forms.DateTimePicker()
        Me.Txt_Ville_Modif = New System.Windows.Forms.TextBox()
        Me.Txt_Rue_Modif = New System.Windows.Forms.TextBox()
        Me.Txt_Prenom_Modif = New System.Windows.Forms.TextBox()
        Me.Txt_Nom_Modif = New System.Windows.Forms.TextBox()
        Me.Txt_Club_Modif = New System.Windows.Forms.TextBox()
        Me.Txt_Licence_Modif = New System.Windows.Forms.TextBox()
        Me.Txt_VilleMembre = New System.Windows.Forms.Label()
        Me.Txt_PrenomMembre = New System.Windows.Forms.Label()
        Me.Txt_DateNaissanceMembre = New System.Windows.Forms.Label()
        Me.Txt_NumRueMembre = New System.Windows.Forms.Label()
        Me.Txt_NomMembre = New System.Windows.Forms.Label()
        Me.Txt_NumClubMembre = New System.Windows.Forms.Label()
        Me.Txt_LicenceMembre = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Photo_Membre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label_Prenom_Modif)
        Me.Panel2.Controls.Add(Me.Label_Nom_Modif)
        Me.Panel2.Location = New System.Drawing.Point(15, 14)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(775, 52)
        Me.Panel2.TabIndex = 22
        '
        'Label_Prenom_Modif
        '
        Me.Label_Prenom_Modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Prenom_Modif.Location = New System.Drawing.Point(403, 10)
        Me.Label_Prenom_Modif.Name = "Label_Prenom_Modif"
        Me.Label_Prenom_Modif.Size = New System.Drawing.Size(195, 30)
        Me.Label_Prenom_Modif.TabIndex = 1
        Me.Label_Prenom_Modif.Text = "Prénom"
        Me.Label_Prenom_Modif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_Nom_Modif
        '
        Me.Label_Nom_Modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Nom_Modif.Location = New System.Drawing.Point(184, 10)
        Me.Label_Nom_Modif.Name = "Label_Nom_Modif"
        Me.Label_Nom_Modif.Size = New System.Drawing.Size(195, 30)
        Me.Label_Nom_Modif.TabIndex = 0
        Me.Label_Nom_Modif.Text = "Nom"
        Me.Label_Nom_Modif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Txt_cp_Modif)
        Me.Panel1.Controls.Add(Me.Label_cp)
        Me.Panel1.Controls.Add(Me.Cmd_Enregistrer)
        Me.Panel1.Controls.Add(Me.Photo_Membre)
        Me.Panel1.Controls.Add(Me.Cmd_Retour2)
        Me.Panel1.Controls.Add(Me.DateTimeNaissance_Membre_Modif)
        Me.Panel1.Controls.Add(Me.Txt_Ville_Modif)
        Me.Panel1.Controls.Add(Me.Txt_Rue_Modif)
        Me.Panel1.Controls.Add(Me.Txt_Prenom_Modif)
        Me.Panel1.Controls.Add(Me.Txt_Nom_Modif)
        Me.Panel1.Controls.Add(Me.Txt_Club_Modif)
        Me.Panel1.Controls.Add(Me.Txt_Licence_Modif)
        Me.Panel1.Controls.Add(Me.Txt_VilleMembre)
        Me.Panel1.Controls.Add(Me.Txt_PrenomMembre)
        Me.Panel1.Controls.Add(Me.Txt_DateNaissanceMembre)
        Me.Panel1.Controls.Add(Me.Txt_NumRueMembre)
        Me.Panel1.Controls.Add(Me.Txt_NomMembre)
        Me.Panel1.Controls.Add(Me.Txt_NumClubMembre)
        Me.Panel1.Controls.Add(Me.Txt_LicenceMembre)
        Me.Panel1.Location = New System.Drawing.Point(15, 71)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(775, 371)
        Me.Panel1.TabIndex = 21
        '
        'Txt_cp_Modif
        '
        Me.Txt_cp_Modif.Location = New System.Drawing.Point(341, 196)
        Me.Txt_cp_Modif.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_cp_Modif.Name = "Txt_cp_Modif"
        Me.Txt_cp_Modif.Size = New System.Drawing.Size(200, 22)
        Me.Txt_cp_Modif.TabIndex = 21
        '
        'Label_cp
        '
        Me.Label_cp.AutoSize = True
        Me.Label_cp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_cp.Location = New System.Drawing.Point(131, 198)
        Me.Label_cp.Name = "Label_cp"
        Me.Label_cp.Size = New System.Drawing.Size(100, 20)
        Me.Label_cp.TabIndex = 20
        Me.Label_cp.Text = "Code Postal"
        '
        'Cmd_Enregistrer
        '
        Me.Cmd_Enregistrer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Enregistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Enregistrer.Location = New System.Drawing.Point(209, 309)
        Me.Cmd_Enregistrer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmd_Enregistrer.Name = "Cmd_Enregistrer"
        Me.Cmd_Enregistrer.Size = New System.Drawing.Size(132, 38)
        Me.Cmd_Enregistrer.TabIndex = 18
        Me.Cmd_Enregistrer.Text = "Enregistrer"
        Me.Cmd_Enregistrer.UseVisualStyleBackColor = True
        '
        'Photo_Membre
        '
        Me.Photo_Membre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Photo_Membre.Enabled = False
        Me.Photo_Membre.Location = New System.Drawing.Point(593, 59)
        Me.Photo_Membre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Photo_Membre.Name = "Photo_Membre"
        Me.Photo_Membre.Size = New System.Drawing.Size(143, 131)
        Me.Photo_Membre.TabIndex = 17
        Me.Photo_Membre.TabStop = False
        '
        'Cmd_Retour2
        '
        Me.Cmd_Retour2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Retour2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Retour2.Location = New System.Drawing.Point(465, 309)
        Me.Cmd_Retour2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmd_Retour2.Name = "Cmd_Retour2"
        Me.Cmd_Retour2.Size = New System.Drawing.Size(132, 38)
        Me.Cmd_Retour2.TabIndex = 16
        Me.Cmd_Retour2.Text = "Retour"
        Me.Cmd_Retour2.UseVisualStyleBackColor = True
        '
        'DateTimeNaissance_Membre_Modif
        '
        Me.DateTimeNaissance_Membre_Modif.CustomFormat = "22/01/2021"
        Me.DateTimeNaissance_Membre_Modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeNaissance_Membre_Modif.Location = New System.Drawing.Point(341, 167)
        Me.DateTimeNaissance_Membre_Modif.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimeNaissance_Membre_Modif.Name = "DateTimeNaissance_Membre_Modif"
        Me.DateTimeNaissance_Membre_Modif.Size = New System.Drawing.Size(200, 22)
        Me.DateTimeNaissance_Membre_Modif.TabIndex = 14
        Me.DateTimeNaissance_Membre_Modif.Value = New Date(2021, 1, 22, 0, 0, 0, 0)
        '
        'Txt_Ville_Modif
        '
        Me.Txt_Ville_Modif.Location = New System.Drawing.Point(341, 266)
        Me.Txt_Ville_Modif.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Ville_Modif.Name = "Txt_Ville_Modif"
        Me.Txt_Ville_Modif.Size = New System.Drawing.Size(200, 22)
        Me.Txt_Ville_Modif.TabIndex = 13
        '
        'Txt_Rue_Modif
        '
        Me.Txt_Rue_Modif.Location = New System.Drawing.Point(341, 229)
        Me.Txt_Rue_Modif.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Rue_Modif.Name = "Txt_Rue_Modif"
        Me.Txt_Rue_Modif.Size = New System.Drawing.Size(200, 22)
        Me.Txt_Rue_Modif.TabIndex = 12
        '
        'Txt_Prenom_Modif
        '
        Me.Txt_Prenom_Modif.Location = New System.Drawing.Point(341, 129)
        Me.Txt_Prenom_Modif.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Prenom_Modif.Name = "Txt_Prenom_Modif"
        Me.Txt_Prenom_Modif.Size = New System.Drawing.Size(200, 22)
        Me.Txt_Prenom_Modif.TabIndex = 11
        '
        'Txt_Nom_Modif
        '
        Me.Txt_Nom_Modif.Location = New System.Drawing.Point(341, 94)
        Me.Txt_Nom_Modif.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Nom_Modif.Name = "Txt_Nom_Modif"
        Me.Txt_Nom_Modif.Size = New System.Drawing.Size(200, 22)
        Me.Txt_Nom_Modif.TabIndex = 10
        '
        'Txt_Club_Modif
        '
        Me.Txt_Club_Modif.Location = New System.Drawing.Point(341, 59)
        Me.Txt_Club_Modif.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Club_Modif.Name = "Txt_Club_Modif"
        Me.Txt_Club_Modif.Size = New System.Drawing.Size(200, 22)
        Me.Txt_Club_Modif.TabIndex = 9
        '
        'Txt_Licence_Modif
        '
        Me.Txt_Licence_Modif.Location = New System.Drawing.Point(341, 21)
        Me.Txt_Licence_Modif.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Licence_Modif.Name = "Txt_Licence_Modif"
        Me.Txt_Licence_Modif.Size = New System.Drawing.Size(200, 22)
        Me.Txt_Licence_Modif.TabIndex = 8
        '
        'Txt_VilleMembre
        '
        Me.Txt_VilleMembre.AutoSize = True
        Me.Txt_VilleMembre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_VilleMembre.Location = New System.Drawing.Point(133, 266)
        Me.Txt_VilleMembre.Name = "Txt_VilleMembre"
        Me.Txt_VilleMembre.Size = New System.Drawing.Size(41, 20)
        Me.Txt_VilleMembre.TabIndex = 7
        Me.Txt_VilleMembre.Text = "Ville"
        '
        'Txt_PrenomMembre
        '
        Me.Txt_PrenomMembre.AutoSize = True
        Me.Txt_PrenomMembre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PrenomMembre.Location = New System.Drawing.Point(131, 129)
        Me.Txt_PrenomMembre.Name = "Txt_PrenomMembre"
        Me.Txt_PrenomMembre.Size = New System.Drawing.Size(67, 20)
        Me.Txt_PrenomMembre.TabIndex = 6
        Me.Txt_PrenomMembre.Text = "Prénom"
        '
        'Txt_DateNaissanceMembre
        '
        Me.Txt_DateNaissanceMembre.AutoSize = True
        Me.Txt_DateNaissanceMembre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DateNaissanceMembre.Location = New System.Drawing.Point(131, 167)
        Me.Txt_DateNaissanceMembre.Name = "Txt_DateNaissanceMembre"
        Me.Txt_DateNaissanceMembre.Size = New System.Drawing.Size(149, 20)
        Me.Txt_DateNaissanceMembre.TabIndex = 5
        Me.Txt_DateNaissanceMembre.Text = "Date de naissance"
        '
        'Txt_NumRueMembre
        '
        Me.Txt_NumRueMembre.AutoSize = True
        Me.Txt_NumRueMembre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NumRueMembre.Location = New System.Drawing.Point(131, 231)
        Me.Txt_NumRueMembre.Name = "Txt_NumRueMembre"
        Me.Txt_NumRueMembre.Size = New System.Drawing.Size(113, 20)
        Me.Txt_NumRueMembre.TabIndex = 4
        Me.Txt_NumRueMembre.Text = "N° et nom rue"
        '
        'Txt_NomMembre
        '
        Me.Txt_NomMembre.AutoSize = True
        Me.Txt_NomMembre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NomMembre.Location = New System.Drawing.Point(131, 94)
        Me.Txt_NomMembre.Name = "Txt_NomMembre"
        Me.Txt_NomMembre.Size = New System.Drawing.Size(44, 20)
        Me.Txt_NomMembre.TabIndex = 3
        Me.Txt_NomMembre.Text = "Nom"
        '
        'Txt_NumClubMembre
        '
        Me.Txt_NumClubMembre.AutoSize = True
        Me.Txt_NumClubMembre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NumClubMembre.Location = New System.Drawing.Point(131, 59)
        Me.Txt_NumClubMembre.Name = "Txt_NumClubMembre"
        Me.Txt_NumClubMembre.Size = New System.Drawing.Size(64, 20)
        Me.Txt_NumClubMembre.TabIndex = 2
        Me.Txt_NumClubMembre.Text = "N° club"
        '
        'Txt_LicenceMembre
        '
        Me.Txt_LicenceMembre.AutoSize = True
        Me.Txt_LicenceMembre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_LicenceMembre.Location = New System.Drawing.Point(131, 21)
        Me.Txt_LicenceMembre.Name = "Txt_LicenceMembre"
        Me.Txt_LicenceMembre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_LicenceMembre.Size = New System.Drawing.Size(86, 20)
        Me.Txt_LicenceMembre.TabIndex = 1
        Me.Txt_LicenceMembre.Text = "N° licence"
        '
        'Form_Membre_Modif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form_Membre_Modif"
        Me.Text = "Form_Membre_Modif"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Photo_Membre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label_Prenom_Modif As Label
    Friend WithEvents Label_Nom_Modif As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Txt_cp_Modif As TextBox
    Friend WithEvents Label_cp As Label
    Friend WithEvents Cmd_Enregistrer As Button
    Friend WithEvents Photo_Membre As PictureBox
    Friend WithEvents Cmd_Retour2 As Button
    Friend WithEvents DateTimeNaissance_Membre_Modif As DateTimePicker
    Friend WithEvents Txt_Ville_Modif As TextBox
    Friend WithEvents Txt_Rue_Modif As TextBox
    Friend WithEvents Txt_Prenom_Modif As TextBox
    Friend WithEvents Txt_Nom_Modif As TextBox
    Friend WithEvents Txt_Club_Modif As TextBox
    Friend WithEvents Txt_Licence_Modif As TextBox
    Friend WithEvents Txt_VilleMembre As Label
    Friend WithEvents Txt_PrenomMembre As Label
    Friend WithEvents Txt_DateNaissanceMembre As Label
    Friend WithEvents Txt_NumRueMembre As Label
    Friend WithEvents Txt_NomMembre As Label
    Friend WithEvents Txt_NumClubMembre As Label
    Friend WithEvents Txt_LicenceMembre As Label
End Class
