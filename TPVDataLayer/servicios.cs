//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TPVDataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class servicios
    {
        public servicios()
        {
            this.calendarevent = new HashSet<calendarevent>();
        }
    
        public int idServicios { get; set; }
        public string serviceName { get; set; }
        public Nullable<int> averageDuration { get; set; }
        public string defaultColor { get; set; }
    
        public virtual ICollection<calendarevent> calendarevent { get; set; }
    }
}