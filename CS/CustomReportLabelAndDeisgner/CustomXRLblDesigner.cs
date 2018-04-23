using System;
using System.Collections.Generic;
using DevExpress.XtraReports.Design;
using System.ComponentModel.Design;

namespace CustomReportControl {
    internal class CustomXRLblDesigner : XRLabelDesigner {
        public CustomXRLblDesigner()
            : base() {
        }
        protected override void RegisterActionLists(DesignerActionListCollection list) {
            list.Add(new XRLabelDesignerCustomActionList(this));
        }
    }
}
