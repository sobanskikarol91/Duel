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
    public bool IsCardDiscovered { get { return (coveredByCards.Count == 0); } }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        CoverAllReferenceCards();
    }

    public void Init()
    {
        if (isVisible) ShowCard();
        else HideCard(); 

        if (IsCardDiscovered)
            CardAvailableManager.AddSlot(this);
    }

    public void DiscoverThisCard(Slot byCard)
    {
        coveredByCards.Remove(byCard);

        if (IsCardDiscovered)
        {
            ShowCard();
            CardAvailableManager.AddSlot(this);
        }
    }

    void CoverAllReferenceCards()
    {
        coveredCards.ForEach(p => p.CoverThisCard(this));
    }

    public void CoverThisCard(Slot coverCard)
    {
        coveredByCards.Add(coverCard);
    }

    void DiscoverAllReferenceCards()
    {
        coveredCards.ForEach(p => p.DiscoverThisCard(this));
    }

    private void OnMouseDown()
    {
        if (IsCardDiscovered)
        {
            CardStateMachine.instance.BuyCard(card);
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
