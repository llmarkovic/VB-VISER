Public Class FormZadatak5
    Private Sub FormZadatak5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim blue As New Zadatak5FormBlue
        blue.Width = Me.ClientSize.Width / 2
        blue.Height = Me.ClientSize.Height / 2
        blue.MdiParent = Me
        blue.Show()
        blue.Left = Me.ClientSize.Width / 2

        Dim green As New Zadatak5FormGreen
        green.Width = Me.ClientSize.Width / 2
        green.Height = Me.ClientSize.Height / 2
        green.MdiParent = Me
        green.Show()
        green.Top = Me.ClientSize.Height / 2
    End Sub
End Class