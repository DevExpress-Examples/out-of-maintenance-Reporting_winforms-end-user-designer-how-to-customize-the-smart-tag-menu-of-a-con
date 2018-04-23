using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.UI;

namespace CustomReportControl {
    public class XRLabelDesignerCustomActionList : XRControlTextDesignerActionList {
        public XRLabelDesignerCustomActionList(XRTextControlDesigner designer)
            : base(designer) {
        }
        private XRLabel Label {
            get {
                return (XRLabel)Component;
            }
        }
        [RefreshProperties(RefreshProperties.All)]
        public float WidthF {
            get {
                return Label.WidthF;
            }
            set {
                SetPropertyValue("WidthF", value);
            }
        }
        [RefreshProperties(RefreshProperties.All)]
        public float HeightF {
            get {
                return Label.HeightF;
            }
            set {
                SetPropertyValue("HeightF", value);
            }
        }
        [RefreshProperties(RefreshProperties.All)]
        public float LocationX {
            get {
                return Label.LocationF.X;
            }
            set {
                SetPropertyValue("LocationF", new PointF(value, Label.LocationF.Y));
            }
        }
        [RefreshProperties(RefreshProperties.All)]
        public float LocationY {
            get {
                return Label.LocationF.Y;
            }
            set {
                SetPropertyValue("LocationF", new PointF(Label.LocationF.X, value));
            }
        }
        public override DesignerActionItemCollection GetSortedActionItems() {
            DesignerActionItemCollection items = base.GetSortedActionItems();
            DesignerActionPropertyItem item = items.OfType<DesignerActionPropertyItem>().FirstOrDefault(x => x.MemberName == "FormatString");
            if (item != null) {
                items.Remove(item);
            }
            items.Add(new DesignerActionPropertyItem("WidthF", "WidthF"));
            items.Add(new DesignerActionPropertyItem("HeightF", "HeightF"));
            items.Add(new DesignerActionPropertyItem("LocationX", "LocationX"));
            items.Add(new DesignerActionPropertyItem("LocationY", "LocationY"));
            return items;
        }
    }
}
