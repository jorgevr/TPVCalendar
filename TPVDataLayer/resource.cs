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
    
    public partial class resource
    {
        public resource()
        {
            this.calendarevent = new HashSet<calendarevent>();
            this.resourcestimeoff = new HashSet<resourcestimeoff>();
        }
    
        public int idResource { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<calendarevent> calendarevent { get; set; }
        public virtual ICollection<resourcestimeoff> resourcestimeoff { get; set; }
    }
}