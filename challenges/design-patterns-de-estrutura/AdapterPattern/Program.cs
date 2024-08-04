using AdapterPattern.Interface;
using AdapterPattern.Models;

class Program
{
    public static void Main(string[] args)
    {
        Personagem Mariana = new();
        Aviao aviao_de_batalha = new();
        IAcao adaptador = new Adapter(aviao_de_batalha);

        Console.WriteLine("--- CAMINHANDO ---");

        Mariana.Andar("Mariana");
        Mariana.Atirar();

        Console.WriteLine();

        Console.WriteLine("--- PEGOU UM AVIAO NO JOGO ---");
        adaptador.Andar("Mariana");
        adaptador.Atirar();
    }

}