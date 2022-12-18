Imports System.Collections.Generic
Imports System.Windows

Namespace DataSourceBasedErrorBars

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Function GetData() As List(Of DataItem)
            Return New List(Of DataItem)() From {New DataItem("A", 20, 5, 8), New DataItem("B", 50, 3, 5), New DataItem("C", 40, 20, 10), New DataItem("D", 22, 15, 5), New DataItem("E", 30, 5, 8), New DataItem("F", 45, 5, 4), New DataItem("G", 35, 5, 3), New DataItem("H", 28, 4, 2), New DataItem("I", 46, 6, 4), New DataItem("J", 27, 8, 20), New DataItem("K", 20, 5, 8), New DataItem("L", 50, 3, 5), New DataItem("M", 40, 20, 10), New DataItem("N", 22, 15, 5), New DataItem("O", 30, 5, 8), New DataItem("P", 45, 5, 2), New DataItem("Q", 35, 5, 5)}
        End Function

        Private Sub OnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If Me.pointSeries IsNot Nothing Then
                Me.pointSeries.ArgumentDataMember = "Argument"
                Me.pointSeries.ValueDataMember = "Value"
                Me.pointSeries.DataSource = GetData()
            End If
        End Sub
    End Class

    Public Class DataItem

        Private _Argument As String, _Value As Integer, _Negative As Integer, _Positive As Integer

        Public Property Argument As String
            Get
                Return _Argument
            End Get

            Private Set(ByVal value As String)
                _Argument = value
            End Set
        End Property

        Public Property Value As Integer
            Get
                Return _Value
            End Get

            Private Set(ByVal value As Integer)
                _Value = value
            End Set
        End Property

        Public Property Negative As Integer
            Get
                Return _Negative
            End Get

            Private Set(ByVal value As Integer)
                _Negative = value
            End Set
        End Property

        Public Property Positive As Integer
            Get
                Return _Positive
            End Get

            Private Set(ByVal value As Integer)
                _Positive = value
            End Set
        End Property

        Public Sub New(ByVal argument As String, ByVal value As Integer, ByVal negative As Integer, ByVal positive As Integer)
            Me.Argument = argument
            Me.Value = value
            Me.Negative = negative
            Me.Positive = positive
        End Sub
    End Class
End Namespace
