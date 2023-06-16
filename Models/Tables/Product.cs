using System.ComponentModel.DataAnnotations.Schema;

namespace DiabetesWebApp.Models.Tables
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public float Calories { get; set; }
        public float Carbohydrates { get; set; }
        public virtual ICollection<TypeProduct>? TypeProduct { get; set; }

        [NotMapped]
        public TypeProduct FirstTypeProduct
        {
            get { return TypeProduct.First(); }
        }
    }
}
