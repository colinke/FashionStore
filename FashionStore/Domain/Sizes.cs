//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sizes
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
    
        public virtual Products Products { get; set; }
    }
}
