Public Class GrayedBG

    Private Sub GrayedBG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShutdownForm.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Opacity < 0.75 Then
            Me.Opacity += 0.01
        End If
    End Sub
End Class