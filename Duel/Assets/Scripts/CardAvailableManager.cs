﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardAvailableManager
{
    static List<SlotCard> _slots = new List<SlotCard>();

    public static void AddSlot(SlotCard s)
    {
        _slots.Add(s);
    }

    public static void DeleteSlot(SlotCard s)
    {
        _slots.Remove(s);
    }

    public static void SetCardStates()
    {
        BuyStateCard _buyStateCard = new BuyStateCard();
        _slots.ForEach(s => _buyStateCard.DetermineBuyState(s));
    }
}

