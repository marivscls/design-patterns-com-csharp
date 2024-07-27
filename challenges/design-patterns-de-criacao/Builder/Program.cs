using Builder.Models;

class Program
{
    public static void Main(string[] args)
    {

        var exercito = new Exercito();
        CriadorDeSoldado criadorDeSoldado;
        Soldado soldado;

        criadorDeSoldado = new CriadorDeForcasEspeciais();
        exercito.ConstruirSoldado(criadorDeSoldado);

        soldado = criadorDeSoldado.ObterSoldado();

        Console.WriteLine("Soldado com as caracteristicas: {0}, {1}, {2}", soldado.Arma, soldado.Foco, soldado.Transporte);

        criadorDeSoldado = new CriadorDeInfantariaLeve();
        exercito.ConstruirSoldado(criadorDeSoldado);

        soldado = criadorDeSoldado.ObterSoldado();
        Console.WriteLine("Soldado com as caracteristicas: {0}, {1}, {2}", soldado.Arma, soldado.Foco, soldado.Transporte);

    }
}