using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Card : MonoBehaviour
{
    [SerializeField] public List<Card> coveredCards = new List<Card>();
    [SerializeField] public Resources price;

    List<Card> coveredByCards = new List<Card>();

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
        if (IsCardCovered()) ;
    }

    void BoughtByPlayer()
    {
        coveredCards.ForEach(p => p.DiscoverThisCard(this));
    }

    void CoverAllReferenceCards()
    {
        coveredCards.ForEach(p => p.CoverThisCard(this));
    }

    void DiscoverAllReferenceCards()
    {
        coveredCards.ForEach(p => p.DiscoverThisCard(this));
    }

    bool IsCardCovered() { return (coveredByCards.Count == 0); }

    private void OnMouseDown()
    {
        if (IsCardCovered())
        {
            GameManager.instance.SelectedCard(this);
            gameObject.SetActive(false);
            DiscoverAllReferenceCards();
        }
    }
}
