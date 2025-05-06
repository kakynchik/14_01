namespace _14_01;

public class CharacterBuilder
{
    private Character _character = new Character();

    public CharacterBuilder SetName(string name)
    {
        _character.Name = name;
        return this;
    }

    public CharacterBuilder SetClass(string characterClass)
    {
        _character.Class = characterClass;
        return this;
    }

    public CharacterBuilder SetLevel(int level)
    {
        _character.Level = level;
        return this;
    }

    public CharacterBuilder SetHealth(int health)
    {
        _character.Health = health;
        return this;
    }

    public Character Build()
    {
        return _character;
    }
}