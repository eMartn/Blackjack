

/**
Card class. This is where the attributes of each card are stored.
*/
public class Card ()
{
    #region fields
    private string rank, suit, color;
    private int cardValue;
    #endregion
    public string Rank{get=>rank; set=>rank=value;} //lambda expressions are getting and setting
    public int CardValue{get=>cardValue; set=>cardValue=value;}
    public string Suit{get=>suit; set=>suit=value;}
    public string Color{get=>color; set=>color=value;}

    // TODO: An ace card can have a value of 1 or 11. Figure out a way to make it happen. A tuple? Two vars?git
    
    
    public Array generateCards ()
    {
        
    }
}
