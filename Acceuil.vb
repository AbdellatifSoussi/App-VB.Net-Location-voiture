'Imports System.Data
'Imports System.Data.SqlClient

Imports MySql.Data.MySqlClient
Public Class Acceuil


    Dim mydb As New MySqlDbType


    Public Sub connect()
        Dim DatabaseName As String = "test"
        Dim server As String = "localhost"
        Dim userName As String = "root"
        Dim password As String = ""
        If Not con Is Nothing Then con.Close()
        con.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        Try
            con.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'If (con.State = 1) Then
        '    Me.Close()

        'End If
        'con.Close()
    End Sub

    Dim waitTime As Integer = 500
    Dim speed As Integer = 15

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClientMAJ.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        IMAGE1.Location = New Point(IMAGE1.Location.X + 3, IMAGE1.Location.Y)
        If IMAGE1.Location.X = 1 Then
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        Timer1.Enabled = True
        Timer1.Interval = speed
        Timer2.Interval = waitTime
        'MsgBox(IMAGE1.Location.X)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        VoituresMAJ.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CautionMAJ.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ReservationMAJ.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FactureMAJ.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ContratMAJ.Show()

        'Dim r As Integer
        'r = MsgBox("Voulez vous vraiment quitter l'application", 36, "Terminer")
        'If r = 6 Then End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CatalogueVoitures.Show()
    End Sub
End Class
