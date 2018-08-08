using System.Collections;
using UnityEngine;

public class Card : ScriptableObject
{
    public Sprite cardImg;
    public Sprite reverseImg;
    [HideInInspector] public Deck _deck;
    public Resources cost;
    public CARD_TYPE type;

    public SYMBOL_CARD signToFreeBuy = SYMBOL_CARD.NONE;
    public SYMBOL_CARD getForSign = SYMBOL_CARD.NONE;


    public void EraseFromDeck()
    {
        _deck.EraseCard(this);
    }
}
