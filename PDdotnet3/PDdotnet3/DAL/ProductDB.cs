using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using PDdotnet3.Models;


namespace PDdotnet3.DAL
{
    public class ProductDB
    {
        private List<Product> products;
        public void Load(string jsonProducts)
        {
            if (jsonProducts == null)
            {
                products = Product.GetProducts();
            }
            else
            {
                products = JsonSerializer.Deserialize<List<Product>>(jsonProducts);
            }
        }

        private int GetNextId()
        {
            return (products.Count != 0) ? products[products.Count - 1].id + 1 : 1;
        }
        public void Create(Product p)
        {
            p.id = GetNextId();
            products.Add(p);
            foreach(var x in products)
            {
                Console.WriteLine($"{x.id} {x.name} {x.price}");
            }
        }

        public void Delete(int id)
        {
            Product product = null;
            foreach (var item in products)
            {
                if(item.id == id)
                {
                    product = item;
                }
            }
            products.Remove(product);
        }

        public string Save()
        {
            return JsonSerializer.Serialize(products);
        }
        public List<Product> List()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            Product product = null;
            foreach (var item in products)
            {
                if (item.id == id)
                {
                    product = item;
                }
            }
            return product;
        }

        public void ModifyProduct(Product product)
        {
            Console.WriteLine(product.id);
            foreach (var item in products)
            {
                if (item.id == product.id)
                {
                    item.price = product.price;
                    item.name = product.name;
                }
            }
        }
    }
}
