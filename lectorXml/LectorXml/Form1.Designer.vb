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
        Me.txtRutaArchivo = New System.Windows.Forms.TextBox()
        Me.btnCargarArchivo = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.CargaFile = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'txtRutaArchivo
        '
        Me.txtRutaArchivo.Location = New System.Drawing.Point(12, 11)
        Me.txtRutaArchivo.Name = "txtRutaArchivo"
        Me.txtRutaArchivo.Size = New System.Drawing.Size(459, 20)
        Me.txtRutaArchivo.TabIndex = 0
        '
        'btnCargarArchivo
        '
        Me.btnCargarArchivo.Location = New System.Drawing.Point(477, 10)
        Me.btnCargarArchivo.Name = "btnCargarArchivo"
        Me.btnCargarArchivo.Size = New System.Drawing.Size(75, 23)
        Me.btnCargarArchivo.TabIndex = 1
        Me.btnCargarArchivo.Text = "Cargar"
        Me.btnCargarArchivo.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 37)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(540, 355)
        Me.ListBox1.TabIndex = 2
        '
        'CargaFile
        '
        Me.CargaFile.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 401)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnCargarArchivo)
        Me.Controls.Add(Me.txtRutaArchivo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRutaArchivo As TextBox
    Friend WithEvents btnCargarArchivo As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents CargaFile As OpenFileDialog
End Class
