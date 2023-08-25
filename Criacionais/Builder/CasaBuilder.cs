namespace DesignPatterns.Criacionais.Builder
{
    public class CasaBuilder : PrimeiroPasso, SegundoPasso
    {
        private Casa Casa { get; set; }

        private CasaBuilder()
        {
            Casa = new Casa();
        }

        public static PrimeiroPasso ComecarConstrucao()
        {
            return new CasaBuilder();
        }

        public SegundoPasso FazerParede(IParede parede)
        {
            Casa.Parede = parede;
            return this;
        }

        public SegundoPasso FazerTeto(ITeto teto)
        {
            Casa.Teto = teto;
            return this;
        }

        public SegundoPasso FazerJanela(IJanela janela)
        {
            Casa.Janela = janela;
            return this;
        }

        public SegundoPasso FazerPorta(IPorta porta)
        {
            Casa.Porta = porta;
            return this;
        }

        public Casa ConstruirCasa()
        {
            return Casa;
        }
    }

    public interface PrimeiroPasso
    {
        SegundoPasso FazerParede(IParede parede);
    }

    public interface SegundoPasso : PrimeiroPasso
    {
        SegundoPasso FazerTeto(ITeto teto);
        SegundoPasso FazerJanela(IJanela janela);
        SegundoPasso FazerPorta(IPorta porta);
        Casa ConstruirCasa();
    }
}
