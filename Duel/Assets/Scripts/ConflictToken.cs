using UnityEngine;
using System.Collections;
using System;

public class ConflictToken
{
    public bool IsDiscarded { get; private set; }
    int goldToDiscard;
    Action<int> ErasePlayerMoney;
    //GameObject _visualToken;

    public ConflictToken(Action<int> eraseMoneyMethod, int value)
    {
       // _visualToken = token;
        goldToDiscard = value;
        ErasePlayerMoney = eraseMoneyMethod;
    }

    public void DiscardIt()
    {
        if (IsDiscarded) return;

       
        ErasePlayerMoney(goldToDiscard);
        IsDiscarded = true;
    }
}
