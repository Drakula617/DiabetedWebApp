using DiabetesWebApp.Models.Tables;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace DiabetesWebApp.Models
{
    public class UserContext
    {
        public Person Person { get; set; }
        public Profile SelectedProfile { get; set; }
        public int Count { get; set; }

        readonly IFirebaseConfig _productsConfig;
        readonly IFirebaseConfig _diaryDiabetesConfig;
        public UserContext()
        {
            var diaryDiabetesConfig = new FirebaseConfig()
            {
                AuthSecret = "IxeHekuERScNR6mbNYbdTJg3aMmvVqDU1eatKC1w",
                BasePath = "https://diarydiabetic-default-rtdb.firebaseio.com"
            };
            var productsConfig = new FirebaseConfig()
            {
                AuthSecret = "lA9b00EU3ZNwtaqz5uN92s71AYiVUuCrKVJbm2jj",
                BasePath = "https://products-3490c-default-rtdb.firebaseio.com"
            };
            _productsConfig = productsConfig;
            _diaryDiabetesConfig = diaryDiabetesConfig;
        }

        public void GetPerson(string email, string password)
        {
            IFirebaseClient client = new FirebaseClient(_diaryDiabetesConfig);
            Person person = client.Get("/").ResultAs<List<Person>>().Find(c=> c.Email == email && c.Password == password);
            if (person != null)
            {
                Person = person;
                SelectedProfile = Person.Profiles.FirstOrDefault();
                return;
            }
            else
                return;
        }

        public List<Product> GetProducts()
        {
            var client = new FirebaseClient(_productsConfig);
            return client.Get("/").ResultAs<List<Product>>();
        }

    }
}
