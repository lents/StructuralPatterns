namespace Facade
{
    public class SoundSystem
    {
        public void TurnOn()
        {
            Console.WriteLine("Sound System is turned ON.");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine($"Sound System volume set to {level}.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Sound System is turned OFF.");
        }
    }

}
