namespace University.CSharpTranslator.LexicalAnalysis
{
    /// <summary>
    /// На выходе будет
    /// Таблица идентификаторов,
    /// Таблица внешних представлений
    /// </summary>
    public enum TokenType
    {
        Identifier,
        Keyword,
        Operator,
        Separator,
        Literal
    }
}
