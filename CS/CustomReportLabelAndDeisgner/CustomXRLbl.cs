using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports;

namespace CustomReportControl {
    [XRDesigner("CustomReportControl.CustomXRLblDesigner")]
    public class CustomXRLbl : XRLabel {
        public CustomXRLbl()
            : base() {
        }

        public string CustomProperty { get; set; }
    }
}
