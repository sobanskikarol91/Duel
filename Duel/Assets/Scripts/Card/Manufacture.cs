using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Manufacture", menuName = "Card/Manufacture")]
public class Manufacture : ProduceCard 
{
    Manufacture()
    {
        Type = CARD_TYPE.MANUFACTURE;
    }
}
