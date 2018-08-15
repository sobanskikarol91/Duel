using UnityEngine;
using System.Collections;

public abstract class Slot<CardType> : Interactable where CardType : Buyable
{
    [HideInInspector] public SpriteRenderer spriteRenderer;
    [HideInInspector] public CardType Card { get { return card; } set { card = value; Init(); } }
    [HideInInspector] public BuyResult BuyResult { get; set; }
    public abstract void Init();
    
    private CardType card;

    protected override void Awake()
    {
        base.Awake();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
