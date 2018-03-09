'Imports System.Data
'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class ContratMAJ
    'Sub comboreserv2()
    '    Dim cmd As New MySqlCommand
    '    Dim dr As MySqlDataReader

    '    Dim req = "SELECT nom_client,prenom_client FROM client code_client=@xmat"

    '    cmd.Connection = con
    '    cmd.CommandText = req

    '    cmd.Parameters.Add("@xmat", MySqlDbType.Int16)
    '    cmd.Parameters("@xmat").Value = t3.SelectedIndex

    '    dr = cmd.ExecuteReader()

    '    If dr.Read() Then
    '        t1.Text = dr.GetValue(1)
    '        t2.Text = dr.GetValue(2)
    '    End If
    '    dr.Close()
    'End Sub

    Sub reservchanged()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        Dim req = "select num_reservation,client.code_client,nom_client,prenom_client FROM client,reservation where client.code_client=reservation.code_client and num_reservation=@xmat"

        cmd.Connection = con
        cmd.CommandText = req

        cmd.Parameters.Add("@xmat", MySqlDbType.Int16)
        cmd.Parameters("@xmat").Value = reserv.SelectedItem

        dr = cmd.ExecuteReader()

        If dr.Read() Then
            t3.Text = dr.GetValue(1)
            t1.Text = dr.GetValue(2)
            t2.Text = dr.GetValue(3)

        End If
        dr.Close()

    End Sub

    Sub comboreservation()
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("select distinct num_reservation from reservation", con)

        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()

        While dr.Read() = True
            reserv.Items.Add(dr.GetValue(0))
        End While

        dr.Close()
    End Sub


    Sub comboreserv()
      Dim cmd As MySqlCommand
        cmd = New MySqlCommand("select distinct code_client from client", con)

        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()

        While dr.Read() = True
            t3.Items.Add(dr.GetValue(0))
        End While

        dr.Close()
    End Sub

    Sub remplircombocautio()
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("select distinct num_caution from caution", con)

        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()

        While dr.Read() = True
            cautio.Items.Add(dr.GetValue(0))
        End While

        dr.Close()
    End Sub

    'Sub remplircomboreserv()
    '    Dim cmd As MySqlCommand
    '    cmd = New MySqlCommand("select nom_client,prenom_client,client.code_client from reservation,client where client.code num_reservation=@xmat", con)

    '    cmd.Parameters.Add("@xmat", MySqlDbType.Int16)
    '    cmd.Parameters("@xmat").Value = reserv.SelectedIndex

    '    Dim dr As MySqlDataReader
    '    dr = cmd.ExecuteReader()

    '    While dr.Read() = True
    '        reserv.Items.Add(dr.GetValue(0))
    '        t1.Text = dr.GetValue(0)
    '        t2.Text = dr.GetValue(1)
    '        t3.Text = dr.GetValue(2)
    '    End While

    '    dr.Close()
    'End Sub

    'Sub remplircombocin()
    '    Dim cmd As MySqlCommand
    '    cmd = New MySqlCommand("select Code_client from client", con)

    '    Dim dr As MySqlDataReader
    '    dr = cmd.ExecuteReader()

    '    While dr.Read() = True
    '        t3.Items.Add(dr.GetValue(0))
    '    End While

    '    dr.Close()
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        CautionMAJ.Show()
    End Sub


    Private Sub ContratMAJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DGV.AutoResizeColumnHeadersHeight()
        DGV.ColumnCount = 5
        DGV.Columns(0).HeaderText = "Num_contrat"
        DGV.Columns(1).HeaderText = "Date_contrat"
        DGV.Columns(2).HeaderText = "Num_reservation"
        DGV.Columns(3).HeaderText = "Cin_client"
        DGV.Columns(4).HeaderText = "Num_caution"
     
        DGV.AllowUserToAddRows = False
        DGV.RowCount = 0

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("select * from contrat", con)

        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()

        While dr.Read() = True
            DGV.Rows.Add({dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4)})
        End While
        dr.Close()

        remplircombocautio()
        'remplircomboreserv()

        'comboreserv2()
        comboreserv()
        comboreservation()

        Dim column3 As DataGridViewColumn = DGV.Columns(0)
        column3.Width = 170


        Dim column1 As DataGridViewColumn = DGV.Columns(1)
        column1.Width = 217

        Dim column2 As DataGridViewColumn = DGV.Columns(2)
        column2.Width = 170

        Dim column4 As DataGridViewColumn = DGV.Columns(3)
        column4.Width = 170

        Dim column5 As DataGridViewColumn = DGV.Columns(4)
        column5.Width = 170
    End Sub


    Private Sub Ajouter_Click(sender As Object, e As EventArgs) Handles Ajouter.Click
        Dim cmd As New MySqlCommand
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO contrat VALUES (@numc, @dat, @numr,@cin,@numk)"

        cmd.Parameters.Add("@numc", MySqlDbType.Int16)
        cmd.Parameters("@numc").Value = Nom.Text

        cmd.Parameters.Add("@dat", MySqlDbType.VarChar)
        cmd.Parameters("@dat").Value = dat.Text

        cmd.Parameters.Add("@numr", MySqlDbType.VarChar)
        cmd.Parameters("@numr").Value = reserv.Text

        cmd.Parameters.Add("@cin", MySqlDbType.VarChar)
        cmd.Parameters("@cin").Value = t3.Text

        cmd.Parameters.Add("@numk", MySqlDbType.Int16)
        cmd.Parameters("@numk").Value = cautio.Text

        Try
            cmd.ExecuteNonQuery()
            DGV.Rows.Add({Nom.Text, dat.Text, reserv.Text, t3.Text, cautio.Text})
        Catch ex As MySqlException
            If ex.Number = 2627 Then
                MsgBox("Numero de contrat Deja Saisi")
                Nom.Focus()
            Else
                MsgBox(ex.Number & Chr(10) & ex.Message)
            End If

        End Try
        MsgBox("Le contrat a bien eté ajoutée")

    End Sub

    Private Sub Rechercher_Click(sender As Object, e As EventArgs)
        Dim cmd As New MySqlCommand
        cmd.Connection = con
        cmd.CommandText = "update contrat set date_contrat=@dat, contrat.num_reservation=@numr, contrat.Code_client=@cin, contrat.num_caution=@numk where reservation.Num_Reservation=contrat.Num_Reservation and client.code_client=contrat.code_client and caution.num_caution=contrat.num_caution and Num_contrat=@ymat"

        cmd.Parameters.Add("@ymat", MySqlDbType.Int16)
        cmd.Parameters("@ymat").Value = Nom.Text

        cmd.Parameters.Add("@dat", MySqlDbType.VarChar)
        cmd.Parameters("@dat").Value = dat.Text

        cmd.Parameters.Add("@numr", MySqlDbType.Int16)
        cmd.Parameters("@numr").Value = reserv.Text

        cmd.Parameters.Add("@cin", MySqlDbType.Int16)
        cmd.Parameters("@cin").Value = t3.Text

        cmd.Parameters.Add("@numk", MySqlDbType.Int16)
        cmd.Parameters("@numk").Value = cautio.Text

        Try
            cmd.ExecuteNonQuery()

        Catch ex As MySqlException
            If ex.Number = 2627 Then
                MsgBox("Numero de contrat Deja Saisi")
                Nom.Focus()
            Else
                MsgBox(ex.Number & Chr(10) & ex.Message)
            End If

        End Try
        MsgBox("contrat Modifier")
    End Sub

    Private Sub Supprimer_Click(sender As Object, e As EventArgs) Handles Supprimer.Click
        Dim cmd As New MySqlCommand
        Dim r = MsgBox("Voulez vous supprimer cette  contrat", 20, "Suppression")

        If r = 7 Then Exit Sub

        cmd.Connection = con

        cmd.CommandText = "DELETE FROM contrat WHERE Num_contrat=@xmat"

        cmd.Parameters.Add("@xmat", MySqlDbType.Int16)
        cmd.Parameters("@xmat").Value = Nom.Text

        Try
            cmd.ExecuteNonQuery()
            Nom.Text = ""
            reserv.Text = ""
            t3.Text = ""
            cautio.Text = ""
            MsgBox("Le contrat a bien été supprimeée")
        Catch ex As MySqlException
            If ex.Number = 547 Then
                MsgBox("Cette contrat est en cours de location", 16, "Suppression")
            Else
                MsgBox(ex.Number & Chr(10) & ex.Message)
            End If

        End Try
    End Sub



    Private Sub DGV_SelectionChanged(sender As Object, e As EventArgs) Handles DGV.SelectionChanged

        Try
            Me.Nom.Text = DGV.CurrentRow.Cells(0).Value


            If IsDBNull(DGV.CurrentRow.Cells(1).Value) Then
                Me.dat.Text = ""
            Else
                Me.dat.Text = DGV.CurrentRow.Cells(1).Value
            End If

            If IsDBNull(DGV.CurrentRow.Cells(2).Value) Then
                Me.reserv.SelectedItem = ""
            Else
                Me.reserv.SelectedItem = DGV.CurrentRow.Cells(2).Value
            End If

            If IsDBNull(DGV.CurrentRow.Cells(3).Value) Then
                Me.t3.SelectedItem = ""
            Else
                Me.t3.SelectedItem = DGV.CurrentRow.Cells(3).Value
            End If
            If IsDBNull(DGV.CurrentRow.Cells(4).Value) Then
                Me.cautio.Text = ""
            Else
                Me.cautio.Text = DGV.CurrentRow.Cells(4).Value
            End If

          
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        FactureMAJ.Show()
    End Sub

   

   
    Private Sub t3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles t3.SelectedIndexChanged
        'Dim cmd As New MySqlCommand
        'Dim dr As MySqlDataReader

        'Dim req = "select * FROM client where code_client=@xmat"

        'cmd.Connection = con
        'cmd.CommandText = req

        'cmd.Parameters.Add("@xmat", MySqlDbType.Int16)
        'cmd.Parameters("@xmat").Value = t3.SelectedItem

        'dr = cmd.ExecuteReader()

        'If dr.Read() Then

        '    t1.Text = dr.GetValue(1)
        '    t2.Text = dr.GetValue(2)

        'End If
        'dr.Close()
    End Sub

    Private Sub reserv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles reserv.SelectedIndexChanged
        reservchanged()
    End Sub

    Private Sub Modifier_Click(sender As Object, e As EventArgs)
        '    Dim cmd As New MySqlCommand
        '    Dim dr As MySqlDataReader

        '    xmat = InputBox("Donner Le num caution  à chercher")

        '    Dim req = "select * from contrat where num_contrat=@ymat"

        '    cmd.Connection = con
        '    cmd.CommandText = req

        '    cmd.Parameters.Add("@ymat", MySqlDbType.Int16)
        '    cmd.Parameters("@ymat").Value = xmat

        '    dr = cmd.ExecuteReader()

        '    Dim ligne = dr.Read()
        '    If ligne Then

        '        Nom.Text = dr.GetValue(0)
        '        dat.Text = dr.GetValue(1)
        '        'Dim reserv = dr.GetValue(2)
        '        'Dim cauti = dr.GetValue(4)
        '        'dr.Close()

        '        'reserv.SelectedItem = reserv
        '        'cautio.SelectedItem = cauti

        '    Else
        '        MsgBox("Num Non Trouvé")
        '    End If


        'End Sub
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class