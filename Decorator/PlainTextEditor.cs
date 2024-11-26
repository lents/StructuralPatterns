namespace Decorator
{
    public class PlainTextEditor : ITextEditor
    {
        private readonly string _text;

        public PlainTextEditor(string text)
        {
            _text = text;
        }

        public string ProcessText()
        {
            return _text;
        }
    }

}
