using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardAvailableManager
{
    static List<Slot> _slot = new List<Slot>();

    public static void AddSlot(Slot s)
    {
        Debug.Log("Dodaj karte");
        _slot.Add(s);
    }

    public static void SetAvailableCards()
    {
        Debug.Log("Dostepne karty:" + _slot.Count);
        Player player = GameManager.instance._CurrentPlayer;

        foreach (Slot s in _slot)
        {
            if (player.Resources <= s.Card.cost)
                NotAvailabeCard(s);
            else
                AvailableCard(s);

        }
    }

    static void AvailableCard(Slot s)
    {
        s.GetComponent<SpriteRenderer>().color = Color.white;
    }

    static void NotAvailabeCard(Slot s)
    {
        s.GetComponent<SpriteRenderer>().color = new Color32(100,100,100,255);
    }
}
