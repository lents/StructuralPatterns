namespace Facade
{
    public class StreamingService
    {
        public void Login()
        {
            Console.WriteLine("Logged into Streaming Service.");
        }

        public void PlayMovie(string movie)
        {
            Console.WriteLine($"Playing movie: {movie}");
        }
    }

}
