﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Wonder> _Wonders { get; set; } = new List<Wonder>();
    public PlayerDeck _playerDeck;
    public int Gold { get; private set; } = Settings.StartGold;
    public List<ConflictToken> _conflictTokens;
    public List<SYMBOL_CARD> card_signs;
    public int Id;

    private void Awake()
    {
        _playerDeck.Init(this);
    }

    public void Pay(int value)
    {
        Debug.Log("Money erased:" + value);
    }

    public void AddGold()
    {
        Debug.Log(GoldenCardsCount() + " gold");
        Gold += GoldenCardsCount() + Settings.CardCost;
        Debug.Log("Hajs " + Gold);
    }

    int GoldenCardsCount()
    {
        return _playerDeck._cards.ContainsKey(CARD_TYPE.COMMERCIAL) ?
            _playerDeck._cards[CARD_TYPE.COMMERCIAL].Where(c => c._card != null).Count() : 0;
    }

    public void BuyCard(Card c)
    {
        Gold -= c.cost.gold;
        _playerDeck.AddCardToPlayerSlot(c);
    }

    public int GetResources(PRODUCE type)
    {
        List<PlayerCard> _playerCards = new List<PlayerCard>();

        if (type == PRODUCE.GLASS || type == PRODUCE.PAPYRUS)
            _playerDeck._cards.TryGetValue(CARD_TYPE.MANUFACTURE, out _playerCards);
        else
            _playerDeck._cards.TryGetValue(CARD_TYPE.RAW_MATERIAL, out _playerCards);

        List<ProduceCard> produceCards = new List<ProduceCard>();
        _playerCards?.ForEach(p => produceCards.Add((ProduceCard)p?._card));
        return produceCards.Where(p => p?.produce == type).Count();
    }

    public Resources GetResources()
    {
        Resources r = new Resources();
        r.wood = GetResources(PRODUCE.WOOD);
        r.brick = GetResources(PRODUCE.BRICK);
        r.rock = GetResources(PRODUCE.ROCK);
        r.glass = GetResources(PRODUCE.GLASS);
        r.papyrus = GetResources(PRODUCE.PAPYRUS);
        r.gold = Gold;
        return r;
    }
}
