using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardAvailableManager
{
    static List<Slot> _slots = new List<Slot>();

    public static void AddSlot(Slot s)
    {
        _slots.Add(s);
    }

    public static void DeleteSlot(Slot s)
    {
        _slots.Remove(s);
    }

    public static void SetCardStates()
    {
        Debug.Log("Sloty: " + _slots.Count);
        BuyStateCard _buyStateCard = new BuyStateCard();
        _slots.ForEach(s => _buyStateCard.DetermineBuyState(s));
    }
}

