using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Military", menuName = "Card/Military")]
public class Military : Card
{
    public SIGN_MILITARY signToFreeBuy;
    public SIGN_MILITARY getForSign;
    public int strength;
}
