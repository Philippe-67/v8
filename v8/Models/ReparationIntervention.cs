﻿using System.ComponentModel.DataAnnotations;
namespace v8.Models
{
    public class ReparationIntervention
    {
        [Key]
        public int Id { get; set; }
      //  public int ReparationInterventionId { get; set; }
        public int ReparationId { get; set; }
        public Reparation Reparation { get; set; }

        public int InterventionId { get; set; }
        public Intervention Intervention { get; set; }

        public int VoitureId { get; set; }
        public Voiture Voiture{ get; set; }
    }
}