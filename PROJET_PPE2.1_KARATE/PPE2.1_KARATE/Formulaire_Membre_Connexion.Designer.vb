<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulaire_Membre_Connexion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmd_Creer = New System.Windows.Forms.Button()
        Me.Cmd_Consulter = New System.Windows.Forms.Button()
        Me.Cmd_Back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(582, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GESTION DES MEMBRES[MENU]"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cmd_Creer
        '
        Me.Cmd_Creer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Creer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Creer.Location = New System.Drawing.Point(202, 105)
        Me.Cmd_Creer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Cmd_Creer.Name = "Cmd_Creer"
        Me.Cmd_Creer.Size = New System.Drawing.Size(203, 49)
        Me.Cmd_Creer.TabIndex = 1
        Me.Cmd_Creer.Text = "Créer un membre"
        Me.Cmd_Creer.UseVisualStyleBackColor = True
        '
        'Cmd_Consulter
        '
        Me.Cmd_Consulter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Consulter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Consulter.Location = New System.Drawing.Point(202, 184)
        Me.Cmd_Consulter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Cmd_Consulter.Name = "Cmd_Consulter"
        Me.Cmd_Consulter.Size = New System.Drawing.Size(203, 49)
        Me.Cmd_Consulter.TabIndex = 2
        Me.Cmd_Consulter.Text = "Consulter Membre"
        Me.Cmd_Consulter.UseVisualStyleBackColor = True
        '
        'Cmd_Back
        '
        Me.Cmd_Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Back.Location = New System.Drawing.Point(230, 287)
        Me.Cmd_Back.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Cmd_Back.Name = "Cmd_Back"
        Me.Cmd_Back.Size = New System.Drawing.Size(142, 49)
        Me.Cmd_Back.TabIndex = 4
        Me.Cmd_Back.Text = "Retour"
        Me.Cmd_Back.UseVisualStyleBackColor = True
        '
        'Formulaire_Membre_Connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.Cmd_Back)
        Me.Controls.Add(Me.Cmd_Consulter)
        Me.Controls.Add(Me.Cmd_Creer)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Formulaire_Membre_Connexion"
        Me.Text = "Formulaire_Membre_Connexion"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Cmd_Creer As Button
    Friend WithEvents Cmd_Consulter As Button
    Friend WithEvents Cmd_Back As Button
End Class
