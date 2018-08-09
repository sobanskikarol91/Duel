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
            Card c = s.Card;
            if (GetCardForSymbol(c) || EnoughResources(c) || MoneyForResources(c))
                AvailableCard(s);
            else
                NotAvailabeCard(s);
        }
    }

    static bool GetCardForSymbol(Card c)
    {
        return player.card_signs.Contains(c.getForSign);
    }

    static bool EnoughResources(Card c)
    {
        Debug.Log("Koszt:" + (player.GetResources() >= c.cost));
        return player.GetResources() >= c.cost;
    }

    static bool MoneyForResources(Card c)
    {
        Resources oponentResources = GameManager.instance.NextPlayer.GetResources();
        Resources difference = player.GetResources() - c.cost;
        int cost = Resources.GetPriceDependsOnOponentResources(difference, oponentResources);
        Debug.Log("Cost: " + cost);
        return player.Gold >= cost;
    }

    static void AvailableCard(Slot s)
    {
        s.GetComponent<SpriteRenderer>().color = Color.white;
    }

    static void NotAvailabeCard(Slot s)
    {
        s.GetComponent<SpriteRenderer>().color = Settings.toExpensiveCard;
    }
}
