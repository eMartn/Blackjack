/**
Deck class. The deck deals cards out to all players, including the dealer.


ENUM 
SPADES [1,2,3,4,5,6,7,8,9,10,J,Q,K,A]
HEARTS [1,2,3,4,5,6,7,8,9,10,J,Q,K,A]
DIAMONDS [1,2,3,4,5,6,7,8,9,10,J,Q,K,A]
TREBLES [1,2,3,4,5,6,7,8,9,10,J,Q,K,A]

decklist<cards> [52 cards] shuffle and remove 2 random cards and deal to one player, then move on to 
the next player and deal 2 random cards

TODO: Figure out how to put cards back into deck RANDOMLY
Shuffle method?? 

TODO: For which data structure to use, arrays are not an option because they are static.
Consider using Stack.

Consider shuffling the cards before they are in the deck and then entering the deck in a stack that becomes the main deck.


*/


public class Deck
{

    private List<Card> mainDeck = new List<Card>();

    public void fillDeck(List<Card> startingDeck)
    {
        //calls the fillDeck method in the Card class
        Card createDeck = new Card();
        createDeck.fillDeck(startingDeck);
    }

    public List<Card> shuffle(List<Card> deck)

    {
        // this method should randomly shuffle the cards in the given list and return the new list


        return deck;
    }

    public List<Card> deal(int numberToDeal)
    {
        // this method should deal cards from the remaining cards in the deck

        List<Card> cardsToDeal = new List<Card>();


        return cardsToDeal;
    }


}


