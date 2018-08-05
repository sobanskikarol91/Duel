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

    public Price() { wood = 0; brick = 0; rock = 0; glass = 0; papyrus = 0; gold = 0; }
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
        return p1.wood < p2.wood ||
               p1.brick < p2.brick ||
               p1.rock < p2.rock ||
               p1.glass < p2.glass ||
               p1.papyrus < p2.papyrus ||
               p1.gold < p2.gold;
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

    public static int GetPriceDependsOnOponentResources(Price cost, Price oponent)
    {
        Price result = new Price();
        result.wood = CompareCostWithOponentResources(cost.wood, oponent.wood);
        result.brick = CompareCostWithOponentResources(cost.brick, oponent.brick);
        result.rock = CompareCostWithOponentResources(cost.rock, oponent.rock);
        result.glass = CompareCostWithOponentResources(cost.glass, oponent.glass);
        result.papyrus = CompareCostWithOponentResources(cost.papyrus, oponent.papyrus);
        Debug.Log(result.wood + result.brick + result.rock);
        Debug.Log(result.GetResourcesSum());
        return result.GetResourcesSum();
    }

    static int CompareCostWithOponentResources(int resAmount, int oponentRes)
    {
        return resAmount == 0 ? 0 : Settings.ResourcesCost * resAmount + oponentRes;
    }

    public int GetResourcesSum()
    {
        return wood + brick + rock + glass + papyrus + gold;
    }
}
