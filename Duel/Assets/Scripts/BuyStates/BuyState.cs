using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

public abstract class BuyState
{
    CheckState[] states;
    Buyable b;

    public Buy FindCorrectState(CheckState[] states, Buyable b)
    {
        return GetStatesResult();
    }

    Buy GetStatesResult()
    {
        List<CheckState> stateResult = states.Where(s => s.Check(b)).ToList();

        return GetOneCorrectState(stateResult);
    }

    Buy GetOneCorrectState(List<CheckState> states)
    {
        return new Buy();
        // check all states
    }
}

public class Buy
{
    //public bool isTrue { get; protected set; }
}

public class ResultResources : Buy
{
    Resources difference;
}

public class ResultExpensive : Buy
{
 
}