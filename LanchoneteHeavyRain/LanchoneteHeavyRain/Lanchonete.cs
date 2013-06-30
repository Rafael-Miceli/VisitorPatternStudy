using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteHeavyRain
{
    public class Combo : IAsset
    {
        public List<IAsset> Assets = new List<IAsset>();

        public void Accept(IComboVisitor visitor)
        {
            foreach (var asset in Assets)
            {
                if (asset is Sandwiche)
                {
                    foreach (var asseting in ((Sandwiche)asset).Assets)
                    {
                           asseting.Accept(visitor);
                    }
                }
                asset.Accept(visitor);
            }
        }
    }

    public class Drink : IAsset
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public double Price { get; set; }

        public void Accept(IComboVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Sandwiche : IAsset
    {
        public string Name { get; set; }
        public List<ISandwichAsset> Assets = new List<ISandwichAsset>();
        public double Price { get; set; }

        public void Accept(IComboVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Ingredient : ISandwichAsset
    {
        public string IngredientName { get; set; }
        public double Price { get; set; }

        public void Accept(IComboVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
