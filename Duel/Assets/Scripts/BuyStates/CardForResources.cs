using UnityEngine;
using System.Collections;

public class CardForResources : BuyState
{
    public CardForResources() : base(false) { }
    public CardForResources(bool isTrue) : base(isTrue) { }

    public static CardForResources EnoughResources(Buyable b)
    {
        bool state = GameManager.instance._CurrentPlayer.GetResources() >= b.cost;
        return new CardForResources(state);
    }

    public override void DisplayCard()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    public override void PlayerHasChoosenCard()
    {
        // ustaw karte ma bialy kolor

    }
}
