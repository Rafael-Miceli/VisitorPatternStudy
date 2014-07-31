using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWithVisitorExample
{
    public interface IVisitor
    {
        void Visit(Coordenador coordenador);
        void Visit(Gerente gerente);
        void Visit(Consultor consultor);
        void Visit(Diretor diretor);
        void Visit(Presidente presidente);
    }

    public class TotalEmCaixaVisitor : IVisitor
    {
        public double TotalEmCaixaDaEmpresa = 0;
        public void Visit(Coordenador coordenador)
        {
            //Lógica para buscar o valor do coordenador

            TotalEmCaixaDaEmpresa += coordenador.ValorParaAprovacao;
        }

        public void Visit(Gerente gerente)
        {
            //Lógica para buscar o valor do gerente

            TotalEmCaixaDaEmpresa += gerente.ValorParaAprovacao;
        }

        public void Visit(Consultor consultor)
        {
            //Lógica para buscar o valor do consultor

            TotalEmCaixaDaEmpresa += consultor.ValorParaAprovacao;
        }

        public void Visit(Diretor diretor)
        {
            //Lógica para buscar o valor do diretor

            TotalEmCaixaDaEmpresa += diretor.ValorParaAprovacao;
        }

        public void Visit(Presidente presidente)
        {
            //Lógica para buscar o valor do presidente

            TotalEmCaixaDaEmpresa += presidente.ValorParaAprovacao;
        }
    }


    





















    public class CalcularTotalEmContratosVisitor : IVisitor
    {
        public double TotalEmContratos = 0;

        public void Visit(Coordenador coordenador)
        {
            TotalEmContratos += coordenador.Contratos.Sum(c => c.Valor);
        }

        public void Visit(Gerente gerente)
        {
            TotalEmContratos += gerente.Contratos.Sum(c => c.Valor);
        }

        public void Visit(Consultor consultor)
        {
            TotalEmContratos += consultor.Contratos.Sum(c => c.Valor);
        }

        public void Visit(Diretor diretor)
        {
            TotalEmContratos += diretor.Contratos.Sum(c => c.Valor);
        }

        public void Visit(Presidente presidente)
        {
            TotalEmContratos += presidente.Contratos.Sum(c => c.Valor);
        }
    }
}
