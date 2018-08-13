using UnityEngine;
using System.Collections;

public abstract class BuyState : MonoBehaviour
{
    protected BuyState(bool isTrue) 
    {
        this.isTrue = isTrue;
    }

    public bool isTrue { get; protected set; }
    public abstract void DisplayCard();
    public abstract void PlayerHasChoosenCard();
}
