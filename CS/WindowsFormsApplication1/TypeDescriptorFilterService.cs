using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using DevExpress.DataAccess.Sql;

namespace WindowsFormsApplication1 {
    public class TypeDescriptorFilterService : ITypeDescriptorFilterService {
        private ITypeDescriptorFilterService baseServ;
        public TypeDescriptorFilterService(ITypeDescriptorFilterService baseServ) {
            this.baseServ = baseServ;
        }
        public bool FilterAttributes(IComponent component, System.Collections.IDictionary attributes) {
            return baseServ.FilterAttributes(component, attributes);
        }
        public bool FilterEvents(IComponent component, System.Collections.IDictionary events) {
            return baseServ.FilterEvents(component, events);
        }
        public bool FilterProperties(IComponent component, System.Collections.IDictionary properties) {
            if (component is SqlDataSource) {
                properties.Remove("ConnectionName");
                properties.Remove("ConnectionParameters");
            }
            return baseServ.FilterProperties(component, properties);
        }
    }
}
