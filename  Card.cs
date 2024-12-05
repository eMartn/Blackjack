
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
    private string Suit{get=>suit; set=>suit=value;}
    private string Color{get=>color; set=>color=value;}

    
    
}
