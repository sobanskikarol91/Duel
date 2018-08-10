using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Commercial", menuName = "Card/Commercial")]
public class Commercial : Card 
{
    Commercial()
    {
        Type = CARD_TYPE.COMMERCIAL;
    }
}
