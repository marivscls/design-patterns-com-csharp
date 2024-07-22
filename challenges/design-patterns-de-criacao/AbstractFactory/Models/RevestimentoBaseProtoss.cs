using AbstractFactory.Interface;

namespace AbstractFactory.Models;

public class RevestimentoBaseProtoss : IRevestimento
{
    public void Composicao()
    {
        Console.WriteLine("Base revestida pela cor amarela");

    }

}