<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShutdownForm
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
        Me.ShutdownBtn = New System.Windows.Forms.PictureBox
        Me.WindowsLogo = New System.Windows.Forms.PictureBox
        Me.CancelBtn = New System.Windows.Forms.Button
        Me.SleepBtn = New System.Windows.Forms.PictureBox
        Me.RestartBtn = New System.Windows.Forms.PictureBox
        Me.TitleText = New System.Windows.Forms.Label
        Me.SleepText = New System.Windows.Forms.Label
        Me.ShutdownText = New System.Windows.Forms.Label
        Me.RestartText = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        CType(Me.ShutdownBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WindowsLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SleepBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestartBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShutdownBtn
        '
        Me.ShutdownBtn.BackColor = System.Drawing.Color.Transparent
        Me.ShutdownBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShutdownBtn.Image = Global.xpshutdown.My.Resources.Resources.shutdown
        Me.ShutdownBtn.Location = New System.Drawing.Point(139, 78)
        Me.ShutdownBtn.Name = "ShutdownBtn"
        Me.ShutdownBtn.Size = New System.Drawing.Size(32, 32)
        Me.ShutdownBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ShutdownBtn.TabIndex = 0
        Me.ShutdownBtn.TabStop = False
        '
        'WindowsLogo
        '
        Me.WindowsLogo.Image = Global.xpshutdown.My.Resources.Resources.shutdownlogo
        Me.WindowsLogo.Location = New System.Drawing.Point(265, 0)
        Me.WindowsLogo.Name = "WindowsLogo"
        Me.WindowsLogo.Size = New System.Drawing.Size(48, 40)
        Me.WindowsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.WindowsLogo.TabIndex = 1
        Me.WindowsLogo.TabStop = False
        '
        'CancelBtn
        '
        Me.CancelBtn.ForeColor = System.Drawing.Color.Black
        Me.CancelBtn.Location = New System.Drawing.Point(239, 166)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(62, 22)
        Me.CancelBtn.TabIndex = 2
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'SleepBtn
        '
        Me.SleepBtn.BackColor = System.Drawing.Color.Transparent
        Me.SleepBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SleepBtn.Image = Global.xpshutdown.My.Resources.Resources.sleep
        Me.SleepBtn.Location = New System.Drawing.Point(46, 78)
        Me.SleepBtn.Name = "SleepBtn"
        Me.SleepBtn.Size = New System.Drawing.Size(32, 32)
        Me.SleepBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.SleepBtn.TabIndex = 3
        Me.SleepBtn.TabStop = False
        '
        'RestartBtn
        '
        Me.RestartBtn.BackColor = System.Drawing.Color.Transparent
        Me.RestartBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RestartBtn.Image = Global.xpshutdown.My.Resources.Resources.restart
        Me.RestartBtn.Location = New System.Drawing.Point(237, 78)
        Me.RestartBtn.Name = "RestartBtn"
        Me.RestartBtn.Size = New System.Drawing.Size(32, 32)
        Me.RestartBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.RestartBtn.TabIndex = 4
        Me.RestartBtn.TabStop = False
        '
        'TitleText
        '
        Me.TitleText.AutoSize = True
        Me.TitleText.BackColor = System.Drawing.Color.Transparent
        Me.TitleText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleText.Location = New System.Drawing.Point(12, 13)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(145, 19)
        Me.TitleText.TabIndex = 5
        Me.TitleText.Text = "Turn off computer"
        '
        'SleepText
        '
        Me.SleepText.BackColor = System.Drawing.Color.Transparent
        Me.SleepText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SleepText.Location = New System.Drawing.Point(15, 113)
        Me.SleepText.Name = "SleepText"
        Me.SleepText.Size = New System.Drawing.Size(94, 34)
        Me.SleepText.TabIndex = 6
        Me.SleepText.Text = "Stand By"
        Me.SleepText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ShutdownText
        '
        Me.ShutdownText.BackColor = System.Drawing.Color.Transparent
        Me.ShutdownText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShutdownText.Location = New System.Drawing.Point(112, 113)
        Me.ShutdownText.Name = "ShutdownText"
        Me.ShutdownText.Size = New System.Drawing.Size(86, 34)
        Me.ShutdownText.TabIndex = 7
        Me.ShutdownText.Text = "Turn Off"
        Me.ShutdownText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RestartText
        '
        Me.RestartText.BackColor = System.Drawing.Color.Transparent
        Me.RestartText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestartText.Location = New System.Drawing.Point(207, 113)
        Me.RestartText.Name = "RestartText"
        Me.RestartText.Size = New System.Drawing.Size(94, 34)
        Me.RestartText.TabIndex = 8
        Me.RestartText.Text = "Restart"
        Me.RestartText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem7, Me.MenuItem3, Me.MenuItem4})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "About XP Shutdown..."
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 1
        Me.MenuItem7.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Reddit Post"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "Github"
        '
        'ShutdownForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.xpshutdown.My.Resources.Resources.shutdownbg
        Me.ClientSize = New System.Drawing.Size(313, 198)
        Me.Controls.Add(Me.RestartText)
        Me.Controls.Add(Me.ShutdownText)
        Me.Controls.Add(Me.SleepText)
        Me.Controls.Add(Me.TitleText)
        Me.Controls.Add(Me.RestartBtn)
        Me.Controls.Add(Me.SleepBtn)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.WindowsLogo)
        Me.Controls.Add(Me.ShutdownBtn)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ShutdownForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Turn off computer"
        Me.TopMost = True
        CType(Me.ShutdownBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WindowsLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SleepBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestartBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShutdownBtn As System.Windows.Forms.PictureBox
    Friend WithEvents WindowsLogo As System.Windows.Forms.PictureBox
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents SleepBtn As System.Windows.Forms.PictureBox
    Friend WithEvents RestartBtn As System.Windows.Forms.PictureBox
    Friend WithEvents TitleText As System.Windows.Forms.Label
    Friend WithEvents SleepText As System.Windows.Forms.Label
    Friend WithEvents ShutdownText As System.Windows.Forms.Label
    Friend WithEvents RestartText As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem

End Class
