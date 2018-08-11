using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Materials", menuName = "Card/Materials")]
public class RawMaterial : ProduceCard
{
    RawMaterial()
    {
        Type = CARD_TYPE.RAW_MATERIAL;
    }
}
