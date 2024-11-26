namespace Facade
{
    public class HomeTheaterFacade
    {
        private readonly TV _tv;
        private readonly SoundSystem _soundSystem;
        private readonly StreamingService _streamingService;

        public HomeTheaterFacade(TV tv, SoundSystem soundSystem, StreamingService streamingService)
        {
            _tv = tv;
            _soundSystem = soundSystem;
            _streamingService = streamingService;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Setting up home theater...");
            _tv.TurnOn();
            _soundSystem.TurnOn();
            _soundSystem.SetVolume(20);
            _streamingService.Login();
            _streamingService.PlayMovie(movie);
            Console.WriteLine("Enjoy the movie!");
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting down home theater...");
            _tv.TurnOff();
            _soundSystem.TurnOff();
        }
    }

}
