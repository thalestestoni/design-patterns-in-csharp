namespace DesignPatterns.Criacionais.Builder
{
    public interface IParede : IDescrevivel { }

    public class ParedeMadeira : IParede
    {
        public void Descrever()
        {
            Console.WriteLine("Parede de madeira");
        }
    }

    public class ParedeVidro : IParede
    {
        public void Descrever()
        {
            Console.WriteLine("Parede de vidro");
        }
    }
}
