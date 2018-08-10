using UnityEngine;
using System.Collections;

public class Manufacture : Card 
{
    public PRODUCE produce;
    public int amount = 1;

    Manufacture()
    {
        Type = CARD_TYPE.MANUFACTURE;
    }
}
