using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[System.Serializable]
public class Deck
{
    public List<Card> _cards;
    public Slot[] _slots;

    public void DealCards()
    {
        int nr = 0;
        _slots.ForEach(p => p.Card = _cards[nr++]);
    }

    public bool IsEmpty()
    {
        Debug.Log(_cards.Count);
        return _cards.Any();
    }

    public void SetDeckReferenceToCards()
    {
        _cards.ForEach(c => c._deck = this);
    }

    public void EraseCard(Card c)
    {
        _cards.Remove(c);
    }
}
