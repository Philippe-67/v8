using System.ComponentModel.DataAnnotations;
using System;
namespace v8.Models
{
    public class Reparation
    {
        [Key]
        public int Id { get; set; }
        public DateTime DatePEC { get; set; }
        public string Description { get; set; }
       // public decimal Cout { get; set; }
        public DateTime? DateDisponibilite { get; set; }
        public ICollection<ReparationIntervention> ReparationInterventions { get; set; }
    }
}

