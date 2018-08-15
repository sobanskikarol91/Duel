using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardAvailableManager
{
    static List<Slot> _slot = new List<Slot>();

    public static void AddSlot(Slot s)
    {
        _slot.Add(s);
    }

    public static void DeleteSlot(Slot s)
    {
        _slot.Remove(s);
    }

    public static void SetCardStates()
    {
        List<Card> _cards = new List<Card>();
        //TODO uproscic

        _slot.ForEach(s => _cards.Add(s.Card));

        BuyStateCard _buyStateCard = new BuyStateCard();
        _cards.ForEach(c => _buyStateCard.DetermineBuyState(c));
    }
}
