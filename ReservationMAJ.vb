'Imports System.Data
'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class ReservationMAJ
    Sub clientchanged()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        Dim req = "select Nom_client,prenom_client FROM client  where  Code_client=@xclient"

        cmd.Connection = con
        cmd.CommandText = req

        cmd.Parameters.Add("@xclient", MySqlDbType.Int16)
        cmd.Parameters("@xclient").Value = cb1.SelectedItem

        dr = cmd.ExecuteReader()

        If dr.Read() Then
            nomclient.Text = dr.GetValue(0)
            prenomclient.Text = dr.GetValue(1)

        End If
        dr.Close()

    End Sub



    Sub remplircombocodcli()
        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("select  code_client from client", con)

        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()

        While dr.Read() = True
            cb1.Items.Add(dr.GetValue(0))
        End While


        dr.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CautionMAJ.Show()
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        'datfin.Text = DateTime.Now.Day(+(CDate(duree.SelectedIndex))

        'Dim startDate As Date = Date.Now
        'Dim endDate As Date = startDate.AddDays(duree.Text)
        'Dim timeSpan As TimeSpan = endDate.Subtract(startDate)
        'Dim difDays As Integer = TimeSpan.Days
        'Console.WriteLine("Time Difference (days): " + timeSpan.Days)

        'Dim Number, StartDate As String   'Declare variables.
        'Dim Days As Double
        'Dim SecondDate As Date
        'Dim IntervalType As DateInterval
        'IntervalType = DateInterval.Day  ' Specifies months as interval.
        'StartDate = datdeb.Text
        'SecondDate = CDate(StartDate)
        'Number = duree.Text
        'Days = Val(Number)
        ''datfin.Text = DateAdd(IntervalType, Days, SecondDate)
        'datfin.Text = (DateAdd(IntervalType, Days, SecondDate)).ToString("dddd     dd     MMMM     yyyy")

    End Sub

    Private Sub ReservationMAJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV.AutoResizeColumnHeadersHeight()
        DGV.ColumnCount = 6
        DGV.Columns(0).HeaderText = "Num_Reservation"
        DGV.Columns(1).HeaderText = "Date_Reservation"
        DGV.Columns(2).HeaderText = "Mat_Voiture"
        DGV.Columns(3).HeaderText = "Date_Debut"
        DGV.Columns(4).HeaderText = "Date_Fin"
        DGV.Columns(5).HeaderText = "Code_client"

        DGV.AllowUserToAddRows = False
        DGV.RowCount = 0

        Dim cmd As MySqlCommand
        cmd = New MySqlCommand("select * from Reservation", con)


        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()

        While dr.Read() = True
            DGV.Rows.Add({dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5)})
        End While
        dr.Close()
        remplircombocodcli()

        Dim column1 As DataGridViewColumn = DGV.Columns(1)
        column1.Width = 180

        Dim column2 As DataGridViewColumn = DGV.Columns(5)
        column2.Width = 160

        Dim column3 As DataGridViewColumn = DGV.Columns(3)
        column3.Width = 170

        Dim column4 As DataGridViewColumn = DGV.Columns(4)
        column4.Width = 180

        Dim column5 As DataGridViewColumn = DGV.Columns(2)
        column5.Width = 116
    End Sub

    Private Sub Ajouter_Click(sender As Object, e As EventArgs) Handles Ajouter.Click
        Dim cmd As New MySqlCommand
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO Reservation Values(@num, @datres, @mat, @datdeb, @datfin,@cod)"

        cmd.Parameters.Add("@num", MySqlDbType.Int16)
        cmd.Parameters("@num").Value = numres.Text

        cmd.Parameters.Add("@datres", MySqlDbType.VarChar)
        cmd.Parameters("@datres").Value = datres.Text

        cmd.Parameters.Add("@mat", MySqlDbType.VarChar)
        cmd.Parameters("@mat").Value = Matreserv.Text

        cmd.Parameters.Add("@datdeb", MySqlDbType.VarChar)
        cmd.Parameters("@datdeb").Value = datdeb.Text

        cmd.Parameters.Add("@datfin", MySqlDbType.VarChar)
        cmd.Parameters("@datfin").Value = datfin.Text

        cmd.Parameters.Add("@cod", MySqlDbType.Int16)
        cmd.Parameters("@cod").Value = cb1.Text

        Try
            cmd.ExecuteNonQuery()
            DGV.Rows.Add({numres.Text, datres.Text, Matreserv.Text, datdeb.Text, datfin.Text, cb1.Text})
        Catch ex As MySqlException
            If ex.Number = 2627 Then
                MsgBox("Reservation de Voiture Deja Saisi")
                numres.Focus()
            Else
                MsgBox(ex.Number & Chr(10) & ex.Message)
            End If

        End Try
        MsgBox("Le Reservation a bien eté ajoutée")
    End Sub

    Private Sub Rechercher_Click(sender As Object, e As EventArgs) Handles Modifier.Click
        Dim cmd As New MySqlCommand

        cmd.Connection = con
        cmd.CommandText = "UPDATE reservation set Date_Reservation='" & datres.Text & "',reservation.Mat_Voiture='" & Matreserv.Text & "',Date_Debut='" & datdeb.Text & "',Date_fin='" & datfin.Text & "',Code_client='" & cb1.Text & "' where Num_Reservation='" & numres.Text & "'"

        'MsgBox("UPDATE reservation set Date_Reservation='" & datres.Text & "',reservation.Mat_Voiture='" & Matreserv.Text & "',Date_Debut='" & datdeb.Text & "',Duree='" & duree.Text & "' where Num_Reservation='" & numres.Text & "'")


        'cmd.Parameters.Add("@ymat", SqlDbType.Int)
        'cmd.Parameters("@ymat").Value = numres.Text

        'cmd.Parameters.Add("@datres", SqlDbType.Date)
        'cmd.Parameters("@datres").Value = datres.Text

        'cmd.Parameters.Add("@mat", SqlDbType.VarChar)
        'cmd.Parameters("@mat").Value = Matreserv.Text

        'cmd.Parameters.Add("@datdeb", SqlDbType.Date)
        'cmd.Parameters("@datdeb").Value = datdeb.Text

        'cmd.Parameters.Add("@Dure", SqlDbType.Int)
        'cmd.Parameters("@Dure").Value = duree.Text


        Try
            cmd.ExecuteNonQuery()
            MsgBox("Reservation Modifieé")
        Catch ex As MySqlException
            If ex.Number = 2627 Then
                MsgBox("Reservation déja stockée Deja Saisi")
                numres.Focus()
            Else
                MsgBox(ex.Number & Chr(10) & ex.Message)

            End If
        End Try
    End Sub

    Private Sub DGV_Click(sender As Object, e As EventArgs) Handles DGV.Click
        Try
            Me.numres.Text = DGV.CurrentRow.Cells(0).Value

            If IsDBNull(DGV.CurrentRow.Cells(1).Value) Then
                Me.datres.Text = ""
            Else
                Me.datres.Text = DGV.CurrentRow.Cells(1).Value
            End If

            If IsDBNull(DGV.CurrentRow.Cells(2).Value) Then
                Me.Matreserv.Text = ""
            Else
                Me.Matreserv.Text = DGV.CurrentRow.Cells(2).Value
            End If

            If IsDBNull(DGV.CurrentRow.Cells(3).Value) Then
                Me.datdeb.Text = ""
            Else
                Me.datdeb.Text = DGV.CurrentRow.Cells(3).Value
            End If

            If IsDBNull(DGV.CurrentRow.Cells(4).Value) Then
                Me.datfin.Text = ""
            Else
                Me.datfin.Text = DGV.CurrentRow.Cells(4).Value
            End If

            If IsDBNull(DGV.CurrentRow.Cells(5).Value) Then
                Me.cb1.Text = ""
            Else
                Me.cb1.Text = DGV.CurrentRow.Cells(5).Value
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Modifier_Click(sender As Object, e As EventArgs) Handles Recherche.Click

        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader


        xmat = InputBox("Donner Le numero de reservation de voiture à chercher")

        Dim req = ("select * from reservation where Num_Reservation=@xmat")


        cmd.Connection = con
        cmd.CommandText = req

        cmd.Parameters.Add("@xmat", MySqlDbType.Int16)
        cmd.Parameters("@xmat").Value = xmat


        dr = cmd.ExecuteReader()

        Dim ligne = dr.Read()
        If ligne Then

            Try
                Me.numres.Text = DGV.CurrentRow.Cells(0).Value

                If IsDBNull(DGV.CurrentRow.Cells(1).Value) Then
                    Me.datres.Text = ""
                Else
                    Me.datres.Text = DGV.CurrentRow.Cells(1).Value
                End If

                If IsDBNull(DGV.CurrentRow.Cells(2).Value) Then
                    Me.Matreserv.Text = ""
                Else
                    Me.Matreserv.Text = DGV.CurrentRow.Cells(2).Value
                End If

                If IsDBNull(DGV.CurrentRow.Cells(3).Value) Then
                    Me.datdeb.Text = ""
                Else
                    Me.datdeb.Text = DGV.CurrentRow.Cells(3).Value
                End If

                If IsDBNull(DGV.CurrentRow.Cells(4).Value) Then
                    Me.datfin.Text = ""
                Else
                    Me.datfin.Text = DGV.CurrentRow.Cells(4).Value
                End If

                If IsDBNull(DGV.CurrentRow.Cells(5).Value) Then
                    Me.cb1.SelectedItem = ""
                Else
                    Me.cb1.SelectedItem = DGV.CurrentRow.Cells(5).Value
                End If
            Catch ex As Exception
            End Try
            MsgBox("code trouvé")
        Else
            MsgBox("code non trouvé")
        End If
        dr.Close()
    End Sub

    Private Sub Supprimer_Click(sender As Object, e As EventArgs) Handles Supprimer.Click
        Dim cmd As New MySqlCommand
        Dim r = MsgBox("Voulez vous supprimer cette  Reservation", 20, "suppression")

        If r = 7 Then Exit Sub

        cmd.Connection = con

        cmd.CommandText = "DELETE FROM Reservation WHERE Num_reservation =@xmat"

        cmd.Parameters.Add("@xmat", MySqlDbType.Int16)
        cmd.Parameters("@xmat").Value = numres.Text
        Try
            cmd.ExecuteNonQuery()
            numres.Text = ""
            datres.Text = ""
            Matreserv.Text = ""
            datdeb.Text = ""
            datfin.Text = ""
            cb1.Text = ""

            MsgBox("La Reservation bien été supprimée")
        Catch ex As MySqlException
            If ex.Number = 547 Then
                MsgBox("Cette Voiture est en cours de location", 16, "Suppression")
            Else
                MsgBox(ex.Number & Chr(10) & ex.Message)
            End If
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClientMAJ.Show()
        Me.Close()
    End Sub


    Private Sub cb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb1.SelectedIndexChanged
        clientchanged()
    End Sub
End Class