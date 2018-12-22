Imports Microsoft.VisualBasic
Imports System.Data

Namespace Classes.TableStructure

    Public Class TestResults

        Private _TestResultID As Integer
        Private _Name As String
        Private _BornDate As String
        Private _SexID As Integer
        Private _SexString As String
        Private _MarriageStatusID As Integer
        Private _MarriageStatusString As String
        Private _GraduateID As Integer
        Private _GraduateString As String
        Private _TypeID As String
        Private _ItemCount As Decimal
        Private _ItemPercent As Single
        Private _TypeCount As Decimal
        Private _TypePercent As Single

        Sub New(ByVal dr As DataRow)
            _TestResultID = dr("TestResultID")
            _Name = dr("Name")
            _BornDate = dr("BornDate")
            _SexID = dr("SexID")
            _SexString = dr("SexString")
            _MarriageStatusID = dr("MarriageStatusID")
            _MarriageStatusString = dr("MarriageStatusString")
            _GraduateID = (dr("GraduateID"))
            _GraduateString = dr("GraduateString")
            _TypeID = dr("TypeID")
            _ItemCount = dr("ItemCount")
            _ItemPercent = dr("ItemPercent")
            _TypePercent = dr("TypePercent")
            _TypeCount = dr("TypeCount")
        End Sub

        Public Property [TestResultID]() As Integer
            Get
                Return _TestResultID
            End Get
            Set(ByVal value As Integer)
                _TestResultID = value
            End Set
        End Property

        Public Property [Name]() As String
            Get
                Return _Name
            End Get
            Set(ByVal value As String)
                _Name = value
            End Set
        End Property

        Public Property BornDate() As String
            Get
                Return _BornDate
            End Get
            Set(ByVal value As String)
                _BornDate = value
            End Set
        End Property

        Public Property SexID() As Integer
            Get
                Return _SexID
            End Get
            Set(ByVal value As Integer)
                _SexID = value
            End Set
        End Property

        Public Property MarriageStatusID() As Integer
            Get
                Return _MarriageStatusID
            End Get
            Set(ByVal value As Integer)
                _MarriageStatusID = value
            End Set
        End Property

        Public Property GraduateID() As Integer
            Get
                Return _GraduateID
            End Get
            Set(ByVal value As Integer)
                _GraduateID = value
            End Set
        End Property

        Public Property TypeID() As String
            Get
                Return _TypeID
            End Get
            Set(ByVal value As String)
                _TypeID = value
            End Set
        End Property

        Public Property SexString() As String
            Get
                Return _SexString
            End Get
            Set(ByVal value As String)
                _SexString = value
            End Set
        End Property

        Public Property MarriageStatusString() As String
            Get
                Return _MarriageStatusString
            End Get
            Set(ByVal value As String)
                _MarriageStatusString = value
            End Set
        End Property

        Public Property GraduateString() As String
            Get
                Return _GraduateString
            End Get
            Set(ByVal value As String)
                _GraduateString = value
            End Set
        End Property

        Public Property ItemCount() As Decimal
            Get
                Return _ItemCount
            End Get
            Set(ByVal value As Decimal)
                _ItemCount = value
            End Set
        End Property

        Public Property ItemPercent() As Single
            Get
                Return _ItemPercent
            End Get
            Set(ByVal value As Single)
                _ItemPercent = value
            End Set
        End Property

        Public Property TypeCount() As Decimal
            Get
                Return _TypeCount
            End Get
            Set(ByVal value As Decimal)
                _TypeCount = value
            End Set
        End Property

        Public Property TypePercent() As Single
            Get
                Return _TypePercent
            End Get
            Set(ByVal value As Single)
                _TypePercent = value
            End Set
        End Property

    End Class

End Namespace