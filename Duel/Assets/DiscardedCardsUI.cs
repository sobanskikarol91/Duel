using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DiscardedCardsUI : MonoBehaviour
{
    public void ShowCardsOnScreen(List<Card> cards)
    {
        cards.ForEach(c => Debug.Log(c.name));
    }
}
