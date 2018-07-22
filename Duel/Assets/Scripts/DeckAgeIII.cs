using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DeckAgeIII : Deck
{
    const int guildAmount = 3;
    [SerializeField] List<Card> guildCards;

    protected override void ChooseCardsToDeck()
    {
        AddGuildCards();
    }

    void AddGuildCards()
    {
        guildCards.Shuffle();
        List<Card> choosenCards = guildCards.RemoveAndGetRange(0, 3);
        _cards.AddRange(choosenCards);
    }
}
