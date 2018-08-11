using UnityEngine;
using System.Collections;

public class DiscardCardDeck : MonoBehaviour 
{
    private void OnMouseDown()
    {
        DiscardedCardsUI.instance.ShowCardsOnScreen();
    }
}
