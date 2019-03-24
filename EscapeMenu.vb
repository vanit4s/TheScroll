Public Class EscapeMenu

    Private Sub EscapeMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ControlBox = False
        ButtonDesign()

    End Sub

    Private Sub ButtonDesign()
        btnResume.FlatStyle = FlatStyle.Flat
        btnResume.ForeColor = System.Drawing.Color.Black
        btnResume.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        btnResume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray

        btnHelp.FlatStyle = FlatStyle.Flat
        btnHelp.ForeColor = System.Drawing.Color.Black
        btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray

        btnScoreboard.FlatStyle = FlatStyle.Flat
        btnScoreboard.ForeColor = System.Drawing.Color.Black
        btnScoreboard.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        btnScoreboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray

        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.ForeColor = System.Drawing.Color.Black
        btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray

        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.ForeColor = System.Drawing.Color.Black
        btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Select Case MsgBox("Are you sure you want to leave the game?", MsgBoxStyle.YesNo, "Are you sure?")
            Case MsgBoxResult.Yes
                MainMenu.Show()
                GameForm.Hide()
                Level2.Hide()
                Me.Hide()
            Case MsgBoxResult.No
                Exit Sub
        End Select

    End Sub

    Private Sub btnResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResume.Click
        Me.Close()
    End Sub

    Private Sub btnScoreboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScoreboard.Click
        Scoreboard.Show()
    End Sub
End Class