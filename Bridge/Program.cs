namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use vector renderer
            IRenderer vectorRenderer = new VectorRenderer();

            Shape circle = new Circle(vectorRenderer, 5);
            circle.Draw();

            Shape rectangle = new Rectangle(vectorRenderer, 10, 4);
            rectangle.Draw();

            // Use raster renderer
            IRenderer rasterRenderer = new RasterRenderer();

            circle = new Circle(rasterRenderer, 7);
            circle.Draw();

            rectangle = new Rectangle(rasterRenderer, 6, 3);
            rectangle.Draw();
        }
    }
}
