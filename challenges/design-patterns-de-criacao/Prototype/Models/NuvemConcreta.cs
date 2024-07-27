namespace Prototype.Models;

public class NuvemConcreta(string preenchimento, string contorno) : NuvemMolde
{
    private readonly string cor_preenchimento = preenchimento;
    private readonly string cor_contorno = contorno;

    public override NuvemMolde? Clone()
    {
        Console.WriteLine("A nuvem clonada tem contorno: " + cor_contorno + " e preenchimento " + cor_preenchimento);
        return MemberwiseClone() as NuvemMolde;
    }

}