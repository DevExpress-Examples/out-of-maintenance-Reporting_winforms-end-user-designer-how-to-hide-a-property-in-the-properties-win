Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.Design
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner

Namespace WindowsFormsApplication1
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            InitReport()
        End Sub
        Private Sub InitReport()
            Dim report As New XtraReport1()
            Dim designTool As New ReportDesignTool(report)
            AddHandler designTool.DesignForm.DesignMdiController.DesignPanelLoaded, AddressOf DesignMdiController_DesignPanelLoaded
            designTool.ShowDesignerDialog()
        End Sub
        Private Sub DesignMdiController_DesignPanelLoaded(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs)
            Dim panel As XRDesignPanel = DirectCast(sender, XRDesignPanel)
            If panel Is Nothing Then
                Return
            End If
            Dim host As IDesignerHost = TryCast(panel.GetService(GetType(IDesignerHost)), IDesignerHost)
            If host Is Nothing Then
                Return
            End If
            Dim serv As ITypeDescriptorFilterService = TryCast(host.GetService(GetType(ITypeDescriptorFilterService)), ITypeDescriptorFilterService)
            host.RemoveService(GetType(ITypeDescriptorFilterService))
            host.AddService(GetType(ITypeDescriptorFilterService), New TypeDescriptorFilterService(serv))
        End Sub
    End Class
End Namespace
