using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

public abstract class BuyState
{
    public abstract void SetStates();
    protected List<CheckState> states = new List<CheckState>();

    public void DetermineBuyState(Buyable b)
    {
        Debug.Log(states.Count);
        CheckState stateResult = states.First(s => s.Check(b));
        b.buyState = stateResult.Result;
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
        states.Add(new CheckExpensive());
    }
}