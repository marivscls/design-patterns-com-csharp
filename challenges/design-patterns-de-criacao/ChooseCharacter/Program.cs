using ChooseCharacter;

class Program
{
    public static void Main(string[] args)
    {
        var fm = new FactoryMethod();

        Console.WriteLine("Liu Kang | Subzero | Scorpion ");

        Console.WriteLine();

        Console.WriteLine("Escolha seu personagem: ");

        var choice = Console.ReadLine();

        ICharacter? character = FactoryMethod.SelectCharacter(choice);

        Console.WriteLine();

        if (character != null)
        {
            Console.WriteLine("Voce vai jogar com: ");
            character.Chosen();
        }
        else
        {
            Console.WriteLine("Personagem não reconhecido!");
        }
    }
}
