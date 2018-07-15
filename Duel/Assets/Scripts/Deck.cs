using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Deck
{
    public List<Card> _cards;
    public Slot[] _slots;

    public void Shuffle()
    {
        _cards.Shuffle();
    }

    public void DealCads()
    {
        int nr = 0;
        _slots.ForEach(p => p.Card = _cards[nr++]);
    }
}
