Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Public Class ShutdownForm

#Region "INI Parser Code"

    <DllImport("kernel32")> _
    Private Shared Function GetPrivateProfileString(ByVal section As String, ByVal key As String, ByVal def As String, ByVal retVal As StringBuilder, ByVal size As Integer, ByVal filePath As String) As Integer
    End Function

    Public Function GetIniValue(ByVal section As String, ByVal key As String, ByVal filename As String, Optional ByVal defaultValue As String = "") As String
        Dim sb As New StringBuilder(500)
        If GetPrivateProfileString(section, key, defaultValue, sb, sb.Capacity, filename) > 0 Then
            Return sb.ToString
        Else
            Return defaultValue
        End If
    End Function

#End Region

    Dim translator As String = "Original English"

    Private Sub ShutdownForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        GrayedBG.Close()
    End Sub

    Private Sub ShutdownForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WindowsLogo.ContextMenu = ContextMenu1
        Dim inifile As String = Path.Combine(My.Application.Info.DirectoryPath, "xpshutdown.ini")
        If File.Exists(inifile) Then
            Me.Text = GetIniValue("xpshutdown", "title", inifile, "Turn off computer")
            TitleText.Text = GetIniValue("xpshutdown", "title", inifile, "Turn off computer")
            SleepText.Text = GetIniValue("xpshutdown", "sleep", inifile, "Stand by")
            If GetIniValue("xpshutdown", "sleepon", inifile, "0") = "0" Then
                SleepBtn.Enabled = False
                SleepBtn.Image = My.Resources.sleep_disabled
            Else
                SleepBtn.Enabled = True
            End If
            ShutdownText.Text = GetIniValue("xpshutdown", "shutdown", inifile, "Turn off")
            RestartText.Text = GetIniValue("xpshutdown", "restart", inifile, "Restart")
            CancelBtn.Text = GetIniValue("xpshutdown", "cancel", inifile, "Cancel")
            translator = GetIniValue("xpshutdown", "translator", inifile, "Other Translation")
        End If
    End Sub

#Region "Button Style"
    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub SleepBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SleepBtn.Click
        Application.SetSuspendState(PowerState.Suspend, True, True)
        Me.Close()
    End Sub

    Private Sub SleepBtn_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SleepBtn.MouseDown
        SleepBtn.Image = My.Resources.sleep_down
    End Sub

    Private Sub SleepBtn_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SleepBtn.MouseUp
        SleepBtn.Image = My.Resources.sleep_over
    End Sub

    Private Sub SleepBtn_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles SleepBtn.MouseEnter
        SleepBtn.Image = My.Resources.sleep_over
    End Sub

    Private Sub SleepBtn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles SleepBtn.MouseLeave
        SleepBtn.Image = My.Resources.sleep
    End Sub

    Private Sub ShutdownBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShutdownBtn.Click
        Dim s As New ProcessStartInfo
        s.WindowStyle = ProcessWindowStyle.Hidden
        s.FileName = "shutdown.exe"
        s.Arguments = "-s -t 0"
        Process.Start(s)
    End Sub

    Private Sub ShutdownBtn_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ShutdownBtn.MouseDown
        ShutdownBtn.Image = My.Resources.shutdown_down
    End Sub

    Private Sub ShutdownBtn_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ShutdownBtn.MouseUp
        ShutdownBtn.Image = My.Resources.shutdown_over
    End Sub

    Private Sub ShutdownBtn_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ShutdownBtn.MouseEnter
        ShutdownBtn.Image = My.Resources.shutdown_over
    End Sub

    Private Sub ShutdownBtn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ShutdownBtn.MouseLeave
        ShutdownBtn.Image = My.Resources.shutdown
    End Sub

    Private Sub RestartBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartBtn.Click
        Dim s As New ProcessStartInfo
        s.WindowStyle = ProcessWindowStyle.Hidden
        s.FileName = "shutdown.exe"
        s.Arguments = "-r -t 0"
        Process.Start(s)
    End Sub

    Private Sub RestartBtn_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RestartBtn.MouseDown
        RestartBtn.Image = My.Resources.restart_down
    End Sub

    Private Sub RestartBtn_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RestartBtn.MouseUp
        RestartBtn.Image = My.Resources.restart_over
    End Sub

    Private Sub RestartBtn_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RestartBtn.MouseEnter
        RestartBtn.Image = My.Resources.restart_over
    End Sub

    Private Sub RestartBtn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles RestartBtn.MouseLeave
        RestartBtn.Image = My.Resources.restart
    End Sub

#End Region

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        MessageBox.Show("XP Shutdown, version " & My.Application.Info.Version.ToString & vbNewLine & " - Assets: Copyright (c) Microsoft" & vbNewLine & " - Creator: TuxPuf Enterprises" & vbNewLine & " - Translation: " & translator, "About XP Shutdown...", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Process.Start("https://reddit.com/r/windowsxp/comments/goy3w9/request_hi_can_someone_make_a_working_exe_ui_with/")
        Me.Close()
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Process.Start("https://github.com/tuxpuf/xpshutdown/")
        Me.Close()
    End Sub
End Class
