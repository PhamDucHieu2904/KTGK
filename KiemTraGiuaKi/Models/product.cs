//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KiemTraGiuaKi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string shorname { get; set; }
        public string note { get; set; }
        public int CategoryId { get; set; }
    
        public virtual category category { get; set; }
    }
}
