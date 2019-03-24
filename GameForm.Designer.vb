<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameForm))
        Me.pbGround = New System.Windows.Forms.PictureBox
        Me.pbPlayer = New System.Windows.Forms.PictureBox
        Me.DoNotEdit = New System.Windows.Forms.PictureBox
        Me.pbBox2 = New System.Windows.Forms.PictureBox
        Me.pbBox1 = New System.Windows.Forms.PictureBox
        Me.pbBox3 = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pbBox1Col = New System.Windows.Forms.PictureBox
        Me.pbBox2Col = New System.Windows.Forms.PictureBox
        Me.pbGroundCol = New System.Windows.Forms.PictureBox
        Me.pbBox3Col = New System.Windows.Forms.PictureBox
        Me.pbGem = New System.Windows.Forms.PictureBox
        Me.lblScoreTXT = New System.Windows.Forms.Label
        Me.lblScore = New System.Windows.Forms.Label
        Me.pbGem2 = New System.Windows.Forms.PictureBox
        Me.pbGem3 = New System.Windows.Forms.PictureBox
        Me.pbFinish = New System.Windows.Forms.PictureBox
        Me.pbFinish2 = New System.Windows.Forms.PictureBox
        Me.pbFallingOut = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.sTutorial1 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.pbSpike = New System.Windows.Forms.PictureBox
        Me.pbHealth1 = New System.Windows.Forms.PictureBox
        Me.pbHealth2 = New System.Windows.Forms.PictureBox
        Me.pbHealth3 = New System.Windows.Forms.PictureBox
        Me.lblHealth = New System.Windows.Forms.Label
        Me.pbSpikeCol1 = New System.Windows.Forms.PictureBox
        CType(Me.pbGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoNotEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBox1Col, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBox2Col, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGroundCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBox3Col, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFinish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFinish2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFallingOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSpike, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHealth1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHealth2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHealth3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSpikeCol1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbGround
        '
        Me.pbGround.BackColor = System.Drawing.Color.Gray
        Me.pbGround.Location = New System.Drawing.Point(124, 343)
        Me.pbGround.Name = "pbGround"
        Me.pbGround.Size = New System.Drawing.Size(1206, 50)
        Me.pbGround.TabIndex = 0
        Me.pbGround.TabStop = False
        '
        'pbPlayer
        '
        Me.pbPlayer.BackColor = System.Drawing.SystemColors.Highlight
        Me.pbPlayer.InitialImage = CType(resources.GetObject("pbPlayer.InitialImage"), System.Drawing.Image)
        Me.pbPlayer.Location = New System.Drawing.Point(137, 295)
        Me.pbPlayer.Name = "pbPlayer"
        Me.pbPlayer.Size = New System.Drawing.Size(50, 50)
        Me.pbPlayer.TabIndex = 1
        Me.pbPlayer.TabStop = False
        '
        'DoNotEdit
        '
        Me.DoNotEdit.BackColor = System.Drawing.Color.Transparent
        Me.DoNotEdit.Location = New System.Drawing.Point(2427, 197)
        Me.DoNotEdit.Name = "DoNotEdit"
        Me.DoNotEdit.Size = New System.Drawing.Size(10, 53)
        Me.DoNotEdit.TabIndex = 2
        Me.DoNotEdit.TabStop = False
        '
        'pbBox2
        '
        Me.pbBox2.BackColor = System.Drawing.Color.Gray
        Me.pbBox2.Location = New System.Drawing.Point(477, 245)
        Me.pbBox2.Name = "pbBox2"
        Me.pbBox2.Size = New System.Drawing.Size(50, 100)
        Me.pbBox2.TabIndex = 3
        Me.pbBox2.TabStop = False
        '
        'pbBox1
        '
        Me.pbBox1.BackColor = System.Drawing.Color.Gray
        Me.pbBox1.Location = New System.Drawing.Point(358, 295)
        Me.pbBox1.Name = "pbBox1"
        Me.pbBox1.Size = New System.Drawing.Size(50, 50)
        Me.pbBox1.TabIndex = 4
        Me.pbBox1.TabStop = False
        '
        'pbBox3
        '
        Me.pbBox3.BackColor = System.Drawing.Color.Gray
        Me.pbBox3.Location = New System.Drawing.Point(612, 256)
        Me.pbBox3.Name = "pbBox3"
        Me.pbBox3.Size = New System.Drawing.Size(48, 90)
        Me.pbBox3.TabIndex = 5
        Me.pbBox3.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 25
        '
        'pbBox1Col
        '
        Me.pbBox1Col.BackColor = System.Drawing.Color.Transparent
        Me.pbBox1Col.Location = New System.Drawing.Point(358, 294)
        Me.pbBox1Col.Name = "pbBox1Col"
        Me.pbBox1Col.Size = New System.Drawing.Size(50, 2)
        Me.pbBox1Col.TabIndex = 6
        Me.pbBox1Col.TabStop = False
        '
        'pbBox2Col
        '
        Me.pbBox2Col.BackColor = System.Drawing.Color.Transparent
        Me.pbBox2Col.Location = New System.Drawing.Point(477, 244)
        Me.pbBox2Col.Name = "pbBox2Col"
        Me.pbBox2Col.Size = New System.Drawing.Size(50, 2)
        Me.pbBox2Col.TabIndex = 7
        Me.pbBox2Col.TabStop = False
        '
        'pbGroundCol
        '
        Me.pbGroundCol.BackColor = System.Drawing.Color.Transparent
        Me.pbGroundCol.Location = New System.Drawing.Point(124, 343)
        Me.pbGroundCol.Name = "pbGroundCol"
        Me.pbGroundCol.Size = New System.Drawing.Size(1208, 1)
        Me.pbGroundCol.TabIndex = 8
        Me.pbGroundCol.TabStop = False
        '
        'pbBox3Col
        '
        Me.pbBox3Col.BackColor = System.Drawing.Color.Transparent
        Me.pbBox3Col.Location = New System.Drawing.Point(611, 254)
        Me.pbBox3Col.Name = "pbBox3Col"
        Me.pbBox3Col.Size = New System.Drawing.Size(50, 1)
        Me.pbBox3Col.TabIndex = 9
        Me.pbBox3Col.TabStop = False
        '
        'pbGem
        '
        Me.pbGem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbGem.Location = New System.Drawing.Point(269, 303)
        Me.pbGem.Name = "pbGem"
        Me.pbGem.Size = New System.Drawing.Size(25, 25)
        Me.pbGem.TabIndex = 10
        Me.pbGem.TabStop = False
        '
        'lblScoreTXT
        '
        Me.lblScoreTXT.AutoSize = True
        Me.lblScoreTXT.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblScoreTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblScoreTXT.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblScoreTXT.Location = New System.Drawing.Point(12, 6)
        Me.lblScoreTXT.Name = "lblScoreTXT"
        Me.lblScoreTXT.Size = New System.Drawing.Size(109, 37)
        Me.lblScoreTXT.TabIndex = 11
        Me.lblScoreTXT.Text = "Score:"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblScore.Location = New System.Drawing.Point(116, 6)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 37)
        Me.lblScore.TabIndex = 12
        '
        'pbGem2
        '
        Me.pbGem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbGem2.Location = New System.Drawing.Point(369, 254)
        Me.pbGem2.Name = "pbGem2"
        Me.pbGem2.Size = New System.Drawing.Size(25, 25)
        Me.pbGem2.TabIndex = 13
        Me.pbGem2.TabStop = False
        '
        'pbGem3
        '
        Me.pbGem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbGem3.Location = New System.Drawing.Point(489, 203)
        Me.pbGem3.Name = "pbGem3"
        Me.pbGem3.Size = New System.Drawing.Size(25, 25)
        Me.pbGem3.TabIndex = 14
        Me.pbGem3.TabStop = False
        '
        'pbFinish
        '
        Me.pbFinish.BackColor = System.Drawing.Color.Yellow
        Me.pbFinish.Location = New System.Drawing.Point(789, 213)
        Me.pbFinish.Name = "pbFinish"
        Me.pbFinish.Size = New System.Drawing.Size(26, 74)
        Me.pbFinish.TabIndex = 15
        Me.pbFinish.TabStop = False
        '
        'pbFinish2
        '
        Me.pbFinish2.BackColor = System.Drawing.Color.Yellow
        Me.pbFinish2.Location = New System.Drawing.Point(789, 306)
        Me.pbFinish2.Name = "pbFinish2"
        Me.pbFinish2.Size = New System.Drawing.Size(26, 23)
        Me.pbFinish2.TabIndex = 16
        Me.pbFinish2.TabStop = False
        '
        'pbFallingOut
        '
        Me.pbFallingOut.BackColor = System.Drawing.Color.Transparent
        Me.pbFallingOut.Location = New System.Drawing.Point(-4, 427)
        Me.pbFallingOut.Name = "pbFallingOut"
        Me.pbFallingOut.Size = New System.Drawing.Size(1716, 1)
        Me.pbFallingOut.TabIndex = 17
        Me.pbFallingOut.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlText
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(2437, 50)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'sTutorial1
        '
        Me.sTutorial1.AutoSize = True
        Me.sTutorial1.Location = New System.Drawing.Point(105, 121)
        Me.sTutorial1.Name = "sTutorial1"
        Me.sTutorial1.Size = New System.Drawing.Size(0, 13)
        Me.sTutorial1.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(735, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "This indicates the end of the level!"
        '
        'pbSpike
        '
        Me.pbSpike.BackColor = System.Drawing.Color.Transparent
        Me.pbSpike.Image = CType(resources.GetObject("pbSpike.Image"), System.Drawing.Image)
        Me.pbSpike.Location = New System.Drawing.Point(558, 293)
        Me.pbSpike.Name = "pbSpike"
        Me.pbSpike.Size = New System.Drawing.Size(25, 50)
        Me.pbSpike.TabIndex = 21
        Me.pbSpike.TabStop = False
        '
        'pbHealth1
        '
        Me.pbHealth1.BackColor = System.Drawing.Color.Black
        Me.pbHealth1.Image = CType(resources.GetObject("pbHealth1.Image"), System.Drawing.Image)
        Me.pbHealth1.Location = New System.Drawing.Point(523, 12)
        Me.pbHealth1.Name = "pbHealth1"
        Me.pbHealth1.Size = New System.Drawing.Size(25, 25)
        Me.pbHealth1.TabIndex = 22
        Me.pbHealth1.TabStop = False
        '
        'pbHealth2
        '
        Me.pbHealth2.BackColor = System.Drawing.Color.Black
        Me.pbHealth2.Image = CType(resources.GetObject("pbHealth2.Image"), System.Drawing.Image)
        Me.pbHealth2.InitialImage = CType(resources.GetObject("pbHealth2.InitialImage"), System.Drawing.Image)
        Me.pbHealth2.Location = New System.Drawing.Point(556, 12)
        Me.pbHealth2.Name = "pbHealth2"
        Me.pbHealth2.Size = New System.Drawing.Size(25, 25)
        Me.pbHealth2.TabIndex = 23
        Me.pbHealth2.TabStop = False
        '
        'pbHealth3
        '
        Me.pbHealth3.BackColor = System.Drawing.Color.Black
        Me.pbHealth3.Image = CType(resources.GetObject("pbHealth3.Image"), System.Drawing.Image)
        Me.pbHealth3.InitialImage = CType(resources.GetObject("pbHealth3.InitialImage"), System.Drawing.Image)
        Me.pbHealth3.Location = New System.Drawing.Point(588, 12)
        Me.pbHealth3.Name = "pbHealth3"
        Me.pbHealth3.Size = New System.Drawing.Size(25, 25)
        Me.pbHealth3.TabIndex = 24
        Me.pbHealth3.TabStop = False
        '
        'lblHealth
        '
        Me.lblHealth.AutoSize = True
        Me.lblHealth.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblHealth.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHealth.Location = New System.Drawing.Point(405, 6)
        Me.lblHealth.Name = "lblHealth"
        Me.lblHealth.Size = New System.Drawing.Size(118, 37)
        Me.lblHealth.TabIndex = 25
        Me.lblHealth.Text = "Health:"
        '
        'pbSpikeCol1
        '
        Me.pbSpikeCol1.BackColor = System.Drawing.Color.Transparent
        Me.pbSpikeCol1.Location = New System.Drawing.Point(546, 292)
        Me.pbSpikeCol1.Name = "pbSpikeCol1"
        Me.pbSpikeCol1.Size = New System.Drawing.Size(50, 2)
        Me.pbSpikeCol1.TabIndex = 26
        Me.pbSpikeCol1.TabStop = False
        '
        'GameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(632, 446)
        Me.Controls.Add(Me.lblHealth)
        Me.Controls.Add(Me.pbHealth3)
        Me.Controls.Add(Me.pbHealth2)
        Me.Controls.Add(Me.pbHealth1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sTutorial1)
        Me.Controls.Add(Me.pbFinish2)
        Me.Controls.Add(Me.pbFinish)
        Me.Controls.Add(Me.pbGem3)
        Me.Controls.Add(Me.pbGem2)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblScoreTXT)
        Me.Controls.Add(Me.pbGem)
        Me.Controls.Add(Me.pbPlayer)
        Me.Controls.Add(Me.pbBox3)
        Me.Controls.Add(Me.pbBox1)
        Me.Controls.Add(Me.pbBox2)
        Me.Controls.Add(Me.DoNotEdit)
        Me.Controls.Add(Me.pbGround)
        Me.Controls.Add(Me.pbBox1Col)
        Me.Controls.Add(Me.pbBox2Col)
        Me.Controls.Add(Me.pbGroundCol)
        Me.Controls.Add(Me.pbFallingOut)
        Me.Controls.Add(Me.pbBox3Col)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pbSpike)
        Me.Controls.Add(Me.pbSpikeCol1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "GameForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Level 1"
        CType(Me.pbGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoNotEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBox1Col, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBox2Col, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGroundCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBox3Col, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFinish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFinish2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFallingOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSpike, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHealth1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHealth2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHealth3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSpikeCol1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbGround As System.Windows.Forms.PictureBox
    Friend WithEvents pbPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents DoNotEdit As System.Windows.Forms.PictureBox
    Friend WithEvents pbBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pbBox1Col As System.Windows.Forms.PictureBox
    Friend WithEvents pbBox2Col As System.Windows.Forms.PictureBox
    Friend WithEvents pbGroundCol As System.Windows.Forms.PictureBox
    Friend WithEvents pbBox3Col As System.Windows.Forms.PictureBox
    Friend WithEvents pbGem As System.Windows.Forms.PictureBox
    Friend WithEvents lblScoreTXT As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents pbGem2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbGem3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbFinish As System.Windows.Forms.PictureBox
    Friend WithEvents pbFinish2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbFallingOut As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents sTutorial1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbSpike As System.Windows.Forms.PictureBox
    Friend WithEvents pbHealth1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbHealth2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbHealth3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblHealth As System.Windows.Forms.Label
    Friend WithEvents pbSpikeCol1 As System.Windows.Forms.PictureBox
End Class
