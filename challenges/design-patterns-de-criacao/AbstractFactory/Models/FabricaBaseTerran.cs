using AbstractFactory.Interface;
namespace AbstractFactory.Models;
public class FabricaBaseTerran : IFabricaBases
{
    public void CriarBase()
    {
        Console.WriteLine("Base criada com sucesso!");

        RevestimentoBaseProtoss revestimentoBaseProtoss = new();
        revestimentoBaseProtoss.Composicao();

        EnergiaBaseProtoss energiaBaseProtoss = new();
        energiaBaseProtoss.Composicao();

    }

}