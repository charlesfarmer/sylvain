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
    
    public partial class Etudiant
    {
        public Etudiant()
        {
            this.Inscription = new HashSet<Inscription>();
        }
    
        public int Id { get; set; }
    
        public virtual Coordonnees Coordonnees { get; set; }
        public virtual Login Login { get; set; }
        public virtual ICollection<Inscription> Inscription { get; set; }
    }
}