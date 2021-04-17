Imports System
Imports System.Xml

Module LectorXml
    Dim _documento As Documento

    Public Function LeeXML(ruta As String) As Boolean
        Dim esConsultada As Boolean = False
        Try
            Dim documento = CargarXml(ruta)
            MsgBox(documento.CiudadFecha & " " & documento.NumeroAutorizacion & " " & documento.CodDoc)
        Catch ex As Exception
            Debug.WriteLine(ex.Message & " " & ex.StackTrace)
        End Try
        Return esConsultada
    End Function

    Public Function CargarXml(ruta As String) As Documento
        Dim table As New DataTable
        Dim xmlFile As XmlReader

        _documento = New Documento()

        Try
            xmlFile = XmlReader.Create(ruta, New XmlReaderSettings())
            Dim ds As New DataSet
            Dim dv As DataView
            Dim nuevoXml As String
            ds.ReadXml(xmlFile)

            dv = New DataView(ds.Tables(0))
            dv.Sort = "numeroAutorizacion"
            Dim index As Integer = dv.Find("numeroAutorizacion")

            table = dv.ToTable()

            If table.Rows.Count > 0 Then
                _documento.NumeroAutorizacion = table.Rows(0)("numeroAutorizacion")
                nuevoXml = table.Rows(0)("comprobante")
                NuevoXmls(nuevoXml)
            End If

            'If index = -1 Then
            '    MsgBox("Item Not Found")
            'Else
            '    MsgBox(dv(index)("comprobante").ToString())
            'End If
        Catch ex As Exception
            Throw ex
        End Try
        Return _documento
    End Function

    Public Sub NuevoXmls(cadena As String)
        Dim xmlDoc As New XmlDocument()

        cadena = cadena.Replace("﻿<?xml version=""1.0"" encoding=""UTF-8""?>", "")


        xmlDoc.LoadXml(cadena)

        For Each Attribute As XmlAttribute In xmlDoc.DocumentElement.Attributes
            Console.WriteLine("{0}: {1}", Attribute.Name, Attribute.Value)
        Next

        Try
            For Each node As XmlNode In xmlDoc.DocumentElement.SelectNodes("infoTributaria") ' or just SelectNodes("*")
                Console.WriteLine("ruc: " + node.SelectSingleNode("ruc").InnerText) 'access element
                _documento.Ruc = node.SelectSingleNode("ruc").InnerText
                Console.WriteLine("codDoc: " + node.SelectSingleNode("codDoc").InnerText) 'access element
                _documento.CodDoc = node.SelectSingleNode("codDoc").InnerText
                Console.WriteLine("secuencial: " + node.SelectSingleNode("secuencial").InnerText) 'access element
                _documento.Secuencial = node.SelectSingleNode("secuencial").InnerText
                Console.WriteLine("claveAcceso: " + node.SelectSingleNode("claveAcceso").InnerText) 'access element
                _documento.ClaveAcceso = node.SelectSingleNode("claveAcceso").InnerText
                Console.WriteLine("estab: " + node.SelectSingleNode("estab").InnerText) 'access element
                _documento.Establecimiento = node.SelectSingleNode("estab").InnerText
                Console.WriteLine("ptoEmi: " + node.SelectSingleNode("ptoEmi").InnerText) 'access element
                _documento.PuntoEmision = node.SelectSingleNode("ptoEmi").InnerText
            Next

            For Each node As XmlNode In xmlDoc.DocumentElement.SelectNodes("infoFactura") ' or just SelectNodes("*")
                Console.WriteLine("fechaEmision: " + node.SelectSingleNode("fechaEmision").InnerText) 'access element
                _documento.FechaEmision = node.SelectSingleNode("fechaEmision").InnerText
                Console.WriteLine("razonSocialComprador: " + node.SelectSingleNode("razonSocialComprador").InnerText) 'access element
                _documento.RazonSocialComprador = node.SelectSingleNode("razonSocialComprador").InnerText
            Next

            For Each node As XmlNode In xmlDoc.DocumentElement.SelectNodes("infoAdicional") ' or just SelectNodes("*")

                For Each child As XmlNode In node.ChildNodes
                    Console.WriteLine(child.Attributes(0).InnerText & " " & child.InnerText)

                    Select Case child.Attributes(0).InnerText
                        Case "Direccion"
                            _documento.Direccion = child.InnerText
                            Exit Select
                        Case "Email"
                            _documento.Email = child.InnerText
                            Exit Select
                        Case "ValorLetras"
                            _documento.ValorLetras = child.InnerText
                            Exit Select
                        Case "Motivo"
                            _documento.Motivo = child.InnerText
                            Exit Select
                        Case "CiudadFecha"
                            _documento.CiudadFecha = child.InnerText
                            Exit Select
                    End Select
                Next
            Next
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace)
        End Try



    End Sub
End Module
