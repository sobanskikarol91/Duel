using UnityEngine;
using System.Collections;
using System;

public class ConflictToken
{
    public bool IsDiscarded { get; private set; }
    int goldToDiscard;
    Action<int> ErasePlayerMoney;
    VisualConflictToken _visualToken;

    public ConflictToken(Action<int> eraseMoneyMethod, int value, VisualConflictToken _visual)
    {
        _visualToken = _visual;
        goldToDiscard = value;
        ErasePlayerMoney = eraseMoneyMethod;
    }

    public void DiscardIt()
    {
        if (IsDiscarded) return;

        _visualToken.DestroyIt();
        ErasePlayerMoney(goldToDiscard);
        IsDiscarded = true;
    }
}
