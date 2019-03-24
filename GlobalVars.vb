Module GlobalVars

    'Connection to the database SKDB.mdb
    Public con As New OleDb.OleDbConnection
    Public attempt As Integer
    Public dsData As New DataSet

    Public sProvider As String
    Public sSource As String
    Public da As OleDb.OleDbDataAdapter
    Public sSQL As String
    Public cmd As String

End Module
