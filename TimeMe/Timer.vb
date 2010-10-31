Public Class Timer
    Public secElapsed As Integer = 0
    Public result As DialogResult

    Private Sub btn_OnTop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OnTop.Click
        Me.TopMost = btn_OnTop.Checked
    End Sub

    Private Sub clockTick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        secElapsed = secElapsed + 1
        Dim hour As Integer
        Dim minutes As Integer
        Dim seconds As Integer

        hour = (secElapsed - 1800) / 3600
        minutes = ((secElapsed - 30) / 60) Mod 60
        seconds = secElapsed Mod 60

        timeLabel.Text = "" + hour.ToString + "h" + minutes.ToString + "m" + seconds.ToString + "s"
        nfi.Text = timeLabel.Text
    End Sub

    Private Sub btn_PlayPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PlayPause.Click
        Timer1.Enabled = btn_PlayPause.Checked
    End Sub

    Private Sub Timer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.stopwatch48
        nfi.Icon = My.Resources.stopwatch48
    End Sub

    Private Sub btn_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exit.Click
        result = MessageBox.Show("Really quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Application.Exit()
        End If
    End Sub

    Private Sub Timer_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (result = Windows.Forms.DialogResult.Yes) Then
            Return
        End If
        e.Cancel = True
        Me.Visible = False
        nfi.Visible = True
    End Sub

    Private Sub nfi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nfi.Click
        Me.Visible = True
        nfi.Visible = False
    End Sub
End Class
