using UnityEngine;
using System.Collections;

public abstract class BuyResult : MonoBehaviour
{
    public abstract void DisplayCard();
}

public class ResultResources : BuyResult
{
    Resources difference;

    public override void DisplayCard()
    {

    }
}

public class ResultExpensive : BuyResult
{
    public override void DisplayCard()
    { 
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}