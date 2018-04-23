using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomReportControl;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;

namespace dxExample {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            ShowDesigner();

        }
        private void ShowDesigner() {
            XRDesignFormEx designer = new XRDesignFormEx();
            XtraReport r = new XtraReport();
            r.DesignerLoaded += new DesignerLoadedEventHandler(r_DesignerLoaded);
            designer.OpenReport(r);
            designer.ShowDialog();
        }
        private void r_DesignerLoaded(object sender, DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs e) {
            IToolboxService ts = e.DesignerHost.GetService(typeof(IToolboxService)) as IToolboxService;
            RemoveStandardItem(ts);
            AddCustomItem(ts);
        }
        private static void RemoveStandardItem(IToolboxService ts) {
            ToolboxItemCollection items = ts.GetToolboxItems();
            ToolboxItem standardItem = items.OfType<ToolboxItem>().FirstOrDefault(x => x.DisplayName == "Label");
            if(standardItem != null) {
                ts.RemoveToolboxItem(standardItem);
            }
        }
        private static void AddCustomItem(IToolboxService ts) {
            ts.AddToolboxItem(new ToolboxItem(typeof(CustomXRLbl)));
        }
    }
}
