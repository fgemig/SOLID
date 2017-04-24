namespace LSP.Violacao
{
    public class Quadrado : Retangulo
    {
        public Quadrado(double altura, double largura) 
            : base(altura, largura)
        {
            base.Altura = altura;
            base.Largura = largura;
        }

        public override double Area()
        {
            return base.Area();
        }
    }
}
