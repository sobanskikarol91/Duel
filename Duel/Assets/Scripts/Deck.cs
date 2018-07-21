using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[System.Serializable]
public class Deck 
{
    [SerializeField] List<Card> _cards;
    List<Card> _unusedCards;
    public GameObject _slotsLayoutPrefab;
    GameObject _slotsLayout;

    Slot[] _slots;

    public void Init()
    {
        CreateSlotsLayout();
        SetDeckReferenceToCards();
        _slots.Shuffle();
        DiscardUnusedCards();
    }

    public void CreateSlotsLayout()
    {
        _slots = _slotsLayoutPrefab.GetComponentsInChildren<Slot>();
    }

    public void SetDeckReferenceToCards()
    {
        _cards.ForEach(c => c._deck = this);
    }

    void DiscardUnusedCards()
    {
        int slotsAmount = _slots.Count();
        int count = _cards.Count - slotsAmount;

        _unusedCards = _cards.RemoveAndGetRange(slotsAmount - 1, count);
    }

    public void DealCards()
    {
        int nr = 0;
        _slots.ForEach(p => p.Card = _cards[nr++]);
    }

    public bool IsEmpty()
    {
        return _cards.Any();
    }

    public void EraseCard(Card c)
    {
        _cards.Remove(c);
    }
}
