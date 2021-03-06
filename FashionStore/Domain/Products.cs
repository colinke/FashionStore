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
    
    public partial class Products
    {
        public Products()
        {
            this.CartProducts = new HashSet<CartProducts>();
            this.Colors = new HashSet<Colors>();
            this.OrderProducts = new HashSet<OrderProducts>();
            this.Pictures = new HashSet<Pictures>();
            this.Sizes = new HashSet<Sizes>();
            this.FiltCatagories = new HashSet<FiltCatagories>();
            this.AttrContents = new HashSet<AttrContents>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public int BrandId { get; set; }
        public decimal Price { get; set; }
        public Nullable<decimal> NewPrice { get; set; }
        public int Count { get; set; }
        public System.DateTime Date { get; set; }
        public string Description { get; set; }
        public bool IsNew { get; set; }
        public bool IsHot { get; set; }
        public bool IsDiscout { get; set; }
        public int SaleCount { get; set; }
        public int VisitCount { get; set; }
    
        public virtual Brand Brand { get; set; }
        public virtual ICollection<CartProducts> CartProducts { get; set; }
        public virtual ICollection<Colors> Colors { get; set; }
        public virtual ICollection<OrderProducts> OrderProducts { get; set; }
        public virtual ICollection<Pictures> Pictures { get; set; }
        public virtual ICollection<Sizes> Sizes { get; set; }
        public virtual ICollection<FiltCatagories> FiltCatagories { get; set; }
        public virtual ICollection<AttrContents> AttrContents { get; set; }
    }
}
