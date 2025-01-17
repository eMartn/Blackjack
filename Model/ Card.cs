
/**
Card class. This is where the attributes of each card are stored.
*/
public class Card
{
    #region fields
    private string rank, suit, color;
    private int cardValue;
    #endregion
    public string Rank { get => rank; set => rank = value; } //lambda expressions are getting and setting
    public int CardValue { get => cardValue; set => cardValue = value; }
    public string Suit { get => suit; set => suit = value; }
    public string Color { get => color; set => color = value; }

    // TODO: An ace card can have a value of 1 or 11. Figure out a way to make it happen. A tuple? Two vars?
    // TODO: Database for keeping track of player logins (password optional) and their scores.

    //deck to hold the cards in a list and shuffles them as well as deals them
    public Card()
    {
        
    }

    public Card(string color, string suit) 
    {
        this.Color = color;
        this.Suit = suit;
    }
   
    public List<Card> fillDeck(List<Card> startingDeck) // return type likely needs to be a stack. the deck starts as a list, gets randomized, then put into a stack.
    {
        // diamonds, clubs, spades, hearts
        // 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A
        
        int counter = 0;
        List<Card> tempDeck = startingDeck;
        for (int i = 2; i <= 14; i++)
        {
           Card cardContainer = new Card();
           if ( counter == 0)
            {
                cardContainer.Suit = "Diamonds";
                cardContainer.Color = "Red";
            }
            if (counter == 1)
            {
                cardContainer.Suit = "Hearts";
                cardContainer.Color = "Red";
            }
            else if (counter == 2)
            {
                cardContainer.color = "Black";
                cardContainer.Suit = "Spades";
            }
            else if (counter == 3)
            {
                cardContainer.color = "Black";
                cardContainer.Suit = "Clubs";
            }
            

            if (i == 11)
            {
                cardContainer.Rank = "J";
                cardContainer.CardValue = 10;
            }
            else if (i == 12)
            {
                cardContainer.Rank = "Q";
                cardContainer.CardValue = 10;
            }
            else if (i == 13)
            {
                cardContainer.Rank = "K";
                cardContainer.CardValue = 10;
            }
            else if (i == 14)
            {
                cardContainer.Rank = "A";
                cardContainer.CardValue = 11;
                if (counter != 3) 
                { 
                   counter++; 
                   i = 1; 
                }
            }
            else
            {
                cardContainer.Rank = i.ToString();
                cardContainer.CardValue = i;
            }
         
            tempDeck.Add(cardContainer);
        }

        // for loop
        // goes through tempdeck and 

       /** for (int i = 2; i <= 14; i++)
        {
            cardContainer.Suit = "Hearts";
            cardContainer.Rank = i.ToString();
            cardContainer.CardValue = i;
            cardContainer.Color = "Red";

        }

        for (int i = 2; i <= 14; i++)
        {
            cardContainer.Suit = "Clubs";
            cardContainer.Rank = i.ToString();
            cardContainer.CardValue = i;
            cardContainer.Color = "Black";

        }
        for (int i = 2; i <= 14; i++)
        {
            cardContainer.Suit = "Spades";
            cardContainer.Rank = i.ToString();
            cardContainer.CardValue = i;
            cardContainer.Color = "Black";

        }**/



        return tempDeck;
    }
}
