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
    
    public partial class AttrTitles
    {
        public AttrTitles()
        {
            this.AttrContents = new HashSet<AttrContents>();
            this.FiltCatagories = new HashSet<FiltCatagories>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
    
        public virtual ICollection<AttrContents> AttrContents { get; set; }
        public virtual ICollection<FiltCatagories> FiltCatagories { get; set; }
    }
}
