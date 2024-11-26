namespace Decorator
{
    public abstract class TextEditorDecorator : ITextEditor
    {
        protected readonly ITextEditor _editor;

        protected TextEditorDecorator(ITextEditor editor)
        {
            _editor = editor;
        }

        public virtual string ProcessText()
        {
            return _editor.ProcessText();
        }
    }

}
