//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shipping
    {
        public Shipping()
        {
            this.Orders = new HashSet<Orders>();
        }
    
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
    
        public virtual Customers Customers { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
