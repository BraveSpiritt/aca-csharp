namespace Task_3
{
    internal class Program
    {
        interface IPlayable
        {
             void Play();
             void Pause();
        }
        interface IRecordable
        {
             void Record();
             void StopRecording();
        }
        class MediaPlayer : IRecordable, IPlayable
        {
            public void Play()
            {
                Console.WriteLine("MediaPlayer is playing");
            }
            public void Pause()
            {
                Console.WriteLine("MediaPlayer is paused");
            }
            public void Record()
            {
                Console.WriteLine("MediaPlayer is recording");
            }
            public void StopRecording()
            {
                Console.WriteLine("MediaPlayer has stopped recording");
            }
        }
        static void Main(string[] args)
        {
            MediaPlayer ipod = new MediaPlayer();   
            ipod.Play();
            ipod.Pause();
            ipod.Record();
            ipod.StopRecording();
        }
    }
}
