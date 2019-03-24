<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.btnPlay = New System.Windows.Forms.Button
        Me.btnSettings = New System.Windows.Forms.Button
        Me.btnFAQ = New System.Windows.Forms.Button
        Me.btnScoreboard = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblMarquee = New System.Windows.Forms.Label
        Me.tmrMarquee = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(480, 114)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(123, 46)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.Location = New System.Drawing.Point(480, 270)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(123, 46)
        Me.btnSettings.TabIndex = 1
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnFAQ
        '
        Me.btnFAQ.Location = New System.Drawing.Point(480, 218)
        Me.btnFAQ.Name = "btnFAQ"
        Me.btnFAQ.Size = New System.Drawing.Size(123, 46)
        Me.btnFAQ.TabIndex = 2
        Me.btnFAQ.Text = "Help/FAQ"
        Me.btnFAQ.UseVisualStyleBackColor = True
        '
        'btnScoreboard
        '
        Me.btnScoreboard.Location = New System.Drawing.Point(480, 166)
        Me.btnScoreboard.Name = "btnScoreboard"
        Me.btnScoreboard.Size = New System.Drawing.Size(123, 46)
        Me.btnScoreboard.TabIndex = 4
        Me.btnScoreboard.Text = "Scoreboard"
        Me.btnScoreboard.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(480, 322)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(123, 46)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblMarquee
        '
        Me.lblMarquee.AutoSize = True
        Me.lblMarquee.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarquee.Location = New System.Drawing.Point(175, 44)
        Me.lblMarquee.Name = "lblMarquee"
        Me.lblMarquee.Size = New System.Drawing.Size(342, 33)
        Me.lblMarquee.TabIndex = 6
        Me.lblMarquee.Text = "Welcome to BLOCKER!"
        '
        'tmrMarquee
        '
        Me.tmrMarquee.Interval = 65
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 446)
        Me.Controls.Add(Me.lblMarquee)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnScoreboard)
        Me.Controls.Add(Me.btnFAQ)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnPlay)
        Me.MaximizeBox = False
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnFAQ As System.Windows.Forms.Button
    Friend WithEvents btnScoreboard As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblMarquee As System.Windows.Forms.Label
    Friend WithEvents tmrMarquee As System.Windows.Forms.Timer
End Class
