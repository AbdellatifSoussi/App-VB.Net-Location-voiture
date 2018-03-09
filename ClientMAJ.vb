
'Imports System.Data
'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class ClientMAJ
    '    Sub remplircomboreserv()
    '        Dim cmd As MySqlCommand
    '        cmd = New MySqlCommand("select distinct Num_reservation from reservation", con)

    '        Dim dr As MySqlDataReader
    '        dr = cmd.ExecuteReader()

    '        While dr.Read() = True
    '            reserv.Items.Add(dr.GetValue(0))
    '        End While


    '        dr.Close()
    '    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ReservationMAJ.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ClientMAJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'remplircomboreserv()
        DGV.AutoResizeColumnHeadersHeight()
        DGV.ColumnCount = 6
        DGV.Columns(0).HeaderText = "Code_Client"
        DGV.Columns(1).HeaderText = "Nom_Client"
        DGV.Columns(2).HeaderText = "Prenom_Client"
        DGV.Columns(3).HeaderText = "Tel_Client"
        DGV.Columns(4).HeaderText = "Ville_Client"
        'DGV.Columns(5).HeaderText = "Adresse_Client"
        DGV.Columns(5).HeaderText = "Email_Client"
        'DGV.Columns(6).HeaderText = "Motdpass"



        DGV.AllowUserToAddRows = False
        DGV.RowCount = 0

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("select * from Client order by Code_client", con)


        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()

        While dr.Read() = True
            DGV.Rows.Add({dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6)})
        End While
        dr.Close()

        Dim column1 As DataGridViewColumn = DGV.Columns(5)
        column1.Width = 207

        Dim column2 As DataGridViewColumn = DGV.Columns(2)
        column2.Width = 200

        Dim column3 As DataGridViewColumn = DGV.Columns(1)
        column3.Width = 200

    End Sub

    Private Sub Ajouter_Click(sender As Object, e As EventArgs) Handles Ajouter.Click
        Dim cmd As New MySqlCommand
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO Client Values (@cin, @nom, @pre, @tel, @vil,@mail ,@pass)"

        cmd.Parameters.Add("@cin", MySqlDbType.Int16)
        cmd.Parameters("@cin").Value = Code.Text

        cmd.Parameters.Add("@nom", MySqlDbType.VarChar)
        cmd.Parameters("@nom").Value = Nom.Text

        cmd.Parameters.Add("@pre", MySqlDbType.VarChar)
        cmd.Parameters("@pre").Value = Pre.Text

        cmd.Parameters.Add("@tel", MySqlDbType.VarChar)
        cmd.Parameters("@tel").Value = tel.Text

        cmd.Parameters.Add("@vil", MySqlDbType.VarChar)
        cmd.Parameters("@vil").Value = vil.Text

        cmd.Parameters.Add("@mail", MySqlDbType.VarChar)
        cmd.Parameters("@mail").Value = mail.Text

        cmd.Parameters.Add("@pass", MySqlDbType.VarChar)
        cmd.Parameters("@pass").Value = mdp.Text
        Try
            cmd.ExecuteNonQuery()
            DGV.Rows.Add({Code.Text, Nom.Text, Pre.Text, tel.Text, vil.Text, mail.Text})
        Catch ex As MySqlException
            If ex.Number = 2627 Then
                MsgBox("Client Deja Saisi")
                numres.Focus()
            Else
                MsgBox(ex.Number & Chr(10) & ex.Message)
            End If

        End Try
        MsgBox("Le Client a bien eté ajouté")
    End Sub

    Private Sub Rechercher_Click(sender As Object, e As EventArgs) Handles midifie.Click
        Dim cmd As New MySqlCommand

        cmd.Connection = con
        cmd.CommandText = "UPDATE Client set Nom_Client=@nom,Prenom_client=@pre,Tel_Client=@tel,Ville_Client=@vil,Email_client=@mail,Motdepasse_Client=@pass where Code_Client=@ymat"


        cmd.Parameters.Add("@ymat", MySqlDbType.Int16)
        cmd.Parameters("@ymat").Value = Code.Text

        cmd.Parameters.Add("@nom", MySqlDbType.VarChar)
        cmd.Parameters("@nom").Value = Nom.Text

        cmd.Parameters.Add("@pre", MySqlDbType.VarChar)
        cmd.Parameters("@pre").Value = Pre.Text

        cmd.Parameters.Add("@tel", MySqlDbType.VarChar)
        cmd.Parameters("@tel").Value = tel.Text

        cmd.Parameters.Add("@vil", MySqlDbType.VarChar)
        cmd.Parameters("@vil").Value = vil.Text

        cmd.Parameters.Add("@mail", MySqlDbType.VarChar)
        cmd.Parameters("@mail").Value = mail.Text

        cmd.Parameters.Add("@pass", MySqlDbType.VarChar)
        cmd.Parameters("@pass").Value = mdp.Text

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Client Modifier")
        Catch ex As MySqlException
            If ex.Number = 2627 Then
                MsgBox("Client déja stockée Deja Saisi")
                Code.Focus()
            Else
                MsgBox(ex.Number & Chr(10) & ex.Message)

            End If
        End Try

    End Sub

    Private Sub DGV_SelectionChanged(sender As Object, e As EventArgs) Handles DGV.SelectionChanged
        Try
            Me.Code.Text = DGV.CurrentRow.Cells(0).Value


            If IsDBNull(DGV.CurrentRow.Cells(2).Value) Then
                Me.Nom.Text = ""
            Else
                Me.Nom.Text = DGV.CurrentRow.Cells(2).Value
            End If


            If IsDBNull(DGV.CurrentRow.Cells(1).Value) Then
                Me.Pre.Text = ""
            Else
                Me.Pre.Text = DGV.CurrentRow.Cells(1).Value
            End If

            If IsDBNull(DGV.CurrentRow.Cells(3).Value) Then
                Me.tel.Text = ""
            Else
                Me.tel.Text = DGV.CurrentRow.Cells(3).Value
            End If

            If IsDBNull(DGV.CurrentRow.Cells(4).Value) Then
                Me.vil.Text = ""
            Else
                Me.vil.Text = DGV.CurrentRow.Cells(4).Value
            End If

            If IsDBNull(DGV.CurrentRow.Cells(5).Value) Then
                Me.mail.Text = ""
            Else
                Me.mail.Text = DGV.CurrentRow.Cells(5).Value
            End If

            

        Catch ex As Exception
        End Try
    End Sub


    Private Sub recherch_Click(sender As Object, e As EventArgs) Handles recherch.Click
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        xmat = InputBox("Donner le Code client à chercher")

        Dim req = "select  * from Client where Code_client=@xmat"

        cmd.Connection = con
        cmd.CommandText = req

        cmd.Parameters.Add("@xmat", MySqlDbType.VarChar)
        cmd.Parameters("@xmat").Value = xmat

        dr = cmd.ExecuteReader()

        Dim ligne = dr.Read()
        If ligne Then

            Code.Text = dr.GetValue(0)
            Nom.Text = dr.GetValue(1)
            Pre.Text = dr.GetValue(2)
            tel.Text = dr.GetValue(3)
            vil.Text = dr.GetValue(4)
            mail.Text = dr.GetValue(5)
            mdp.Text = dr.GetValue(6)
          
        Else
            MsgBox("Code Non Trouvé")
        End If
        dr.Close()
    End Sub

    Private Sub Supprimer_Click(sender As Object, e As EventArgs) Handles Supprimer.Click
        Dim cmd As New MySqlCommand
        Dim r = MsgBox("Voulez vous supprimer ce Client", 20, "suppression")

        If r = 7 Then Exit Sub

        cmd.Connection = con

        cmd.CommandText = "DELETE FROM Client WHERE Code_client =@ymat"

        cmd.Parameters.Add("@ymat", MySqlDbType.Int16)
        cmd.Parameters("@ymat").Value = Code.Text
        Try
            cmd.ExecuteNonQuery()
            Code.Text = ""
            Nom.Text = ""
            Pre.Text = ""
            tel.Text = ""
            vil.Text = ""
            mail.Text = ""

            MsgBox("Le Client a bien été supprimé")
        Catch ex As MySqlException
            If ex.Number = 547 Then
                MsgBox("Cette Voiture est en cours de location", 16, "Suppression")
            Else
                MsgBox(ex.Number & Chr(10) & ex.Message)
            End If

        End Try
    End Sub

    Private Sub Liste_Click(sender As Object, e As EventArgs) Handles Liste.Click
        DGV.Refresh()
        DGV.Update()

        Code.Text = ""
        Nom.Text = ""
        Pre.Text = ""
        tel.Text = ""
        vil.Text = ""
        mail.Text = ""

    End Sub

    Private Sub numres_Enter(sender As Object, e As EventArgs) Handles numres.Enter

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class