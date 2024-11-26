namespace Flyweight
{
    public class TreeType : ITree
    {
        private readonly string _name;
        private readonly string _color;
        private readonly string _texture;

        public TreeType(string name, string color, string texture)
        {
            _name = name;
            _color = color;
            _texture = texture;
        }

        public void Display(int x, int y)
        {
            Console.WriteLine($"Displaying tree of type {_name} at ({x}, {y}) with color {_color} and texture {_texture}.");
        }
    }

}
