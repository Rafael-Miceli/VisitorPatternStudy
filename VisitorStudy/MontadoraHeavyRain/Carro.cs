using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MontadoraHeavyRain
{
    public class Carro: IPartes
    {
        //public List<Treco> Trecos = new List<Treco>();
        //public List<Bagulho> Bagulhos = new List<Bagulho>();
        public List<IPartes> Partes  = new List<IPartes>();

        public void Accept(ICarroVisitor visitor)
        {
            foreach (var parte in Partes)
            {
                parte.Accept(visitor);
            }
        }
    }
}
