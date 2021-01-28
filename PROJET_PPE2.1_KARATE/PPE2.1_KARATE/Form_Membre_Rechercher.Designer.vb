<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Membre_Rechercher
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
        Me.Txt_RechLicence = New System.Windows.Forms.Label()
        Me.Txt_RechNom = New System.Windows.Forms.Label()
        Me.Txt_NomRechercher = New System.Windows.Forms.TextBox()
        Me.Txt_PrenomRechercher = New System.Windows.Forms.TextBox()
        Me.Cmd_Rechercher = New System.Windows.Forms.Button()
        Me.Cmd_Retour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txt_Creer
        '
        Me.Txt_Creer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Creer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Creer.Location = New System.Drawing.Point(12, 9)
        Me.Txt_Creer.Name = "Txt_Creer"
        Me.Txt_Creer.Size = New System.Drawing.Size(775, 45)
        Me.Txt_Creer.TabIndex = 1
        Me.Txt_Creer.Text = "Rechercher un Membre"
        Me.Txt_Creer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_RechLicence
        '
        Me.Txt_RechLicence.AutoSize = True
        Me.Txt_RechLicence.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_RechLicence.Location = New System.Drawing.Point(67, 206)
        Me.Txt_RechLicence.Name = "Txt_RechLicence"
        Me.Txt_RechLicence.Size = New System.Drawing.Size(143, 20)
        Me.Txt_RechLicence.TabIndex = 2
        Me.Txt_RechLicence.Text = "Nom du Membre :"
        '
        'Txt_RechNom
        '
        Me.Txt_RechNom.AutoSize = True
        Me.Txt_RechNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_RechNom.Location = New System.Drawing.Point(67, 258)
        Me.Txt_RechNom.Name = "Txt_RechNom"
        Me.Txt_RechNom.Size = New System.Drawing.Size(171, 20)
        Me.Txt_RechNom.TabIndex = 3
        Me.Txt_RechNom.Text = "Prénom du Membre : "
        '
        'Txt_NomRechercher
        '
        Me.Txt_NomRechercher.Location = New System.Drawing.Point(267, 202)
        Me.Txt_NomRechercher.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_NomRechercher.Name = "Txt_NomRechercher"
        Me.Txt_NomRechercher.Size = New System.Drawing.Size(225, 22)
        Me.Txt_NomRechercher.TabIndex = 4
        '
        'Txt_PrenomRechercher
        '
        Me.Txt_PrenomRechercher.Location = New System.Drawing.Point(267, 257)
        Me.Txt_PrenomRechercher.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_PrenomRechercher.Name = "Txt_PrenomRechercher"
        Me.Txt_PrenomRechercher.Size = New System.Drawing.Size(225, 22)
        Me.Txt_PrenomRechercher.TabIndex = 5
        '
        'Cmd_Rechercher
        '
        Me.Cmd_Rechercher.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Rechercher.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Rechercher.Location = New System.Drawing.Point(540, 206)
        Me.Cmd_Rechercher.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmd_Rechercher.Name = "Cmd_Rechercher"
        Me.Cmd_Rechercher.Size = New System.Drawing.Size(213, 60)
        Me.Cmd_Rechercher.TabIndex = 6
        Me.Cmd_Rechercher.Text = "Rechercher"
        Me.Cmd_Rechercher.UseVisualStyleBackColor = True
        '
        'Cmd_Retour
        '
        Me.Cmd_Retour.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Retour.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Retour.Location = New System.Drawing.Point(335, 374)
        Me.Cmd_Retour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmd_Retour.Name = "Cmd_Retour"
        Me.Cmd_Retour.Size = New System.Drawing.Size(132, 38)
        Me.Cmd_Retour.TabIndex = 17
        Me.Cmd_Retour.Text = "Retour"
        Me.Cmd_Retour.UseVisualStyleBackColor = True
        '
        'Form_Membre_Rechercher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Cmd_Retour)
        Me.Controls.Add(Me.Cmd_Rechercher)
        Me.Controls.Add(Me.Txt_PrenomRechercher)
        Me.Controls.Add(Me.Txt_NomRechercher)
        Me.Controls.Add(Me.Txt_RechNom)
        Me.Controls.Add(Me.Txt_RechLicence)
        Me.Controls.Add(Me.Txt_Creer)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form_Membre_Rechercher"
        Me.Text = "Form_Membre_CA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Creer As Label
    Friend WithEvents Txt_RechLicence As Label
    Friend WithEvents Txt_RechNom As Label
    Friend WithEvents Txt_NomRechercher As TextBox
    Friend WithEvents Txt_PrenomRechercher As TextBox
    Friend WithEvents Cmd_Rechercher As Button
    Friend WithEvents Cmd_Retour As Button
End Class
