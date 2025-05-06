namespace _14_01;

public sealed class CharacterManager
{
    private static readonly CharacterManager _instance = new CharacterManager();
    private List<Character> _characters = new List<Character>();

    private CharacterManager() { }

    public static CharacterManager Instance
    {
        get { return _instance; }
    }

    public void AddCharacter(Character character)
    {
        _characters.Add(character);
    }

    public void DisplayCharacters()
    {
        foreach (var character in _characters)
        {
            character.DisplayInfo();
        }
    }
}