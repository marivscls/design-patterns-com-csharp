namespace Prototype.Models;

public class GerenciadorNuvens
{
    private readonly Dictionary<string, NuvemMolde> nuvens = [];

    public NuvemMolde this[string key]
    {
        get { return nuvens[key]; }
        set { nuvens.Add(key, value); }
    }

}