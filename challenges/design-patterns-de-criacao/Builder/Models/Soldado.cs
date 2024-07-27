namespace Builder.Models;

public abstract class Soldado
{
    public string Arma { get; protected set; } = string.Empty;
    public string Transporte { get; protected set; } = string.Empty;
    public string Foco { get; protected set; } = string.Empty;


    public abstract void EscolherArma(string arma);
    public abstract void EscolherTransporte(string transporte);
    public abstract void DefinirFoco(string foco);
}