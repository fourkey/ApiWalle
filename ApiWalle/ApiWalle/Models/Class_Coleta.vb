Public Class Class_Coleta

    Private _Cod_Coleta As Integer
    Public Property Cod_Coleta() As Integer
        Get
            Return _Cod_Coleta
        End Get
        Set(ByVal value As Integer)
            _Cod_Coleta = value
        End Set
    End Property

    Private _Cod_Cliente As Integer
    Public Property Cod_Cliente() As Integer
        Get
            Return _Cod_Cliente
        End Get
        Set(ByVal value As Integer)
            _Cod_Cliente = value
        End Set
    End Property

    Private _Des_Usuario_Rede As String
    Public Property Des_Usuario_Rede() As String
        Get
            Return _Des_Usuario_Rede
        End Get
        Set(ByVal value As String)
            _Des_Usuario_Rede = value
        End Set
    End Property

    Private _Des_Processo As String
    Public Property Des_Processo() As String
        Get
            Return _Des_Processo
        End Get
        Set(ByVal value As String)
            _Des_Processo = value
        End Set
    End Property

    Private _Cod_Categoria_App As Integer
    Public Property Cod_Categoria_App() As Integer
        Get
            Return _Cod_Categoria_App
        End Get
        Set(ByVal value As Integer)
            _Cod_Categoria_App = value
        End Set
    End Property

    Private _Des_Nome As String
    Public Property Des_Nome() As String
        Get
            Return _Des_Nome
        End Get
        Set(ByVal value As String)
            _Des_Nome = value
        End Set
    End Property

    Private _Cod_Categoria_Page As Integer
    Public Property Cod_Categoria_Page() As Integer
        Get
            Return _Cod_Categoria_Page
        End Get
        Set(ByVal value As Integer)
            _Cod_Categoria_Page = value
        End Set
    End Property

    Private _Des_URL As String
    Public Property Des_URL() As String
        Get
            Return _Des_URL
        End Get
        Set(ByVal value As String)
            _Des_URL = value
        End Set
    End Property

    Private _Cod_Categoria_Url As Integer
    Public Property Cod_Categoria_Url() As Integer
        Get
            Return _Cod_Categoria_Url
        End Get
        Set(ByVal value As Integer)
            _Cod_Categoria_Url = value
        End Set
    End Property

    Private _Des_Local As String
    Public Property Des_Local() As String
        Get
            Return _Des_Local
        End Get
        Set(ByVal value As String)
            _Des_Local = value
        End Set
    End Property

    Private _Date_Hora_Inicio As Date
    Public Property Date_Hora_Inicio() As Date
        Get
            Return _Date_Hora_Inicio
        End Get
        Set(ByVal value As Date)
            _Date_Hora_Inicio = value
        End Set
    End Property

    Private _Date_Hora_Fim As Date
    Public Property Date_Hora_Fim() As Date
        Get
            Return _Date_Hora_Fim
        End Get
        Set(ByVal value As Date)
            _Date_Hora_Fim = value
        End Set
    End Property

    Private _Int_Tempo As Integer
    Public Property Int_Tempo() As Integer
        Get
            Return _Int_Tempo
        End Get
        Set(ByVal value As Integer)
            _Int_Tempo = value
        End Set
    End Property

    Private _Des_Identificador_PC As String
    Public Property Des_Identificador_PC() As String
        Get
            Return _Des_Identificador_PC
        End Get
        Set(ByVal value As String)
            _Des_Identificador_PC = value
        End Set
    End Property

    Private _Des_Chave_Processo As String
    Public Property Des_Chave_Processo() As String
        Get
            Return _Des_Chave_Processo
        End Get
        Set(ByVal value As String)
            _Des_Chave_Processo = value
        End Set
    End Property

    Private _Cod_Cliente_Usuario As Integer
    Public Property Cod_Cliente_Usuario() As Integer
        Get
            Return _Cod_Cliente_Usuario
        End Get
        Set(ByVal value As Integer)
            _Cod_Cliente_Usuario = value
        End Set
    End Property

    Private _Des_Versao As String
    Public Property Des_Versao() As String
        Get
            Return _Des_Versao
        End Get
        Set(ByVal value As String)
            _Des_Versao = value
        End Set
    End Property

    Private _Des_Rastrear As String
    Public Property Des_Rastrear() As String
        Get
            Return _Des_Rastrear
        End Get
        Set(ByVal value As String)
            _Des_Rastrear = value
        End Set
    End Property

End Class
