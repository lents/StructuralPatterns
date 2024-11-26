namespace Decorator
{
    public class SpellCheckDecorator : TextEditorDecorator
    {
        public SpellCheckDecorator(ITextEditor editor) : base(editor) { }

        public override string ProcessText()
        {
            var text = base.ProcessText();
            return $"{text} [Spell-checked]";
        }
    }

}
