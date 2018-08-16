using UnityEngine;
using System.Collections;

public abstract class Slot : Interactable
{
    [HideInInspector] public SpriteRenderer spriteRenderer;
    [HideInInspector] public Buyable Card { get { return card; } set { card = value; Init(); } }
    [HideInInspector] public IResult BuyResult { get; set; }
    public abstract void Init();
    
    private Buyable card;

    protected override void Awake()
    {
        base.Awake();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
