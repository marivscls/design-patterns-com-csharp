namespace ChooseCharacter;
public class FactoryMethod
{
    public static ICharacter? SelectCharacter(string character)
    {
        return character switch
        {
            "Liu Kang" => new LiuKang(),
            "Subzero" => new Subzero(),
            "Scorpion" => new Scorpion(),
            _ => null,
        };
    }

}