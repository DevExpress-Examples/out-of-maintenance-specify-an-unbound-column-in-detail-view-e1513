' Developer Express Code Central Example:
' Specify an unbound column in detail view
' 
' You should configure your detail view as described in the Master-Detail:
' DataTable Use
' (ms-help://DevExpress.NETv8.2/DevExpress.XtraGrid/CustomDocument731.htm) help
' topic. Take note of the 5th point: "Specify and Customize Views To Represent
' Datatables ". Create an unbound column for the detail view, and subscribe to the
' CustomUnboundColumnData event of the detail view. Handle this event as described
' in the following topic:
' ColumnView.CustomUnboundColumnData Event
' (ms-help://DevExpress.NETv8.2/DevExpress.XtraGrid/DevExpressXtraGridViewsBaseColumnView_CustomUnboundColumnDatatopic.htm)
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1513

Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim gridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.customerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.dataSet11 = New WindowsApplication1.DataSet1()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colSecondName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colArticleID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colAuthor1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colContent = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colBookID1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
			Me.colBookID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colAuthor = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCustomerID1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridView2
			' 
			Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colBookID, Me.colAuthor, Me.colName, Me.colCustomerID1, Me.colQuantity, Me.colUnitPrice, Me.gridColumn1})
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			Me.gridView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
'			Me.gridView2.CustomUnboundColumnData += New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(Me.gridView2_CustomUnboundColumnData);
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.customerBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			gridLevelNode1.LevelTemplate = Me.gridView2
			gridLevelNode1.RelationName = "Customer_Book"
			Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(689, 367)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView3, Me.gridView2})
			' 
			' customerBindingSource
			' 
			Me.customerBindingSource.DataMember = "Customer"
			Me.customerBindingSource.DataSource = Me.dataSet11
			' 
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCustomerID, Me.colFirstName, Me.colSecondName})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' colCustomerID
			' 
			Me.colCustomerID.Caption = "CustomerID"
			Me.colCustomerID.FieldName = "CustomerID"
			Me.colCustomerID.Name = "colCustomerID"
			Me.colCustomerID.Visible = True
			Me.colCustomerID.VisibleIndex = 0
			' 
			' colFirstName
			' 
			Me.colFirstName.Caption = "FirstName"
			Me.colFirstName.FieldName = "FirstName"
			Me.colFirstName.Name = "colFirstName"
			Me.colFirstName.Visible = True
			Me.colFirstName.VisibleIndex = 1
			' 
			' colSecondName
			' 
			Me.colSecondName.Caption = "SecondName"
			Me.colSecondName.FieldName = "SecondName"
			Me.colSecondName.Name = "colSecondName"
			Me.colSecondName.Visible = True
			Me.colSecondName.VisibleIndex = 2
			' 
			' gridView3
			' 
			Me.gridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colArticleID, Me.colAuthor1, Me.colContent, Me.colBookID1})
			Me.gridView3.GridControl = Me.gridControl1
			Me.gridView3.Name = "gridView3"
			' 
			' colArticleID
			' 
			Me.colArticleID.Caption = "ArticleID"
			Me.colArticleID.FieldName = "ArticleID"
			Me.colArticleID.Name = "colArticleID"
			Me.colArticleID.Visible = True
			Me.colArticleID.VisibleIndex = 0
			' 
			' colAuthor1
			' 
			Me.colAuthor1.Caption = "Author"
			Me.colAuthor1.FieldName = "Author"
			Me.colAuthor1.Name = "colAuthor1"
			Me.colAuthor1.Visible = True
			Me.colAuthor1.VisibleIndex = 1
			' 
			' colContent
			' 
			Me.colContent.Caption = "Content"
			Me.colContent.FieldName = "Content"
			Me.colContent.Name = "colContent"
			Me.colContent.Visible = True
			Me.colContent.VisibleIndex = 2
			' 
			' colBookID1
			' 
			Me.colBookID1.Caption = "BookID"
			Me.colBookID1.FieldName = "BookID"
			Me.colBookID1.Name = "colBookID1"
			Me.colBookID1.Visible = True
			Me.colBookID1.VisibleIndex = 3
			' 
			' layoutViewCard1
			' 
			Me.layoutViewCard1.CustomizationFormText = "layoutViewTemplateCard"
			Me.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
			Me.layoutViewCard1.Name = "layoutViewTemplateCard"
			Me.layoutViewCard1.Text = "layoutViewTemplateCard"
			' 
			' colBookID
			' 
			Me.colBookID.Caption = "BookID"
			Me.colBookID.FieldName = "BookID"
			Me.colBookID.Name = "colBookID"
			Me.colBookID.Visible = True
			Me.colBookID.VisibleIndex = 0
			' 
			' colAuthor
			' 
			Me.colAuthor.Caption = "Author"
			Me.colAuthor.FieldName = "Author"
			Me.colAuthor.Name = "colAuthor"
			Me.colAuthor.Visible = True
			Me.colAuthor.VisibleIndex = 1
			' 
			' colName
			' 
			Me.colName.Caption = "Name"
			Me.colName.FieldName = "Name"
			Me.colName.Name = "colName"
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 2
			' 
			' colCustomerID1
			' 
			Me.colCustomerID1.Caption = "CustomerID"
			Me.colCustomerID1.FieldName = "CustomerID"
			Me.colCustomerID1.Name = "colCustomerID1"
			Me.colCustomerID1.Visible = True
			Me.colCustomerID1.VisibleIndex = 3
			' 
			' colQuantity
			' 
			Me.colQuantity.Caption = "Quantity"
			Me.colQuantity.FieldName = "Quantity"
			Me.colQuantity.Name = "colQuantity"
			Me.colQuantity.Visible = True
			Me.colQuantity.VisibleIndex = 4
			' 
			' colUnitPrice
			' 
			Me.colUnitPrice.Caption = "UnitPrice"
			Me.colUnitPrice.FieldName = "UnitPrice"
			Me.colUnitPrice.Name = "colUnitPrice"
			Me.colUnitPrice.Visible = True
			Me.colUnitPrice.VisibleIndex = 5
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "Unbound"
			Me.gridColumn1.FieldName = "Unbound"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 6
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(689, 367)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dataSet11 As DataSet1
		Private WithEvents gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView3 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colArticleID As DevExpress.XtraGrid.Columns.GridColumn
		Private colAuthor1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colContent As DevExpress.XtraGrid.Columns.GridColumn
		Private colBookID1 As DevExpress.XtraGrid.Columns.GridColumn
		Private customerBindingSource As System.Windows.Forms.BindingSource
		Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
		Private colFirstName As DevExpress.XtraGrid.Columns.GridColumn
		Private colSecondName As DevExpress.XtraGrid.Columns.GridColumn
		Private colBookID As DevExpress.XtraGrid.Columns.GridColumn
		Private colAuthor As DevExpress.XtraGrid.Columns.GridColumn
		Private colName As DevExpress.XtraGrid.Columns.GridColumn
		Private colCustomerID1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colQuantity As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

