namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Base text editor
            ITextEditor editor = new PlainTextEditor("This is a sample text.");

            Console.WriteLine("Plain Text:");
            Console.WriteLine(editor.ProcessText());

            // Add spell-check functionality
            editor = new SpellCheckDecorator(editor);
            Console.WriteLine("\nWith Spell Check:");
            Console.WriteLine(editor.ProcessText());

            // Add grammar-check functionality
            editor = new GrammarCheckDecorator(editor);
            Console.WriteLine("\nWith Spell and Grammar Check:");
            Console.WriteLine(editor.ProcessText());
        }
    }
}
