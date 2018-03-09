'Imports System.Data
'Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Image
Imports MySql.Data.MySqlClient

Public Class Voitures_Classiques

    Private Sub Voitures_Classiques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV2.AutoResizeColumnHeadersHeight()
        'For Each c As DataGridViewColumn In DGV2.Columns
        '    c.Width = 500
        '    Dim columnwidth1 As DataGridViewColumn = DGV2.Columns(0)
        '    columnwidth1.Width = 300
        'Next



        DGV2.ColumnCount = 12
        DGV2.Columns(0).HeaderText = "Matricule"
        DGV2.Columns(0).Visible = False
        DGV2.Columns(1).HeaderText = "Nom de La voiture"
        DGV2.Columns(2).HeaderText = "Date_mise_encirculation"
        DGV2.Columns(2).Visible = False
        DGV2.Columns(3).HeaderText = "Nombre_deplace"
        DGV2.Columns(3).Visible = False
        DGV2.Columns(4).HeaderText = "Boite_vitess"
        DGV2.Columns(4).Visible = False
        DGV2.Columns(5).HeaderText = "Carburant"
        DGV2.Columns(5).Visible = False
        DGV2.Columns(6).HeaderText = "Puissance"
        DGV2.Columns(6).Visible = False
        DGV2.Columns(7).HeaderText = "Compteur"
        DGV2.Columns(7).Visible = False
        DGV2.Columns(8).HeaderText = "Disponibilité"
        DGV2.Columns(8).Visible = False
        DGV2.Columns(9).HeaderText = "Image_voiture"
        DGV2.Columns(9).Visible = False
        DGV2.Columns(10).HeaderText = "Prix"
        DGV2.Columns(10).Visible = False
        'DGV2.Columns(8).HeaderText = "code_categ"
        'DGV2.Columns(8).Visible = False
        DGV2.Columns(11).HeaderText = "Libelle_categ"
        DGV2.Columns(11).Visible = False

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("select  Mat_voiture,Nom_voiture,Date_mise_circulation,Nombre_place,boite_vitess,carburant,Puissance,Compteur,Disponibilite,Nom_Image,prix,Libelle_categ from voiture,categorie where voiture.code_categ=categorie.code_categ and categorie.Code_categ=3", con)

        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()

        While dr.Read() = True
            DGV2.Rows.Add({dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7), dr.GetValue(8), dr.GetValue(9), dr.GetValue(10), dr.GetValue(11)})
        End While
        dr.Close()

        Dim column As DataGridViewColumn = DGV2.Columns(1)
        column.Width = 200
    End Sub

    Private Sub DGV2_SelectionChanged(sender As Object, e As EventArgs) Handles DGV2.SelectionChanged
        Try
            If IsDBNull(DGV2.CurrentRow.Cells(0).Value) Then
                Me.Matricule.Text = ""
            Else
                Me.Matricule.Text = DGV2.CurrentRow.Cells(0).Value
            End If


            If IsDBNull(DGV2.CurrentRow.Cells(1).Value) Then
                Me.nom.Text = ""
            Else
                Me.nom.Text = DGV2.CurrentRow.Cells(1).Value
            End If

            If IsDBNull(DGV2.CurrentRow.Cells(2).Value) Then
                Me.dat.Text = ""
            Else
                Me.dat.Text = DGV2.CurrentRow.Cells(2).Value
            End If

            If IsDBNull(DGV2.CurrentRow.Cells(3).Value) Then
                Me.nbp.Text = ""
            Else
                Me.nbp.Text = DGV2.CurrentRow.Cells(3).Value
            End If

            If IsDBNull(DGV2.CurrentRow.Cells(4).Value) Then
                Me.boitev.Text = ""
            Else
                Me.boitev.Text = DGV2.CurrentRow.Cells(4).Value
            End If

            If IsDBNull(DGV2.CurrentRow.Cells(5).Value) Then
                Me.carbur.Text = ""
            Else
                Me.carbur.Text = DGV2.CurrentRow.Cells(5).Value
            End If

            If IsDBNull(DGV2.CurrentRow.Cells(6).Value) Then
                Me.puis.Text = ""
            Else
                Me.puis.Text = DGV2.CurrentRow.Cells(6).Value
            End If

            If IsDBNull(DGV2.CurrentRow.Cells(7).Value) Then
                Me.compt.Text = ""
            Else
                Me.compt.Text = DGV2.CurrentRow.Cells(7).Value
            End If
            If IsDBNull(DGV2.CurrentRow.Cells(10).Value) Then
                Me.prix.Text = ""
            Else
                Me.prix.Text = DGV2.CurrentRow.Cells(10).Value
            End If
            If IsDBNull(DGV2.CurrentRow.Cells(11).Value) Then
                Me.categ.Text = ""
            Else
                Me.categ.Text = DGV2.CurrentRow.Cells(11).Value
            End If

            If DGV2.CurrentRow.Cells(8).Value = "OUI" Then
                dispo.Text = "OUI"
            Else
                dispo.Text = "NON"
            End If

            If IsDBNull(DGV2.CurrentRow.Cells(10).Value) Then
                Me.prix.Text = ""
            Else
                Me.prix.Text = DGV2.CurrentRow.Cells(10).Value
            End If

            Dim ms As String = DGV2.CurrentRow.Cells(9).Value
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\images\" & ms)

            'If IsDBNull(DGV2.CurrentRow.Cells(9).Value) Then
            '    Me.nomimg.Text = ""
            'Else
            'Me.nomimg.Text = DGV2.CurrentRow.Cells(9).Value
            'End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReservationMAJ.Matreserv.Text = Me.Matricule.Text
        Me.Close()
        CatalogueVoitures.Close()
        ReservationMAJ.Show()
    End Sub
End Class