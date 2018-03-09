<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContratMAJ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContratMAJ))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.t3 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.t2 = New System.Windows.Forms.TextBox()
        Me.t1 = New System.Windows.Forms.TextBox()
        Me.dat = New System.Windows.Forms.DateTimePicker()
        Me.reserv = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cautio = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Nom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Liste = New System.Windows.Forms.Button()
        Me.Supprimer = New System.Windows.Forms.Button()
        Me.Ajouter = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Wheat
        Me.Label7.Location = New System.Drawing.Point(277, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(515, 67)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Mise à jour Contrats"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.t3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.t2)
        Me.GroupBox1.Controls.Add(Me.t1)
        Me.GroupBox1.Controls.Add(Me.dat)
        Me.GroupBox1.Controls.Add(Me.reserv)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cautio)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Nom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Marker", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(71, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(940, 299)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Veuillez remplire tous les champs avant de pouvoir ajouter les données a la base " & _
    "de données"
        '
        't3
        '
        Me.t3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.t3.Enabled = False
        Me.t3.FormattingEnabled = True
        Me.t3.Location = New System.Drawing.Point(675, 122)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(234, 36)
        Me.t3.TabIndex = 74
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(574, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 24)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Prenom"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(603, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 24)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Nom"
        '
        't2
        '
        Me.t2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.t2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t2.Location = New System.Drawing.Point(675, 182)
        Me.t2.Multiline = True
        Me.t2.Name = "t2"
        Me.t2.ReadOnly = True
        Me.t2.Size = New System.Drawing.Size(234, 40)
        Me.t2.TabIndex = 71
        '
        't1
        '
        Me.t1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.t1.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t1.Location = New System.Drawing.Point(675, 236)
        Me.t1.Multiline = True
        Me.t1.Name = "t1"
        Me.t1.ReadOnly = True
        Me.t1.Size = New System.Drawing.Size(234, 40)
        Me.t1.TabIndex = 70
        '
        'dat
        '
        Me.dat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dat.Location = New System.Drawing.Point(187, 147)
        Me.dat.Name = "dat"
        Me.dat.Size = New System.Drawing.Size(234, 35)
        Me.dat.TabIndex = 69
        '
        'reserv
        '
        Me.reserv.FormattingEnabled = True
        Me.reserv.Location = New System.Drawing.Point(675, 61)
        Me.reserv.Name = "reserv"
        Me.reserv.Size = New System.Drawing.Size(234, 36)
        Me.reserv.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(482, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 24)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Num_Reservation"
        '
        'cautio
        '
        Me.cautio.FormattingEnabled = True
        Me.cautio.Location = New System.Drawing.Point(187, 236)
        Me.cautio.Name = "cautio"
        Me.cautio.Size = New System.Drawing.Size(234, 36)
        Me.cautio.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(533, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 24)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Code_Client"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 24)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Num_Caution"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 24)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Date_Contrat"
        '
        'Nom
        '
        Me.Nom.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom.Location = New System.Drawing.Point(187, 61)
        Me.Nom.Multiline = True
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(234, 36)
        Me.Nom.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 24)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Num_Contrat"
        '
        'Liste
        '
        Me.Liste.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Liste.BackgroundImage = CType(resources.GetObject("Liste.BackgroundImage"), System.Drawing.Image)
        Me.Liste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Liste.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Liste.Location = New System.Drawing.Point(109, 414)
        Me.Liste.Name = "Liste"
        Me.Liste.Size = New System.Drawing.Size(203, 58)
        Me.Liste.TabIndex = 59
        Me.Liste.UseVisualStyleBackColor = False
        '
        'Supprimer
        '
        Me.Supprimer.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Supprimer.BackgroundImage = CType(resources.GetObject("Supprimer.BackgroundImage"), System.Drawing.Image)
        Me.Supprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Supprimer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Supprimer.Location = New System.Drawing.Point(777, 414)
        Me.Supprimer.Name = "Supprimer"
        Me.Supprimer.Size = New System.Drawing.Size(203, 58)
        Me.Supprimer.TabIndex = 61
        Me.Supprimer.UseVisualStyleBackColor = False
        '
        'Ajouter
        '
        Me.Ajouter.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Ajouter.BackgroundImage = CType(resources.GetObject("Ajouter.BackgroundImage"), System.Drawing.Image)
        Me.Ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ajouter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ajouter.Location = New System.Drawing.Point(438, 414)
        Me.Ajouter.Name = "Ajouter"
        Me.Ajouter.Size = New System.Drawing.Size(203, 58)
        Me.Ajouter.TabIndex = 63
        Me.Ajouter.UseVisualStyleBackColor = False
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(71, 478)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(940, 244)
        Me.DGV.TabIndex = 58
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.PanWest
        Me.Button2.Location = New System.Drawing.Point(71, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 74)
        Me.Button2.TabIndex = 68
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.PanEast
        Me.Button3.Location = New System.Drawing.Point(889, 13)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 74)
        Me.Button3.TabIndex = 76
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ContratMAJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1084, 661)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Liste)
        Me.Controls.Add(Me.Supprimer)
        Me.Controls.Add(Me.Ajouter)
        Me.Controls.Add(Me.DGV)
        Me.MaximizeBox = False
        Me.Name = "ContratMAJ"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTRAT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cautio As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Nom As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Liste As System.Windows.Forms.Button
    Friend WithEvents Supprimer As System.Windows.Forms.Button
    Friend WithEvents Ajouter As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dat As System.Windows.Forms.DateTimePicker
    Friend WithEvents reserv As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents t2 As System.Windows.Forms.TextBox
    Friend WithEvents t1 As System.Windows.Forms.TextBox
    Friend WithEvents t3 As System.Windows.Forms.ComboBox
End Class
