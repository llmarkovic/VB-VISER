Public Class FormZadatak1
    Private Sub btnShowSqrt_Click(sender As Object, e As EventArgs) Handles btnShowSqrt.Click
        MessageBox.Show(KorenSume(Val(txtX.Text), Val(txtY.Text), Val(txtZ.Text)))
    End Sub
End Class