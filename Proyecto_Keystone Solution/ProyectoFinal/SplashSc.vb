﻿Public Class SplashSc
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub
End Class