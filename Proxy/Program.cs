namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IImage image = new ProxyImage("test_image.jpg");

            // Image is loaded only when Display() is called
            Console.WriteLine("Image proxy created.");

            // First display (lazy initialization)
            image.Display();

            // Second display (already initialized)
            image.Display();
        }
    }
}
