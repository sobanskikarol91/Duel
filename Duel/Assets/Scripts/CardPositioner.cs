using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class CardPositioner : MonoBehaviour
{
    public Dictionary<CARD_TYPE, List<Slot>> _playerCards = new Dictionary<CARD_TYPE, List<Slot>>();
    Card _card;

    public void AddCardToPlayerSlot(Card _card)
    {
        this._card = _card;
        Slot empty = FindEmptySpotInGroup();
        empty.Card = _card;
    }

    Slot FindEmptySpotInGroup()
    {
        List<Slot> _cardGroup = GetAllSlotsForCardType();
        return _cardGroup.First(p => p.Card = null);
    }

    List<Slot> GetAllSlotsForCardType()
    {
        return _playerCards[_card.type];
    }
}
