using AbstractFactory.Interface;

namespace AbstractFactory.Models;
public class RevestimentoBaseTerran : IRevestimento
{
    public void Composicao()
    {
        Console.WriteLine("Base revestida pela cor verde");
    }

}