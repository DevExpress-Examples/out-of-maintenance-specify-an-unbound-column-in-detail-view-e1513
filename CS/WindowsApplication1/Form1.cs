using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace WindowsApplication1 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		public void InitData() {
				dataSet11.Tables["Customer"].Rows.Add(new object[] { 1, "Bob", "Roy" });
				dataSet11.Tables["Customer"].Rows.Add(new object[] { 2, "Alice", "Smith" });
				dataSet11.Tables["Customer"].Rows.Add(new object[] { 3, "Alice", "Smith" });

				
				dataSet11.Tables["Book"].Rows.Add(new object[] { 1, "Tesla", "My Inventions", 1 ,2,3.4});
				dataSet11.Tables["Book"].Rows.Add(new object[] { 2, "Cataneda", "Teaching of Don Juan", 1 ,4,5.2});

				dataSet11.Tables["Book"].Rows.Add(new object[] { 3, "Tesla", "My Inventions", 2,3,4.3 });
				dataSet11.Tables["Book"].Rows.Add(new object[] { 4, "Cataneda", "Teaching of Don Juan", 2,4,4});

				dataSet11.Tables["BookDetail"].Rows.Add(new object[] { 1, "Boo", "It's bad!", 2 });
				dataSet11.Tables["BookDetail"].Rows.Add(new object[] { 2, "Foo", "Excellent!", 2 });

				dataSet11.Tables["Magazine"].Rows.Add(new object[] { 1, "NewsWeek", 1 });
				dataSet11.Tables["Magazine"].Rows.Add(new object[] { 2, "Rolling Stones",1 });

		}



		private void Form1_Load(object sender, EventArgs e) {
			this.InitData();
			gridControl1.ShowOnlyPredefinedDetails = true;
		}

		private void gridView2_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e) {
			GridView view = sender as GridView;
			if(e.Column.FieldName == "Unbound") {
				e.Value = (decimal)view.GetRowCellValue(e.RowHandle, view.Columns["Quantity"]) + (decimal)view.GetRowCellValue(e.RowHandle, view.Columns["UnitPrice"]);
			}
		}



	}
}