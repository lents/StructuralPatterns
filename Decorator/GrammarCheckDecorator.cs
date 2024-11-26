namespace Decorator
{
    public class GrammarCheckDecorator : TextEditorDecorator
    {
        public GrammarCheckDecorator(ITextEditor editor) : base(editor) { }

        public override string ProcessText()
        {
            var text = base.ProcessText();
            return $"{text} [Grammar-checked]";
        }
    }

}
