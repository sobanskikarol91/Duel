﻿using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Civilian", menuName = "Card/Civilian")]
public class Civilian : Card
{
    public int expierience;

    Civilian()
    {
        Type = CARD_TYPE.CIVILIAN;
    }
}
