using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_editor
{
    public class Editor
    {
        public string JoinWords(params string[] words)
        {
            string joinedWords = string.Join("", words).Replace(" ", "");

            return joinedWords;
        }

        public string CapitalizeStartingLetters(string text)
        {
            int index = 1;
            string newText = "";
            foreach (var letter in text)
            {
                if (index == 1)
                {
                    newText += letter.ToString().ToUpper();
                }
                else
                {
                    newText += letter;
                }
                index = letter.ToString() == " " ? 1 : 0;
            }
            return newText;
        }

        public string ReverseText(string text)
        {
            string reversedText = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedText += text[i];
            }
            return reversedText;
        }
    }
}
