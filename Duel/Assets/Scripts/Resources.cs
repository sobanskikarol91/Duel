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
    public SIGN sign;

    public Resources(int money = 7, int wood = 0, int brick = 0, int rock = 0, int papytus = 0, int glass = 0)
    {
        this.money = money;
        this.wood = wood;
        this.brick = brick;
        this.rock = rock;
        this.papyrus = papytus;
        this.glass = glass;
    }
}
