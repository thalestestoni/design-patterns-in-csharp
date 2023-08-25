namespace DesignPatterns.Criacionais.Builder
{

    public interface IPorta : IDescrevivel { }

    public class PortaMadeira : IPorta
    {
        public void Descrever()
        {
            Console.WriteLine("Porta de madeira");
        }
    }

    public class PortaVidro : IPorta
    {
        public void Descrever()
        {
            Console.WriteLine("Porta de vidro");
        }
    }
}
