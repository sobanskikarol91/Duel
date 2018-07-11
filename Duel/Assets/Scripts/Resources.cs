using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Resources
{
    public int money = 0;
    public int wood = 0;
    public int brick = 0;
    public int rock = 0;
    public int papyrus = 0;
    public int glass = 0;

    public Resources(int money = 0, int wood = 0, int brick = 0, int rock = 0, int papyrus = 0, int glass = 0)
    {
        this.money = money;
        this.wood = wood;
        this.brick = brick;
        this.rock = rock;
        this.papyrus = papyrus;
        this.glass = glass;
    }

    public static Resources operator +(Resources x, Resources y)
    {
        int m = x.money + y.money;
        int w = x.wood + y.wood;
        int b = x.brick + y.brick;
        int r = x.rock + y.rock;
        int p = x.papyrus + y.papyrus;
        int g = x.glass + y.glass;
        return new Resources(m, w, b, r, p, g);
    }

    public static Resources operator -(Resources x, Resources y)
    {
        int m = x.money - y.money;
        int w = x.wood;
        int b = x.brick;
        int r = x.rock;
        int p = x.papyrus;
        int g = x.glass;
        return new Resources(m, w, b, r, p, g);
    }

    public static bool operator >(Resources x, Resources y)
    {
        Debug.Log((x.papyrus > y.papyrus) + " " + x.papyrus + " " + y.papyrus);
        return (x.money > y.money || x.wood > y.wood || x.brick > y.brick
           || x.rock > y.rock || x.papyrus > y.papyrus || x.glass > y.glass);
    }

    public static bool operator <(Resources x, Resources y)
    {
        return (x.money < y.money || x.wood < y.wood || x.brick < y.brick 
           || x.rock < y.rock || x.papyrus < y.papyrus || x.glass < y.glass);
    }

    public void Info()
    {
        Debug.Log("M: " + money + " W: " + wood + " B: " + brick + " R: " + rock + " P: " + papyrus + " G: " + glass);
    }
}
