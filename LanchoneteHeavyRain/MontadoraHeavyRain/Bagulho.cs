namespace MontadoraHeavyRain
{
    public class Bagulho: IPartes
    {
        public int HomenHora { get; set; }
        public bool Bolado { get; set; }
        public void Accept(ICarroVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
