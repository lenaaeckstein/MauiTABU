using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTABU.GameLogic
{
    public class Card
    {
        public string Word { get; private set; } =string.Empty;

        public List<string> BlacklistWords { get; set; } = new();



        public Card(string word, List<string> blacklistword) 
        {
            BlacklistWords = blacklistword;
            Word = word;    
        }


    }
}
