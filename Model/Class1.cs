using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Model
{
    internal class Driver
    {
        static void Main(string[] args)
        {
            // Display the number of command line arguments.
            
            Deck deck1 = new Deck();
            Card card1 = new Card();

            List<Card> cards = new List<Card>();
            deck1.fillDeck(cards);
        }
    }
}
