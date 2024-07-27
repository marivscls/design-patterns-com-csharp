using System.Security.Cryptography.X509Certificates;

namespace Builder.Models;

public class CriadorDeInfantariaLeve : CriadorDeSoldado
{
    public CriadorDeInfantariaLeve()
    {
        _soldado = new SoldadoDeInfatariaLeve();
    }

    public override void Arma()
    {
        _soldado.EscolherArma("Ataque Aereo");
    }

    public override void Foco()
    {
        _soldado.DefinirFoco("Resposta rapida aerea");
    }

    public override void Transporte()
    {
        _soldado.EscolherTransporte("Helicoptero de ataque do exercito");
    }

}