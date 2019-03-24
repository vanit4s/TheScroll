Imports System.Data
Imports System.Data.SqlClient

Public Class GameForm

    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

    Dim sDirection As String
    Dim sCrashDirection As String
    Dim bJump As Boolean = True
    Dim bCollision As Boolean = False
    Dim Score As Integer
    Dim FasterMovement As Boolean = False
    Dim Timer2 As New Timer
    Dim Timer3 As New Timer
    Dim playerLives As String = 3

    Private Sub GameForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.AutoScroll = False

        '[----======Scoring======----]'
        lblScore.Text = 0         'Displays starting value in the score label

        '[----======Text animation for tutorial======----]'

        AddHandler Timer2.Tick, AddressOf TipPopups
        AddHandler Timer3.Tick, AddressOf TipDisappear
        sTutorial1.Visible = False
        Timer2.Interval = 1500
        Timer3.Interval = 8000
        Timer2.Start()
        Timer3.Start()

    End Sub
    Private Sub TipDisappear()

        sTutorial1.Text = ""
        sTutorial1.Visible = False
        Timer3.Enabled = False

    End Sub

    Private Sub TipPopups()

        sTutorial1.Text = "Welcome to BLOCKER!" + vbNewLine + _
                          "In order to move, use the LEFT and RIGHT on the arrow keys!"
        sTutorial1.Visible = True
        Timer2.Enabled = False

    End Sub

    Private Sub GameForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Dim pbObstacles() As PictureBox = {pbBox1, pbBox2, pbBox3, pbGround}

        '[----======CONTROLS======----]'

        Select Case e.KeyCode
            Case Keys.ShiftKey
                FasterMovement = True
            Case Keys.Right
                CheckCollision()
                If Not sCrashDirection = "right" Then       'Crash direction flag (from sDirection)
                    If FasterMovement = False Then
                        pbPlayer.Left = pbPlayer.Left + 15   'Moves player object to the right by 15 pixels
                    ElseIf FasterMovement = True Then
                        pbPlayer.Left = pbPlayer.Left + 25
                    End If
                    sDirection = "right"               'Direction flag is set to right
                End If
            Case Keys.Left
                CheckCollision()
                If Not sCrashDirection = "left" Then      'Crash direction flag (from sDirection)
                    If FasterMovement = False Then
                        pbPlayer.Left = pbPlayer.Left - 15   'Moves player object to the left by 15 pixels
                    ElseIf FasterMovement = True Then
                        pbPlayer.Left = pbPlayer.Left - 25
                    End If
                    sDirection = "left"                 'Direction flag is set to left
                End If
            Case Keys.Space
                If bJump = True Then                    'bJump is used to make sure player can't jump twice in the air
                    pbPlayer.Top = pbPlayer.Top - 120   'Player object is raised by 120 pictures in the air
                    If sDirection = "right" Then            'Makes sure the direction is right to move in the air
                        pbPlayer.Left = pbPlayer.Left + 15  'If player is in the air he can go right 15 pixels
                    ElseIf sDirection = "left" Then         'Makes sure the direction is left to move in the air
                        pbPlayer.Left = pbPlayer.Left - 15  'If player is in the air he can go left for 15 pixels
                    End If

                    Timer1.Start()      'After jumping up, the timer allows the controllable object to fall to the collidable object
                    bJump = False     'After jumping, doesn't allow the player to jump twice in the air
                End If
            Case Keys.Escape
                EscapeMenu.Show()
        End Select

        Scoring()           'Calls the Scoring subroutine
        CameraMovement()    'Calls the Camera Movement
        Lives()

        '[----======DIRECTION FLAGS======----]'

        sCrashDirection = ""        'Crash direction is reset for the collision to allow the player to move when not colliding

        For i = 0 To pbObstacles.Length - 1
            If pbPlayer.Bounds.IntersectsWith(pbObstacles(i).Bounds) Then
                If sDirection = "right" Then        'If direction flag = right the collision will be to the right, vice versa
                    sCrashDirection = "right"
                ElseIf sDirection = "left" Then     'If direction flag = left the collision will be to the right, vice versa
                    sCrashDirection = "left"
                End If
            End If
        Next

        '[----======ON-TOP-OF-BLOCK COLLISION======----]'

        Dim pbCols() As PictureBox = {pbBox1Col, pbBox2Col, pbBox3Col, pbBox1, pbBox2, pbBox3} 'Control Array for all of the objects which the player has a change to be on top of

        For i = 0 To pbCols.Length - 1
            If pbPlayer.Bounds.IntersectsWith(pbCols(i).Bounds) Then    'If player bounds collide with any of the array objects...
                bCollision = True                                       '...collision is true.
            ElseIf Not pbPlayer.Bounds.IntersectsWith(pbCols(i).Bounds) Then
                bCollision = False
                Timer1.Enabled = True
            End If
        Next

        '[----======FINISH LEVEL======----]'
        If pbPlayer.Bounds.IntersectsWith(pbFinish.Bounds) Or pbPlayer.Bounds.IntersectsWith(pbFinish2.Bounds) Then
            MsgBox("You progress to another level with the score of " & Score & "!")
            ScoreStore()
            Me.Hide()
            Level2.Show()
        End If


    End Sub

    Private Sub GameForm_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        Select Case e.KeyCode
            Case Keys.ShiftKey
                FasterMovement = False
        End Select

    End Sub

    Private Sub ScoreStore()
        Dim sNickname As String

