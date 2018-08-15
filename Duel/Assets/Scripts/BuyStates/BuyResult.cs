using UnityEngine;
using System.Collections;

public abstract class BuyResult : MonoBehaviour
{
    protected SlotCard slot;
    public BuyResult(SlotCard slot)
    {
        this.slot = slot;
    }
    public abstract void Displayed();
    //public abstract void Selected();
    //public abstract void Bought();
}

public class ResultResources : BuyResult
{
    Resources difference;

    public ResultResources(SlotCard slot) : base(slot) { }

    public override void Displayed()
    {
        slot.spriteRenderer.color = Color.green;
    }
}

public class ResultExpensive : BuyResult
{
    public ResultExpensive(SlotCard slot) : base(slot) { }

    public override void Displayed()
    {
        slot.spriteRenderer.color = Color.red;
    }
}

public class ResultGold : BuyResult
{
    public ResultGold(SlotCard slot) : base(slot) { }

    public override void Displayed()
    {
        slot.spriteRenderer.color = Color.yellow;
    }
}