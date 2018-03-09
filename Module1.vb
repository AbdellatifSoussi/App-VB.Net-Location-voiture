Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Module Module1
  
    Public con As New MySqlConnection()
    Public xmat As String 'Matricule voiture a chercher
    Public ymat As Integer 'Num Reservation'
    'Public p As Integer = -1  'Position de voiture
    'Public n As Integer = 0 'Nombre D'élement insérés dans T voitures
    Public Property Width As Integer

    Public Dfrech As MySqlCommandBuilder



End Module
