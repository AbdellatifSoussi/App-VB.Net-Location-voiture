'Imports System.Data
'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class CautionMAJ
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ContratMAJ.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        ReservationMAJ.Show()
    End Sub

    Private Sub CautionMAJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV.AutoResizeColumnHeadersHeight()
        DGV.ColumnCount = 2
        DGV.Columns(0).HeaderText = "Num_caution"
        DGV.Columns(1).HeaderText = "Valeur_caution"

        DGV.AllowUserToAddRows = False
        DGV.RowCount = 0

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("select Num_caution,Valeur_caution from caution order by  Num_caution ", con)


        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()

        While dr.Read() = True
            DGV.Rows.Add({dr.GetValue(0), dr.GetValue(1)})
        End While
        dr.Close()

        Dim column1 As DataGridViewColumn = DGV.Columns(0)
        column1.Width = 438

        Dim column2 As DataGridViewColumn = DGV.Columns(1)
        column2.Width = 438
      
    End Sub

    Private Sub Ajouter_Click(sender As Object, e As EventArgs) Handles Ajouter.Click
        Dim cmd As New MySqlCommand
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO caution Values (@num, @val)"

        cmd.Parameters.Add("@num", MySqlDbType.Int16)
        cmd.Parameters("@num").Value = num.Text

        cmd.Parameters.Add("@val", MySqlDbType.Float)
        cmd.Parameters("@val").Value = valeur.Text

        Try
            cmd.ExecuteNonQuery()
            DGV.Rows.Add({num.Text, valeur.Text})


        Catch ex As MySqlException
            If ex.Number = 2627 Then
                MsgBox("Caution déja Saisi")
                num.Focus()
            Else
                MsgBox(ex.Number & Chr(10) & ex.Message)
            End If
        End Try
        MsgBox("La caution a bien eté ajouté")
    End Sub



    Private Sub DGV_SelectionChanged(sender As Object, e As EventArgs) Handles DGV.SelectionChanged
        Try
            Me.num.Text = DGV.CurrentRow.Cells(0).Value

            If IsDBNull(DGV.CurrentRow.Cells(1).Value) Then
                Me.valeur.Text = ""
            Else
                Me.valeur.Text = DGV.CurrentRow.Cells(1).Value
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Rechercher_Click(sender As Object, e As EventArgs) Handles Rechercher.Click
        Dim cmd As New MySqlCommand

        cmd.Connection = con
        cmd.CommandText = "UPDATE caution set valeur_caution=@val where  Num_caution=@xmat"

        cmd.Parameters.Add("@xmat", MySqlDbType.Int16)
        cmd.Parameters("@xmat").Value = num.Text

        cmd.Parameters.Add("@val", MySqlDbType.Float)
        cmd.Parameters("@val").Value = valeur.Text

        Try
            cmd.ExecuteNonQuery()
            MsgBox("caution Modifier")
        Catch ex As MySqlException
            If ex.Number = 2627 Then
                MsgBox("caution déja saisie")
                num.Focus()
            Else
                MsgBox(ex.Number & Chr(10) & ex.Message)
            End If
        End Try

    End Sub

    Private Sub Modifier_Click(sender As Object, e As EventArgs) Handles Modifier.Click
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        xmat = InputBox("Donner Le num caution  à chercher")

        Dim req = "select * from caution where caution.Num_Caution=@xmat"

        cmd.Connection = con
        cmd.CommandText = req

        cmd.Parameters.Add("@xmat", MySqlDbType.Int16)
        cmd.Parameters("@xmat").Value = xmat

        dr = cmd.ExecuteReader()

        Dim ligne = dr.Read()
        If ligne Then

            num.Text = dr.GetValue(0)
            valeur.Text = dr.GetValue(1)

        Else
            MsgBox("Num Non Trouvé")
        End If
        dr.Close()
    End Sub

    Private Sub Supprimer_Click(sender As Object, e As EventArgs) Handles Supprimer.Click
        Dim cmd As New MySqlCommand
        Dim r = MsgBox("Voulez vous supprimer cette caution", 20, "suppression")

        If r = 7 Then Exit Sub

        cmd.Connection = con

        cmd.CommandText = "DELETE FROM caution WHERE num_caution =@xmat"

        cmd.Parameters.Add("@xmat", MySqlDbType.VarChar)
        cmd.Parameters("@xmat").Value = num.Text

        Try
            cmd.ExecuteNonQuery()
            num.Text = ""
            valeur.Text = ""

            MsgBox("La caution a bien été supprimeée")
        Catch ex As MySqlException
            If ex.Number = 547 Then
                MsgBox("Cette caution est en cours ", 16, "Suppression")
            Else
                MsgBox(ex.Number & Chr(10) & ex.Message)
            End If

        End Try
    End Sub

    Private Sub Liste_Click(sender As Object, e As EventArgs) Handles Liste.Click
        DGV.Refresh()
        DGV.Update()

        num.Text = ""
        valeur.Text = ""
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub
End Class