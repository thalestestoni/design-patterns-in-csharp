namespace DesignPatterns.Criacionais.Builder
{
    public class Casa
    {
        public IParede Parede { get; set; }
        public IPorta Porta { get; set; }
        public IJanela Janela { get; set; }
        public ITeto Teto { get; set; }

        public void Descrever()
        {
            Parede.Descrever();
            Porta.Descrever();
            Janela.Descrever();
            Teto.Descrever();
        }
    }
}
