namespace DesignPatterns.Criacionais.Builder
{
    public interface ITeto : IDescrevivel { }

    public class TetoMadeira : ITeto
    {
        public void Descrever()
        {
            Console.WriteLine("Teto de madeira");
        }
    }

    public class TetoVidro : ITeto
    {
        public void Descrever()
        {
            Console.WriteLine("Teto de vidro");
        }
    }
}