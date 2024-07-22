using AbstractFactory.Interface;

namespace AbstractFactory.Models;

public class EnergiaBaseProtoss : IEnergia
{
    public void Composicao()
    {
        Console.WriteLine("Energia de sustentacao da base com cristais");

    }

}