using System.Collections;
using UnityEngine;

public class Card : ScriptableObject
{
    public Sprite cardImg;
    public Sprite reverseImg;
    [HideInInspector] public Deck _deck;
    public Price cost;
    public CARD_TYPE type;

    public void EraseFromDeck()
    {
        _deck.EraseCard(this);
    }
}
