using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7Nutshell
{
    public class Sentence
    {
        string[] words = "The quick brown fox".Split();

        public string this [int wordNum] //indexer
        {
            get { return words[wordNum]; }
            set { words[wordNum] = value; }
        }
    }
}
