﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameConsole
{
    class UnoGame
    {
        public Deck deck;
        private Player player1;
        private Player player2;
        private int userInput;
        private bool loop;
        private bool gameOver = false;

        public UnoGame()
        {
            deck = new Deck(this);
            player1 = new Player("Albert", this);
            player2 = new Player("Karsten", this);

            player1.DrawCard(7);
            player2.DrawCard(7);

            deck.cardsRevealed.Add(deck.Draw());

            while (!gameOver)
            {
                ChooseCard(player1);

                ChooseCard(player2);

                if (deck.cards.Count == 0)
                {
                    Console.WriteLine("GAME OVER!");
                }
            }
        }

        private void ChooseCard(Player player)
        {
            Console.WriteLine("Det er " + player.name + "'s tur");
            loop = true;
            while (loop)
            {
                Console.WriteLine(player.ToString());

                if (deck.cardsRevealed.Count == 0) Console.WriteLine("Intet kort er lagt endnu");
                else Console.WriteLine("Sidste kort var: " + deck.Peek());

                Console.WriteLine("Hvilket kort vil du lægge ned?");
                Console.Write("> ");
                userInput = Convert.ToInt32(Console.ReadLine());
                deck.PlayCard(player.hand[userInput]);
                Console.Clear();
                if (deck.PlayCard(player.hand[userInput]))
                {
                    Console.WriteLine(player.hand[userInput] + " er lagt ned");
                    loop = false;
                    Console.WriteLine();
                    player.hand.Remove(player.hand[userInput]);
                    player.DrawCard();
                }
                else
                {
                    Console.WriteLine(player.hand[userInput] + " kan ikke ligges på " + deck.Peek());
                    Console.WriteLine("Prøv igen!");
                    Console.WriteLine();
                }
            }
        }
    }
}
