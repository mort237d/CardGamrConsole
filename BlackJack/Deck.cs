using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGameConsole;

namespace CardGameConsole
{
    class Deck
    {
        public List<Card> cards = new List<Card>();
        public List<Card> cardsRevealed = new List<Card>();
        private UnoGame unoGame;

        public Deck(UnoGame unoGame)
        {
            this.unoGame = unoGame;
            for (int i = 0; i < 10; i++)
            {
                // red cards
                cards.Add(new Card("red", i));
                cards.Add(new Card("red", i));

                //blue cards
                cards.Add(new Card("blue", i));
                cards.Add(new Card("blue", i));

                //green cards
                cards.Add(new Card("green", i));
                cards.Add(new Card("green", i));

                //yellow cards
                cards.Add(new Card("yellow", i));
                cards.Add(new Card("yellow", i));
            }

            Shuffle();
        }

        public Card Peek()
        {
            return cardsRevealed.Last();
        }

        public Card Draw()
        {
            Card c = cards[0]; //finder øverste kort
            cards.Remove(c); //fjerner kort fra bunken (c = øverste kort)
            return c; //giver kortet til den der kalder metoden
        }

        public void Shuffle()
        {
            Random random = new Random();
            cards = cards.OrderBy(x => random.Next()).ToList();
        }

        public bool PlayCard(Card card)
        {
            if (cardsRevealed.Count == 0)
            {
                cardsRevealed.Add(card);
                return false;
            }
            else
            {
                if (Peek().Color == card.Color || Peek().Value == card.Value)
                {
                    cardsRevealed.Add(card);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < cards.Count; i++)
            {
                sb.Append("[");
                sb.Append(cards[i]);
                sb.Append("], ");
            }
            return sb.ToString();
        }
    }
}
