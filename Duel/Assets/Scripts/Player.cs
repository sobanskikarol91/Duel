﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    List<Card> cards = new List<Card>();
    List<Wonder> wonders = new List<Wonder>();
    List<Token> tokens = new List<Token>();
    public Resources Resources { get; set; }
    public int Id { get; set; }

    private void Awake()
    {
         Resources = new Resources(7,2,2,2,2,2);
        // Resources = new Resources(7);
    }

    public bool BuyCard(Card card)
    {
        if (card.price > Resources) return false;

        Resources -= card.price;
        cards.Add(card);
        card.BuyCard();
        Resources = Resources + card.production;
        Resources.Info();
        return true;
    }
}
