using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteHeavyRain
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = new double();

            var combo = new Combo();
            combo.Assets.Add(new Drink{Name = "Coca", Size = 300, Price = 3});
            combo.Assets.Add(new Sandwiche
                {
                    Name = "BK Supremo",
                    IngredientsesList = new List<Ingredient> {new Ingredient {IngredientName = "Pao"}, new Ingredient(){IngredientName = "Carne"}},
                    Price = 6
                });

            combo.Assets.Add(new Drink { Name = "Guarana", Size = 500, Price = 2.50});
            combo.Assets.Add(new Sandwiche
            {
                Name = "Heavy Chicken",
                IngredientsesList = { new Ingredient { IngredientName = "Pao" }, new Ingredient() { IngredientName = "Frango" }, new Ingredient() { IngredientName = "bacon", Price = 2} },
                Price = 5
            });

            //foreach (var cmb in combo.SandwichesList)
            //{
            //    price += cmb.Price;
            //}

            //foreach (var cmb in combo.DrinksList)
            //{
            //    price += cmb.Price;
            //}

            var visitor = new ComboVisitor();

            combo.Accept(visitor);

            //foreach (var cmb in combo.SandwichesList)
            //{
            //    foreach (var ing in cmb.IngredientsesList.Where(c => c.Price != null))
            //    {
            //        price += ing.Price;
            //    }
            //}

            Console.WriteLine(visitor.Price);

            Console.ReadLine();
        }
    }
}
