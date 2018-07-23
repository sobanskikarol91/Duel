using UnityEngine;
using System.Collections;
using System;

public class ConflictToken : MonoBehaviour
{
    bool IsDiscarded { get; }
    int goldToDiscard;
    Action<int> ErasePlayerMoney;

    public ConflictToken(Action<int> eraseMoneyMethod, int value)
    {
        ErasePlayerMoney = eraseMoneyMethod;
    }

    public void DiscardIt()
    {
        ErasePlayerMoney(goldToDiscard);
    }
}
