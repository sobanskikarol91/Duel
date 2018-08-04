using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardAvailableManager
{
    static List<Slot> _slot = new List<Slot>();
    static Player player = GameManager.instance._CurrentPlayer;

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
            if (GetCardForSymbol(s) || EnoughResources(s) || MoneyForResources(s))
                AvailableCard(s);
            else
                NotAvailabeCard(s);
        }
    }

    static bool GetCardForSymbol(Slot s)
    {
        return player.card_signs.Contains(s.Card.getForSign);
    }

    static bool EnoughResources(Slot s)
    {
        return player.Resources <= s.Card.cost;
    }

    static bool MoneyForResources(Slot s)
    {
        Player nextPlayer = GameManager.instance.NextPlayer;

        return false;
    }

    static void AvailableCard(Slot s)
    {
        s.GetComponent<SpriteRenderer>().color = Color.white;
    }

    static void NotAvailabeCard(Slot s)
    {
        s.GetComponent<SpriteRenderer>().color = new Color32(110, 110, 110, 255);
    }
}
