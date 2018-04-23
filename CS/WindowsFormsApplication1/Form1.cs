using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            InitReport();
        }
        private void InitReport() {
            XtraReport1 report = new XtraReport1();
            ReportDesignTool designTool = new ReportDesignTool(report);
            designTool.DesignForm.DesignMdiController.DesignPanelLoaded += DesignMdiController_DesignPanelLoaded;
            designTool.ShowDesignerDialog();
        }
        private void DesignMdiController_DesignPanelLoaded(object sender, DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs e) {
            XRDesignPanel panel = (XRDesignPanel)sender;
            if (panel == null) {
                return;
            }
            IDesignerHost host = panel.GetService(typeof(IDesignerHost)) as IDesignerHost;
            if (host == null) {
                return;
            }
            ITypeDescriptorFilterService serv = host.GetService(typeof(ITypeDescriptorFilterService)) as ITypeDescriptorFilterService;
            host.RemoveService(typeof(ITypeDescriptorFilterService));
            host.AddService(typeof(ITypeDescriptorFilterService), new TypeDescriptorFilterService(serv));
        }
    }
}
