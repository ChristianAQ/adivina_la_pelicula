Module Module1

    Dim nPeli As Integer
    Dim peliculas() As String = {"el padrino", "x men", "peter pan"}
    Dim mipeli As String
    Dim fallos As Integer
    Dim guiones As String

    Sub cambio_imagen(imagenes As PictureBox)
        imagenes.Image = Image.FromFile(Application.StartupPath & "\img\" & fallos & ".GIF")
    End Sub

    Function reiniciar(lblErrores As Label, lblguiones As Label, pctImagenes As PictureBox)
        fallos = 0
        lblErrores.Text = ": "
        lblguiones.Text = inicio()
        cambio_imagen(pctImagenes)
    End Function

    Function ganar(lblErrores As Label, lblguiones As Label, pctImagenes As PictureBox)
        If guiones = mipeli Then
            MsgBox("felicidades has ganado! ")
            reiniciar(lblErrores, lblguiones, pctImagenes)
        End If
    End Function

    Function perder(lblErrores As Label, lblguiones As Label, pctImagenes As PictureBox)
        If (fallos = 6) Then
            MsgBox("Has perdido")
            Dim condiciónReinicio As Integer
            condiciónReinicio = MsgBox("¿Te rindes?,¿Quieres saber que pelicula era?", vbYesNo)
            If condiciónReinicio = vbYes Then
                MsgBox("La palabra era " & mipeli)
            End If
            reiniciar(lblErrores, lblguiones, pctImagenes)
        End If
    End Function

    Function inicio() As String

        guiones = ""

        nPeli = CInt(Int(3 * Rnd()))

        MsgBox(nPeli)
        mipeli = peliculas(nPeli)

        For i = 0 To mipeli.Length - 1
            If mipeli(i) = " " Then
                guiones &= " "
            Else
                guiones &= "-"
            End If
        Next

        Return guiones
    End Function

    Function comprobar(letra As Char, pct As PictureBox, lblErrores As Label) As String
        Dim aux As Boolean
        For i = 0 To mipeli.Length - 1
            If mipeli(i) = letra Then
                guiones = guiones.Remove(i, 1)
                guiones = guiones.Insert(i, letra)
                aux = True
            End If
        Next

        If aux = True Then

        End If

        If aux = False Then
            fallos += 1
            lblErrores.Text += letra & ", "
            cambio_imagen(pct)
        End If
        Return guiones
    End Function

End Module
