using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[System.Serializable]
public class Deck
{
    [SerializeField] List<Card> _cards;
    List<Card> _unusedCards;

    public Slot[] _slots;

    public void Init()
    {
        SetDeckReferenceToCards();
        _slots.Shuffle();
        DiscardUnusedCards();
    }

    public void DealCards()
    {
        int nr = 0;
        _slots.ForEach(p => p.Card = _cards[nr++]);
    }

    void DiscardUnusedCards()
    {
        int slotsAmount = _slots.Count();
        int count =  _cards.Count - slotsAmount;
        Debug.Log(slotsAmount + " " + count + " " + _cards.Count);

        _unusedCards = _cards.RemoveAndGetRange(slotsAmount-1, count);

    }

    public bool IsEmpty()
    {
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
