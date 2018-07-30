using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class DiscardedCardsUI : MonoBehaviour
{
    [SerializeField] Image[] images = new Image[4];

    public void ShowCardsOnScreen()
    {
        List<Card> _discardedCards = DeckManager.instance.GetDiscardedCards();
        _discardedCards.ForEach(c => Debug.Log(c.name));

        int nr = 0;
        _discardedCards.ForEach(d => images[nr++].sprite = d.cardImg);
    }
}
