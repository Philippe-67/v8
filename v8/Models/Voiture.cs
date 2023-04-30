
using System.ComponentModel.DataAnnotations;
using System;
namespace v8.Models
{
    public class Voiture
    {
        [Key]
        public int Id { get; set; }
        public int Annee { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public string Finition { get; set; }
        public DateTime DateAchat { get; set; }
        public DateTime? DateVente { get; set; }
        public decimal? PrixAchat { get; set; }
        public decimal? PrixVente { get; set; }
    }
}
