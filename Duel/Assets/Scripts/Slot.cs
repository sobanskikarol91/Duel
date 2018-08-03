using UnityEngine;
using System.Collections.Generic;

public class Slot : MonoBehaviour
{
    [SerializeField] public bool isVisible = true;
    [SerializeField] public List<Slot> coveredCards = new List<Slot>();
    List<Slot> coveredByCards = new List<Slot>();

    private SpriteRenderer spriteRenderer;

    private Card card;
    int sortingOrder;
    [HideInInspector] public Card Card { get { return card; } set { card = value; Init(); } }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Init()
    {
        if (isVisible) ShowCard();
        else HideCard();
        CoverAllReferenceCards();
    }

    public void CoverThisCard(Slot coverCard)
    {
        coveredByCards.Add(coverCard);
    }

    public void DiscoverThisCard(Slot byCard)
    {
        coveredByCards.Remove(byCard);
        if (isCardDiscovered()) ShowCard();
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
            CardStateMachine.instance.DiscardCard(card);
            DiscoverAllReferenceCards();
            Destroy(gameObject);
        }
    }

    private void OnMouseEnter()
    {
        if (isVisible)
        {
            sortingOrder = GetComponent<SpriteRenderer>().sortingOrder;
            gameObject.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            //gameObject.transform.position += new Vector3(0, 0, -0.1f);
            //SlotWindow.ActivePanelOnPos(gameObject.transform.position);
            GetComponent<SpriteRenderer>().sortingOrder = 10;
        }
    }

    private void OnMouseExit()
    {
        if (isVisible)
        {
            gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            GetComponent<SpriteRenderer>().sortingOrder = sortingOrder;
            //gameObject.transform.position += new Vector3(0, 0, +0.1f);
            // SlotWindow.DeactivePanel();
        }
    }

    public void BuyCard()
    {
        DiscoverAllReferenceCards();
    }

    public void ShowCard()
    {
        spriteRenderer.sprite = Card.cardImg;
    }

    void HideCard()
    {
        spriteRenderer.sprite = Card.reverseImg;
    }
}
