using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Science", menuName = "Card/Science")]
public class Science : Card
{
    public int expierience;
    public SYMBOL_SCIENCE symbol = SYMBOL_SCIENCE.NONE;

    Science()
    {
        Type = CARD_TYPE.SCIENTIFIC;
    }
}
