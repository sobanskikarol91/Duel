using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Card : MonoBehaviour
{
    public List<Card> coveredCards;
    public List<Card> coveredByCards;
    int price;

    private void Start()
    {
        CoverAllReferenceCards(); 
    }

    // subscribe
    public void CoverThisCard(Card coverCard)
    {
        coveredByCards.Add(coverCard);
    }

    // unsubscribe
    public void DiscoverThisCard(Card byCard)
    {
        coveredByCards.Remove(byCard);
        ShowCard();
    }

    void ShowCard()
    {
        if (coveredByCards.Count == 0) ;
    }

    void BoughtByPlayer()
    {
        coveredCards.ForEach(p => p.DiscoverThisCard(this));
    }

    void CoverAllReferenceCards()
    {
        coveredCards.ForEach(p => p.CoverThisCard(this));
    }
}
