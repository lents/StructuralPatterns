namespace Flyweight
{
    public class Forest
    {
        private readonly List<(ITree tree, int x, int y)> _trees = new();

        public void PlantTree(int x, int y, string name, string color, string texture)
        {
            TreeType treeType = TreeFactory.GetTreeType(name, color, texture);
            _trees.Add((treeType, x, y));
        }

        public void DisplayTrees()
        {
            foreach (var (tree, x, y) in _trees)
            {
                tree.Display(x, y);
            }
        }
    }

}
