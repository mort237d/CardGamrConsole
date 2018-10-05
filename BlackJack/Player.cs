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
        public List<Card> hand;
        private UnoGame unoGame;
        public string name;

        public Player(string name, UnoGame unoGame)
        {
            this.unoGame = unoGame;
            this.name = name;
            hand = new List<Card>();
        }

        public void DrawCard()
        {
            hand.Add(unoGame.deck.Draw());
        }

        public void DrawCard(int numberOfCards)
        {
            for (int i = 0; i < numberOfCards; i++)
            {
                DrawCard();
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
