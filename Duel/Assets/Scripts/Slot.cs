using UnityEngine;
using System.Collections.Generic;

public class Slot : MonoBehaviour
{
    [SerializeField] public bool isVisible = true;
    [SerializeField] public List<Slot> coveredCards = new List<Slot>();
    List<Slot> coveredByCards = new List<Slot>();

    private SpriteRenderer spriteRenderer;
    private Card card;

    [HideInInspector] public Card Card { get { return card; } set { card = value; Initial(); } }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Initial()
    {
        if (isVisible) ShowCard(true);
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

        if (isCardDiscovered()) ShowCard(true);
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
            DiscoverAllReferenceCards();
            GameManager.instance.SelectedCard(Card);
            Destroy(gameObject);
        }

        Debug.Log("B: " + coveredByCards.Count);
    }

    public void BuyCard()
    {
        DiscoverAllReferenceCards();
    }

    public void ShowCard(bool state)
    {
        spriteRenderer.sprite = Card.cardImg;
    }
}
