using AbstractFactory.Interface;

namespace AbstractFactory.Models;

public class EnergiaBaseTerran : IEnergia
{
    public void Composicao()
    {
        Console.WriteLine("Energia de sustentacao da base mecanica");
    }

}