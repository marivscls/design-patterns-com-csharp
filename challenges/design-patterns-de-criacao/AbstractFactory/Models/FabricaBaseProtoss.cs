using AbstractFactory.Interface;

namespace AbstractFactory.Models;
public class FabricaBaseProtoss : IFabricaBases
{
    public void CriarBase()
    {
        Console.WriteLine("Base Protoss criada com sucesso!");

        RevestimentoBaseProtoss revestimentoBaseProtoss = new();
        revestimentoBaseProtoss.Composicao();

        EnergiaBaseProtoss energiaBaseProtoss = new();
        energiaBaseProtoss.Composicao();
    }

}