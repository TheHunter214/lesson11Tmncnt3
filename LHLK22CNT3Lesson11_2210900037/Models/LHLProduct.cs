//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LHLK22CNT3Lesson11_2210900037.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LHLProduct
    {
        public string LhlId2210900037 { get; set; }
        public string LhlProName { get; set; }
        public Nullable<int> LhlQty { get; set; }
        public Nullable<double> LhlPrice { get; set; }
        public Nullable<int> LhlCateId { get; set; }
        public Nullable<bool> LhlActive { get; set; }
    
        public virtual LHLCategory LHLCategory { get; set; }
    }
}
