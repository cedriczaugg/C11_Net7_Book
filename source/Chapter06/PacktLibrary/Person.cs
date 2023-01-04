namespace Packt.Shared;

public class Person : object
{
    // delegate fields
    public EventHandler? Shout;
    
    // data field
    public int AngerLevel;
    
    // properties
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }

    // methods
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
    }

    public void Poke()
    {
        AngerLevel++;
        if (AngerLevel >= 3)
        {
            Shout?.Invoke(this, EventArgs.Empty);
        }
    }
}