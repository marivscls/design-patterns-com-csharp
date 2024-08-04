using AdapterPattern.Interface;

namespace AdapterPattern.Models;

public class Personagem : IAcao
{
    public void Andar(string Personagem)
    {
        Console.WriteLine(Personagem + " ANDOU PARA FRENTE");
    }

    public void Atirar()
    {
        Console.WriteLine(" Atirou no jogo!");
    }
}