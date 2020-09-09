Public Class FormZadatak3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nizStr() = TextBox1.Text.Split(" ")
        For Each broj As String In nizStr
            If Val(broj) Mod 2 <> 0 And Val(broj) Mod 3 <> 0 Then
                TextBox2.Text += $"{broj} "
            End If
        Next
    End Sub
End Class