// Developer Express Code Central Example:
// Specify an unbound column in detail view
// 
// You should configure your detail view as described in the Master-Detail:
// DataTable Use
// (ms-help://DevExpress.NETv8.2/DevExpress.XtraGrid/CustomDocument731.htm) help
// topic. Take note of the 5th point: "Specify and Customize Views To Represent
// Datatables ". Create an unbound column for the detail view, and subscribe to the
// CustomUnboundColumnData event of the detail view. Handle this event as described
// in the following topic:
// ColumnView.CustomUnboundColumnData Event
// (ms-help://DevExpress.NETv8.2/DevExpress.XtraGrid/DevExpressXtraGridViewsBaseColumnView_CustomUnboundColumnDatatopic.htm)
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E1513

namespace WindowsApplication1 {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet11 = new WindowsApplication1.DataSet1();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSecondName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colArticleID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAuthor1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colContent = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBookID1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
			this.colBookID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAuthor = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCustomerID1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
			this.SuspendLayout();
			// 
			// gridView2
			// 
			this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBookID,
            this.colAuthor,
            this.colName,
            this.colCustomerID1,
            this.colQuantity,
            this.colUnitPrice,
            this.gridColumn1});
			this.gridView2.GridControl = this.gridControl1;
			this.gridView2.Name = "gridView2";
			this.gridView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
			this.gridView2.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView2_CustomUnboundColumnData);
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.customerBindingSource;
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			gridLevelNode1.LevelTemplate = this.gridView2;
			gridLevelNode1.RelationName = "Customer_Book";
			this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
			this.gridControl1.Location = new System.Drawing.Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(689, 367);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView3,
            this.gridView2});
			// 
			// customerBindingSource
			// 
			this.customerBindingSource.DataMember = "Customer";
			this.customerBindingSource.DataSource = this.dataSet11;
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerID,
            this.colFirstName,
            this.colSecondName});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			// 
			// colCustomerID
			// 
			this.colCustomerID.Caption = "CustomerID";
			this.colCustomerID.FieldName = "CustomerID";
			this.colCustomerID.Name = "colCustomerID";
			this.colCustomerID.Visible = true;
			this.colCustomerID.VisibleIndex = 0;
			// 
			// colFirstName
			// 
			this.colFirstName.Caption = "FirstName";
			this.colFirstName.FieldName = "FirstName";
			this.colFirstName.Name = "colFirstName";
			this.colFirstName.Visible = true;
			this.colFirstName.VisibleIndex = 1;
			// 
			// colSecondName
			// 
			this.colSecondName.Caption = "SecondName";
			this.colSecondName.FieldName = "SecondName";
			this.colSecondName.Name = "colSecondName";
			this.colSecondName.Visible = true;
			this.colSecondName.VisibleIndex = 2;
			// 
			// gridView3
			// 
			this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colArticleID,
            this.colAuthor1,
            this.colContent,
            this.colBookID1});
			this.gridView3.GridControl = this.gridControl1;
			this.gridView3.Name = "gridView3";
			// 
			// colArticleID
			// 
			this.colArticleID.Caption = "ArticleID";
			this.colArticleID.FieldName = "ArticleID";
			this.colArticleID.Name = "colArticleID";
			this.colArticleID.Visible = true;
			this.colArticleID.VisibleIndex = 0;
			// 
			// colAuthor1
			// 
			this.colAuthor1.Caption = "Author";
			this.colAuthor1.FieldName = "Author";
			this.colAuthor1.Name = "colAuthor1";
			this.colAuthor1.Visible = true;
			this.colAuthor1.VisibleIndex = 1;
			// 
			// colContent
			// 
			this.colContent.Caption = "Content";
			this.colContent.FieldName = "Content";
			this.colContent.Name = "colContent";
			this.colContent.Visible = true;
			this.colContent.VisibleIndex = 2;
			// 
			// colBookID1
			// 
			this.colBookID1.Caption = "BookID";
			this.colBookID1.FieldName = "BookID";
			this.colBookID1.Name = "colBookID1";
			this.colBookID1.Visible = true;
			this.colBookID1.VisibleIndex = 3;
			// 
			// layoutViewCard1
			// 
			this.layoutViewCard1.CustomizationFormText = "layoutViewTemplateCard";
			this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
			this.layoutViewCard1.Name = "layoutViewTemplateCard";
			this.layoutViewCard1.Text = "layoutViewTemplateCard";
			// 
			// colBookID
			// 
			this.colBookID.Caption = "BookID";
			this.colBookID.FieldName = "BookID";
			this.colBookID.Name = "colBookID";
			this.colBookID.Visible = true;
			this.colBookID.VisibleIndex = 0;
			// 
			// colAuthor
			// 
			this.colAuthor.Caption = "Author";
			this.colAuthor.FieldName = "Author";
			this.colAuthor.Name = "colAuthor";
			this.colAuthor.Visible = true;
			this.colAuthor.VisibleIndex = 1;
			// 
			// colName
			// 
			this.colName.Caption = "Name";
			this.colName.FieldName = "Name";
			this.colName.Name = "colName";
			this.colName.Visible = true;
			this.colName.VisibleIndex = 2;
			// 
			// colCustomerID1
			// 
			this.colCustomerID1.Caption = "CustomerID";
			this.colCustomerID1.FieldName = "CustomerID";
			this.colCustomerID1.Name = "colCustomerID1";
			this.colCustomerID1.Visible = true;
			this.colCustomerID1.VisibleIndex = 3;
			// 
			// colQuantity
			// 
			this.colQuantity.Caption = "Quantity";
			this.colQuantity.FieldName = "Quantity";
			this.colQuantity.Name = "colQuantity";
			this.colQuantity.Visible = true;
			this.colQuantity.VisibleIndex = 4;
			// 
			// colUnitPrice
			// 
			this.colUnitPrice.Caption = "UnitPrice";
			this.colUnitPrice.FieldName = "UnitPrice";
			this.colUnitPrice.Name = "colUnitPrice";
			this.colUnitPrice.Visible = true;
			this.colUnitPrice.VisibleIndex = 5;
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "Unbound";
			this.gridColumn1.FieldName = "Unbound";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(689, 367);
			this.Controls.Add(this.gridControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DataSet1 dataSet11;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
		private DevExpress.XtraGrid.Columns.GridColumn colArticleID;
		private DevExpress.XtraGrid.Columns.GridColumn colAuthor1;
		private DevExpress.XtraGrid.Columns.GridColumn colContent;
		private DevExpress.XtraGrid.Columns.GridColumn colBookID1;
		private System.Windows.Forms.BindingSource customerBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
		private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
		private DevExpress.XtraGrid.Columns.GridColumn colSecondName;
		private DevExpress.XtraGrid.Columns.GridColumn colBookID;
		private DevExpress.XtraGrid.Columns.GridColumn colAuthor;
		private DevExpress.XtraGrid.Columns.GridColumn colName;
		private DevExpress.XtraGrid.Columns.GridColumn colCustomerID1;
		private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
		private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
	}
}

