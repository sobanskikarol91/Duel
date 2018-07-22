using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Deck Age III", menuName = "Deck Age III")]
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
