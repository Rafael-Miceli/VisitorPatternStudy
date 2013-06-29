namespace MontadoraHeavyRain
{
    public interface ICarroVisitor
    {
        void Visit(Bagulho bagulho);
        void Visit(Treco treco);
    }

    public interface IPartes
    {
        void Accept(ICarroVisitor visitor);
    }

    public class CarroVisitor: ICarroVisitor
    {
        public double Total { get; set; }

        public void Visit(Bagulho bagulho)
        {
            Total += bagulho.HomenHora*2;
            Total += bagulho.Bolado ? 200 : 0;
        }

        public void Visit(Treco treco)
        {
            Total += treco.preco;
        }
    }
}
