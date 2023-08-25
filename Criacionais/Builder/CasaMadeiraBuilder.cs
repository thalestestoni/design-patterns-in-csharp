namespace DesignPatterns.Criacionais.Builder
{
    internal class CasaMadeiraBuilder
    {
        private Casa Casa { get; set; }

        public CasaMadeiraBuilder()
        {
            Casa = new Casa();
        }

        public Casa ConstruirCasa()
        {
            Casa.Teto = new TetoMadeira();
            Casa.Parede = new ParedeMadeira();
            Casa.Janela = new JanelaMadeira();
            Casa.Porta = new PortaMadeira();
            return Casa;
        }

    }
}
