namespace _14_01;

class Program
{
    static void Main(string[] args)
    {
        var builder = new CharacterBuilder();
        var bastard = builder.SetName("john snow")
            .SetClass("Bastard")
            .SetLevel(15)
            .SetHealth(200)
            .Build();

        var mage = builder.SetName("Sauron")
            .SetClass("Mage")
            .SetLevel(25)
            .SetHealth(120)
            .Build();
        
        
        var clonedWarrior = bastard.Clone();
        clonedWarrior.Name = "Targarien";

        // singlton
        var manager = CharacterManager.Instance;
        manager.AddCharacter(bastard);
        manager.AddCharacter(mage);
        manager.AddCharacter(clonedWarrior);

        // vivod
        manager.DisplayCharacters();
    }
}