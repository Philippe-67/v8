namespace v8.Models.MappingData
{
    public class InterventionDetail
    {
        public decimal Prix { get; set; }

        public string Nom { get; set; }
    }
    public class Reparations
    {
        public int ReparationId { get; set; }

        public string Description { get; set; }

        public List<InterventionDetail> Interventions { get; set; }
    }
    public class VoitureModel
    {
        public Voiture Voiture { get; set; }

        public List<Reparations> Reparations { get; set; }


    }
}
