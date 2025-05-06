namespace _14_01;

public interface ICharacterPrototype
{
    Character Clone();
}

public class Character
{
    public string Name { get; set; }
    public string Class { get; set; }
    public int Level { get; set; }
    public int Health { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Class: {Class}, Level: {Level}, Health: {Health}");
    }
    
    public Character Clone()
    {
        return new Character
        {
            Name = this.Name,
            Class = this.Class,
            Level = this.Level,
            Health = this.Health
        };
    }
}