//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Backend
{
    using System;
    using System.Collections.Generic;
    
    public partial class Paiement
    {
        public int Id { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public decimal Montant { get; set; }
        public bool Rembourse { get; set; }
    
        public virtual Inscription Inscription { get; set; }
    }
}
