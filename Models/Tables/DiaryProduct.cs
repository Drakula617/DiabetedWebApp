using FireSharp;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiabetesWebApp.Models.Tables
{
    public class DiaryProduct
    {
        [NotMapped]
        UserContext _userContext;
        public DiaryProduct()
        {
            _userContext = new UserContext();
            _product = Product;
        }
        public int ProductId { get; set; }

        [NotMapped]
        Product _product;
        [NotMapped]
        public Product? Product
        {
            get 
            {
                var product = _userContext.GetProducts().Find(c => c.Id == ProductId);
                if (product != null)
                    return product;
                else
                    return null;
            }
        }
        [NotMapped]
        public float Caloies
        {
            get { return _product.Calories / 100 * Weidth; }
        }
        [NotMapped]
        public float He
        {
            get { return _product.Carbohydrates / 100 / 12 * Weidth; }
        }
        public int Weidth { get; set; }
    }
}
