﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[CreateAssetMenu(fileName = "Deck", menuName = "Deck")]
public class Deck : ScriptableObject
{
    [SerializeField] protected List<Card> _cards;
    public GameObject _slotsLayoutPrefab;
    List<Card> _unusedCards;
    GameObject _slotsLayout;

    [HideInInspector] public List<Slot> _slots;

    public void Init()
    {
        GetAllSlotsReferences();
        SetDeckReferenceToCards();
        ChooseCardsToDeck();
        _cards.Shuffle();
    }

    protected virtual void ChooseCardsToDeck()
    {
        DiscardUnusedCards();
    }

    void GetAllSlotsReferences()
    {
        _slots = _slotsLayout.GetComponentsInChildren<Slot>().ToList();
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
        return !_cards.Any();
    }

    public void EraseCard(Card c)
    {
        _cards.Remove(c);
    }

    public void SetLayoutPrefab(GameObject prefab)
    {
        _slotsLayout = prefab;
    }

    public void DisableDeck()
    {
        _slotsLayout.SetActive(false);
    }

    public void EnableDeck()
    {
        _slotsLayout.SetActive(true);
    }
}
