<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientMAJ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientMAJ))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.vil = New System.Windows.Forms.TextBox()
        Me.tel = New System.Windows.Forms.TextBox()
        Me.Liste = New System.Windows.Forms.Button()
        Me.midifie = New System.Windows.Forms.Button()
        Me.Supprimer = New System.Windows.Forms.Button()
        Me.recherch = New System.Windows.Forms.Button()
        Me.Ajouter = New System.Windows.Forms.Button()
        Me.Pre = New System.Windows.Forms.TextBox()
        Me.Code = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.numres = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mdp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Nom = New System.Windows.Forms.TextBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.numres.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(587, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 24)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Ville"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(583, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 24)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "GSM"
        '
        'vil
        '
        Me.vil.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vil.Location = New System.Drawing.Point(660, 110)
        Me.vil.Multiline = True
        Me.vil.Name = "vil"
        Me.vil.Size = New System.Drawing.Size(266, 37)
        Me.vil.TabIndex = 37
        '
        'tel
        '
        Me.tel.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tel.Location = New System.Drawing.Point(660, 176)
        Me.tel.Multiline = True
        Me.tel.Name = "tel"
        Me.tel.Size = New System.Drawing.Size(266, 37)
        Me.tel.TabIndex = 36
        '
        'Liste
        '
        Me.Liste.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Liste.BackgroundImage = CType(resources.GetObject("Liste.BackgroundImage"), System.Drawing.Image)
        Me.Liste.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Liste.Location = New System.Drawing.Point(844, 330)
        Me.Liste.Name = "Liste"
        Me.Liste.Size = New System.Drawing.Size(172, 69)
        Me.Liste.TabIndex = 30
        Me.Liste.UseVisualStyleBackColor = False
        '
        'midifie
        '
        Me.midifie.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.midifie.BackgroundImage = CType(resources.GetObject("midifie.BackgroundImage"), System.Drawing.Image)
        Me.midifie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.midifie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.midifie.Location = New System.Drawing.Point(261, 330)
        Me.midifie.Name = "midifie"
        Me.midifie.Size = New System.Drawing.Size(172, 69)
        Me.midifie.TabIndex = 31
        Me.midifie.UseVisualStyleBackColor = False
        '
        'Supprimer
        '
        Me.Supprimer.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Supprimer.BackgroundImage = CType(resources.GetObject("Supprimer.BackgroundImage"), System.Drawing.Image)
        Me.Supprimer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Supprimer.Location = New System.Drawing.Point(654, 330)
        Me.Supprimer.Name = "Supprimer"
        Me.Supprimer.Size = New System.Drawing.Size(172, 69)
        Me.Supprimer.TabIndex = 32
        Me.Supprimer.UseVisualStyleBackColor = False
        '
        'recherch
        '
        Me.recherch.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.recherch.BackgroundImage = CType(resources.GetObject("recherch.BackgroundImage"), System.Drawing.Image)
        Me.recherch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.recherch.Location = New System.Drawing.Point(451, 330)
        Me.recherch.Name = "recherch"
        Me.recherch.Size = New System.Drawing.Size(179, 69)
        Me.recherch.TabIndex = 33
        Me.recherch.UseVisualStyleBackColor = False
        '
        'Ajouter
        '
        Me.Ajouter.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Ajouter.BackgroundImage = CType(resources.GetObject("Ajouter.BackgroundImage"), System.Drawing.Image)
        Me.Ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ajouter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ajouter.Location = New System.Drawing.Point(66, 330)
        Me.Ajouter.Name = "Ajouter"
        Me.Ajouter.Size = New System.Drawing.Size(172, 69)
        Me.Ajouter.TabIndex = 34
        Me.Ajouter.UseVisualStyleBackColor = False
        '
        'Pre
        '
        Me.Pre.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pre.Location = New System.Drawing.Point(660, 44)
        Me.Pre.Multiline = True
        Me.Pre.Name = "Pre"
        Me.Pre.Size = New System.Drawing.Size(266, 37)
        Me.Pre.TabIndex = 26
        '
        'Code
        '
        Me.Code.BackColor = System.Drawing.Color.White
        Me.Code.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Code.Location = New System.Drawing.Point(96, 110)
        Me.Code.Multiline = True
        Me.Code.Name = "Code"
        Me.Code.Size = New System.Drawing.Size(266, 37)
        Me.Code.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(555, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 24)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Prénom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(26, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 24)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(26, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 24)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Code"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(66, 405)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(950, 304)
        Me.DGV.TabIndex = 42
        '
        'numres
        '
        Me.numres.Controls.Add(Me.Label9)
        Me.numres.Controls.Add(Me.mail)
        Me.numres.Controls.Add(Me.tel)
        Me.numres.Controls.Add(Me.Label3)
        Me.numres.Controls.Add(Me.vil)
        Me.numres.Controls.Add(Me.Label5)
        Me.numres.Controls.Add(Me.Pre)
        Me.numres.Controls.Add(Me.Label2)
        Me.numres.Controls.Add(Me.Label4)
        Me.numres.Controls.Add(Me.Label1)
        Me.numres.Controls.Add(Me.Code)
        Me.numres.Controls.Add(Me.Nom)
        Me.numres.Font = New System.Drawing.Font("Segoe Marker", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numres.Location = New System.Drawing.Point(66, 76)
        Me.numres.Name = "numres"
        Me.numres.Size = New System.Drawing.Size(950, 235)
        Me.numres.TabIndex = 43
        Me.numres.TabStop = False
        Me.numres.Text = "Veuillez remplire tous les champs avant de pouvoir ajouter les données a la base " & _
    "de données"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(17, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 24)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "E-Mail"
        '
        'mail
        '
        Me.mail.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mail.Location = New System.Drawing.Point(96, 176)
        Me.mail.Multiline = True
        Me.mail.Name = "mail"
        Me.mail.Size = New System.Drawing.Size(267, 37)
        Me.mail.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(165, 629)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 24)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "MDP"
        Me.Label6.Visible = False
        '
        'mdp
        '
        Me.mdp.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mdp.Location = New System.Drawing.Point(273, 614)
        Me.mdp.Multiline = True
        Me.mdp.Name = "mdp"
        Me.mdp.Size = New System.Drawing.Size(221, 44)
        Me.mdp.TabIndex = 47
        Me.mdp.Visible = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Wheat
        Me.Label7.Location = New System.Drawing.Point(212, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(564, 67)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Mise à jour des clients"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.PanEast
        Me.Button1.Location = New System.Drawing.Point(894, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 74)
        Me.Button1.TabIndex = 67
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Nom
        '
        Me.Nom.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom.Location = New System.Drawing.Point(97, 45)
        Me.Nom.Multiline = True
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(266, 37)
        Me.Nom.TabIndex = 27
        '
        'ClientMAJ
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1080, 657)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.mdp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.numres)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Liste)
        Me.Controls.Add(Me.midifie)
        Me.Controls.Add(Me.Supprimer)
        Me.Controls.Add(Me.recherch)
        Me.Controls.Add(Me.Ajouter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "ClientMAJ"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLIENT"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.numres.ResumeLayout(False)
        Me.numres.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents vil As System.Windows.Forms.TextBox
    Friend WithEvents tel As System.Windows.Forms.TextBox
    Friend WithEvents Liste As System.Windows.Forms.Button
    Friend WithEvents midifie As System.Windows.Forms.Button
    Friend WithEvents Supprimer As System.Windows.Forms.Button
    Friend WithEvents recherch As System.Windows.Forms.Button
    Friend WithEvents Ajouter As System.Windows.Forms.Button
    Friend WithEvents Pre As System.Windows.Forms.TextBox
    Friend WithEvents Code As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents numres As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents mail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mdp As System.Windows.Forms.TextBox
    Friend WithEvents Nom As System.Windows.Forms.TextBox
End Class