ValidationAgain:

        sNickname = InputBox("Input your nickname!")

        If sNickname = " " Then
            MsgBox("The field was left empty, try again!")
            GoTo ValidationAgain
        ElseIf sNickname = "" Then
            'Cancel button
            Select Case MsgBox("Do you want to store your score in the scoreboard?", MsgBoxStyle.YesNo, "Are you sure?")
                Case MsgBoxResult.Yes
                    ScoreStore()
                    GoTo SqlWrite
                    Exit Select
                Case MsgBoxResult.No
                    Exit Sub
            End Select
        End If

        '[----======Storing Scores in Database======----]'
SqlWrite:
        'Version of ACCESS, source of data from database SKDB.mdb
        sProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        sSource = "Data Source = " & Application.StartupPath & "\SKDB.mdb"

        sSQL = "INSERT INTO Scores (Nickname, Score) VALUES (@Nickname,@Score)"

        Using con = New OleDb.OleDbConnection(sProvider & sSource)
            Using cmd = New OleDb.OleDbCommand(sSQL, con)
                con.Open()
                cmd.Parameters.AddWithValue("@Nickname", sNickname)
                cmd.Parameters.AddWithValue("@Scores", Score)
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    Private Sub Lives()

        '[----======Lives system (3)======----]'

        Dim Health() As PictureBox = {pbHealth3, pbHealth2, pbHealth1}
        Dim obstacles() As PictureBox = {pbSpike, pbSpikeCol1}

        For Each life As PictureBox In Health
            For Each obstacle As PictureBox In obstacles
                If pbPlayer.Bounds.IntersectsWith(pbSpike.Bounds) Then
                    playerLives = playerLives - 1
                    life.Hide()
                    pbSpike.Hide()
                    pbSpike.Top = pbSpike.Top + 500
                End If
            Next
        Next

            Select Case playerLives
                Case playerLives = 0
GameLost:
                Application.Restart()
            Case playerLives > 0
                GoTo GameLost
        End Select

    End Sub

    Private Sub Scoring()    'Score update
        Dim Gems() As PictureBox = {pbGem, pbGem2, pbGem3} 'Control Array for objects increasing the score.

        For Each pbGem As PictureBox In Gems                        ''LOOPS THROUGH ALL ARRAY ITEMS''
            If pbPlayer.Bounds.IntersectsWith(pbGem.Bounds) Then 'If player object collides with any of the gems
                Score += 10                                      'Increment score by 10 if player collides
                LastScore = Score                                'LastScore is used for storing info for further levels.
                lblScore.Text = CStr((Score))                    'Label is set to the score (converted into string)
                pbGem.Top = pbGem.Top + 1000                     'The gem is moved up in the air so it doesn't allow repeatable collection of points
                pbGem.Hide()                                     'Gem is hidden after moved in the air for the above reason
            End If
        Next

    End Sub

    Private Sub CheckCollision()  'Checks for collision based on the set directional flag

        Dim pbCols() As PictureBox = {pbBox1, pbBox2, pbBox3} 'Collision obstacles Control Array

        For Each pbCol As PictureBox In pbCols
            If pbPlayer.Bounds.IntersectsWith(pbCol.Bounds) Then 'If player collides with any objects in the array
                If sCrashDirection = "right" Then 'If player's crash direction = right
                    bCollision = True             'Collision is true, collided
                ElseIf sCrashDirection = "left" Then 'If player's crash direction = left
                    bCollision = True                'Collision is true, collided
                Else
                    bCollision = False             'If there is no crash direction, player has not collided.
                    Exit For
                End If
            End If
        Next

    End Sub

    Private Sub CameraMovement()

        Dim objects() As PictureBox = {pbSpikeCol1, pbSpike, pbBox1, pbBox1Col, pbBox2, pbBox2Col, pbBox3, pbBox3Col, pbGround, pbGroundCol, pbGem, pbGem2, pbGem3, pbFinish, pbFinish2}

        If bCollision = False Then
            Select Case sDirection
                Case "right"
                    For i = 0 To objects.Length - 1
                        objects(i).Left -= 10
                    Next
                Case "left"
                    For i = 0 To objects.Length - 1
                        objects(i).Left += 10
                    Next
            End Select
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim gbOnTopOfCol As Boolean = False

        Dim pbObstacles() As PictureBox = {pbBox1Col, pbBox2Col, pbBox3Col}
        Dim pbGround() As PictureBox = {pbGroundCol}

        '[----======JUMP GRAVITY======----]'

        For i = 0 To pbObstacles.Length - 1
            If pbPlayer.Bounds.IntersectsWith(pbObstacles(i).Bounds) Then
                gbOnTopOfCol = True
                bJump = True
                Exit Sub
            Else
                If gbOnTopOfCol = True Then
                    gbOnTopOfCol = False
                End If
            End If
        Next

        For i = 0 To pbGround.Length - 1
            If pbPlayer.Bounds.IntersectsWith(pbGround(i).Bounds) Then
                Timer1.Stop()
                bJump = True
                Exit Sub
            End If
        Next

        pbPlayer.Top = pbPlayer.Top + 10

    End Sub
End Class