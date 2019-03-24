Public Class MainMenu

    Private Sub MainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ButtonDesign()
        Call MarqueeTitle()

        'Version of ACCESS, source of data from database SKDB.mdb
        sProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        sSource = "Data Source = " & Application.StartupPath & "\SKDB.mdb"

        'Connection to the database with the use of source path and version
        con.ConnectionString = sProvider & sSource
        con.Open()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        con.Close()
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub MarqueeTitle()
        lblMarquee.AutoSize = True
        tmrMarquee.Start()
    End Sub

    Private Sub ButtonDesign()
        btnPlay.FlatStyle = FlatStyle.Flat
        btnPlay.ForeColor = System.Drawing.Color.Black
        btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray

        btnFAQ.FlatStyle = FlatStyle.Flat
        btnFAQ.ForeColor = System.Drawing.Color.Black
        btnFAQ.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        btnFAQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray

        btnScoreboard.FlatStyle = FlatStyle.Flat
        btnScoreboard.ForeColor = System.Drawing.Color.Black
        btnScoreboard.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        btnScoreboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray

        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.ForeColor = System.Drawing.Color.Black
        btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray

        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.ForeColor = System.Drawing.Color.Black
        btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray

    End Sub

    Private Sub tmrMarquee_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMarquee.Tick
        lblMarquee.Left -= 10
        If lblMarquee.Left <= -Width Then
            lblMarquee.Left = Width
        End If
    End Sub

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        PlaySubmenu.Show()
    End Sub

    Private Sub btnScoreboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScoreboard.Click
        Scoreboard.Show()
    End Sub
End Class