using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Civilian", menuName = "Card/Civilian")]
public class Civilian : Card
{
    public SIGN_CIVILIAN signToFreeBuy;
    public SIGN_CIVILIAN getForSign;
    public int expierience;
}
