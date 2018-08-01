using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class DiscardedCardsUI : Singleton<DiscardedCardsUI>
{
    [SerializeField] RectTransform cardsHolder;
    [SerializeField] GameObject discardedCardPrefab;

    public void AddCard(Card _card)
    {
        GameObject cardGO = Instantiate(discardedCardPrefab);
        cardGO.GetComponent<Image>().sprite = _card.cardImg;
        cardGO.transform.SetParent(cardsHolder);
        cardGO.transform.localScale = Vector3.one;
        cardGO.transform.rotation = Camera.main.transform.rotation;
        cardGO.transform.localPosition = Vector3.zero;
    }

    public void ShowCardsOnScreen()
    {
        List<Card> _discardedCards = DeckManager.instance.GetDiscardedCards();
        _discardedCards.ForEach(c => Debug.Log(c.name));

        int nr = 0;
        //_discardedCards.ForEach(d => images[nr++].sprite = d.cardImg);
    }
}
