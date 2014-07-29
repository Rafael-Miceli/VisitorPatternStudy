using System;
using System.Collections.Generic;

namespace ConsoleAppWithVisitorExample
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
            var totalEmCaixaVisitor = new TotalEmCaixaVisitor();

            foreach (var aprovador in _empresaAtual.Aprovadores)
            {
                aprovador.Accept(totalEmCaixaVisitor);
            }

            Console.WriteLine(totalEmCaixaVisitor.TotalEmCaixaDaEmpresa);
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
        public List<IAprovador> Aprovadores = new List<IAprovador>();
    }

    public abstract class Aprovador
    {
        public virtual double ValorParaAprovacao { get { return 0; } }
        public virtual List<Contrato> Contratos { get; set; }
    }

    public class Consultor : Aprovador
    {
        public override double ValorParaAprovacao { get { return 1000; } }
        public override List<Contrato> Contratos { get; set; }
    }

    public class Coordenador : Aprovador, IAprovador
    {
        public override double ValorParaAprovacao { get { return 3000; } }
        public override List<Contrato> Contratos { get; set; }
        public void Accept(ITotalEmCaixaVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Gerente : Aprovador, IAprovador
    {
        public override double ValorParaAprovacao { get { return 5000; } }
        public override List<Contrato> Contratos { get; set; }
        public void Accept(ITotalEmCaixaVisitor visitor)
        {
            visitor.Visit(this);
        }
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
