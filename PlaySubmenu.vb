Public Class PlaySubmenu

    Private Sub PlaySubmenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Me.Text = ""

        Call ButtonDesign()

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewGame.Click
        GameForm.Show()
        Me.Hide()
        MainMenu.Hide()
    End Sub

    Private Sub ButtonDesign()
        btnNewGame.FlatStyle = FlatStyle.Flat
        btnNewGame.ForeColor = System.Drawing.Color.Black
        btnNewGame.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        btnNewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray

        btnLoadGame.FlatStyle = FlatStyle.Flat
        btnLoadGame.ForeColor = System.Drawing.Color.Black
        btnLoadGame.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        btnLoadGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray

        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.ForeColor = System.Drawing.Color.Black
        btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
    End Sub
End Class