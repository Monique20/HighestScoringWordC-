using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestScoringWord
{
    public class HighestScoringWordClass
    {
        public string Score(string stringOfWords)
        {
            if (string.IsNullOrWhiteSpace(stringOfWords))
            {
                return "0";
            }

            var words = stringOfWords.ToLower().Split(' ');
            var lengths = new List<int>();
            foreach (var word in words)
            {
                var wordScore = 0;
                foreach (var character in word)
                {
                    wordScore += (int) character - 'a' + 1;
                }

                lengths.Add(wordScore);
            }

            return words[lengths.IndexOf(lengths.Max())];
        }
    }
}
