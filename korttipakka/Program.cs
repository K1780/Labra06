using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            //create deck
            Deck PokerDeck = new Deck();
            //add x amount of cards to each house
            //13 makes normal size poker deck (52 cards)
            PokerDeck.MakeDeck(13);
            //show deck
            PokerDeck.ShowDeck();
            //shuffle deck
            //????????????

        }
    }
}
