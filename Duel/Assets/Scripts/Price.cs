using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//[System.Serializable]
//public class Resource
//{
//    public PRODUCE type;
//    public int value;
//}

[System.Serializable]
public class Price
{
    public int wood;
    public int brick;
    public int rock;
    public int glass;
    public int papyrus;
    public int gold;

    public static bool operator >=(Price p1, Price p2)
    {
        return p1.wood >= p2.wood &&
               p1.brick >= p2.brick &&
               p1.rock >= p2.rock &&
               p1.glass >= p2.glass &&
               p1.papyrus >= p2.papyrus &&
               p1.gold >= p2.gold;
    }

    public static bool operator <=(Price p1, Price p2)
    {
        return p1.wood <= p2.wood &&
               p1.brick <= p2.brick &&
               p1.rock <= p2.rock &&
               p1.glass <= p2.glass &&
               p1.papyrus <= p2.papyrus &&
               p1.gold <= p2.gold;
    }
}
