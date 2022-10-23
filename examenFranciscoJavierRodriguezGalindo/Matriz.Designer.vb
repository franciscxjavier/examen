<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Matriz
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.gbMatriz = New System.Windows.Forms.GroupBox()
        Me.dgvMatriz = New System.Windows.Forms.DataGridView()
        Me.gpMatrizParam = New System.Windows.Forms.GroupBox()
        Me.btnTransmitirDatos = New System.Windows.Forms.Button()
        Me.lblCantidadColumnas = New System.Windows.Forms.Label()
        Me.txtCantidadColumnas = New System.Windows.Forms.TextBox()
        Me.lblCantidadFilas = New System.Windows.Forms.Label()
        Me.txtCantidadFilas = New System.Windows.Forms.TextBox()
        Me.gpVariables = New System.Windows.Forms.GroupBox()
        Me.lblDesSumaTotalF1y2C2 = New System.Windows.Forms.Label()
        Me.lblSumaTotalF1y2C2 = New System.Windows.Forms.Label()
        Me.lblDesSumaTotalColumna3 = New System.Windows.Forms.Label()
        Me.lblSumaTotalColumna3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEliminarValoresF1y2C2 = New System.Windows.Forms.Button()
        Me.btnLlenaF3a7C4 = New System.Windows.Forms.Button()
        Me.gbMatriz.SuspendLayout()
        CType(Me.dgvMatriz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpMatrizParam.SuspendLayout()
        Me.gpVariables.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbMatriz
        '
        Me.gbMatriz.Controls.Add(Me.dgvMatriz)
        Me.gbMatriz.Location = New System.Drawing.Point(12, 246)
        Me.gbMatriz.Name = "gbMatriz"
        Me.gbMatriz.Size = New System.Drawing.Size(479, 353)
        Me.gbMatriz.TabIndex = 0
        Me.gbMatriz.TabStop = False
        Me.gbMatriz.Text = "Matriz"
        '
        'dgvMatriz
        '
        Me.dgvMatriz.AllowUserToAddRows = False
        Me.dgvMatriz.AllowUserToDeleteRows = False
        Me.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMatriz.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMatriz.Location = New System.Drawing.Point(3, 19)
        Me.dgvMatriz.Name = "dgvMatriz"
        Me.dgvMatriz.RowTemplate.Height = 25
        Me.dgvMatriz.Size = New System.Drawing.Size(473, 331)
        Me.dgvMatriz.TabIndex = 0
        '
        'gpMatrizParam
        '
        Me.gpMatrizParam.Controls.Add(Me.btnTransmitirDatos)
        Me.gpMatrizParam.Controls.Add(Me.lblCantidadColumnas)
        Me.gpMatrizParam.Controls.Add(Me.txtCantidadColumnas)
        Me.gpMatrizParam.Controls.Add(Me.lblCantidadFilas)
        Me.gpMatrizParam.Controls.Add(Me.txtCantidadFilas)
        Me.gpMatrizParam.Location = New System.Drawing.Point(15, 12)
        Me.gpMatrizParam.Name = "gpMatrizParam"
        Me.gpMatrizParam.Size = New System.Drawing.Size(473, 82)
        Me.gpMatrizParam.TabIndex = 1
        Me.gpMatrizParam.TabStop = False
        Me.gpMatrizParam.Text = "Matriz Parámetros"
        '
        'btnTransmitirDatos
        '
        Me.btnTransmitirDatos.Location = New System.Drawing.Point(332, 32)
        Me.btnTransmitirDatos.Name = "btnTransmitirDatos"
        Me.btnTransmitirDatos.Size = New System.Drawing.Size(115, 33)
        Me.btnTransmitirDatos.TabIndex = 1
        Me.btnTransmitirDatos.Text = "Transmitir Datos"
        Me.btnTransmitirDatos.UseVisualStyleBackColor = True
        '
        'lblCantidadColumnas
        '
        Me.lblCantidadColumnas.AutoSize = True
        Me.lblCantidadColumnas.Location = New System.Drawing.Point(9, 50)
        Me.lblCantidadColumnas.Name = "lblCantidadColumnas"
        Me.lblCantidadColumnas.Size = New System.Drawing.Size(182, 15)
        Me.lblCantidadColumnas.TabIndex = 4
        Me.lblCantidadColumnas.Text = "Ingrese la cantidad de Columnas:"
        '
        'txtCantidadColumnas
        '
        Me.txtCantidadColumnas.Location = New System.Drawing.Point(197, 47)
        Me.txtCantidadColumnas.Name = "txtCantidadColumnas"
        Me.txtCantidadColumnas.Size = New System.Drawing.Size(100, 23)
        Me.txtCantidadColumnas.TabIndex = 3
        '
        'lblCantidadFilas
        '
        Me.lblCantidadFilas.AutoSize = True
        Me.lblCantidadFilas.Location = New System.Drawing.Point(40, 26)
        Me.lblCantidadFilas.Name = "lblCantidadFilas"
        Me.lblCantidadFilas.Size = New System.Drawing.Size(151, 15)
        Me.lblCantidadFilas.TabIndex = 2
        Me.lblCantidadFilas.Text = "Ingrese la cantidad de Filas:"
        '
        'txtCantidadFilas
        '
        Me.txtCantidadFilas.Location = New System.Drawing.Point(197, 23)
        Me.txtCantidadFilas.Name = "txtCantidadFilas"
        Me.txtCantidadFilas.Size = New System.Drawing.Size(100, 23)
        Me.txtCantidadFilas.TabIndex = 0
        '
        'gpVariables
        '
        Me.gpVariables.Controls.Add(Me.lblDesSumaTotalF1y2C2)
        Me.gpVariables.Controls.Add(Me.lblSumaTotalF1y2C2)
        Me.gpVariables.Controls.Add(Me.lblDesSumaTotalColumna3)
        Me.gpVariables.Controls.Add(Me.lblSumaTotalColumna3)
        Me.gpVariables.Location = New System.Drawing.Point(12, 100)
        Me.gpVariables.Name = "gpVariables"
        Me.gpVariables.Size = New System.Drawing.Size(476, 67)
        Me.gpVariables.TabIndex = 2
        Me.gpVariables.TabStop = False
        Me.gpVariables.Text = "Variables"
        '
        'lblDesSumaTotalF1y2C2
        '
        Me.lblDesSumaTotalF1y2C2.AutoSize = True
        Me.lblDesSumaTotalF1y2C2.Location = New System.Drawing.Point(214, 41)
        Me.lblDesSumaTotalF1y2C2.Name = "lblDesSumaTotalF1y2C2"
        Me.lblDesSumaTotalF1y2C2.Size = New System.Drawing.Size(0, 15)
        Me.lblDesSumaTotalF1y2C2.TabIndex = 3
        '
        'lblSumaTotalF1y2C2
        '
        Me.lblSumaTotalF1y2C2.AutoSize = True
        Me.lblSumaTotalF1y2C2.Location = New System.Drawing.Point(10, 41)
        Me.lblSumaTotalF1y2C2.Name = "lblSumaTotalF1y2C2"
        Me.lblSumaTotalF1y2C2.Size = New System.Drawing.Size(198, 15)
        Me.lblSumaTotalF1y2C2.TabIndex = 2
        Me.lblSumaTotalF1y2C2.Text = "Suma Total [Filas 1 y 2] [Columna 2]:"
        '
        'lblDesSumaTotalColumna3
        '
        Me.lblDesSumaTotalColumna3.AutoSize = True
        Me.lblDesSumaTotalColumna3.Location = New System.Drawing.Point(147, 19)
        Me.lblDesSumaTotalColumna3.Name = "lblDesSumaTotalColumna3"
        Me.lblDesSumaTotalColumna3.Size = New System.Drawing.Size(0, 15)
        Me.lblDesSumaTotalColumna3.TabIndex = 1
        '
        'lblSumaTotalColumna3
        '
        Me.lblSumaTotalColumna3.AutoSize = True
        Me.lblSumaTotalColumna3.Location = New System.Drawing.Point(12, 19)
        Me.lblSumaTotalColumna3.Name = "lblSumaTotalColumna3"
        Me.lblSumaTotalColumna3.Size = New System.Drawing.Size(129, 15)
        Me.lblSumaTotalColumna3.TabIndex = 0
        Me.lblSumaTotalColumna3.Text = "Suma Total Columna 3:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLlenaF3a7C4)
        Me.GroupBox1.Controls.Add(Me.btnEliminarValoresF1y2C2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 173)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 67)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acciones"
        '
        'btnEliminarValoresF1y2C2
        '
        Me.btnEliminarValoresF1y2C2.Location = New System.Drawing.Point(6, 22)
        Me.btnEliminarValoresF1y2C2.Name = "btnEliminarValoresF1y2C2"
        Me.btnEliminarValoresF1y2C2.Size = New System.Drawing.Size(228, 30)
        Me.btnEliminarValoresF1y2C2.TabIndex = 2
        Me.btnEliminarValoresF1y2C2.Text = "Eliminar valores [Filas 1 y 2] [Columna 2]"
        Me.btnEliminarValoresF1y2C2.UseVisualStyleBackColor = True
        '
        'btnLlenaF3a7C4
        '
        Me.btnLlenaF3a7C4.Location = New System.Drawing.Point(240, 22)
        Me.btnLlenaF3a7C4.Name = "btnLlenaF3a7C4"
        Me.btnLlenaF3a7C4.Size = New System.Drawing.Size(228, 30)
        Me.btnLlenaF3a7C4.TabIndex = 3
        Me.btnLlenaF3a7C4.Text = "Llena valores [Filas 3 a 7] [Columna 4]"
        Me.btnLlenaF3a7C4.UseVisualStyleBackColor = True
        '
        'Matriz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 611)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gpVariables)
        Me.Controls.Add(Me.gpMatrizParam)
        Me.Controls.Add(Me.gbMatriz)
        Me.Name = "Matriz"
        Me.Text = "Examen Francisco Javier Rodríguez Galindo"
        Me.gbMatriz.ResumeLayout(False)
        CType(Me.dgvMatriz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpMatrizParam.ResumeLayout(False)
        Me.gpMatrizParam.PerformLayout()
        Me.gpVariables.ResumeLayout(False)
        Me.gpVariables.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbMatriz As GroupBox
    Friend WithEvents dgvMatriz As DataGridView
    Friend WithEvents gpMatrizParam As GroupBox
    Friend WithEvents lblCantidadColumnas As Label
    Friend WithEvents txtCantidadColumnas As TextBox
    Friend WithEvents lblCantidadFilas As Label
    Friend WithEvents btnTransmitirDatos As Button
    Friend WithEvents txtCantidadFilas As TextBox
    Friend WithEvents gpVariables As GroupBox
    Friend WithEvents lblDesSumaTotalColumna3 As Label
    Friend WithEvents lblSumaTotalColumna3 As Label
    Friend WithEvents lblDesSumaTotalF1y2C2 As Label
    Friend WithEvents lblSumaTotalF1y2C2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnEliminarValoresF1y2C2 As Button
    Friend WithEvents btnLlenaF3a7C4 As Button
End Class
