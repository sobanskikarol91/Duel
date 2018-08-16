using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

public abstract class BuyState
{
    public abstract void SetStates();
    protected List<ICheckBuyable> states = new List<ICheckBuyable>();

    public void DetermineBuyState(Slot s)
    {
        Debug.Log("States:" + states.Count());
        ICheckBuyable stateResult = states.First(d => d.Check(s) != null);

        IResult res = stateResult.Check(s);

        res.Displayed();
    }
}

public class BuyStateCard : BuyState
{
    public BuyStateCard()
    {
        SetStates();
    }

    public override void SetStates()
    {
        states.Add(new CheckResources());
       // states.Add(new CheckGold());
        states.Add(new CheckExpensive());
    }
}