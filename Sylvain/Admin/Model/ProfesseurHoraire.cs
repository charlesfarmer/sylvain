//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Admin
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProfesseurHoraire
    {
        public int Id { get; set; }
        public bool Actif { get; set; }
    
        public virtual Professeur Professeur { get; set; }
        public virtual Heure Heure { get; set; }
        public virtual Jour Jour { get; set; }
    }
}
