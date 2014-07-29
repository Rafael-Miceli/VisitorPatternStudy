using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWithVisitorExample
{
    public interface ITotalEmCaixaVisitor
    {
        void Visit(Coordenador coordenador);
        void Visit(Gerente gerente);
    }

    public class TotalEmCaixaVisitor : ITotalEmCaixaVisitor
    {
        public double TotalEmCaixaDaEmpresa = 0;
        public void Visit(Coordenador coordenador)
        {
            TotalEmCaixaDaEmpresa += coordenador.ValorParaAprovacao;
        }

        public void Visit(Gerente gerente)
        {
            TotalEmCaixaDaEmpresa += gerente.ValorParaAprovacao;
        }
    }

    public interface IAprovador
    {
        void Accept(ITotalEmCaixaVisitor visitor);
    }
}
