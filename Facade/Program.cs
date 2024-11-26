namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create subsystem instances
            TV tv = new TV();
            SoundSystem soundSystem = new SoundSystem();
            StreamingService streamingService = new StreamingService();

            // Create the facade
            HomeTheaterFacade homeTheater = new HomeTheaterFacade(tv, soundSystem, streamingService);

            // Use the facade to watch a movie
            homeTheater.WatchMovie("Inception");

            // End the movie
            homeTheater.EndMovie();
        }
    }
}
