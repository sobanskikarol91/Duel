﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public  class CardAvailableManager : ResourceComparer
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

    public static void SetAvailableCards()
    {
        foreach (Slot s in _slot)
        {
            Card c = s.Card;
            if (GetCardForSymbol(c) || EnoughResources(c) || MoneyForResources(c))
                CanBuyEffects(s);
            else
                ToExpensiveEffects(s);
        }
    }

    static bool GetCardForSymbol(Card c)
    {
        return player.card_signs.Contains(c.getForSign);
    }
}
