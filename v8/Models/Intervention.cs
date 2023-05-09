
using System.ComponentModel.DataAnnotations;

namespace v8.Models
{
    public class Intervention
    {
        [Key]
        public int Id { get; set; }
        public string NomIntervention { get; set; }
        
        public decimal PrixIntervention { get; set; }
    }
}

