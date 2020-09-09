<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormZadatak1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.txtY = New System.Windows.Forms.TextBox()
        Me.txtZ = New System.Windows.Forms.TextBox()
        Me.btnShowSqrt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "U modulu kreirati funkciju koja za tri vrednosti unete u TextBox-ovima, vraća kva" &
    "drat artimetičke sredine vrednosti. Rezultat se prikazuje u iskačućem prozoru."
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(109, 83)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(144, 25)
        Me.txtX.TabIndex = 1
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(109, 114)
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(144, 25)
        Me.txtY.TabIndex = 2
        '
        'txtZ
        '
        Me.txtZ.Location = New System.Drawing.Point(109, 145)
        Me.txtZ.Name = "txtZ"
        Me.txtZ.Size = New System.Drawing.Size(144, 25)
        Me.txtZ.TabIndex = 3
        '
        'btnShowSqrt
        '
        Me.btnShowSqrt.Location = New System.Drawing.Point(109, 176)
        Me.btnShowSqrt.Name = "btnShowSqrt"
        Me.btnShowSqrt.Size = New System.Drawing.Size(144, 43)
        Me.btnShowSqrt.TabIndex = 4
        Me.btnShowSqrt.Text = "Prikaži"
        Me.btnShowSqrt.UseVisualStyleBackColor = True
        '
        'FormZadatak1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 236)
        Me.Controls.Add(Me.btnShowSqrt)
        Me.Controls.Add(Me.txtZ)
        Me.Controls.Add(Me.txtY)
        Me.Controls.Add(Me.txtX)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormZadatak1"
        Me.Text = "FormZadatak1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtX As TextBox
    Friend WithEvents txtY As TextBox
    Friend WithEvents txtZ As TextBox
    Friend WithEvents btnShowSqrt As Button
End Class
