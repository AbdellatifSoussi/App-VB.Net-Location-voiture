<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Authentification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Authentification))
        Me.NomS = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.G1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.G1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NomS
        '
        Me.NomS.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomS.ForeColor = System.Drawing.SystemColors.Highlight
        Me.NomS.Location = New System.Drawing.Point(350, 73)
        Me.NomS.Multiline = True
        Me.NomS.Name = "NomS"
        Me.NomS.Size = New System.Drawing.Size(237, 36)
        Me.NomS.TabIndex = 13
        Me.NomS.Text = "localhost"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(142, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 36)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nom Serveur"
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Blue
        Me.Button2.Location = New System.Drawing.Point(340, 365)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(205, 52)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Annuler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(129, 365)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(205, 52)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Se connecter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'G1
        '
        Me.G1.BackColor = System.Drawing.Color.Transparent
        Me.G1.BackgroundImage = CType(resources.GetObject("G1.BackgroundImage"), System.Drawing.Image)
        Me.G1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.G1.Controls.Add(Me.Label3)
        Me.G1.Controls.Add(Me.Label1)
        Me.G1.Controls.Add(Me.TextBox2)
        Me.G1.Controls.Add(Me.TextBox1)
        Me.G1.Controls.Add(Me.Label2)
        Me.G1.Controls.Add(Me.Button1)
        Me.G1.Controls.Add(Me.Button2)
        Me.G1.Controls.Add(Me.NomS)
        Me.G1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G1.ForeColor = System.Drawing.Color.Red
        Me.G1.Location = New System.Drawing.Point(26, 151)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(765, 468)
        Me.G1.TabIndex = 17
        Me.G1.TabStop = False
        Me.G1.Text = "Connexion à la base de données"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.TextBox1.Location = New System.Drawing.Point(350, 129)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(237, 36)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.Text = "localhost"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.TextBox2.Location = New System.Drawing.Point(350, 171)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(237, 36)
        Me.TextBox2.TabIndex = 15
        Me.TextBox2.Text = "localhost"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(134, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 36)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Utilisateur"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(129, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 36)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Mot de passe"
        '
        'Authentification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(815, 673)
        Me.Controls.Add(Me.G1)
        Me.MaximizeBox = False
        Me.Name = "Authentification"
        Me.Text = "Authentification"
        Me.G1.ResumeLayout(False)
        Me.G1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NomS As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents G1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
