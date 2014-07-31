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
            CalcularValorTotalDeAprovacoesQueEmpresaPodeFazer();
        }

        private static void CalcularValorTotalDeAprovacoesQueEmpresaPodeFazer()
        {
            var totalEmCaixaVisitor = new TotalEmCaixaVisitor();

            foreach (var aprovador in _empresaAtual.Aprovadores)
            {
                aprovador.Accept(totalEmCaixaVisitor);
            }

            Console.WriteLine(totalEmCaixaVisitor.TotalEmCaixaDaEmpresa);
        }

        //private static void CalcularValorTotalDeEmContratos()
        //{
        //    var calcularTotalEmContratosVisitor = new CalcularTotalEmContratosVisitor();

        //    foreach (var aprovador in _empresaAtual.Aprovadores)
        //    {
        //        aprovador.Accept(calcularTotalEmContratosVisitor);
        //    }

        //    Console.WriteLine(calcularTotalEmContratosVisitor.TotalEmContratos);
        //}

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

            _empresaAtual.Aprovadores.Add(new Diretor
            {
                Contratos = new List<Contrato>
                {
                    new Contrato
                    {
                        Valor = 2500
                    },
                    new Contrato
                    {
                        Valor = 1735
                    },
                    new Contrato
                    {
                        Valor = 2735
                    },
                    new Contrato
                    {
                        Valor = 852
                    }
                }
            });

            _empresaAtual.Aprovadores.Add(new Consultor
            {
                Contratos = new List<Contrato>
                {
                    new Contrato
                    {
                        Valor = 1300
                    }
                }
            });

            _empresaAtual.Aprovadores.Add(new Presidente
            {
                Contratos = new List<Contrato>
                {
                    new Contrato
                    {
                        Valor = 1550
                    },
                    new Contrato
                    {
                        Valor = 7830
                    },
                    new Contrato
                    {
                        Valor = 28030
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
        public virtual void Accept(IVisitor visitor)
        {}
    }

    public class Consultor : Aprovador
    {
        public override double ValorParaAprovacao { get { return 1000; } }
        public override List<Contrato> Contratos { get; set; }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Coordenador : Aprovador
    {
        public override double ValorParaAprovacao { get { return 3000; } }
        public override List<Contrato> Contratos { get; set; }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Gerente : Aprovador
    {
        public override double ValorParaAprovacao { get { return 5000; } }
        public override List<Contrato> Contratos { get; set; }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Diretor : Aprovador
    {
        public override double ValorParaAprovacao { get { return 10000; } }
        public override List<Contrato> Contratos { get; set; }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Presidente : Aprovador
    {
        public override double ValorParaAprovacao { get { return 50000; } }
        public override List<Contrato> Contratos { get; set; }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Contrato
    {
        public double Valor { get; set; }
    }
}
