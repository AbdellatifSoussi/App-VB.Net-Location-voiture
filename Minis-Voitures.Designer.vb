<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Minis_Voitures
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Minis_Voitures))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.carbur = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Matricule = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.compt = New System.Windows.Forms.TextBox()
        Me.nbp = New System.Windows.Forms.TextBox()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.puis = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dispo = New System.Windows.Forms.TextBox()
        Me.boitev = New System.Windows.Forms.TextBox()
        Me.categ = New System.Windows.Forms.TextBox()
        Me.dat = New System.Windows.Forms.TextBox()
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        Me.pr = New System.Windows.Forms.Label()
        Me.prix = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(13, 303)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(254, 105)
        Me.Button1.TabIndex = 37
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(461, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 24)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Carburant"
        '
        'carbur
        '
        Me.carbur.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.carbur.Location = New System.Drawing.Point(568, 70)
        Me.carbur.Multiline = True
        Me.carbur.Name = "carbur"
        Me.carbur.ReadOnly = True
        Me.carbur.Size = New System.Drawing.Size(209, 39)
        Me.carbur.TabIndex = 66
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(21, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 24)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Boite à vitesse"
        '
        'Matricule
        '
        Me.Matricule.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Matricule.Location = New System.Drawing.Point(119, 23)
        Me.Matricule.Multiline = True
        Me.Matricule.Name = "Matricule"
        Me.Matricule.ReadOnly = True
        Me.Matricule.Size = New System.Drawing.Size(209, 39)
        Me.Matricule.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(124, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 24)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Puissance"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(97, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 24)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Compteur"
        '
        'compt
        '
        Me.compt.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compt.Location = New System.Drawing.Point(204, 113)
        Me.compt.Multiline = True
        Me.compt.Name = "compt"
        Me.compt.ReadOnly = True
        Me.compt.Size = New System.Drawing.Size(209, 39)
        Me.compt.TabIndex = 55
        '
        'nbp
        '
        Me.nbp.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nbp.Location = New System.Drawing.Point(685, 169)
        Me.nbp.Multiline = True
        Me.nbp.Name = "nbp"
        Me.nbp.ReadOnly = True
        Me.nbp.Size = New System.Drawing.Size(209, 39)
        Me.nbp.TabIndex = 54
        '
        'nom
        '
        Me.nom.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom.Location = New System.Drawing.Point(509, 23)
        Me.nom.Multiline = True
        Me.nom.Name = "nom"
        Me.nom.ReadOnly = True
        Me.nom.Size = New System.Drawing.Size(209, 39)
        Me.nom.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(18, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 24)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Matricule"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(497, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 24)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Nombre de places"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(449, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 24)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Nom"
        '
        'puis
        '
        Me.puis.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.puis.Location = New System.Drawing.Point(236, 162)
        Me.puis.Multiline = True
        Me.puis.Name = "puis"
        Me.puis.ReadOnly = True
        Me.puis.Size = New System.Drawing.Size(209, 39)
        Me.puis.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(33, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(222, 24)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Date mis en circulation"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(591, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 24)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Disponibilité"
        '
        'dispo
        '
        Me.dispo.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dispo.Location = New System.Drawing.Point(721, 214)
        Me.dispo.Multiline = True
        Me.dispo.Name = "dispo"
        Me.dispo.ReadOnly = True
        Me.dispo.Size = New System.Drawing.Size(209, 39)
        Me.dispo.TabIndex = 75
        '
        'boitev
        '
        Me.boitev.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boitev.Location = New System.Drawing.Point(171, 68)
        Me.boitev.Multiline = True
        Me.boitev.Name = "boitev"
        Me.boitev.ReadOnly = True
        Me.boitev.Size = New System.Drawing.Size(209, 39)
        Me.boitev.TabIndex = 77
        '
        'categ
        '
        Me.categ.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categ.Location = New System.Drawing.Point(724, 23)
        Me.categ.Multiline = True
        Me.categ.Name = "categ"
        Me.categ.ReadOnly = True
        Me.categ.Size = New System.Drawing.Size(209, 39)
        Me.categ.TabIndex = 78
        Me.categ.Visible = False
        '
        'dat
        '
        Me.dat.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dat.Location = New System.Drawing.Point(274, 207)
        Me.dat.Multiline = True
        Me.dat.Name = "dat"
        Me.dat.ReadOnly = True
        Me.dat.Size = New System.Drawing.Size(209, 39)
        Me.dat.TabIndex = 79
        '
        'DGV2
        '
        Me.DGV2.AllowUserToAddRows = False
        Me.DGV2.AllowUserToDeleteRows = False
        Me.DGV2.AllowUserToResizeColumns = False
        Me.DGV2.AllowUserToResizeRows = False
        Me.DGV2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DGV2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV2.Location = New System.Drawing.Point(12, 12)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.ReadOnly = True
        Me.DGV2.Size = New System.Drawing.Size(254, 285)
        Me.DGV2.TabIndex = 80
        '
        'pr
        '
        Me.pr.AutoSize = True
        Me.pr.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pr.ForeColor = System.Drawing.Color.Black
        Me.pr.Location = New System.Drawing.Point(476, 129)
        Me.pr.Name = "pr"
        Me.pr.Size = New System.Drawing.Size(137, 24)
        Me.pr.TabIndex = 82
        Me.pr.Text = "Prix  Location"
        '
        'prix
        '
        Me.prix.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prix.Location = New System.Drawing.Point(619, 120)
        Me.prix.Multiline = True
        Me.prix.Name = "prix"
        Me.prix.ReadOnly = True
        Me.prix.Size = New System.Drawing.Size(209, 39)
        Me.prix.TabIndex = 81
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PictureBox1.Location = New System.Drawing.Point(286, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(761, 396)
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.pr)
        Me.GroupBox1.Controls.Add(Me.prix)
        Me.GroupBox1.Controls.Add(Me.dat)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.categ)
        Me.GroupBox1.Controls.Add(Me.puis)
        Me.GroupBox1.Controls.Add(Me.boitev)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dispo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.nom)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.nbp)
        Me.GroupBox1.Controls.Add(Me.carbur)
        Me.GroupBox1.Controls.Add(Me.compt)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Matricule)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 425)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1035, 286)
        Me.GroupBox1.TabIndex = 85
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Les caractéristiques de la voiture"
        '
        'Minis_Voitures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1064, 724)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DGV2)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Minis_Voitures"
        Me.Text = "Minis_Voitures"
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents carbur As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Matricule As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents compt As System.Windows.Forms.TextBox
    Friend WithEvents nbp As System.Windows.Forms.TextBox
    Friend WithEvents nom As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents puis As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dispo As System.Windows.Forms.TextBox
    Friend WithEvents boitev As System.Windows.Forms.TextBox
    Friend WithEvents categ As System.Windows.Forms.TextBox
    Friend WithEvents dat As System.Windows.Forms.TextBox
    Friend WithEvents DGV2 As System.Windows.Forms.DataGridView
    Friend WithEvents pr As System.Windows.Forms.Label
    Friend WithEvents prix As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
