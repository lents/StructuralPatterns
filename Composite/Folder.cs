namespace Composite
{
    public class Folder : IFileSystemComponent
    {
        private readonly string _name;
        private readonly List<IFileSystemComponent> _children = new();

        public Folder(string name)
        {
            _name = name;
        }

        public void Add(IFileSystemComponent component)
        {
            _children.Add(component);
        }

        public void Remove(IFileSystemComponent component)
        {
            _children.Remove(component);
        }

        public void Display(string indent)
        {
            Console.WriteLine($"{indent}+ Folder: {_name}");
            foreach (var child in _children)
            {
                child.Display(indent + "  ");
            }
        }
    }
}
