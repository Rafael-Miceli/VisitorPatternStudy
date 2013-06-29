using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MontadoraHeavyRain
{
    public class Treco: IPartes
    {
        public double preco;

        public void Accept(ICarroVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
