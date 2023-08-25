namespace DesignPatterns.Criacionais.Builder
{
    public interface IJanela : IDescrevivel { }

    public class JanelaMadeira : IJanela
    {
        public void Descrever()
        {
            Console.WriteLine("Janela de madeira");
        }
    }

    public class JanelaVidro : IJanela
    {
        public void Descrever()
        {
            Console.WriteLine("Janela de vidro");
        }
    }

}
