<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservationMAJ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReservationMAJ))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.p = New System.Windows.Forms.Label()
        Me.n = New System.Windows.Forms.Label()
        Me.prenomclient = New System.Windows.Forms.TextBox()
        Me.nomclient = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.datfin = New System.Windows.Forms.DateTimePicker()
        Me.Matreserv = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.datdeb = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.datres = New System.Windows.Forms.DateTimePicker()
        Me.numres = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Actualiser = New System.Windows.Forms.Button()
        Me.Modifier = New System.Windows.Forms.Button()
        Me.Supprimer = New System.Windows.Forms.Button()
        Me.Recherche = New System.Windows.Forms.Button()
        Me.Ajouter = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.Label7.Location = New System.Drawing.Point(237, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(606, 67)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Mise à jour Reservations"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.p)
        Me.GroupBox1.Controls.Add(Me.n)
        Me.GroupBox1.Controls.Add(Me.prenomclient)
        Me.GroupBox1.Controls.Add(Me.nomclient)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cb1)
        Me.GroupBox1.Controls.Add(Me.datfin)
        Me.GroupBox1.Controls.Add(Me.Matreserv)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.datdeb)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.datres)
        Me.GroupBox1.Controls.Add(Me.numres)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Marker", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(65, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(953, 271)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Veuillez remplire tous les champs avant de pouvoir ajouter les données a la base " & _
    "de données"
        '
        'p
        '
        Me.p.AutoSize = True
        Me.p.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p.ForeColor = System.Drawing.Color.White
        Me.p.Location = New System.Drawing.Point(454, 226)
        Me.p.Name = "p"
        Me.p.Size = New System.Drawing.Size(147, 24)
        Me.p.TabIndex = 55
        Me.p.Text = "Prénom_Client"
        '
        'n
        '
        Me.n.AutoSize = True
        Me.n.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.n.ForeColor = System.Drawing.Color.White
        Me.n.Location = New System.Drawing.Point(483, 180)
        Me.n.Name = "n"
        Me.n.Size = New System.Drawing.Size(118, 24)
        Me.n.TabIndex = 54
        Me.n.Text = "Nom_Client"
        '
        'prenomclient
        '
        Me.prenomclient.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prenomclient.Location = New System.Drawing.Point(635, 219)
        Me.prenomclient.Multiline = True
        Me.prenomclient.Name = "prenomclient"
        Me.prenomclient.Size = New System.Drawing.Size(278, 32)
        Me.prenomclient.TabIndex = 53
        '
        'nomclient
        '
        Me.nomclient.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomclient.Location = New System.Drawing.Point(635, 173)
        Me.nomclient.Multiline = True
        Me.nomclient.Name = "nomclient"
        Me.nomclient.Size = New System.Drawing.Size(278, 32)
        Me.nomclient.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(477, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 24)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Code_Client"
        '
        'cb1
        '
        Me.cb1.FormattingEnabled = True
        Me.cb1.Location = New System.Drawing.Point(635, 118)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(278, 36)
        Me.cb1.TabIndex = 50
        '
        'datfin
        '
        Me.datfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datfin.Location = New System.Drawing.Point(635, 77)
        Me.datfin.Name = "datfin"
        Me.datfin.Size = New System.Drawing.Size(278, 35)
        Me.datfin.TabIndex = 49
        '
        'Matreserv
        '
        Me.Matreserv.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Matreserv.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Matreserv.Location = New System.Drawing.Point(216, 165)
        Me.Matreserv.Multiline = True
        Me.Matreserv.Name = "Matreserv"
        Me.Matreserv.ReadOnly = True
        Me.Matreserv.Size = New System.Drawing.Size(234, 32)
        Me.Matreserv.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(98, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 24)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Matricule"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(508, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 24)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Date_Fin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(483, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 24)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Date_Début"
        '
        'datdeb
        '
        Me.datdeb.CustomFormat = "01/06/2016 02:03"
        Me.datdeb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datdeb.Location = New System.Drawing.Point(635, 34)
        Me.datdeb.MinDate = New Date(2016, 6, 1, 0, 0, 0, 0)
        Me.datdeb.Name = "datdeb"
        Me.datdeb.Size = New System.Drawing.Size(278, 35)
        Me.datdeb.TabIndex = 39
        Me.datdeb.Value = New Date(2016, 6, 1, 2, 3, 52, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 24)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Date_Reservation"
        '
        'datres
        '
        Me.datres.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datres.Location = New System.Drawing.Point(216, 104)
        Me.datres.Name = "datres"
        Me.datres.Size = New System.Drawing.Size(234, 35)
        Me.datres.TabIndex = 35
        '
        'numres
        '
        Me.numres.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numres.Location = New System.Drawing.Point(216, 42)
        Me.numres.Multiline = True
        Me.numres.Name = "numres"
        Me.numres.Size = New System.Drawing.Size(234, 32)
        Me.numres.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 24)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Num_Reservation"
        '
        'Actualiser
        '
        Me.Actualiser.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Actualiser.BackgroundImage = CType(resources.GetObject("Actualiser.BackgroundImage"), System.Drawing.Image)
        Me.Actualiser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Actualiser.Location = New System.Drawing.Point(846, 369)
        Me.Actualiser.Name = "Actualiser"
        Me.Actualiser.Size = New System.Drawing.Size(172, 69)
        Me.Actualiser.TabIndex = 59
        Me.Actualiser.UseVisualStyleBackColor = False
        '
        'Modifier
        '
        Me.Modifier.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Modifier.BackgroundImage = CType(resources.GetObject("Modifier.BackgroundImage"), System.Drawing.Image)
        Me.Modifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Modifier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Modifier.Location = New System.Drawing.Point(259, 369)
        Me.Modifier.Name = "Modifier"
        Me.Modifier.Size = New System.Drawing.Size(172, 69)
        Me.Modifier.TabIndex = 60
        Me.Modifier.UseVisualStyleBackColor = False
        '
        'Supprimer
        '
        Me.Supprimer.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Supprimer.BackgroundImage = CType(resources.GetObject("Supprimer.BackgroundImage"), System.Drawing.Image)
        Me.Supprimer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Supprimer.Location = New System.Drawing.Point(656, 369)
        Me.Supprimer.Name = "Supprimer"
        Me.Supprimer.Size = New System.Drawing.Size(172, 69)
        Me.Supprimer.TabIndex = 61
        Me.Supprimer.UseVisualStyleBackColor = False
        '
        'Recherche
        '
        Me.Recherche.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Recherche.BackgroundImage = CType(resources.GetObject("Recherche.BackgroundImage"), System.Drawing.Image)
        Me.Recherche.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Recherche.Location = New System.Drawing.Point(452, 369)
        Me.Recherche.Name = "Recherche"
        Me.Recherche.Size = New System.Drawing.Size(179, 69)
        Me.Recherche.TabIndex = 62
        Me.Recherche.UseVisualStyleBackColor = False
        '
        'Ajouter
        '
        Me.Ajouter.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Ajouter.BackgroundImage = CType(resources.GetObject("Ajouter.BackgroundImage"), System.Drawing.Image)
        Me.Ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ajouter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ajouter.Location = New System.Drawing.Point(68, 369)
        Me.Ajouter.Name = "Ajouter"
        Me.Ajouter.Size = New System.Drawing.Size(172, 69)
        Me.Ajouter.TabIndex = 63
        Me.Ajouter.UseVisualStyleBackColor = False
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(68, 444)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(950, 278)
        Me.DGV.TabIndex = 58
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.PanEast
        Me.Button1.Location = New System.Drawing.Point(896, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 74)
        Me.Button1.TabIndex = 66
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.PanWest
        Me.Button2.Location = New System.Drawing.Point(65, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 74)
        Me.Button2.TabIndex = 69
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ReservationMAJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1084, 661)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Actualiser)
        Me.Controls.Add(Me.Modifier)
        Me.Controls.Add(Me.Supprimer)
        Me.Controls.Add(Me.Recherche)
        Me.Controls.Add(Me.Ajouter)
        Me.Controls.Add(Me.DGV)
        Me.MaximizeBox = False
        Me.Name = "ReservationMAJ"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RESERVATION"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents datres As System.Windows.Forms.DateTimePicker
    Friend WithEvents numres As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Actualiser As System.Windows.Forms.Button
    Friend WithEvents Modifier As System.Windows.Forms.Button
    Friend WithEvents Supprimer As System.Windows.Forms.Button
    Friend WithEvents Recherche As System.Windows.Forms.Button
    Friend WithEvents Ajouter As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents datdeb As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Matreserv As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents datfin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cb1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents p As System.Windows.Forms.Label
    Friend WithEvents n As System.Windows.Forms.Label
    Friend WithEvents prenomclient As System.Windows.Forms.TextBox
    Friend WithEvents nomclient As System.Windows.Forms.TextBox
End Class
