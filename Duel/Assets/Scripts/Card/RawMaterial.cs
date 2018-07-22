﻿using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Materials", menuName = "Card/Materials")]
public class RawMaterial : Card
{
    public PRODUCE produce;
    public int amount = 1;
}
