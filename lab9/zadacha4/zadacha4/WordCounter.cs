using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha4
{
    class WordCounter
    {
        public SortedList wordCounter { get; set; }
        public int UniqueWords
        {
            get { return wordCounter.Count; }
        }

        public IDictionaryEnumerator GetWordsAlphabeticallyEnumerator()
        {
            return (IDictionaryEnumerator)wordCounter.GetEnumerator();
        }

        public string Text { get; set; }
        public Boolean CountStats(out Int64 numWords, out Int64 numChars, string text)
        {
            wordCounter = new SortedList();
            Boolean Ok = true;
            numWords = numChars = 0;
            string[] Words = text.Split(null);
            Console.WriteLine(Words);
            Text = text;
            numWords = Words.Length;
            for (int Word = 0; Word < numWords; Word++)
            {
                if (Words[Word] != "")
                    numChars += Words[Word].Length;
                if (!wordCounter.Contains(Words[Word]))
                {
                    wordCounter.Add(Words[Word], 1);
                }
                else
                {
                    wordCounter[Words[Word]] = (Int32)wordCounter[Words[Word]] + 1;
                }
            }

            return Ok;
        }
    }        
}
