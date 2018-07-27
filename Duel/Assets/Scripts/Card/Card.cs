using System.Collections;
using UnityEngine;

public class Card : ScriptableObject
{
    public Sprite cardImg;
    public Sprite reverseImg;
    [HideInInspector] public Deck _deck;
    public Price cost;
    public CARD_TYPE type;

    public SIGN_CARD signToFreeBuy = SIGN_CARD.NONE;
    public SIGN_CARD getForSign = SIGN_CARD.NONE;


    public void EraseFromDeck()
    {
        _deck.EraseCard(this);
    }
}
