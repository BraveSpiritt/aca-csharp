

class Program
{
    static void Main(string[] args)
    {
        GameSettings settings = GameSettings.None;
        settings ^= GameSettings.SoundOn;
        Console.WriteLine("After toggling SoundOn: " + settings);
        settings ^= GameSettings.SoundOn;
        Console.WriteLine("After toggling SoundOn again: " + settings);
    }
    [Flags]
    enum GameSettings
    {
        None = 0,
        SoundOn = 1,
        MusicOn = 2,
        FullScreen = 4
    }
}