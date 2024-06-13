using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTABU.GameLogic;

public class CardGenerator
{
    public List<Card> Generate()
    {
        List<Card> cards = new List<Card>();

        Card c1 = new Card("Haushaltsabgabe", new List<string>() { "ORF", "Haus" });
        cards.Add(c1);


        Card c2 = new Card("Sonne", new List<string>() { "warm", "gelb", "sterne", "Himmel" });
        cards.Add(c2);

        return cards;
    }
}
