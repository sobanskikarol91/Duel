using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Price
{
    public int wood;
    public int brick;
    public int rock;
    public int glass;
    public int papyrus;
    public int gold;

    public Price(int wood, int brick, int rock, int glass, int papyrus, int gold)
    {
        this.wood = wood;
        this.brick = brick;
        this.rock = rock;
        this.glass = glass;
        this.papyrus = papyrus;
        this.gold = gold;
    }

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

    public static Price operator -(Price p1, Price p2)
    {
        int wood = p1.wood - p2.wood;
        int brick = p1.brick - p2.brick;
        int rock = p1.rock - p2.rock;
        int glass = p1.glass - p2.glass;
        int papyrus = p1.papyrus - p2.papyrus;
        int gold = p1.gold - p2.gold;

        return new Price(wood, brick, rock, glass, papyrus, gold);
    }

    public static Price operator +(Price p1, Price p2)
    {
        int wood = p1.wood + p2.wood;
        int brick = p1.brick + p2.brick;
        int rock = p1.rock + p2.rock;
        int glass = p1.glass + p2.glass;
        int papyrus = p1.papyrus + p2.papyrus;
        int gold = p1.gold + p2.gold;

        return new Price(wood, brick, rock, glass, papyrus, gold);
    }
}
