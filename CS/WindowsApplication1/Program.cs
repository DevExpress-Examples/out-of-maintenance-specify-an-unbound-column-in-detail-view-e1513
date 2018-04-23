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
using System.Windows.Forms;

namespace WindowsApplication1 {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}