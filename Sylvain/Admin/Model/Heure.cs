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
    
    public partial class Heure
    {
        public Heure()
        {
            this.CoursHoraire = new HashSet<CoursHoraire>();
            this.ProfesseurHoraire = new HashSet<ProfesseurHoraire>();
        }
    
        public int Id { get; set; }
        public int Num { get; set; }
    
        public virtual ICollection<CoursHoraire> CoursHoraire { get; set; }
        public virtual ICollection<ProfesseurHoraire> ProfesseurHoraire { get; set; }
    }
}
