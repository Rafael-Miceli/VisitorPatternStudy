using System;
using System.Collections.Generic;

namespace MontadoraHeavyRain
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro = new Carro();
            carro.Partes.AddRange(new List<Treco>()
                {
                    new Treco()
                        {
                            preco = 200.50
                        }
                        ,
                        new Treco()
                        {
                            preco = 800.50
                        }
                        ,
                        new Treco()
                        {
                            preco = 25.50
                        }
                        ,
                        new Treco()
                        {
                            preco = 10.50
                        }
                });

            carro.Partes.AddRange(
                new List<Bagulho>()
                    {
                        new Bagulho()
                            {
                                Bolado = false,
                                HomenHora = 2
                            },
                        new Bagulho()
                            {
                                Bolado = true,
                                HomenHora = 5
                            },
                        new Bagulho()
                            {
                                Bolado = false,
                                HomenHora = 1
                            }
                    }
                );
            
            var carroVisitor = new CarroVisitor();

            carro.Accept(carroVisitor);

            Console.WriteLine(carroVisitor.Total);
        }
    }
}