Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Linq
Imports DevExpress.DataAccess.Sql

Namespace WindowsFormsApplication1
    Public Class TypeDescriptorFilterService
        Implements ITypeDescriptorFilterService

        Private baseServ As ITypeDescriptorFilterService
        Public Sub New(ByVal baseServ As ITypeDescriptorFilterService)
            Me.baseServ = baseServ
        End Sub
        Public Function FilterAttributes(ByVal component As IComponent, ByVal attributes As System.Collections.IDictionary) As Boolean Implements ITypeDescriptorFilterService.FilterAttributes
            Return baseServ.FilterAttributes(component, attributes)
        End Function
        Public Function FilterEvents(ByVal component As IComponent, ByVal events As System.Collections.IDictionary) As Boolean Implements ITypeDescriptorFilterService.FilterEvents
            Return baseServ.FilterEvents(component, events)
        End Function
        Public Function FilterProperties(ByVal component As IComponent, ByVal properties As System.Collections.IDictionary) As Boolean Implements ITypeDescriptorFilterService.FilterProperties
            If TypeOf component Is SqlDataSource Then
                properties.Remove("ConnectionName")
                properties.Remove("ConnectionParameters")
            End If
            Return baseServ.FilterProperties(component, properties)
        End Function
    End Class
End Namespace
