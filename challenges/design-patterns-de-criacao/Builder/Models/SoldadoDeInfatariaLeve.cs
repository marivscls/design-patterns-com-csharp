namespace Builder.Models;

public class SoldadoDeInfatariaLeve : Soldado
{
    public override void EscolherArma(string arma)
    {
        Arma = arma;
    }

    public override void EscolherTransporte(string trasnporte)
    {
        Transporte = trasnporte;
    }
    public override void DefinirFoco(string foco)
    {
        Foco = foco;
    }

}