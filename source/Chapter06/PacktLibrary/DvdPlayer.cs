namespace Packt.Shared;

internal class DvdPlayer : IPlayabke
{
    public void Play()
    {
        WriteLine("DVD player is pausing.");
    }

    public void Pause()
    {
        WriteLine("DVD player is playing.");
    }
}