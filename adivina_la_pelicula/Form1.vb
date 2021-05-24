Public Class Form1

    Private Sub btn_comprobar_Click(sender As Object, e As EventArgs) Handles btn_comprobar.Click
        lblguiones.Text = comprobar(txtLetra.Text, pctImagenes, lblErrores)
        txtLetra.Text = ""
        txtLetra.Focus()
        perder(lblErrores, lblguiones, pctImagenes)
        ganar(lblErrores, lblguiones, pctImagenes)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambio_imagen(pctImagenes)
        lblguiones.Text = inicio()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Dim condición As Integer
        condición = MsgBox("¿Estas seguro que quieres salir?", vbYesNo)
        If condición = vbYes Then Me.Close()
    End Sub

    Private Sub btn_otro_intento_Click(sender As Object, e As EventArgs) Handles btn_otro_intento.Click

        Dim condiciónReinicio As Integer
        condiciónReinicio = MsgBox("¿Estas seguro que quieres reiniciar?", vbYesNo)
        If condiciónReinicio = vbYes Then
            lblguiones.Text = inicio()
            reiniciar(lblErrores, lblguiones, pctImagenes)
            cambio_imagen(pctImagenes)
        End If

    End Sub



End Class