namespace Packt.Shared;

internal interface IPlayabke
{
    void Play();
    void Pause();

    void Stop() // default interface implementation.
    {
        WriteLine("Default implementation of Stop");
    }
}