//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcoleRepo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Etudiant : Personne
    {
        public Etudiant()
        {
            this.PresenceCours = new HashSet<PresenceCours>();
            this.Evaluations = new HashSet<Evaluation>();
        }
    
    
        public virtual ICollection<PresenceCours> PresenceCours { get; set; }
        public virtual ICollection<Evaluation> Evaluations { get; set; }
    }
}