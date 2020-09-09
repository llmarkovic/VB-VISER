Public Class FormZadatak4
    Dim txt As TextBox
    Dim counter As Integer = 0
    Private Sub FormZadatak4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lbl As New Label
        lbl.Text = "Sve kontrole su dinamicke"
        lbl.AutoSize = False
        lbl.Width = Me.ClientSize.Width
        lbl.Height = 40
        Me.Controls.Add(lbl)

        txt = New TextBox()
        txt.Top = lbl.Top + lbl.Height
        txt.Width = Me.ClientSize.Width
        Me.Controls.Add(txt)

        Dim dodaj As New Button
        dodaj.Text = "Dodaj"
        dodaj.Top = txt.Top + txt.Height
        dodaj.Width = Me.ClientSize.Width / 2
        Me.Controls.Add(dodaj)

        Dim delete As New Button
        delete.Text = "Obrisi"
        delete.Top = dodaj.Top + dodaj.Height
        delete.Width = Me.ClientSize.Width / 2
        delete.Left = dodaj.Width
        Me.Controls.Add(delete)

        AddHandler dodaj.Click, AddressOf prikazi
        AddHandler delete.Click, AddressOf ukloni
    End Sub

    Private Sub prikazi(sender As Button, e As EventArgs)
        txt.Text += $"{2 ^ counter}"
        counter += 1
    End Sub

    Private Sub ukloni(sender As Button, e As EventArgs)
        txt.Text = ""
        counter = 0
    End Sub

End Class