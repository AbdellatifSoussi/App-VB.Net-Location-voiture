<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VoituresMAJ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VoituresMAJ))
        Me.Matricule = New System.Windows.Forms.TextBox()
        Me.nbp = New System.Windows.Forms.TextBox()
        Me.puis = New System.Windows.Forms.TextBox()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.compt = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Actualiser = New System.Windows.Forms.Button()
        Me.Modifier = New System.Windows.Forms.Button()
        Me.Supprimer = New System.Windows.Forms.Button()
        Me.Recherche = New System.Windows.Forms.Button()
        Me.Ajouter = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dat = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.R2 = New System.Windows.Forms.RadioButton()
        Me.R1 = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.categ = New System.Windows.Forms.ComboBox()
        Me.carbur = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.prix = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nomimg = New System.Windows.Forms.TextBox()
        Me.Boitev = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.locatpict = New System.Windows.Forms.Button()
        Me.PICTBOX = New System.Windows.Forms.PictureBox()
        Me.codca = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Dispo = New System.Windows.Forms.ComboBox()
        Me.Di = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PICTBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Matricule
        '
        Me.Matricule.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Matricule.Location = New System.Drawing.Point(187, 47)
        Me.Matricule.Multiline = True
        Me.Matricule.Name = "Matricule"
        Me.Matricule.Size = New System.Drawing.Size(234, 39)
        Me.Matricule.TabIndex = 28
        '
        'nbp
        '
        Me.nbp.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nbp.Location = New System.Drawing.Point(655, 111)
        Me.nbp.Multiline = True
        Me.nbp.Name = "nbp"
        Me.nbp.Size = New System.Drawing.Size(234, 39)
        Me.nbp.TabIndex = 28
        '
        'puis
        '
        Me.puis.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.puis.Location = New System.Drawing.Point(655, 178)
        Me.puis.Multiline = True
        Me.puis.Name = "puis"
        Me.puis.Size = New System.Drawing.Size(234, 39)
        Me.puis.TabIndex = 28
        '
        'nom
        '
        Me.nom.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom.Location = New System.Drawing.Point(655, 47)
        Me.nom.Multiline = True
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(234, 39)
        Me.nom.TabIndex = 28
        '
        'compt
        '
        Me.compt.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compt.Location = New System.Drawing.Point(187, 118)
        Me.compt.Multiline = True
        Me.compt.Name = "compt"
        Me.compt.Size = New System.Drawing.Size(234, 39)
        Me.compt.TabIndex = 28
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeColumns = False
        Me.DGV.AllowUserToResizeRows = False
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 529)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(1266, 282)
        Me.DGV.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 24)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Matricule"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(222, 24)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Date mis en circulation"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(449, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 24)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Nombre de places"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(525, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 24)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Puissance"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(577, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 24)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Nom"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 24)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Compteur"
        '
        'Actualiser
        '
        Me.Actualiser.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Actualiser.BackgroundImage = CType(resources.GetObject("Actualiser.BackgroundImage"), System.Drawing.Image)
        Me.Actualiser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Actualiser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Actualiser.Location = New System.Drawing.Point(1031, 454)
        Me.Actualiser.Name = "Actualiser"
        Me.Actualiser.Size = New System.Drawing.Size(243, 69)
        Me.Actualiser.TabIndex = 37
        Me.Actualiser.UseVisualStyleBackColor = False
        '
        'Modifier
        '
        Me.Modifier.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Modifier.BackgroundImage = CType(resources.GetObject("Modifier.BackgroundImage"), System.Drawing.Image)
        Me.Modifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Modifier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Modifier.Location = New System.Drawing.Point(262, 454)
        Me.Modifier.Name = "Modifier"
        Me.Modifier.Size = New System.Drawing.Size(243, 69)
        Me.Modifier.TabIndex = 38
        Me.Modifier.UseVisualStyleBackColor = False
        '
        'Supprimer
        '
        Me.Supprimer.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Supprimer.BackgroundImage = CType(resources.GetObject("Supprimer.BackgroundImage"), System.Drawing.Image)
        Me.Supprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Supprimer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Supprimer.Location = New System.Drawing.Point(775, 454)
        Me.Supprimer.Name = "Supprimer"
        Me.Supprimer.Size = New System.Drawing.Size(243, 69)
        Me.Supprimer.TabIndex = 39
        Me.Supprimer.UseVisualStyleBackColor = False
        '
        'Recherche
        '
        Me.Recherche.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Recherche.BackgroundImage = CType(resources.GetObject("Recherche.BackgroundImage"), System.Drawing.Image)
        Me.Recherche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Recherche.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Recherche.Location = New System.Drawing.Point(518, 454)
        Me.Recherche.Name = "Recherche"
        Me.Recherche.Size = New System.Drawing.Size(243, 69)
        Me.Recherche.TabIndex = 40
        Me.Recherche.UseVisualStyleBackColor = False
        '
        'Ajouter
        '
        Me.Ajouter.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Ajouter.BackgroundImage = CType(resources.GetObject("Ajouter.BackgroundImage"), System.Drawing.Image)
        Me.Ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ajouter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ajouter.Location = New System.Drawing.Point(12, 454)
        Me.Ajouter.Name = "Ajouter"
        Me.Ajouter.Size = New System.Drawing.Size(243, 69)
        Me.Ajouter.TabIndex = 41
        Me.Ajouter.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.dat)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.categ)
        Me.GroupBox1.Controls.Add(Me.carbur)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.prix)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.nomimg)
        Me.GroupBox1.Controls.Add(Me.Boitev)
        Me.GroupBox1.Controls.Add(Me.Matricule)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.compt)
        Me.GroupBox1.Controls.Add(Me.nbp)
        Me.GroupBox1.Controls.Add(Me.nom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.puis)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Marker", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox1.Location = New System.Drawing.Point(12, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1262, 386)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Veuillez remplire tous les champs avant de pouvoir ajouter les données a la base " & _
    "de données"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(487, 293)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(144, 24)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "Boite à vitesse"
        '
        'dat
        '
        Me.dat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dat.Location = New System.Drawing.Point(250, 314)
        Me.dat.Name = "dat"
        Me.dat.Size = New System.Drawing.Size(171, 35)
        Me.dat.TabIndex = 60
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox2.Controls.Add(Me.R2)
        Me.GroupBox2.Controls.Add(Me.R1)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe Print", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(962, 111)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(271, 156)
        Me.GroupBox2.TabIndex = 59
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Disponibilité"
        '
        'R2
        '
        Me.R2.AutoSize = True
        Me.R2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.R2.Font = New System.Drawing.Font("Segoe Marker", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R2.Location = New System.Drawing.Point(6, 75)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(131, 59)
        Me.R2.TabIndex = 58
        Me.R2.TabStop = True
        Me.R2.Text = "NON"
        Me.R2.UseVisualStyleBackColor = True
        '
        'R1
        '
        Me.R1.AutoSize = True
        Me.R1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.R1.Font = New System.Drawing.Font("Segoe Marker", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.Location = New System.Drawing.Point(155, 75)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(110, 59)
        Me.R1.TabIndex = 57
        Me.R1.TabStop = True
        Me.R1.Text = "OUI"
        Me.R1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(525, 245)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 24)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Catégorie"
        '
        'categ
        '
        Me.categ.FormattingEnabled = True
        Me.categ.Location = New System.Drawing.Point(655, 239)
        Me.categ.Name = "categ"
        Me.categ.Size = New System.Drawing.Size(234, 36)
        Me.categ.TabIndex = 49
        '
        'carbur
        '
        Me.carbur.FormattingEnabled = True
        Me.carbur.Items.AddRange(New Object() {"Essence", "Diesel"})
        Me.carbur.Location = New System.Drawing.Point(655, 334)
        Me.carbur.Name = "carbur"
        Me.carbur.Size = New System.Drawing.Size(234, 36)
        Me.carbur.TabIndex = 52
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(14, 252)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 24)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Prix"
        '
        'prix
        '
        Me.prix.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prix.Location = New System.Drawing.Point(187, 252)
        Me.prix.Multiline = True
        Me.prix.Name = "prix"
        Me.prix.Size = New System.Drawing.Size(234, 35)
        Me.prix.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(14, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(157, 24)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Nom de l'image"
        '
        'nomimg
        '
        Me.nomimg.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomimg.Location = New System.Drawing.Point(187, 186)
        Me.nomimg.Multiline = True
        Me.nomimg.Name = "nomimg"
        Me.nomimg.Size = New System.Drawing.Size(234, 39)
        Me.nomimg.TabIndex = 45
        '
        'Boitev
        '
        Me.Boitev.FormattingEnabled = True
        Me.Boitev.Items.AddRange(New Object() {"Automatique", "Manuel"})
        Me.Boitev.Location = New System.Drawing.Point(655, 287)
        Me.Boitev.Name = "Boitev"
        Me.Boitev.Size = New System.Drawing.Size(234, 36)
        Me.Boitev.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(524, 340)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 24)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Carburant"
        '
        'locatpict
        '
        Me.locatpict.Location = New System.Drawing.Point(954, 623)
        Me.locatpict.Name = "locatpict"
        Me.locatpict.Size = New System.Drawing.Size(75, 55)
        Me.locatpict.TabIndex = 47
        Me.locatpict.Text = "..."
        Me.locatpict.UseVisualStyleBackColor = True
        Me.locatpict.Visible = False
        '
        'PICTBOX
        '
        Me.PICTBOX.BackColor = System.Drawing.Color.Honeydew
        Me.PICTBOX.ErrorImage = Nothing
        Me.PICTBOX.InitialImage = Nothing
        Me.PICTBOX.Location = New System.Drawing.Point(1050, 588)
        Me.PICTBOX.Name = "PICTBOX"
        Me.PICTBOX.Size = New System.Drawing.Size(171, 133)
        Me.PICTBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PICTBOX.TabIndex = 46
        Me.PICTBOX.TabStop = False
        Me.PICTBOX.Visible = False
        '
        'codca
        '
        Me.codca.FormattingEnabled = True
        Me.codca.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.codca.Location = New System.Drawing.Point(262, 623)
        Me.codca.Name = "codca"
        Me.codca.Size = New System.Drawing.Size(178, 21)
        Me.codca.TabIndex = 53
        Me.codca.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(616, 632)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 24)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Boite à vitesse"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(100, 628)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(156, 24)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Code Catégorie"
        Me.Label13.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Wheat
        Me.Label7.Location = New System.Drawing.Point(356, -8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(498, 67)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Mise à jour voitures"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Dispo
        '
        Me.Dispo.FormattingEnabled = True
        Me.Dispo.ItemHeight = 13
        Me.Dispo.Items.AddRange(New Object() {"OUI", "NON"})
        Me.Dispo.Location = New System.Drawing.Point(262, 658)
        Me.Dispo.Name = "Dispo"
        Me.Dispo.Size = New System.Drawing.Size(178, 21)
        Me.Dispo.TabIndex = 55
        Me.Dispo.Visible = False
        '
        'Di
        '
        Me.Di.AutoSize = True
        Me.Di.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Di.ForeColor = System.Drawing.Color.White
        Me.Di.Location = New System.Drawing.Point(172, 658)
        Me.Di.Name = "Di"
        Me.Di.Size = New System.Drawing.Size(63, 24)
        Me.Di.TabIndex = 56
        Me.Di.Text = "Dispo"
        Me.Di.Visible = False
        '
        'VoituresMAJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1290, 733)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.locatpict)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Actualiser)
        Me.Controls.Add(Me.PICTBOX)
        Me.Controls.Add(Me.codca)
        Me.Controls.Add(Me.Modifier)
        Me.Controls.Add(Me.Di)
        Me.Controls.Add(Me.Supprimer)
        Me.Controls.Add(Me.Dispo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Recherche)
        Me.Controls.Add(Me.Ajouter)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label8)
        Me.Name = "VoituresMAJ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LES VOITURES"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PICTBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Matricule As System.Windows.Forms.TextBox
    Friend WithEvents nbp As System.Windows.Forms.TextBox
    Friend WithEvents puis As System.Windows.Forms.TextBox
    Friend WithEvents nom As System.Windows.Forms.TextBox
    Friend WithEvents compt As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Actualiser As System.Windows.Forms.Button
    Friend WithEvents Modifier As System.Windows.Forms.Button
    Friend WithEvents Supprimer As System.Windows.Forms.Button
    Friend WithEvents Recherche As System.Windows.Forms.Button
    Friend WithEvents Ajouter As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PICTBOX As System.Windows.Forms.PictureBox
    Friend WithEvents locatpict As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Boitev As System.Windows.Forms.ComboBox
    Friend WithEvents categ As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents prix As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents nomimg As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents carbur As System.Windows.Forms.ComboBox
    Friend WithEvents codca As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Di As System.Windows.Forms.Label
    Friend WithEvents Dispo As System.Windows.Forms.ComboBox
    Friend WithEvents R2 As System.Windows.Forms.RadioButton
    Friend WithEvents R1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dat As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
