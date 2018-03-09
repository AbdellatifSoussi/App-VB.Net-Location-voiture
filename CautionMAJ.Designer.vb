<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CautionMAJ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CautionMAJ))
        Me.Liste = New System.Windows.Forms.Button()
        Me.Rechercher = New System.Windows.Forms.Button()
        Me.Supprimer = New System.Windows.Forms.Button()
        Me.Modifier = New System.Windows.Forms.Button()
        Me.Ajouter = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.num = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.valeur = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Liste
        '
        Me.Liste.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Liste.BackgroundImage = CType(resources.GetObject("Liste.BackgroundImage"), System.Drawing.Image)
        Me.Liste.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Liste.Location = New System.Drawing.Point(828, 375)
        Me.Liste.Name = "Liste"
        Me.Liste.Size = New System.Drawing.Size(172, 69)
        Me.Liste.TabIndex = 43
        Me.Liste.UseVisualStyleBackColor = False
        '
        'Rechercher
        '
        Me.Rechercher.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Rechercher.BackgroundImage = CType(resources.GetObject("Rechercher.BackgroundImage"), System.Drawing.Image)
        Me.Rechercher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Rechercher.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Rechercher.Location = New System.Drawing.Point(257, 375)
        Me.Rechercher.Name = "Rechercher"
        Me.Rechercher.Size = New System.Drawing.Size(172, 69)
        Me.Rechercher.TabIndex = 44
        Me.Rechercher.UseVisualStyleBackColor = False
        '
        'Supprimer
        '
        Me.Supprimer.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Supprimer.BackgroundImage = CType(resources.GetObject("Supprimer.BackgroundImage"), System.Drawing.Image)
        Me.Supprimer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Supprimer.Location = New System.Drawing.Point(650, 375)
        Me.Supprimer.Name = "Supprimer"
        Me.Supprimer.Size = New System.Drawing.Size(172, 69)
        Me.Supprimer.TabIndex = 45
        Me.Supprimer.UseVisualStyleBackColor = False
        '
        'Modifier
        '
        Me.Modifier.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Modifier.BackgroundImage = CType(resources.GetObject("Modifier.BackgroundImage"), System.Drawing.Image)
        Me.Modifier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Modifier.Location = New System.Drawing.Point(449, 375)
        Me.Modifier.Name = "Modifier"
        Me.Modifier.Size = New System.Drawing.Size(179, 69)
        Me.Modifier.TabIndex = 46
        Me.Modifier.UseVisualStyleBackColor = False
        '
        'Ajouter
        '
        Me.Ajouter.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Ajouter.BackgroundImage = CType(resources.GetObject("Ajouter.BackgroundImage"), System.Drawing.Image)
        Me.Ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ajouter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ajouter.Location = New System.Drawing.Point(79, 375)
        Me.Ajouter.Name = "Ajouter"
        Me.Ajouter.Size = New System.Drawing.Size(172, 69)
        Me.Ajouter.TabIndex = 47
        Me.Ajouter.UseVisualStyleBackColor = False
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(79, 456)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(921, 266)
        Me.DGV.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Wheat
        Me.Label7.Location = New System.Drawing.Point(245, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(601, 67)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Mise à jour des cautions"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.num)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.valeur)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Marker", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(79, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(921, 251)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Veuillez remplire tous les champs avant de pouvoir ajouter les données a la base " & _
    "de données"
        '
        'num
        '
        Me.num.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num.Location = New System.Drawing.Point(414, 76)
        Me.num.Multiline = True
        Me.num.Name = "num"
        Me.num.Size = New System.Drawing.Size(234, 39)
        Me.num.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(200, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 24)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Valeur_Caution (DH)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(200, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 24)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Numero_Caution"
        '
        'valeur
        '
        Me.valeur.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valeur.Location = New System.Drawing.Point(414, 158)
        Me.valeur.Multiline = True
        Me.valeur.Name = "valeur"
        Me.valeur.Size = New System.Drawing.Size(234, 39)
        Me.valeur.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.PanEast
        Me.Button1.Location = New System.Drawing.Point(898, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 74)
        Me.Button1.TabIndex = 67
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.PanWest
        Me.Button2.Location = New System.Drawing.Point(67, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 74)
        Me.Button2.TabIndex = 67
        Me.Button2.UseVisualStyleBackColor = False
        '
        'CautionMAJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1084, 661)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Liste)
        Me.Controls.Add(Me.Rechercher)
        Me.Controls.Add(Me.Supprimer)
        Me.Controls.Add(Me.Modifier)
        Me.Controls.Add(Me.Ajouter)
        Me.Controls.Add(Me.DGV)
        Me.MaximizeBox = False
        Me.Name = "CautionMAJ"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAUTION"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Liste As System.Windows.Forms.Button
    Friend WithEvents Rechercher As System.Windows.Forms.Button
    Friend WithEvents Supprimer As System.Windows.Forms.Button
    Friend WithEvents Modifier As System.Windows.Forms.Button
    Friend WithEvents Ajouter As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents num As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents valeur As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
