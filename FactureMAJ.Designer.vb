<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FactureMAJ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FactureMAJ))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Combocontrat = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dat = New System.Windows.Forms.DateTimePicker()
        Me.num = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Liste = New System.Windows.Forms.Button()
        Me.modifi = New System.Windows.Forms.Button()
        Me.Supprimer = New System.Windows.Forms.Button()
        Me.recherche = New System.Windows.Forms.Button()
        Me.Ajouter = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Wheat
        Me.Label7.Location = New System.Drawing.Point(319, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(518, 67)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Mise à jour Factures"
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.Combocontrat)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dat)
        Me.GroupBox1.Controls.Add(Me.num)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Marker", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(88, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(915, 237)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Veuillez remplire tous les champs avant de pouvoir ajouter les données a la base " & _
    "de données"
        '
        'Combocontrat
        '
        Me.Combocontrat.FormattingEnabled = True
        Me.Combocontrat.Location = New System.Drawing.Point(356, 157)
        Me.Combocontrat.Name = "Combocontrat"
        Me.Combocontrat.Size = New System.Drawing.Size(234, 36)
        Me.Combocontrat.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(201, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 24)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Num_Contrat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(201, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 24)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Date_Facture"
        '
        'dat
        '
        Me.dat.Location = New System.Drawing.Point(356, 100)
        Me.dat.Name = "dat"
        Me.dat.Size = New System.Drawing.Size(234, 35)
        Me.dat.TabIndex = 35
        '
        'num
        '
        Me.num.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num.Location = New System.Drawing.Point(356, 45)
        Me.num.Multiline = True
        Me.num.Name = "num"
        Me.num.Size = New System.Drawing.Size(234, 32)
        Me.num.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(201, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 24)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Num_Facture"
        '
        'Liste
        '
        Me.Liste.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Liste.BackgroundImage = CType(resources.GetObject("Liste.BackgroundImage"), System.Drawing.Image)
        Me.Liste.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Liste.Location = New System.Drawing.Point(831, 345)
        Me.Liste.Name = "Liste"
        Me.Liste.Size = New System.Drawing.Size(172, 69)
        Me.Liste.TabIndex = 67
        Me.Liste.UseVisualStyleBackColor = False
        '
        'modifi
        '
        Me.modifi.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.modifi.BackgroundImage = CType(resources.GetObject("modifi.BackgroundImage"), System.Drawing.Image)
        Me.modifi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.modifi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modifi.Location = New System.Drawing.Point(266, 345)
        Me.modifi.Name = "modifi"
        Me.modifi.Size = New System.Drawing.Size(172, 69)
        Me.modifi.TabIndex = 68
        Me.modifi.UseVisualStyleBackColor = False
        '
        'Supprimer
        '
        Me.Supprimer.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Supprimer.BackgroundImage = CType(resources.GetObject("Supprimer.BackgroundImage"), System.Drawing.Image)
        Me.Supprimer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Supprimer.Location = New System.Drawing.Point(644, 345)
        Me.Supprimer.Name = "Supprimer"
        Me.Supprimer.Size = New System.Drawing.Size(172, 69)
        Me.Supprimer.TabIndex = 69
        Me.Supprimer.UseVisualStyleBackColor = False
        '
        'recherche
        '
        Me.recherche.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.recherche.BackgroundImage = CType(resources.GetObject("recherche.BackgroundImage"), System.Drawing.Image)
        Me.recherche.Cursor = System.Windows.Forms.Cursors.Hand
        Me.recherche.Location = New System.Drawing.Point(459, 345)
        Me.recherche.Name = "recherche"
        Me.recherche.Size = New System.Drawing.Size(179, 69)
        Me.recherche.TabIndex = 70
        Me.recherche.UseVisualStyleBackColor = False
        '
        'Ajouter
        '
        Me.Ajouter.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Ajouter.BackgroundImage = CType(resources.GetObject("Ajouter.BackgroundImage"), System.Drawing.Image)
        Me.Ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ajouter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ajouter.Location = New System.Drawing.Point(88, 345)
        Me.Ajouter.Name = "Ajouter"
        Me.Ajouter.Size = New System.Drawing.Size(172, 69)
        Me.Ajouter.TabIndex = 71
        Me.Ajouter.UseVisualStyleBackColor = False
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(88, 420)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(915, 312)
        Me.DGV.TabIndex = 66
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.PanWest
        Me.Button2.Location = New System.Drawing.Point(88, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 74)
        Me.Button2.TabIndex = 74
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FactureMAJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1084, 661)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Liste)
        Me.Controls.Add(Me.modifi)
        Me.Controls.Add(Me.Supprimer)
        Me.Controls.Add(Me.recherche)
        Me.Controls.Add(Me.Ajouter)
        Me.Controls.Add(Me.DGV)
        Me.MaximizeBox = False
        Me.Name = "FactureMAJ"
        Me.Opacity = 0.94R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FACTURE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dat As System.Windows.Forms.DateTimePicker
    Friend WithEvents num As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Liste As System.Windows.Forms.Button
    Friend WithEvents modifi As System.Windows.Forms.Button
    Friend WithEvents Supprimer As System.Windows.Forms.Button
    Friend WithEvents recherche As System.Windows.Forms.Button
    Friend WithEvents Ajouter As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Combocontrat As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
