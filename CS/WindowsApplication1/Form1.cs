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
            DataRowView row = (DataRowView)e.Row;
			if(e.Column.FieldName == "Unbound") {
				e.Value = (decimal)row["Quantity"] + (decimal)row["UnitPrice"];
			}
		}



	}
}