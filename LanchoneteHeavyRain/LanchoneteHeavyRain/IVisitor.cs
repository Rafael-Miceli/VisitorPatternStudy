using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteHeavyRain
{
    public interface IComboVisitor
    {
        void Visit(Sandwiche sandwiche);
        void Visit(Drink drink);
    }

    public interface IAsset
    {
        void Accept(IComboVisitor visitor);
    }

    public class ComboVisitor :IComboVisitor
    {
        public double Price { get; set; }       

        public void Visit(Sandwiche sandwiche)
        {
            Price += sandwiche.Price;
        }

        public void Visit(Drink drink)
        {
            Price += drink.Price + 0.1;
        }

        
    }
}
