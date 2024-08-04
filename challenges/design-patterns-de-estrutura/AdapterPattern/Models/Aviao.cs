namespace AdapterPattern.Models;

public class Aviao
{
    public void Voar(string Personagem)
    {
        Console.WriteLine(Personagem + " VOOU PARA FRENTE");
    }

    public void SoltarMissel()
    {
        Console.WriteLine("Soltou um missel no jogo!");

    }

}