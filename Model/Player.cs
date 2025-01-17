using System;


/**
 * This is the Player class. The player is able to hold a hand of Cards. This can decide whether to stay or hit.
 * This class should also be one of the first generated when the game begins. 
 */
public class Player
{
	private string userName;
	private List<Card> hand;
	private bool isDealer;


	private string UserName { get => userName; set => userName = value;  }
	private bool IsDealer { get => isDealer; set => isDealer=value; }
	private List<Card> Hand { get => hand; set => hand=value; }

	// example of an NPC name: SallyBlackjackNPC


    public Player()
	{
		
	}

	
}
