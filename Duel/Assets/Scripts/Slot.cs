using UnityEngine;
using System.Collections.Generic;

public class Slot : MonoBehaviour
{
    public Card Card { get; set; }
    [SerializeField] public bool isVisible = true;

    [SerializeField] public List<Slot> coveredCards = new List<Slot>();
    List<Slot> coveredByCards = new List<Slot>();

    private void Awake()
    {
        CoverAllReferenceCards();
    }

    // subscribe
    public void CoverThisCard(Slot coverCard)
    {
        coveredByCards.Add(coverCard);
    }

    // unsubscribe
    public void DiscoverThisCard(Slot byCard)
    {
        coveredByCards.Remove(byCard);
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

    bool isCardDiscovered() { return (coveredByCards.Count == 0); }

    private void OnMouseDown()
    {
        if (isCardDiscovered())
        {
            // TODO: check if player has enough resources to buy this card
            GameManager.instance.SelectedCard(Card);
        }
    }

    public void BuyCard()
    {
        DiscoverAllReferenceCards();
    }

    public void ShowCard(bool state)
    {
        if (!isCardDiscovered()) return;

        GetComponent<SpriteRenderer>().sprite = Card.cardImg;
    }
}
