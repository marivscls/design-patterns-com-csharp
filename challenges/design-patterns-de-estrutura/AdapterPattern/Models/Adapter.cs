using AdapterPattern.Interface;

namespace AdapterPattern.Models;

public class Adapter : IAcao
{
    Aviao aviao;
    public Adapter(Aviao novo_aviao)
    {
        aviao = novo_aviao;

    }
    public void Andar(string Personagem)
    {
        aviao.Voar(Personagem);
    }

    public void Atirar()
    {
        aviao.SoltarMissel();
    }
}