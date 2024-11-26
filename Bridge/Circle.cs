namespace Bridge
{
    public class Circle : Shape
    {
        private readonly float _radius;

        public Circle(IRenderer renderer, float radius) : base(renderer)
        {
            _radius = radius;
        }

        public override void Draw()
        {
            Renderer.Render($"Circle with radius {_radius}");
        }
    }

}
