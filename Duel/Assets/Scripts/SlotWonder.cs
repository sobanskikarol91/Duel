using UnityEngine;
using System.Collections;

public class SlotWonder : Slot
{
    public override void Init()
    {
        CardAvailableManager.AddSlot(this);
    }

    protected override void Awake()
    {
        base.Awake();
        Init();
    }
}
