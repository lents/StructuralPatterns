namespace Bridge
{
    public class RasterRenderer : IRenderer
    {
        public void Render(string shape)
        {
            Console.WriteLine($"Rendering {shape} as pixels (raster).");
        }
    }

}
