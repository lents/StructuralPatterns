namespace Bridge
{
    public class VectorRenderer : IRenderer
    {
        public void Render(string shape)
        {
            Console.WriteLine($"Rendering {shape} as lines (vector).");
        }
    }

}
