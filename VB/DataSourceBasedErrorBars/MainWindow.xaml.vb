﻿Imports System.Collections.Generic
Imports System.Windows

Namespace DataSourceBasedErrorBars
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Function GetData() As List(Of DataItem)
			Return New List(Of DataItem)() From {
				New DataItem("A", 20, 5, 8),
				New DataItem("B", 50, 3, 5),
				New DataItem("C", 40, 20, 10),
				New DataItem("D", 22, 15, 5),
				New DataItem("E", 30, 5, 8),
				New DataItem("F", 45, 5, 4),
				New DataItem("G", 35, 5, 3),
				New DataItem("H", 28, 4, 2),
				New DataItem("I", 46, 6, 4),
				New DataItem("J", 27, 8, 20),
				New DataItem("K", 20, 5, 8),
				New DataItem("L", 50, 3, 5),
				New DataItem("M", 40, 20, 10),
				New DataItem("N", 22, 15, 5),
				New DataItem("O", 30, 5, 8),
				New DataItem("P", 45, 5, 2),
				New DataItem("Q", 35, 5, 5)
			}
		End Function
		Private Sub OnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			If pointSeries IsNot Nothing Then
				pointSeries.ArgumentDataMember = "Argument"
				pointSeries.ValueDataMember = "Value"
				pointSeries.DataSource = GetData()
			End If
		End Sub
	End Class
	Public Class DataItem
		Private privateArgument As String
		Public Property Argument() As String
			Get
				Return privateArgument
			End Get
			Private Set(ByVal value As String)
				privateArgument = value
			End Set
		End Property
		Private privateValue As Integer
		Public Property Value() As Integer
			Get
				Return privateValue
			End Get
			Private Set(ByVal value As Integer)
				privateValue = value
			End Set
		End Property
		Private privateNegative As Integer
		Public Property Negative() As Integer
			Get
				Return privateNegative
			End Get
			Private Set(ByVal value As Integer)
				privateNegative = value
			End Set
		End Property
		Private privatePositive As Integer
		Public Property Positive() As Integer
			Get
				Return privatePositive
			End Get
			Private Set(ByVal value As Integer)
				privatePositive = value
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
