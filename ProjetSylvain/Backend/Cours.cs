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
    
    public partial class Cours
    {
        public Cours()
        {
            this.Horaire = new HashSet<CoursHoraire>();
            this.Inscription = new HashSet<Inscription>();
        }
    
        public int Id { get; set; }
        public bool Ouvert { get; set; }
        public decimal Cout { get; set; }
        public System.DateTime DateLimite { get; set; }
    
        public virtual Professeur Professeur { get; set; }
        public virtual Sujet Sujet { get; set; }
        public virtual ICollection<CoursHoraire> Horaire { get; set; }
        public virtual ICollection<Inscription> Inscription { get; set; }
    }
}