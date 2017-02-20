using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Deck
    {
        //properties
        public List<Card> cards;
        //constructor
        public Deck()
        {
            cards = new List<Card>();
        }
        //methods
        public void MakeDeck(int cardsForEachHouse)
        {
            for (int x = 0; x < cardsForEachHouse; x++)
            {
                cards.Add(new Hearts { CardValue = (x + 1) });
                cards.Add(new Diamonds { CardValue = (x + 1) });
                cards.Add(new Clubs { CardValue = (x + 1) });
                cards.Add(new Spades { CardValue = (x + 1) });
            }
        }
        public void ShowDeck()
        {
            int x = 1;
            foreach (Card card in cards)
            {
                Console.WriteLine(String.Format("Card {0} is: {1} value {2}", x, card.House, card.CardValue));
                x++;
            }
        }

    }
    abstract class Card
    {
        public abstract string House { get; }
        private int cardvalue;
        public int CardValue
        {
            get { return cardvalue; }
            set
            {
                if (value <= 13)
                {
                    cardvalue = value;
                }
                else if (value % 13 == 0)
                {
                    cardvalue = 13;
                }
                else
                {
                    cardvalue = (value % 13);
                }
            }
        }
    }
    class Hearts : Card
    {
        //properties
        public override string House
        {
            get { return "Hearts"; }
        }
    }
    class Spades : Card
    {
        //propeties
        public override string House
        {
            get { return "Spades"; }
        }
    }
    class Diamonds : Card
    {
        //propeties
        public override string House
        {
            get { return "Diamonds"; }
        }
    }
    class Clubs : Card
    {
        //propeties
        public override string House
        {
            get { return "Clubs"; }
        }
    }
}