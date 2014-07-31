using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVisitorExample
{
    public class Program
    {
        private static Empresa _empresaAtual;

        static void Main(string[] args)
        {
            _empresaAtual = new Empresa();

            PopularDados();
            CalcularValorTotalDaEmpresa();
        }

        private static void CalcularValorTotalDaEmpresa()
        {
            double totalValorDaEmpresa = 0;

            foreach (var aprovador in _empresaAtual.Aprovadores)
            {
                totalValorDaEmpresa += aprovador.ValorParaAprovacao;
            }

            Console.WriteLine(totalValorDaEmpresa);
            Console.ReadKey();
        }

        private static void PopularDados()
        {
            _empresaAtual.Aprovadores.Add(new Coordenador
            {
                Contratos = new List<Contrato>
                {
                    new Contrato
                    {
                        Valor = 600
                    },
                    new Contrato
                    {
                        Valor = 700
                    }
                }
            });

            _empresaAtual.Aprovadores.Add(new Gerente
            {
                Contratos = new List<Contrato>
                {
                    new Contrato
                    {
                        Valor = 2000
                    },
                    new Contrato
                    {
                        Valor = 2200
                    }
                }
            });
        }
    }

    public class Empresa
    {
        public List<Aprovador> Aprovadores = new List<Aprovador>();
    }

    public abstract class Aprovador
    {
        public virtual double ValorParaAprovacao { get { return 0; } }
        public virtual List<Contrato> Contratos { get; set; }
    }

    public class Consultor: Aprovador
    {
        public override double ValorParaAprovacao { get { return 1000; } }
        public override List<Contrato> Contratos { get; set; }
    }

    public class Coordenador: Aprovador
    {
        public override double ValorParaAprovacao { get { return 3000; } }
        public override List<Contrato> Contratos { get; set; }
    }

    public class Gerente : Aprovador
    {
        public override double ValorParaAprovacao { get { return 5000; } }
        public override List<Contrato> Contratos { get; set; }
    }

    public class Diretor : Aprovador
    {
        public override double ValorParaAprovacao { get { return 10000; } }
        public override List<Contrato> Contratos { get; set; }
    }

    public class Presidente : Aprovador
    {
        public override double ValorParaAprovacao { get { return 50000; } }
        public override List<Contrato> Contratos { get; set; }
    }

    public class Contrato
    {
        public double Valor { get; set; }
    }
}
