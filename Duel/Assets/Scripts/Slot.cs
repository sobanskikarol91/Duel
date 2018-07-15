using UnityEngine;
using System.Collections.Generic;

public class Slot : MonoBehaviour
{
    [SerializeField] public bool isVisible = true;
    [SerializeField] public List<Slot> coveredCards = new List<Slot>();
    List<Slot> coveredByCards = new List<Slot>();

    private SpriteRenderer spriteRenderer;

    private Card card;
    [HideInInspector] public Card Card { get { return card; } set { card = value; Init(); } }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Init()
    {
        if (isVisible) ShowCard(true);
        CoverAllReferenceCards();
    }

    public void CoverThisCard(Slot coverCard)
    {
        coveredByCards.Add(coverCard);
    }

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
            GameManager.instance.PlayerHasChoosenCard(card);
            DiscoverAllReferenceCards();
            Destroy(gameObject);
        }
    }

    private void OnMouseEnter()
    {
        if (isCardDiscovered()) ;

    }

    private void OnMouseExit()
    {
        if (isCardDiscovered()) ;

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
