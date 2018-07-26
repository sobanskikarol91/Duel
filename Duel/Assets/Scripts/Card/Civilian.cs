using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Civilian", menuName = "Card/Civilian")]
public class Civilian : Card, ICardWithSign<Civilian>
{
    public SIGN_CIVILIAN signToFreeBuy;
    public SIGN_CIVILIAN getForSign;
    public int expierience;

    public bool CheckSign(Civilian card)
    {
        return card.getForSign == signToFreeBuy;
    }
}
