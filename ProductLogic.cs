using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    internal class ProductLogic
    {


        private List<Product> _products;
        private Dictionary<string, DogLeash> _dogLeashes;
        private Dictionary<string, CatFood> _catFoods;

        public ProductLogic()
        {
            _products = new List<Product>();
            _dogLeashes = new Dictionary<string, DogLeash>();
            _catFoods = new Dictionary<string, CatFood>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);

            if (product is DogLeash)
            {
                DogLeash dogLeash = product as DogLeash;
                _dogLeashes[dogLeash.Name] = dogLeash;
            }
            else if (product is CatFood)
            {
                CatFood catFood = product as CatFood;
                _catFoods[catFood.Name] = catFood;
            }

            Console.WriteLine("Product added successfully!");
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public DogLeash GetDogLeashByName(string name)
        {
            try
            {
                return _dogLeashes[name];
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine("Dog leash not found.");
                return null;
            }
        }
    }
}