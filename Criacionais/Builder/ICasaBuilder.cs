namespace DesignPatterns.Criacionais.Builder
{
    public interface ICasaBuilder
    {
        CasaBuilder FazerParede(IParede parede);
        CasaBuilder FazerTeto(ITeto teto);
        CasaBuilder FazerJanela(IJanela janela);
        CasaBuilder FazerPorta(IPorta porta);
        Casa ConstruirCasa();
    }

    public interface ICasaBuilderGenerico
    {
        CasaBuilder FazerParede();
        CasaBuilder FazerTeto();
        CasaBuilder FazerJanela();
        CasaBuilder FazerPorta();
        Casa ConstruirCasa();
    }
}
