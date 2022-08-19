using Text_editor;

namespace Text_editor_Xunit
{
    public class EditorUnitTests
    {
        Editor editor;
        public EditorUnitTests()
        {
            editor = new Editor();
        }
        [Fact]
        public void EditorReturnsReversedText()
        {

            string fruit = "banan";
            string expected = "nanab";
            string actual = editor.ReverseText(fruit);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void EditorCapitalizesEachStartingLetterInAWord()
        {
            string text = "sju sjösjuka sjömän";
            string expected = "Sju Sjösjuka Sjömän";
            string actual = editor.CapitalizeStartingLetters(text);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void JoinWords_ReturnsConcatenatedStringWithoutWhiteSpace()
        {
            string expected = "Kassaarbetare";
            string actual = editor.JoinWords("  Kassa  ", "arbe  tare");
            Assert.Equal(expected, actual);
        }
    }
}