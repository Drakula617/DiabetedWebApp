namespace DiabetesWebApp.Models.Tables
{
    public class Profile
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public float MaxGlucose { get; set; }
        public float MinGlucose { get; set; }
        public float Sensitivity { get; set; }
        public virtual ICollection<Basal>? Basal { get; set; }
        public virtual ICollection<CarbCoefficients>? CarbCoefficients { get; set; }
    }
}
