using AbstractFactory.Interface;

namespace AbstractFactory.Models;
public class EnergiaBaseZerg : IEnergia
{
    public void Composicao()
    {
        Console.WriteLine("Energia de sustentacao da base pela terra");

    }

}