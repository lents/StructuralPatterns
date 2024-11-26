namespace Bridge
{
    public class Rectangle : Shape
    {
        private readonly float _width;
        private readonly float _height;

        public Rectangle(IRenderer renderer, float width, float height) : base(renderer)
        {
            _width = width;
            _height = height;
        }

        public override void Draw()
        {
            Renderer.Render($"Rectangle with width {_width} and height {_height}");
        }
    }

}
