using AbstractFactory.Interface;

namespace AbstractFactory.Models;

public class RevestimentoBaseZerg : IRevestimento
{
    public void Composicao()
    {
        Console.WriteLine("Base revestida pela cor vermelhas");

    }

}