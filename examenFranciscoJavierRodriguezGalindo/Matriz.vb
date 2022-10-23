'Clase utilizada para la creación de matrices de nxn.
Public Class Matriz
    'Declaración de variables
    Dim vFila, vColumna As Integer

    'Método que crea una matriz de nxn y llena sus celdas
    Private Sub btnTransmitirDatos_Click(sender As Object, e As EventArgs) Handles btnTransmitirDatos.Click
        Try
            'Se obtiene el valor de las filas y columnas
            vFila = Val(txtCantidadFilas.Text)
            vColumna = Val(txtCantidadColumnas.Text)

            'Se dibuja la matriz
            dgvMatriz.RowCount = vFila
            dgvMatriz.ColumnCount = vColumna

            'Se establece el nombre de la filas
            For f = 0 To vFila - 1
                dgvMatriz.Rows(f).HeaderCell.Value = (f + 1).ToString
            Next

            'Se establece el nombre de las columnas
            For c = 0 To vColumna - 1
                dgvMatriz.Columns(c).HeaderText = c + 1
            Next

            'Se llenan las celdas de la matriz
            For c = 0 To vColumna - 1
                If c <> 3 Then
                    For f = 0 To vFila - 1
                        If f < 10 Then
                            dgvMatriz.Rows(f).Cells(c).Value = CInt((100 - 1) * Rnd() + 1)
                        End If
                    Next
                End If
            Next

            'Eventos que modifican valores de la matriz
            For Each row As DataGridViewRow In dgvMatriz.Rows
                'Llamada a métodos locales
                PL_LlenaColumna3()
                PL_SumaTotalColumna3()

                'Se establecen los valores a 0
                dgvMatriz.Rows(10).Cells(0).Value = dgvMatriz.Rows(0).Cells(0).Value
                dgvMatriz.Rows(11).Cells(0).Value = dgvMatriz.Rows(1).Cells(0).Value

                'Llamada a método local
                PL_SumaTotalFilas1y2()
            Next

        Catch ex As Exception
            MsgBox("Ocurrió un error al intentar ejecutar su petición: " + ex.Message)
        End Try
    End Sub

    'Método que elimina valores de celdas (Columna 2)
    Private Sub btnEliminarValoresF1y2C2_Click(sender As Object, e As EventArgs) Handles btnEliminarValoresF1y2C2.Click
        Try
            dgvMatriz.Rows(0).Cells(1).Value = 0
            dgvMatriz.Rows(1).Cells(1).Value = 0

            'Llamada a métodos locales
            PL_LlenaColumna3()
            PL_SumaTotalColumna3()
            PL_SumaTotalFilas1y2()
        Catch ex As Exception
            MsgBox("Ocurrió un error al intentar ejecutar su petición: " + ex.Message)
        End Try
    End Sub

    'Método que llena valores de celdas (Columna 4)
    Private Sub btnLlenaF3a7C4_Click(sender As Object, e As EventArgs) Handles btnLlenaF3a7C4.Click
        Try
            For Each row As DataGridViewRow In dgvMatriz.Rows
                Dim VLFraccionTotalColumna2 As Single
                VLFraccionTotalColumna2 += Val((row.Cells(1).Value) / 5)

                dgvMatriz.Rows(2).Cells(3).Value = VLFraccionTotalColumna2
                dgvMatriz.Rows(3).Cells(3).Value = VLFraccionTotalColumna2
                dgvMatriz.Rows(4).Cells(3).Value = VLFraccionTotalColumna2
                dgvMatriz.Rows(5).Cells(3).Value = VLFraccionTotalColumna2
                dgvMatriz.Rows(6).Cells(3).Value = VLFraccionTotalColumna2
            Next

            'Llamada a métodos locales
            PL_LlenaColumna3()
            PL_SumaTotalColumna3()
            PL_SumaTotalFilas1y2()

        Catch ex As Exception
            MsgBox("Ocurrió un error al intentar ejecutar su petición: " + ex.Message)
        End Try
    End Sub

    'Método que llena valores de celdas (Columna 3)
    Private Sub PL_LlenaColumna3()
        Try
            For Each row As DataGridViewRow In dgvMatriz.Rows
                Dim VLSumaColumnas1a2y4 As Double = Convert.ToDouble(row.Cells(0).Value) + Convert.ToDouble(row.Cells(1).Value) + Convert.ToDouble(row.Cells(3).Value)
                row.Cells(2).Value = VLSumaColumnas1a2y4
            Next
        Catch ex As Exception
            MsgBox("Ocurrió un error al intentar ejecutar su petición: " + ex.Message)
        End Try
    End Sub

    'Método que establece el valor de etiqueta (Columna 3)
    Private Sub PL_SumaTotalColumna3()
        Try
            For Each row As DataGridViewRow In dgvMatriz.Rows
                Dim VLTotalColumna3 As Single
                VLTotalColumna3 += Val(row.Cells(2).Value)
                Me.lblDesSumaTotalColumna3.Text = VLTotalColumna3.ToString
            Next
        Catch ex As Exception
            MsgBox("Ocurrió un error al intentar ejecutar su petición: " + ex.Message)
        End Try
    End Sub

    'Método que establece el valor de etiqueta (Filas 1 y 2)
    Private Sub PL_SumaTotalFilas1y2()
        Try
            For Each row As DataGridViewRow In dgvMatriz.Rows
                Dim VLTotalF1y2C2 As Single
                VLTotalF1y2C2 = Val(dgvMatriz.Rows(0).Cells(1).Value + dgvMatriz.Rows(1).Cells(1).Value)
                Me.lblDesSumaTotalF1y2C2.Text = VLTotalF1y2C2.ToString
            Next
        Catch ex As Exception
            MsgBox("Ocurrió un error al intentar ejecutar su petición: " + ex.Message)
        End Try
    End Sub

End Class
