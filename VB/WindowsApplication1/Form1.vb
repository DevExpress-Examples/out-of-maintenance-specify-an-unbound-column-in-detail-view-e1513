Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns

Namespace WindowsApplication1
	Public Partial Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub InitData()
				dataSet11.Tables("Customer").Rows.Add(New Object() { 1, "Bob", "Roy" })
				dataSet11.Tables("Customer").Rows.Add(New Object() { 2, "Alice", "Smith" })
				dataSet11.Tables("Customer").Rows.Add(New Object() { 3, "Alice", "Smith" })


				dataSet11.Tables("Book").Rows.Add(New Object() { 1, "Tesla", "My Inventions", 1,2,3.4})
				dataSet11.Tables("Book").Rows.Add(New Object() { 2, "Cataneda", "Teaching of Don Juan", 1,4,5.2})

				dataSet11.Tables("Book").Rows.Add(New Object() { 3, "Tesla", "My Inventions", 2,3,4.3 })
				dataSet11.Tables("Book").Rows.Add(New Object() { 4, "Cataneda", "Teaching of Don Juan", 2,4,4})

				dataSet11.Tables("BookDetail").Rows.Add(New Object() { 1, "Boo", "It's bad!", 2 })
				dataSet11.Tables("BookDetail").Rows.Add(New Object() { 2, "Foo", "Excellent!", 2 })

				dataSet11.Tables("Magazine").Rows.Add(New Object() { 1, "NewsWeek", 1 })
				dataSet11.Tables("Magazine").Rows.Add(New Object() { 2, "Rolling Stones",1 })

		End Sub



		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.InitData()
			gridControl1.ShowOnlyPredefinedDetails = True
		End Sub

		Private Sub gridView2_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gridView2.CustomUnboundColumnData
			Dim view As GridView = TryCast(sender, GridView)
			If e.Column.FieldName = "Unbound" Then
				e.Value = CDec(view.GetRowCellValue(e.RowHandle, view.Columns("Quantity"))) + CDec(view.GetRowCellValue(e.RowHandle, view.Columns("UnitPrice")))
			End If
		End Sub



	End Class
End Namespace