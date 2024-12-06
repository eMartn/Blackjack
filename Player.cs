using System;

public class Player
{
	private string userName;
	private List<Card> hand;
	private bool isDealer;


	private string UserName { get => userName; set => userName=value; }
	private bool IsDealer { get => isDealer; set => isDealer=value; }
	private List<Card> Hand { get => hand; set => hand=value; }

	public Player()
	{

	}
}
