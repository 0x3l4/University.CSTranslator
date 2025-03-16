namespace University.CSharpTranslator.LexicalAnalysis
{
    public class SourceReader
    {
        private readonly string _code;
        private int _position = 0;
        public int Line { get; private set; } = 1;
        public int Column { get; private set; } = 1;

        public SourceReader(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Файл '{filePath}' не найден");

            _code = File.ReadAllText(filePath);
        }
    }
}
