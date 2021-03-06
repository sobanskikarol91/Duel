﻿using System.Collections;
using UnityEngine;

public class Card : Buyable
{
    public Sprite cardImg;
    public Sprite reverseImg;
    [HideInInspector] public Deck _deck;

    public CARD_TYPE Type { get; protected set; } = CARD_TYPE.NONE;
    public SYMBOL_CARD signToFreeBuy = SYMBOL_CARD.NONE;
    public SYMBOL_CARD getForSign = SYMBOL_CARD.NONE;


    public void EraseFromDeck()
    {
        _deck.EraseCard(this);
    }
}
