using UnityEngine;
using System.Collections;

public abstract class Slot<CardType> : Interactable  where CardType : Buyable
{
    public SpriteRenderer spriteRenderer;
    public BuyResult buyState;

    private CardType card;

    [HideInInspector] public CardType Card { get { return card; } set { card = value; Init(); } }
   public abstract void Init();
}
