Public Class Documento
    Public _numeroAutorizacion As String
    Private _claveAcceso As String
    Private _ruc As String
    Private _establecimiento As String
    Private _fechaEmision As String
    Private _codDoc As String
    Private _secuencial As String
    Private _razonSocialComprador As String
    Private _identificacionComprador As String
    Private _motivo As String
    Private _direccion As String
    Private _email As String
    Private _valorLetras As String
    Private _ciudadFecha As String
    Private _motivoAdicional As String
    Private _puntoEmision As String

#Region "Propiedades"
    Public Property NumeroAutorizacion As String
        Get
            Return _numeroAutorizacion
        End Get
        Set(ByVal value As String)
            _numeroAutorizacion = value
        End Set
    End Property

    Public Property ClaveAcceso As String
        Get
            Return _claveAcceso
        End Get
        Set(value As String)
            _claveAcceso = value
        End Set
    End Property

    Public Property Ruc As String
        Get
            Return _ruc
        End Get
        Set(value As String)
            _ruc = value
        End Set
    End Property

    Public Property Establecimiento As String
        Get
            Return _establecimiento
        End Get
        Set(value As String)
            _establecimiento = value
        End Set
    End Property

    Public Property FechaEmision As String
        Get
            Return _fechaEmision
        End Get
        Set(value As String)
            _fechaEmision = value
        End Set
    End Property

    Public Property CodDoc As String
        Get
            Return _codDoc
        End Get
        Set(value As String)
            _codDoc = value
        End Set
    End Property

    Public Property Secuencial As String
        Get
            Return _secuencial
        End Get
        Set(value As String)
            _secuencial = value
        End Set
    End Property

    Public Property RazonSocialComprador As String
        Get
            Return _razonSocialComprador
        End Get
        Set(value As String)
            _razonSocialComprador = value
        End Set
    End Property

    Public Property IdentificacionComprador As String
        Get
            Return _identificacionComprador
        End Get
        Set(value As String)
            _identificacionComprador = value
        End Set
    End Property

    Public Property Motivo As String
        Get
            Return _motivo
        End Get
        Set(value As String)
            _motivo = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property ValorLetras As String
        Get
            Return _valorLetras
        End Get
        Set(value As String)
            _valorLetras = value
        End Set
    End Property

    Public Property CiudadFecha As String
        Get
            Return _ciudadFecha
        End Get
        Set(value As String)
            _ciudadFecha = value
        End Set
    End Property

    Public Property MotivoAdicional As String
        Get
            Return _motivoAdicional
        End Get
        Set(value As String)
            _motivoAdicional = value
        End Set
    End Property

    Public Property PuntoEmision As String
        Get
            Return _puntoEmision
        End Get
        Set(value As String)
            _puntoEmision = value
        End Set
    End Property
#End Region
End Class
