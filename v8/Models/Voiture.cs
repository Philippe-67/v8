
using Microsoft.Graph.Models.TermStore;
using System.ComponentModel.DataAnnotations;

namespace v8.Models
{
    public class Voiture
    {
        [Key]
        public int Id { get; set; }
        [Range(1990, int.MaxValue, ErrorMessage = "Le champ Années doit être supérieur à 1990")]
        public int Annee { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public string Finition { get; set; }
        public DateTime DateAchat { get; set; }
        public DateTime? DateVente { get; set; }
        public decimal? PrixAchat { get; set; }
        public decimal? PrixVente { get; set; }
        public int VoitureId { get; set; }

        public  ICollection<Reparation>Reparations{get; set; }
        public ICollection<Intervention> Interventions { get; set; }

          

    }
}
