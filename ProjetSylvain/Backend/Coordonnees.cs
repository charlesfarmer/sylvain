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
    
    public partial class Coordonnees
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public string Adresse { get; set; }
    
        public virtual Sujet Etudiant { get; set; }
        public virtual Professeur Professeur { get; set; }
    }
}
