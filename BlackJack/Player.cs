using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGameConsole;

namespace CardGameConsole
{
    class Player
    {
        public List<Card> hand = new List<Card>();
        private UnoGame unoGame;

        public Player(UnoGame unoGame)
        {
            this.unoGame = unoGame;
        }

        public void DrawCard()
        {
            hand.Add(unoGame.deck.Draw());
        }

        public void DrawCard(int numberOfCards)
        {
            for (int i = 0; i < numberOfCards; i++)
            {
                hand.Add(unoGame.deck.Draw());
            }
        }

        public override string ToString()
        {
            Console.WriteLine("Din hånd: ");
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hand.Count; i++)
            {
                sb.Append("(" + i + ")" + " [");
                sb.Append(hand[i]);
                sb.Append("], ");
            }
            return sb.ToString();
        }
    }
}
