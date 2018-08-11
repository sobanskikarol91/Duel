using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class DiscardedCardsUI : Singleton<DiscardedCardsUI>
{
    [SerializeField] GameObject discardCardWindow;
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
        bool state = discardCardWindow.gameObject.active ? false : true;
        discardCardWindow.gameObject.SetActive(state);
    }
}
