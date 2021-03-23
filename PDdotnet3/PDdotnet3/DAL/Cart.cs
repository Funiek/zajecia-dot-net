using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PDdotnet3.Models;
using System.Text.Json;

namespace PDdotnet3.DAL
{
    public class Cart
    {
        private List<Product> products;

        public void Load(string jsonProducts)
        {
            if (jsonProducts == null || jsonProducts.Equals("\"[]\""))
            {
                products = new List<Product>();
            }
            else
            {
                Console.WriteLine(jsonProducts);
                products = JsonSerializer.Deserialize<List<Product>>(jsonProducts);
            }
        }

        public void Add(Product p)
        {
            products.Add(p);
        }

        public void Delete()
        {
            products.Clear();
        }

        public string Save()
        {
            return JsonSerializer.Serialize(products);
        }

        public List<Product> List()
        {
            return products;
        }
    }

}
