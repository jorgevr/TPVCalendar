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
    
    public partial class shopworkingslices
    {
        public int idshopworkingslices { get; set; }
        public System.TimeSpan startTime { get; set; }
        public System.TimeSpan endTime { get; set; }
        public Nullable<int> shopTimeTableId { get; set; }
    
        public virtual shoptimetable shoptimetable { get; set; }
    }
}