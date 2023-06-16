using System.ComponentModel.DataAnnotations.Schema;

namespace DiabetesWebApp.Models.Tables
{
    public class DiaryLine
    {
        public DateTime Datetime { get; set; }
        public float Glucose { get; set; }
        public bool IsDoseLower { get; set; }
        public virtual ICollection<DiaryProduct>? DiaryProducts { get; set; }

        [NotMapped]
        public float SummCalories
        {
            get { return DiaryProducts.Sum(c => c.Caloies); }
        }
        [NotMapped]
        public float SummHe
        {
            get { return DiaryProducts.Sum(c => c.He); }
        }

    }
}
