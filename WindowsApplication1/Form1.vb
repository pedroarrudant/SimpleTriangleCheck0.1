Public Class Form1
    Private Sub BtnChecar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChecar.Click
        Dim trinang1, trinang2, trinang3 As String

        trinang1 = "equilatero"
        trinang2 = "escaleno"
        trinang3 = "isosceles"

        If (Txtlado1.Text = trinang1) Then
            'PictureBox recebendo image do Resources
            pbImg.Image = My.Resources.equilatero
            'Inativar Botão checar
            BtnChecar.Enabled = False
            'Ativar Botão Limpar
            btLimpar.Enabled = True
        End If
        If (Txtlado1.Text = trinang2) Then
            'PictureBox recebendo image do Resources
            pbImg.Image = My.Resources.escaleno
            'Inativar Botão checar
            BtnChecar.Enabled = False
            'Ativar Botão Limpar
            btLimpar.Enabled = True
        End If
        Dim a As Single, b As Single, c As Single, x As Single, y As Single, z As Single
        If (Txtlado1.Text = trinang3) Then
            'PictureBox recebendo image do Resources
            pbImg.Image = My.Resources.isosceles
            'Inativar Botão checar
            BtnChecar.Enabled = False
            'Ativar Botão Limpar
            btLimpar.Enabled = True
        End If

        a = Val(Lbllado1.Text)
        b = Val(Lbllado2.Text)
        c = Val(Lbllado3.Text)

        If a > b And a > b Then
            x = a
            y = b
            z = c
        ElseIf b > a And b > c Then
            x = b
            y = a
            z = c
        Else
            x = c
            y = a
            z = b
        End If
        If x ^ 2 = y ^ 2 + z ^ 2 Then
            pbImg.Image = My.Resources.Retângulo
        ElseIf x ^ 2 > y ^ 2 + z ^ 2 Then
            pbImg.Image = My.Resources.escaleno
        ElseIf x ^ 2 < y ^ 2 + z ^ 2 Then
            pbImg.Image = My.Resources.isosceles
        End If
    End Sub

    Private Sub btLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLimpar.Click
        'Limpar PictureBox
        Me.pbImg.Image = Nothing
        'Limpar campo de Digitação
        Txtlado1.Clear()
        'Ativar Botão checar
        BtnChecar.Enabled = True
        'Inativar Botão Limpar
        btLimpar.Enabled = False
    End Sub

    Private Sub Btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsair.Click
        End
    End Sub
End Class