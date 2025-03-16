using University.CSharpTranslator.LexicalAnalysis;

namespace University.CSharpTranslator.Tests
{
    public class LexerTests
    {
        [Fact]
        public void Tokenize_SimpleCode_ReturnsCorrectTokens()
        {
            string testCode = "int x = 5;";
            Lexer lexer = new Lexer(testCode);

            List<Token> tokens = lexer.Tokenize();

            Assert.Equal(5, tokens.Count);
            Assert.Equal(TokenType.Keyword, tokens[0].Type);  // "int"
            Assert.Equal(TokenType.Identifier, tokens[1].Type); // "x"
            Assert.Equal(TokenType.Operator, tokens[2].Type);  // "="
            Assert.Equal(TokenType.Literal, tokens[3].Type);   // "5"
            Assert.Equal(TokenType.Separator, tokens[4].Type);    // ";"
        }

        [Fact]
        public void Tokenize_HandlesComments_Correctly()
        {
            string testCode = "x = 10; // комментарий";
            Lexer lexer = new Lexer(testCode);

            List<Token> tokens = lexer.Tokenize();

            Assert.Equal(3, tokens.Count);
        }
    }
}