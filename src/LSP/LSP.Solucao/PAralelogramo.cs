namespace LSP.Solucao
{
    public abstract class Paralelogramo
    {
        public Paralelogramo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

        protected double Altura { get; set; }

        protected double Largura { get; set; }

        public virtual double Area() => Altura * Largura;
    }
}
