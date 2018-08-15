using UnityEngine;
using System.Collections;

public abstract class BuyResult : MonoBehaviour
{
    protected Slot slot;
    public BuyResult(Slot slot)
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

    public ResultResources(Slot slot) : base(slot) { }

    public override void Displayed()
    {
        slot.spriteRenderer.color = Color.green;
    }
}

public class ResultExpensive : BuyResult
{
    public ResultExpensive(Slot slot) : base(slot) { }

    public override void Displayed()
    {
        slot.spriteRenderer.color = Color.red;
    }
}

public class ResultGold : BuyResult
{
    public ResultGold(Slot slot) : base(slot) { }

    public override void Displayed()
    {
        slot.spriteRenderer.color = Color.yellow;
    }
}