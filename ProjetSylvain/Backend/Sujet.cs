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
    
    public partial class Sujet
    {
        public Sujet()
        {
            this.Cours = new HashSet<Cours>();
            this.Professeur = new HashSet<Professeur>();
        }
    
        public int Id { get; set; }
        public string Nom { get; set; }
    
        public virtual ICollection<Cours> Cours { get; set; }
        public virtual ICollection<Professeur> Professeur { get; set; }
    }
}
