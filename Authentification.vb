'Imports System.Data
'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Authentification

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

    End Sub

    'Public Shared Sub Main()
    '    Dim connStr As String = "server=localhost;user=root;database=location"
    '    Dim con As New MySqlConnection(connStr)
    '    Try
    '        Console.WriteLine("Connecting to MySQL...")
    '        con.Open()
    '    Catch ex As Exception
    '        Console.WriteLine(ex.ToString())
    '    End Try
    '    con.Close()
    '    Console.WriteLine("Done.")
    'End Sub

    Private Sub Exite1_Click(sender As Object, e As EventArgs)
        Dim r As Integer
        r = MsgBox("Voulez vous vraiment quitter l'application", 36, "Terminer")
        If r = 6 Then End
    End Sub



    Private Sub Authentification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Auth.Items.Add("Authentification Windows")
        'Auth.Items.Add("Authentification SQL Server")
        'Auth.SelectedIndex = 0
        'Main()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New MySqlConnection
        con.ConnectionString = "server=localhost;userid=root;password=;database=test"
        Try
            con.Open()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

        If (con.State = 1) Then
            'MsgBox("Connexion réussie")
            Me.Close()

        End If
     

        'Main()

        'Dim serveur = "localhost"
        'Dim base = "location"
        ''Dim authentification = Not CBool(Auth.SelectedIndex)
        ''Dim user = NomU.Text
        ''Dim passs = Pass.Text

        'Dim ChainConnection = "Data Source=" & serveur & "; Initial Catalog=" & base

        'con.ConnectionString = ChainConnection

        'Try
        '    con.Open()
        'Catch ex As MySqlException
        '    MsgBox(ex.Message)
        'End Try

        'If (con.State = 1) Then
        '    MsgBox("Connexion réussie")
        '    Me.Close()

        'End If
    End Sub

    Private Sub PassVis_CheckedChanged(sender As Object, e As EventArgs)
        'If PassVis.Checked Then
        '    Pass.PasswordChar = ""
        'Else
        '    Pass.PasswordChar = "*"
        'End If
    End Sub

    Private Sub Auth_SelectedIndexChanged(sender As Object, e As EventArgs)
        'If Auth.SelectedIndex = 0 Then

        '    NomU.Enabled = False
        '    NomU.Enabled = False
        '    Pass.Enabled = False
        '    PassVis.Enabled = False
        'Else
        '    NomS.Enabled = True
        '    NomU.Enabled = True
        '    NomU.Enabled = True
        '    Pass.Enabled = True
        '    PassVis.Enabled = True
        'End If
    End Sub

    Private Sub G1_Enter(sender As Object, e As EventArgs) Handles G1.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class