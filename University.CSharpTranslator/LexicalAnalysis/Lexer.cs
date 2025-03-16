namespace University.CSharpTranslator.LexicalAnalysis
{
    public class Lexer
    {
        private readonly SourceReader _reader;
        private readonly List<Token> _tokens = new();

        public Lexer(string filePath)
        {
            _reader = new SourceReader(filePath);
        }

        public List<Token> Tokenize()
        {
            return _tokens;
        }
    }
}
