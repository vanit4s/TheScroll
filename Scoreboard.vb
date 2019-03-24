Public Class Scoreboard

    Private Sub Scoreboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sSQL = "SELECT Nickname, Score FROM Scores"

        Using con = New OleDb.OleDbConnection(sProvider & sSource)
            Using cmd = New OleDb.OleDbCommand(sSQL, con)
                con.Open()
                ListBox1.DataSource = sSQL
                cmd.ExecuteNonQuery()
            End Using
        End Using



    End Sub
End Class