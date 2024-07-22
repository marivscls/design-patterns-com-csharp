using AbstractFactory.Interface;

namespace AbstractFactory.Models;
public class FabricaBaseZerg : IFabricaBases
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