using AbstractFactory.Interface;
using AbstractFactory.Models;

class Program
{
    static void Main(string[] args)
    {
        IFabricaBases fabrica;

        Console.WriteLine("Escolha um dos personagens: ");
        Console.WriteLine("1 - Protoss | 2 - Terranos | 3 - Zergs");


        switch (Console.ReadLine())
        {
            case "1":
                fabrica = new FabricaBaseProtoss();
                fabrica.CriarBase();
                break;

            case "2":
                fabrica = new FabricaBaseTerran();
                fabrica.CriarBase();
                break;

            case "3":
                fabrica = new FabricaBaseZerg();
                fabrica.CriarBase();
                break;
        }

    }

}