'Imports System.Data
'Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Image
Imports MySql.Data.MySqlClient

Public Class VoituresMAJ

    'Sub Ajout()

    '    ligneacteur = DGV.NewRow()   'ajouter une nouvelle ligne vide
    '    affecter()                    'affecter les valeurs à la ligne vide ajoutée
    '    acteur.Rows.Add(ligneacteur)  'Ajouter la nouvelle ligne remplie à la table 'ou acteur.ImportRow((ligneacteur)


    'End Sub



    '    Public Function CommitEdit( _
    'context As DataGridViewDataErrorContexts _
    ') As Boolean
    '    End Function

    'Function condi()
    '    If r1.Checked() = True Then
    '        DGV.CurrentRow.Cells(8).Value = "OUI"
    '    Else
    '        DGV.CurrentRow.Cells(8).Value = "NON"
    '    End If

    'End Function

    Sub r1r2combo()
        If R1.Checked() = True Then
            Dispo.SelectedIndex = 0
        End If
        If R2.Checked = True Then
            Dispo.SelectedIndex = 1
        End If
    End Sub
    Sub comborelation()
        If categ.Text = "Petite Voitures" Then
            codca.SelectedIndex = 0
        ElseIf categ.Text = "Moyenne Voitures" Then
            codca.SelectedIndex = 1
        ElseIf categ.Text = "4*4 Voitures" Then
            codca.SelectedIndex = 2
        ElseIf categ.Text = "Voitures de luxe" Then
            codca.SelectedIndex = 3
        End If
    End Sub
    Sub remplircombocateg()
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("select distinct Libelle_categ from categorie", con)

        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()

        While dr.Read() = True
            categ.Items.Add(dr.GetValue(0))
        End While


        dr.Close()
    End Sub


    Dim a As New OpenFileDialog
    'Sub Afficher()
    '    If n = 0 Then
    '        PICTBOX.Image = Image.FromFile(Application.StartupPath & "/Mini-Voitures/" & "Citroën C1.jpg")

    '        Exit Sub
    '    End If
    'End Sub



    Private Sub VoituresMAJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Afficher()
        DGV.AutoResizeColumnHeadersHeight()
        DGV.ColumnCount = 12
        DGV.Columns(0).HeaderText = "Matricule"
        DGV.Columns(1).HeaderText = "Nom"
        DGV.Columns(2).HeaderText = "Date_MSE"
        DGV.Columns(3).HeaderText = "Nombre_deplace"
        DGV.Columns(4).HeaderText = "Boite_vitess"
        DGV.Columns(5).HeaderText = "Carburant"
        DGV.Columns(6).HeaderText = "Puissance"
        DGV.Columns(7).HeaderText = "Compteur"
        DGV.Columns(8).HeaderText = "Disponibilité"
        'DGV.Columns(9).HeaderText = "Image_voiture"
        DGV.Columns(9).HeaderText = "Nom_Image"
        DGV.Columns(9).Visible = False
        DGV.Columns(10).HeaderText = "Prix"
        'DGV.Columns(8).HeaderText = "code_categ"
        DGV.Columns(11).HeaderText = "Libelle_categ"



        DGV.AllowUserToAddRows = False
        DGV.RowCount = 0

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("select Mat_voiture,Nom_voiture,Date_mise_circulation,Nombre_place,Boite_vitess,Carburant,Puissance,Compteur,Disponibilite,Nom_Image,Prix,Libelle_categ from voiture,categorie where voiture.code_categ=categorie.code_categ order by Mat_voiture", con)

        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()

        While dr.Read() = True
            DGV.Rows.Add({dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7), dr.GetValue(8), dr.GetValue(9), dr.GetValue(10), dr.GetValue(11)})
        End While
        dr.Close()
        remplircombocateg()
        'If R1.Checked() = True Then
        '    Dispo.SelectedIndex = 0
        'End If
        'If categ.Text = "Mini-Voitures" Then
        '    codca.SelectedIndex = 0
        'End If
        comborelation()
        r1r2combo()

        Dim column1 As DataGridViewColumn = DGV.Columns(2)
        column1.Width = 120

        Dim column2 As DataGridViewColumn = DGV.Columns(11)
        column2.Width = 160


        Dim column5 As DataGridViewColumn = DGV.Columns(5)
        column5.Width = 130

        Dim column3 As DataGridViewColumn = DGV.Columns(4)
        column3.Width = 112

    End Sub

    Private Sub Ajouter_Click(sender As Object, e As EventArgs) Handles Ajouter.Click

        'Dim cmd As New SqlCommand
        'cmd.Connection = con
        'cmd.CommandText = "INSERT INTO voiture VALUES (" & Nom.Text & ",'" & categ.Text & "','" & dat.MinDate & "','" & nbp.Text & "','" & puis.Text & "','" & compt.Text & "','" & g2.Text & "')"
        'Try
        '    cmd.ExecuteNonQuery()
        'Catch ex As SqlException
        '    If ex.Number = 2627 Then
        '        MsgBox("Voiture Deja stockée")
        '        Nom.Focus()
        '    Else
        '        MsgBox(ex.Number & Chr(10) & ex.Message)

        '    End If

        'End Try

        Dim cmd As New MySqlCommand
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO voiture VALUES (@mat, @nomv, @dat,@nbp,@boitv,@carbur,@puis,@compt,@disp,@imgnm,@prix,@codca)"

        cmd.Parameters.Add("@mat", MySqlDbType.VarChar)
        cmd.Parameters("@mat").Value = Matricule.Text

        cmd.Parameters.Add("@nomv", MySqlDbType.VarChar)
        cmd.Parameters("@nomv").Value = nom.Text

        cmd.Parameters.Add("@dat", MySqlDbType.Date)
        cmd.Parameters("@dat").Value = dat.Text

        cmd.Parameters.Add("@nbp", MySqlDbType.Int16)
        cmd.Parameters("@nbp").Value = nbp.Text

        cmd.Parameters.Add("@boitv", MySqlDbType.VarChar)
        cmd.Parameters("@boitv").Value = Boitev.Text

        cmd.Parameters.Add("@carbur", MySqlDbType.VarChar)
        cmd.Parameters("@carbur").Value = carbur.Text

        cmd.Parameters.Add("@puis", MySqlDbType.VarChar)
        cmd.Parameters("@puis").Value = puis.Text

        cmd.Parameters.Add("@compt", MySqlDbType.VarChar)
        cmd.Parameters("@compt").Value = compt.Text

        cmd.Parameters.Add("@disp", MySqlDbType.VarChar)
        cmd.Parameters("@disp").Value = Dispo.SelectedItem

        'cmd.Parameters.Add("@img", SqlDbType.Image)
        'cmd.Parameters("@img").Value = IO.File.ReadAllBytes(a.FileName)

        cmd.Parameters.Add("@imgnm", MySqlDbType.VarChar)
        cmd.Parameters("@imgnm").Value = nomimg.Text


        cmd.Parameters.Add("@prix", MySqlDbType.VarChar)
        cmd.Parameters("@prix").Value = prix.Text

        cmd.Parameters.Add("@codca", MySqlDbType.Int16)
        cmd.Parameters("@codca").Value = codca.SelectedItem
        Try
            cmd.ExecuteNonQuery()
        Catch ex As MySqlException
            If ex.Number = 2627 Then
                MsgBox("Matricule de Voiture Deja Saisi")
                Matricule.Focus()
            Else
                MsgBox(ex.Number & Chr(10) & ex.Message)

            End If

        End Try

        'Matricule.Text = ""
        'nom.Text = ""
        'dat.Text = ""
        'nbp.Text = ""
        'puis.Text = ""
        'compt.Text = ""
        'nomimg.Text = ""
        'prix.Text = ""
        'carbur.Text = ""
        'categ.Text = ""
        'Boitev.Text = ""
        'R1.Checked = False And R2.Checked = False
        ''PICTBOX.Image = Nothing
        'Dispo.Text = ""
        'Matricule.Focus()
        MsgBox("La Voiture a bien eté ajoutée")
    End Sub

    Private Sub Supprimer_Click(sender As Object, e As EventArgs) Handles Supprimer.Click
        Dim cmd As New MySqlCommand
        Dim r = MsgBox("Voulez vous supprimer cette  Voiture", 20, "suppression")

        If r = 7 Then Exit Sub

        cmd.Connection = con

        cmd.CommandText = "DELETE FROM voiture WHERE Voiture.Mat_Voiture =@xmat"

        cmd.Parameters.Add("@xmat", MySqlDbType.VarChar)
        cmd.Parameters("@xmat").Value = Matricule.Text
        Try
            cmd.ExecuteNonQuery()
            Matricule.Text = ""
            nom.Text = ""
            dat.Text = ""
            nbp.Text = ""
            puis.Text = ""
            compt.Text = ""
            nomimg.Text = ""
            prix.Text = ""
            carbur.Text = ""
            categ.Text = ""
            Boitev.Text = ""
            R1.Checked = False And R2.Checked = False
            Dispo.Text = ""
            MsgBox("La Voiture a bien été supprimeée")
        Catch ex As MySqlException
            If ex.Number = 547 Then
                MsgBox("Cette Voiture est en cours de location", 16, "Suppression")
            Else
                MsgBox(ex.Number & Chr(10) & ex.Message)
            End If

        End Try

    End Sub

    Private Sub Modifier_Click(sender As Object, e As EventArgs) Handles Modifier.Click
        Dim cmd As New MySqlCommand

        cmd.Connection = con
        cmd.CommandText = "UPDATE Voiture set Nom_voiture=@nomv,Date_mise_circulation=@dat,Nombre_place=@nbp,Boite_vitess=@boitv,Carburant=@carbur,Puissance=@puis,Compteur=@compt,Disponibilite=@disp,Nom_Image=@imgnm,Prix=@prix,Voiture.Code_categ=@codca where voiture.Mat_voiture=@xmat"

        'MsgBox("UPDATE Voiture set Nom_voiture=@nomv,Date_mise_circulation=@dat,Nombre_place=@nbp,Boite_vitess=@boitv,Carburant=@carbur,Puissance=@puis,Compteur=@compt,Disponibilite=@disp,Nom_Image=@imgnm,Prix=@prix,Voiture.Code_categ=@codca where voiture.Mat_voiture=@xmat")

        cmd.Parameters.Add("@nomv", MySqlDbType.VarChar)
        cmd.Parameters("@nomv").Value = nom.Text

        cmd.Parameters.Add("@dat", MySqlDbType.VarChar)
        cmd.Parameters("@dat").Value = dat.Text

        cmd.Parameters.Add("@nbp", MySqlDbType.Int16)
        cmd.Parameters("@nbp").Value = nbp.Text

        cmd.Parameters.Add("@boitv", MySqlDbType.VarChar)
        cmd.Parameters("@boitv").Value = Boitev.Text

        cmd.Parameters.Add("@carbur", MySqlDbType.VarChar)
        cmd.Parameters("@carbur").Value = carbur.Text

        cmd.Parameters.Add("@puis", MySqlDbType.Int16)
        cmd.Parameters("@puis").Value = puis.Text

        cmd.Parameters.Add("@compt", MySqlDbType.Int16)
        cmd.Parameters("@compt").Value = compt.Text

        cmd.Parameters.Add("@disp", MySqlDbType.VarChar)
        cmd.Parameters("@disp").Value = Dispo.SelectedItem

        'cmd.Parameters.Add("@img", SqlDbType.Image)
        'cmd.Parameters("@img").Value = IO.File.ReadAllBytes(a.FileName)

        cmd.Parameters.Add("@imgnm", MySqlDbType.VarChar)
        cmd.Parameters("@imgnm").Value = nomimg.Text


        cmd.Parameters.Add("@prix", MySqlDbType.VarChar)
        cmd.Parameters("@prix").Value = prix.Text

        cmd.Parameters.Add("@codca", MySqlDbType.Int16)
        cmd.Parameters("@codca").Value = codca.SelectedItem


        cmd.Parameters.Add("@xmat", MySqlDbType.VarChar)
        cmd.Parameters("@xmat").Value = Matricule.Text

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Voiture Modifier")
        Catch ex As MySqlException
            If ex.Number = 2627 Then
                MsgBox("Voiture déja stockée Deja Saisi")
                Matricule.Focus()
            Else
                MsgBox(ex.Number & Chr(10) & ex.Message)

            End If
        End Try
        'DGV.CommitEdit(DataGridViewDataErrorContexts.CurrentCellChange)
    End Sub

    'Function changphoto(ByVal photo As Integer) As Byte()
    '    Dim cmd As New SqlCommand
    '    con.Open()
    '    With cmd
    '        .Connection = con
    '        .CommandText = "select * from Voiture where mat_voiture=" & DGV.SelectedRows(0).Cells(0).Value
    '    End With
    '    Dim myphoto() As Byte = CType(cmd.ExecuteScalar(), Byte())
    '    con.Close()
    '    Return myphoto
    'End Function

    Private Sub DGV_SelectionChanged(sender As Object, e As EventArgs) Handles DGV.SelectionChanged

        Try
            Me.Matricule.Text = DGV.CurrentRow.Cells(0).Value


            If IsDBNull(DGV.CurrentRow.Cells(1).Value) Then
                Me.nom.Text = ""
            Else
                Me.nom.Text = DGV.CurrentRow.Cells(1).Value
            End If

            If IsDBNull(DGV.CurrentRow.Cells(2).Value) Then
                Me.dat.Text = ""
            Else
                Me.dat.Text = DGV.CurrentRow.Cells(2).Value
            End If

            If IsDBNull(DGV.CurrentRow.Cells(3).Value) Then
                Me.nbp.Text = ""
            Else
                Me.nbp.Text = DGV.CurrentRow.Cells(3).Value
            End If

            If IsDBNull(DGV.CurrentRow.Cells(4).Value) Then
                Me.Boitev.Text = ""
            Else
                Me.Boitev.Text = DGV.CurrentRow.Cells(4).Value
            End If

            If IsDBNull(DGV.CurrentRow.Cells(5).Value) Then
                Me.carbur.Text = ""
            Else
                Me.carbur.Text = DGV.CurrentRow.Cells(5).Value
            End If

            If IsDBNull(DGV.CurrentRow.Cells(6).Value) Then
                Me.puis.Text = ""
            Else
                Me.puis.Text = DGV.CurrentRow.Cells(6).Value
            End If

            If IsDBNull(DGV.CurrentRow.Cells(7).Value) Then
                Me.compt.Text = ""
            Else
                Me.compt.Text = DGV.CurrentRow.Cells(7).Value
            End If

            If DGV.CurrentRow.Cells(8).Value = "OUI" Then
                R1.Checked() = True
            Else
                R2.Checked = True

            End If

            ' Dim ms As New MemoryStream(changphoto(CInt(DGV.SelectedCells(7).Value)))
            ' PICTBOX.Image = Image.FromStream(ms)

            'MsgBox(Application.StartupPath)

            'Dim ms As String = DGV.SelectedCells(9).Value
            'PICTBOX.Image = Image.FromFile(Application.StartupPath & "\images\" & ms)

            If IsDBNull(DGV.CurrentRow.Cells(9).Value) Then
                Me.nomimg.Text = ""
            Else
                Me.nomimg.Text = DGV.CurrentRow.Cells(9).Value
            End If

            If IsDBNull(DGV.CurrentRow.Cells(10).Value) Then
                Me.prix.Text = ""
            Else
                Me.prix.Text = DGV.CurrentRow.Cells(10).Value
            End If


            'If IsDBNull(DGV.CurrentRow.Cells(7).ValueType) Then
            '    PICTBOX.Image = Nothing
            'Else
            '    Me.PICTBOX = DGV.CurrentRow.Cells(7).Value

            'End If

            'For i As Integer = 0 To DGV.Columns.Count - 1
            '    If TypeOf DGV.Columns(i) Is DataGridViewImageColumn Then
            '        DirectCast(DGV.Columns(i), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
            '    End If
            'Next

            Me.categ.Text = DGV.CurrentRow.Cells(11).Value

            'r1r2combo()

        Catch ex As Exception
        End Try
        If R1.Checked Then
            R1.BackColor = Color.Green
            R2.BackColor = Color.Red
        Else
            R2.BackColor = Color.Green
            R1.BackColor = Color.Red
        End If
    End Sub


    Private Sub Actualiser_Click(sender As Object, e As EventArgs) Handles Actualiser.Click
        DGV.Refresh()
        DGV.Update()

        Matricule.Text = ""
        nom.Text = ""
        dat.Text = ""
        nbp.Text = ""
        puis.Text = ""
        compt.Text = ""
        nomimg.Text = ""
        prix.Text = ""
        carbur.Text = ""
        categ.Text = ""
        Boitev.Text = ""
        R1.Checked = False And R2.Checked = False
        'PICTBOX.Image = Nothing
        Dispo.Text = ""
        Matricule.Focus()

    End Sub

    Private Sub Recherche_Click(sender As Object, e As EventArgs) Handles Recherche.Click
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        xmat = InputBox("Donner le Matricule de voiture à chercher")

        Dim req = "select  Mat_voiture,Nom_voiture,Date_mise_circulation,Nombre_place,boite_vitess,carburant,Puissance,Compteur,Disponibilite,Nom_Image,prix,Libelle_categ from voiture,categorie where voiture.code_categ=categorie.code_categ and Mat_voiture=@xmat"

        cmd.Connection = con
        cmd.CommandText = req

        cmd.Parameters.Add("@xmat", MySqlDbType.VarChar)
        cmd.Parameters("@xmat").Value = xmat

        dr = cmd.ExecuteReader()

        Dim ligne = dr.Read()
        If ligne Then

            Matricule.Text = dr.GetValue(0)
            nom.Text = dr.GetValue(1)
            dat.Text = dr.GetValue(2)
            nbp.Text = dr.GetValue(3)
            Boitev.Text = dr.GetValue(4)
            carbur.Text = dr.GetValue(5)

            puis.Text = dr.GetValue(6)
            compt.Text = dr.GetValue(7)
            Dispo.Text = dr.GetValue(8)
            nomimg.Text = dr.GetValue(9)

            'Dim ms As New MemoryStream(changphoto(CInt(DGV.SelectedCells(9).Value)))
            'PICTBOX.Image = Image.FromStream(ms)

            prix.Text = dr.GetValue(10)
            categ.Text = dr.GetValue(11)



        Else
            MsgBox("code Non Trouvé")
        End If

        'Dim ligne = dr.Read()
        'If ligne Then

        '    Matricule.Text = dr.GetValue(0)
        '    nom.Text = dr.GetValue(1)
        '    dat.Text = dr.GetValue(2)
        '    nbp.Text = dr.GetValue(3)
        '    Dim boitv = dr.GetValue(4)
        '    Dim carbur = dr.GetValue(5)

        '    puis.Text = dr.GetValue(6)
        '    compt.Text = dr.GetValue(7)
        '    Dim Dispo = dr.GetValue(8)
        '    nomimg.Text = dr.GetValue(9)

        '    'Dim ms As New MemoryStream(changphoto(CInt(DGV.SelectedCells(9).Value)))
        '    'PICTBOX.Image = Image.FromStream(ms)
        '    'dr.Close()

        '    prix.Text = dr.GetValue(10)
        '    Dim categ = dr.GetValue(11)


        'Else
        '    MsgBox("code Non Trouvé")
        'End If
        comborelation()
        dr.Close()
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles locatpict.Click
        Dim piclocation As String
        a.Filter = Nothing
        piclocation = a.FileName
        a.ShowDialog()
        PICTBOX.Image = Image.FromFile(a.FileName)

    End Sub


    Private Sub categ_SelectedIndexChanged(sender As Object, e As EventArgs) Handles categ.SelectedIndexChanged
        comborelation()
    End Sub

    Private Sub Dispo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Dispo.SelectedIndexChanged
        'r1r2combo()
    End Sub

    Private Sub R2_CheckedChanged(sender As Object, e As EventArgs) Handles R2.CheckedChanged
        r1r2combo()
    End Sub

    Private Sub R1_CheckedChanged(sender As Object, e As EventArgs) Handles R1.CheckedChanged
        r1r2combo()
    End Sub
End Class