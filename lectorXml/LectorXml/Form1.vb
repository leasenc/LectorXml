Public Class Form1
    Private Sub btnCargarArchivo_Click(sender As Object, e As EventArgs) Handles btnCargarArchivo.Click
        CargaFile.Filter = "XML files (*.xml)|*.xml"
        CargaFile.Title = "Escoger Archivo XML"
        CargaFile.Multiselect = False
        CargaFile.FileName = ""

        If Not CargaFile.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            txtRutaArchivo.Text = CargaFile.FileName
            If LeeXML(txtRutaArchivo.Text) Then

            Else

            End If
        End If
    End Sub
End Class
