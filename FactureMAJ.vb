
'Imports System.Data
'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FactureMAJ

    Sub combocontrat1()
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("select distinct num_contrat from contrat", con)

        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()

        While dr.Read() = True
            Combocontrat.Items.Add(dr.GetValue(0))
        End While

        dr.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        ContratMAJ.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        ContratMAJ.Show()
    End Sub

    Private Sub FactureMAJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV.AutoResizeColumnHeadersHeight()
        DGV.ColumnCount = 3
        DGV.Columns(0).HeaderText = "Num_Facture"
        DGV.Columns(1).HeaderText = "daat_caution"
        DGV.Columns(2).HeaderText = "code contrat"

        DGV.AllowUserToAddRows = False
        DGV.RowCount = 0

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("select * from FACTURE", con)


        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()

        While dr.Read() = True
            DGV.Rows.Add({dr.GetValue(0), dr.GetValue(1), dr.GetValue(2)})
        End While
        dr.Close()
        combocontrat1()

        Dim column1 As DataGridViewColumn = DGV.Columns(0)
        column1.Width = 285

        Dim column2 As DataGridViewColumn = DGV.Columns(1)
        column2.Width = 301

        Dim column3 As DataGridViewColumn = DGV.Columns(2)
        column3.Width = 285
    End Sub

    Private Sub Ajouter_Click(sender As Object, e As EventArgs) Handles Ajouter.Click
        Dim cmd As New MySqlCommand
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO facture Values (@num, @val,@cod)"

        cmd.Parameters.Add("@num", MySqlDbType.Int16)
        cmd.Parameters("@num").Value = num.Text

        cmd.Parameters.Add("@val", MySqlDbType.VarChar)
        cmd.Parameters("@val").Value = dat.Text

        cmd.Parameters.Add("@cod", MySqlDbType.Int16)
        cmd.Parameters("@cod").Value = Combocontrat.Text

        Try
            cmd.ExecuteNonQuery()
            DGV.Rows.Add({num.Text, dat.Text, Combocontrat.Text})
        Catch ex As MySqlException
            If ex.Number = 2627 Then
                MsgBox("Facture déja Saisi")
                num.Focus()
            Else
                MsgBox(ex.Number & Chr(10) & ex.Message)
            End If
        End Try
        MsgBox("La Facture a bien eté ajouté")
    End Sub

    Private Sub DGV_SelectionChanged(sender As Object, e As EventArgs) Handles DGV.SelectionChanged
        Try
            Me.num.Text = DGV.CurrentRow.Cells(0).Value

            If IsDBNull(DGV.CurrentRow.Cells(1).Value) Then
                Me.dat.Text = ""
            Else
                Me.dat.Text = DGV.CurrentRow.Cells(1).Value
            End If

            If IsDBNull(DGV.CurrentRow.Cells(2).Value) Then
                Me.Combocontrat.Text = ""
            Else
                Me.Combocontrat.Text = DGV.CurrentRow.Cells(2).Value
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub modifi_Click(sender As Object, e As EventArgs) Handles modifi.Click
        Dim cmd As New MySqlCommand

        cmd.Connection = con
        cmd.CommandText = "UPDATE facture set Date_Facture=@dat,num_contrat=@cod where Num_Facture=@xmat"

        cmd.Parameters.Add("@xmat", MySqlDbType.Int16)
        cmd.Parameters("@xmat").Value = num.Text

        cmd.Parameters.Add("@dat", MySqlDbType.VarChar)
        cmd.Parameters("@dat").Value = dat.Text

        cmd.Parameters.Add("@cod", MySqlDbType.Int16)
        cmd.Parameters("@cod").Value = Combocontrat.Text
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Facture Modifier")
        Catch ex As MySqlException
            If ex.Number = 2627 Then
                MsgBox("Facture Saisi")
                num.Focus()
            Else
                MsgBox(ex.Number & Chr(10) & ex.Message)
            End If
        End Try
    End Sub

    Private Sub recherche_Click(sender As Object, e As EventArgs) Handles recherche.Click
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        xmat = InputBox("Donner Le num caution  à chercher")

        Dim req = "select * from facture where Num_Facture=@xmat"

        cmd.Connection = con
        cmd.CommandText = req

        cmd.Parameters.Add("@xmat", MySqlDbType.Int16)
        cmd.Parameters("@xmat").Value = xmat

        dr = cmd.ExecuteReader()

        Dim ligne = dr.Read()
        If ligne Then

            num.Text = dr.GetValue(0)
            dat.Text = dr.GetValue(1)
            Combocontrat.Text = dr.GetValue(2)

        Else
            MsgBox("Num Non Trouvé")
        End If
        dr.Close()
    End Sub

    Private Sub Supprimer_Click(sender As Object, e As EventArgs) Handles Supprimer.Click
        Dim cmd As New MySqlCommand
        Dim r = MsgBox("Voulez vous supprimer cette Facture", 20, "suppression")

        If r = 7 Then Exit Sub

        cmd.Connection = con

        cmd.CommandText = "DELETE FROM facture where Num_Facture=@xmat"

        cmd.Parameters.Add("@xmat", MySqlDbType.Int16)
        cmd.Parameters("@xmat").Value = num.Text

        Try
            cmd.ExecuteNonQuery()
            num.Text = ""
            dat.Text = ""
            Combocontrat.Text = ""

            MsgBox("La facture a bien été supprimeée")
        Catch ex As MySqlException
            If ex.Number = 547 Then
                MsgBox("Cette facture est en cours ", 16, "Suppression")
            Else
                MsgBox(ex.Number & Chr(10) & ex.Message)
            End If

        End Try
    End Sub

    Private Sub Liste_Click(sender As Object, e As EventArgs) Handles Liste.Click
        DGV.Refresh()
        DGV.Update()

        num.Text = ""
        dat.Text = ""
    End Sub
End Class