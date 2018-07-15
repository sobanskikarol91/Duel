﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{ 
    Dictionary<CARD_TYPE, List<Card>> cardsDict = new Dictionary<CARD_TYPE, List<Card>>();
    public List<Wonder> _Wonders { get; set; } = new List<Wonder>();
    public CardPositioner _cardPositioner;
    public Resources Resources { get; set; }
    public int Id { get; set;}

    private void Awake()
    {
        _cardPositioner.Init();
    }
}
