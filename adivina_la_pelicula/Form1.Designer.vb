<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_comprobar = New System.Windows.Forms.Button()
        Me.btn_otro_intento = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLetra = New System.Windows.Forms.TextBox()
        Me.pctImagenes = New System.Windows.Forms.PictureBox()
        Me.lblguiones = New System.Windows.Forms.Label()
        Me.lblErrores = New System.Windows.Forms.Label()
        CType(Me.pctImagenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_comprobar
        '
        Me.btn_comprobar.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_comprobar.Location = New System.Drawing.Point(364, 220)
        Me.btn_comprobar.Name = "btn_comprobar"
        Me.btn_comprobar.Size = New System.Drawing.Size(210, 72)
        Me.btn_comprobar.TabIndex = 0
        Me.btn_comprobar.Text = "Comprobar"
        Me.btn_comprobar.UseVisualStyleBackColor = True
        '
        'btn_otro_intento
        '
        Me.btn_otro_intento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_otro_intento.Location = New System.Drawing.Point(395, 395)
        Me.btn_otro_intento.Name = "btn_otro_intento"
        Me.btn_otro_intento.Size = New System.Drawing.Size(102, 52)
        Me.btn_otro_intento.TabIndex = 1
        Me.btn_otro_intento.Text = "Otro intento"
        Me.btn_otro_intento.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Location = New System.Drawing.Point(503, 394)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(102, 53)
        Me.btn_salir.TabIndex = 2
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(342, 353)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Errores"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(342, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Pelicula"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(368, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Introduzca letra: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palace Script MT", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(542, 89)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = " Juego del Ahorcado "
        '
        'txtLetra
        '
        Me.txtLetra.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLetra.Location = New System.Drawing.Point(446, 152)
        Me.txtLetra.Name = "txtLetra"
        Me.txtLetra.Size = New System.Drawing.Size(51, 62)
        Me.txtLetra.TabIndex = 7
        '
        'pctImagenes
        '
        Me.pctImagenes.Location = New System.Drawing.Point(23, 124)
        Me.pctImagenes.Name = "pctImagenes"
        Me.pctImagenes.Size = New System.Drawing.Size(313, 323)
        Me.pctImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctImagenes.TabIndex = 8
        Me.pctImagenes.TabStop = False
        '
        'lblguiones
        '
        Me.lblguiones.AutoSize = True
        Me.lblguiones.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblguiones.Location = New System.Drawing.Point(455, 313)
        Me.lblguiones.Name = "lblguiones"
        Me.lblguiones.Size = New System.Drawing.Size(37, 39)
        Me.lblguiones.TabIndex = 9
        Me.lblguiones.Text = "0"
        '
        'lblErrores
        '
        Me.lblErrores.AutoSize = True
        Me.lblErrores.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrores.Location = New System.Drawing.Point(431, 351)
        Me.lblErrores.Name = "lblErrores"
        Me.lblErrores.Size = New System.Drawing.Size(31, 31)
        Me.lblErrores.TabIndex = 10
        Me.lblErrores.Text = ": "
        '
        'Form1
        '
        Me.AcceptButton = Me.btn_comprobar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 459)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblErrores)
        Me.Controls.Add(Me.lblguiones)
        Me.Controls.Add(Me.pctImagenes)
        Me.Controls.Add(Me.txtLetra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_otro_intento)
        Me.Controls.Add(Me.btn_comprobar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pctImagenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_comprobar As Button
    Friend WithEvents btn_otro_intento As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLetra As TextBox
    Friend WithEvents pctImagenes As PictureBox
    Friend WithEvents lblguiones As Label
    Friend WithEvents lblErrores As Label
End Class
