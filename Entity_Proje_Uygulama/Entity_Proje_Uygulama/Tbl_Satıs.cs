//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity_Proje_Uygulama
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Satıs
    {
        public int SATISID { get; set; }
        public Nullable<int> URUN { get; set; }
        public Nullable<int> MUSTERI { get; set; }
        public Nullable<decimal> FIYAT { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
    
        public virtual Tbl_Musterı Tbl_Musterı { get; set; }
        public virtual Tbl_Urun Tbl_Urun { get; set; }
    }
}
