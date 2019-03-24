Public Class Level2

    Dim sDirection As String
    Dim sCrashDirection As String
    Dim bJump As Boolean = True
    Dim bCollision As Boolean = False

    Private Sub GameForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.AutoScroll = False
        Timer1.Start()
        lblScore.Text = CStr((LastScore))

    End Sub

    Private Sub GameForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Dim pbObstacles() As PictureBox = {pbBox1, pbBox2, pbGround, pbGround2}

        '[----======CONTROLS======----]'

        Select Case e.KeyCode
            Case Keys.Right
                CheckCollision()
                If Not sCrashDirection = "right" Then       'Crash direction flag (from sDirection)
                    pbPlayer.Left = pbPlayer.Left + 15   'Moves player object to the right by 15 pixels
                    sDirection = "right"               'Direction flag is set to right
                End If
            Case Keys.Left
                CheckCollision()
                If Not sCrashDirection = "left" Then      'Crash direction flag (from sDirection)
                    pbPlayer.Left = pbPlayer.Left - 15   'Moves player object to the left by 15 pixels
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

        '[----======DIRECTION FLAGS======----]'

        sCrashDirection = ""

        For i = 0 To pbObstacles.Length - 1
            If pbPlayer.Bounds.IntersectsWith(pbObstacles(i).Bounds) Then
                If sDirection = "right" Then
                    sCrashDirection = "right"
                ElseIf sDirection = "left" Then
                    sCrashDirection = "left"
                End If
            End If
        Next

        '[----======ON-TOP-OF-BLOCK COLLISION======----]'

        Dim pbCols() As PictureBox = {pbBoxCol1, pbBoxCol2, pbBox1, pbBox2} 'Control Array for all of the objects which the player has a change to be on top of

        For i = 0 To pbCols.Length - 1
            If pbPlayer.Bounds.IntersectsWith(pbCols(i).Bounds) Then    'If player bounds collide with any of the array objects...
                bCollision = True                                       '...collision is true.
            ElseIf Not pbPlayer.Bounds.IntersectsWith(pbCols(i).Bounds) Then
                bCollision = False
                Timer1.Enabled = True
            End If
        Next

        '[----======FINISH LEVEL======----]'

        'If pbPlayer.Bounds.IntersectsWith(pbFinish.Bounds) Or pbPlayer.Bounds.IntersectsWith(pbFinish2.Bounds) Then
        '    MsgBox("You progress to another level with the score: " & Score)
        '    Me.Hide()
        '    Level3.Show()
        'End If


    End Sub

    Private Sub Scoring()    'Score update
        Dim Gems() As PictureBox = {pbGem, pbGem2, pbGem3}

        For Each pbGem As PictureBox In Gems
            If pbPlayer.Bounds.IntersectsWith(pbGem.Bounds) Then
                LastScore += 10
                lblScore.Text = CStr((LastScore))
                pbGem.Top = pbGem.Top + 1000
                pbGem.Hide()
            End If
        Next

    End Sub

    Private Sub CheckCollision()  'Checks for collision based on the set directional flag

        Dim pbCols() As PictureBox = {pbBox1, pbBox2} 'Collision obstacles Control Array

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

        Dim objects() As PictureBox = {pbBox1, pbBox2, pbBoxCol1, pbBoxCol2, pbGround, pbGroundCol, pbGround2Col, pbGround2, pbGem, pbGem2, pbGem3}

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

        Dim pbObstacles() As PictureBox = {pbBoxCol1, pbBoxCol2}
        Dim pbGround() As PictureBox = {pbGroundCol, pbGround2Col}

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