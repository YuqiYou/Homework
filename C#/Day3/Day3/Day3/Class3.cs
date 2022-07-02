using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class GenericRepository: IRepository<Product>
    {
        List<Product> products = new List<Product>();

        public void Add(Product item)
        {
            products.Add(item);
        }
        public void Remove(Product item)
        {
            products.Remove(item);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

         public IEnumerable<Product> GetAll()
        {
            return products;
        }

        public Product GetById(int id)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == id)
                {
                    return products[i];
                }
            }
            return null;
        }

    }
}
