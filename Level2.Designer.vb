<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Level2
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
        Me.pbGround = New System.Windows.Forms.PictureBox
        Me.pbGround2 = New System.Windows.Forms.PictureBox
        Me.pbPlayer = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pbBox1 = New System.Windows.Forms.PictureBox
        Me.pbBox2 = New System.Windows.Forms.PictureBox
        Me.pbBoxCol1 = New System.Windows.Forms.PictureBox
        Me.pbBoxCol2 = New System.Windows.Forms.PictureBox
        Me.lblScore = New System.Windows.Forms.Label
        Me.lblScoreTXT = New System.Windows.Forms.Label
        Me.pbGem = New System.Windows.Forms.PictureBox
        Me.pbGem2 = New System.Windows.Forms.PictureBox
        Me.pbGem3 = New System.Windows.Forms.PictureBox
        Me.pbGroundCol = New System.Windows.Forms.PictureBox
        Me.DoNotDelete = New System.Windows.Forms.PictureBox
        Me.pbGround2Col = New System.Windows.Forms.PictureBox
        CType(Me.pbGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGround2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBoxCol1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBoxCol2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGroundCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoNotDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGround2Col, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbGround
        '
        Me.pbGround.BackColor = System.Drawing.Color.Gray
        Me.pbGround.Location = New System.Drawing.Point(-4, 363)
        Me.pbGround.Name = "pbGround"
        Me.pbGround.Size = New System.Drawing.Size(846, 50)
        Me.pbGround.TabIndex = 0
        Me.pbGround.TabStop = False
        '
        'pbGround2
        '
        Me.pbGround2.BackColor = System.Drawing.Color.Gray
        Me.pbGround2.Location = New System.Drawing.Point(282, 249)
        Me.pbGround2.Name = "pbGround2"
        Me.pbGround2.Size = New System.Drawing.Size(284, 50)
        Me.pbGround2.TabIndex = 1
        Me.pbGround2.TabStop = False
        '
        'pbPlayer
        '
        Me.pbPlayer.BackColor = System.Drawing.SystemColors.Highlight
        Me.pbPlayer.Location = New System.Drawing.Point(175, 313)
        Me.pbPlayer.Name = "pbPlayer"
        Me.pbPlayer.Size = New System.Drawing.Size(50, 50)
        Me.pbPlayer.TabIndex = 2
        Me.pbPlayer.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 25
        '
        'pbBox1
        '
        Me.pbBox1.BackColor = System.Drawing.Color.Gray
        Me.pbBox1.Location = New System.Drawing.Point(392, 200)
        Me.pbBox1.Name = "pbBox1"
        Me.pbBox1.Size = New System.Drawing.Size(50, 50)
        Me.pbBox1.TabIndex = 3
        Me.pbBox1.TabStop = False
        '
        'pbBox2
        '
        Me.pbBox2.BackColor = System.Drawing.Color.Gray
        Me.pbBox2.Location = New System.Drawing.Point(626, 314)
        Me.pbBox2.Name = "pbBox2"
        Me.pbBox2.Size = New System.Drawing.Size(50, 50)
        Me.pbBox2.TabIndex = 4
        Me.pbBox2.TabStop = False
        '
        'pbBoxCol1
        '
        Me.pbBoxCol1.BackColor = System.Drawing.Color.Transparent
        Me.pbBoxCol1.Location = New System.Drawing.Point(392, 199)
        Me.pbBoxCol1.Name = "pbBoxCol1"
        Me.pbBoxCol1.Size = New System.Drawing.Size(50, 1)
        Me.pbBoxCol1.TabIndex = 5
        Me.pbBoxCol1.TabStop = False
        '
        'pbBoxCol2
        '
        Me.pbBoxCol2.BackColor = System.Drawing.Color.Transparent
        Me.pbBoxCol2.Location = New System.Drawing.Point(626, 312)
        Me.pbBoxCol2.Name = "pbBoxCol2"
        Me.pbBoxCol2.Size = New System.Drawing.Size(50, 1)
        Me.pbBoxCol2.TabIndex = 6
        Me.pbBoxCol2.TabStop = False
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblScore.Location = New System.Drawing.Point(114, 8)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 37)
        Me.lblScore.TabIndex = 14
        '
        'lblScoreTXT
        '
        Me.lblScoreTXT.AutoSize = True
        Me.lblScoreTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblScoreTXT.Location = New System.Drawing.Point(10, 8)
        Me.lblScoreTXT.Name = "lblScoreTXT"
        Me.lblScoreTXT.Size = New System.Drawing.Size(109, 37)
        Me.lblScoreTXT.TabIndex = 13
        Me.lblScoreTXT.Text = "Score:"
        '
        'pbGem
        '
        Me.pbGem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbGem.Location = New System.Drawing.Point(402, 149)
        Me.pbGem.Name = "pbGem"
        Me.pbGem.Size = New System.Drawing.Size(25, 25)
        Me.pbGem.TabIndex = 15
        Me.pbGem.TabStop = False
        '
        'pbGem2
        '
        Me.pbGem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbGem2.Location = New System.Drawing.Point(441, 323)
        Me.pbGem2.Name = "pbGem2"
        Me.pbGem2.Size = New System.Drawing.Size(25, 25)
        Me.pbGem2.TabIndex = 16
        Me.pbGem2.TabStop = False
        '
        'pbGem3
        '
        Me.pbGem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbGem3.Location = New System.Drawing.Point(637, 198)
        Me.pbGem3.Name = "pbGem3"
        Me.pbGem3.Size = New System.Drawing.Size(25, 25)
        Me.pbGem3.TabIndex = 17
        Me.pbGem3.TabStop = False
        '
        'pbGroundCol
        '
        Me.pbGroundCol.BackColor = System.Drawing.Color.Transparent
        Me.pbGroundCol.Location = New System.Drawing.Point(-4, 360)
        Me.pbGroundCol.Name = "pbGroundCol"
        Me.pbGroundCol.Size = New System.Drawing.Size(847, 1)
        Me.pbGroundCol.TabIndex = 18
        Me.pbGroundCol.TabStop = False
        '
        'DoNotDelete
        '
        Me.DoNotDelete.BackColor = System.Drawing.Color.Transparent
        Me.DoNotDelete.Location = New System.Drawing.Point(3000, 165)
        Me.DoNotDelete.Name = "DoNotDelete"
        Me.DoNotDelete.Size = New System.Drawing.Size(1, 50)
        Me.DoNotDelete.TabIndex = 19
        Me.DoNotDelete.TabStop = False
        '
        'pbGround2Col
        '
        Me.pbGround2Col.BackColor = System.Drawing.Color.Transparent
        Me.pbGround2Col.Location = New System.Drawing.Point(282, 246)
        Me.pbGround2Col.Name = "pbGround2Col"
        Me.pbGround2Col.Size = New System.Drawing.Size(284, 1)
        Me.pbGround2Col.TabIndex = 21
        Me.pbGround2Col.TabStop = False
        '
        'Level2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.Controls.Add(Me.DoNotDelete)
        Me.Controls.Add(Me.pbGem3)
        Me.Controls.Add(Me.pbGem2)
        Me.Controls.Add(Me.pbGem)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblScoreTXT)
        Me.Controls.Add(Me.pbPlayer)
        Me.Controls.Add(Me.pbBox2)
        Me.Controls.Add(Me.pbBox1)
        Me.Controls.Add(Me.pbGround2)
        Me.Controls.Add(Me.pbGround)
        Me.Controls.Add(Me.pbGroundCol)
        Me.Controls.Add(Me.pbBoxCol1)
        Me.Controls.Add(Me.pbBoxCol2)
        Me.Controls.Add(Me.pbGround2Col)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Level2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Level 2"
        CType(Me.pbGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGround2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBoxCol1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBoxCol2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGroundCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoNotDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGround2Col, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbGround As System.Windows.Forms.PictureBox
    Friend WithEvents pbGround2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pbBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbBoxCol1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbBoxCol2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblScoreTXT As System.Windows.Forms.Label
    Friend WithEvents pbGem As System.Windows.Forms.PictureBox
    Friend WithEvents pbGem2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbGem3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbGroundCol As System.Windows.Forms.PictureBox
    Friend WithEvents DoNotDelete As System.Windows.Forms.PictureBox
    Friend WithEvents pbGround2Col As System.Windows.Forms.PictureBox
End Class
