<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Timer
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btn_PlayPause = New System.Windows.Forms.ToolStripButton
        Me.btn_OnTop = New System.Windows.Forms.ToolStripButton
        Me.btn_Exit = New System.Windows.Forms.ToolStripButton
        Me.timeLabel = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.nfi = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripMargin = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_PlayPause, Me.btn_OnTop, Me.btn_Exit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(199, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "TimeMe"
        '
        'btn_PlayPause
        '
        Me.btn_PlayPause.Checked = True
        Me.btn_PlayPause.CheckOnClick = True
        Me.btn_PlayPause.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btn_PlayPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_PlayPause.Image = Global.TimeMe.My.Resources.Resources.control_play_blue
        Me.btn_PlayPause.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_PlayPause.Name = "btn_PlayPause"
        Me.btn_PlayPause.Size = New System.Drawing.Size(23, 22)
        Me.btn_PlayPause.Text = "Play/Pause"
        '
        'btn_OnTop
        '
        Me.btn_OnTop.CheckOnClick = True
        Me.btn_OnTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_OnTop.Image = Global.TimeMe.My.Resources.Resources.arrow_up
        Me.btn_OnTop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_OnTop.Name = "btn_OnTop"
        Me.btn_OnTop.Size = New System.Drawing.Size(23, 22)
        Me.btn_OnTop.Text = "Always on top"
        '
        'btn_Exit
        '
        Me.btn_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Exit.Image = Global.TimeMe.My.Resources.Resources.clock_red
        Me.btn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(23, 22)
        Me.btn_Exit.Text = "Quit TimeMe"
        '
        'timeLabel
        '
        Me.timeLabel.AutoSize = True
        Me.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.timeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLabel.Location = New System.Drawing.Point(0, 25)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(151, 42)
        Me.timeLabel.TabIndex = 1
        Me.timeLabel.Text = "0h0m0s"
        Me.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'nfi
        '
        Me.nfi.Text = "0h0m0s"
        '
        'Timer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(199, 66)
        Me.Controls.Add(Me.timeLabel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Timer"
        Me.Text = "TimeMe"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents timeLabel As System.Windows.Forms.Label
    Friend WithEvents btn_PlayPause As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_OnTop As System.Windows.Forms.ToolStripButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents nfi As System.Windows.Forms.NotifyIcon
    Friend WithEvents btn_Exit As System.Windows.Forms.ToolStripButton

End Class
