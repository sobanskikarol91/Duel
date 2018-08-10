﻿using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Military", menuName = "Card/Military")]
public class Military : Card
{
    public int strength;

    Military()
    {
        Type = CARD_TYPE.MILITARY;
    }
}
