using Prototype.Models;

class Program
{
    public static void Main(string[] args)
    {
        var gerenciadorNuvens = new GerenciadorNuvens();

        gerenciadorNuvens["padrao"] = new NuvemConcreta("branco", "azul");

        gerenciadorNuvens["personalizada"] = new NuvemConcreta("branco", "rosa");


        NuvemConcreta? um = gerenciadorNuvens["padrao"].Clone() as NuvemConcreta;

        NuvemConcreta? dois = gerenciadorNuvens["padrao"].Clone() as NuvemConcreta;

        NuvemConcreta? tres = gerenciadorNuvens["personalizada"].Clone() as NuvemConcreta;

        NuvemConcreta? quatro = gerenciadorNuvens["personalizada"].Clone() as NuvemConcreta;

        Console.ReadKey();

    }
}