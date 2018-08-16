using UnityEngine;
using System.Collections.Generic;

public class SlotCard : Slot
{
    [SerializeField] public bool isVisible = true;
    [SerializeField] public List<SlotCard> coveredCards = new List<SlotCard>();
    List<SlotCard> coveredByCards = new List<SlotCard>();
    int sortingOrder;

    [HideInInspector] public new Card Card { get { return card; } set { card = value; Init(); } }
    private Card card;

    public bool IsCardDiscovered { get { return (coveredByCards.Count == 0); } }

    protected override void Awake()
    {
        base.Awake();
        CoverAllReferenceCards();
    }

    public override void Init()
    {
        if (isVisible) ShowCard();
        else HideCard();

        if (IsCardDiscovered)
            CardAvailableManager.AddSlot(this);
    }

    public void DiscoverThisCard(SlotCard byCard)
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

    public void CoverThisCard(SlotCard coverCard)
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
            GameManager.instance.PlayerHasSellectedSlot(this);
        }
    }

    private void OnMouseEnter()
    {
        if (isVisible)
        {
            sortingOrder = spriteRenderer.sortingOrder;
            gameObject.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            spriteRenderer.sortingOrder = 10;
        }
    }

    private void OnMouseExit()
    {
        if (isVisible)
        {
            gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            spriteRenderer.sortingOrder = sortingOrder;
        }
    }

    public void BuyCard()
    {
        DiscoverAllReferenceCards();
    }

    public void ShowCard()
    {
        isVisible = true;
        spriteRenderer.sprite = Card.cardImg;
    }

    void HideCard()
    {
        spriteRenderer.sprite = Card.reverseImg;
    }

    public void DestroySlot()
    {
        DiscoverAllReferenceCards();
        Destroy(gameObject);
    }

    protected override void OnDestroy()
    {
        base.OnDestroy();
        CardAvailableManager.DeleteSlot(this);
    }
}
