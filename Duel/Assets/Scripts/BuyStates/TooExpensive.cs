using UnityEngine;
using System.Collections;

public class TooExpensive : BuyState
{
    protected TooExpensive(bool isTrue) : base(isTrue)
    {
      
    }

    protected override void DisplayCard()
    {
        GetComponent<SpriteRenderer>().color = Settings.toExpensiveCard;
    }

    protected override void PlayerHasChoosenCard()
    {
        throw new System.NotImplementedException();
    }
}
