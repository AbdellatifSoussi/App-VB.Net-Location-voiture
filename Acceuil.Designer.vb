<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acceuil
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Acceuil))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Aide = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.IMAGE1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.IMAGE1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gray
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Aide)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1165, 50)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.White
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Location = New System.Drawing.Point(507, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(161, 41)
        Me.Button8.TabIndex = 24
        Me.Button8.Text = "Mis à jours de Contrat"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Aide
        '
        Me.Aide.BackColor = System.Drawing.Color.Bisque
        Me.Aide.Location = New System.Drawing.Point(1099, 4)
        Me.Aide.Name = "Aide"
        Me.Aide.Size = New System.Drawing.Size(55, 40)
        Me.Aide.TabIndex = 12
        Me.Aide.Text = "Aide"
        Me.Aide.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(873, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(220, 41)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Modification de stock de Voitures"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.ImageKey = "(aucun)"
        Me.Button1.Location = New System.Drawing.Point(6, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 41)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Mis à jours Clients"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Location = New System.Drawing.Point(173, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(161, 41)
        Me.Button7.TabIndex = 22
        Me.Button7.Text = "Mis à jours Reservation"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(340, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(161, 41)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Mis à jours de Caution"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Location = New System.Drawing.Point(674, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(161, 41)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Gestion de Facture"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'IMAGE1
        '
        Me.IMAGE1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IMAGE1.ErrorImage = Nothing
        Me.IMAGE1.Image = CType(resources.GetObject("IMAGE1.Image"), System.Drawing.Image)
        Me.IMAGE1.InitialImage = CType(resources.GetObject("IMAGE1.InitialImage"), System.Drawing.Image)
        Me.IMAGE1.Location = New System.Drawing.Point(-374, 63)
        Me.IMAGE1.Name = "IMAGE1"
        Me.IMAGE1.Size = New System.Drawing.Size(340, 180)
        Me.IMAGE1.TabIndex = 21
        Me.IMAGE1.TabStop = False
        '
        'Timer1
        '
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 409)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(196, 72)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "Catalogue"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Acceuil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1162, 599)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.IMAGE1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Acceuil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestion de Locaiton de Voitures"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.IMAGE1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Aide As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents IMAGE1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button

End Class
