using UnityEngine;
using System.Collections;

public abstract class BuyResult { }

public class ResultResources : BuyResult
{
    Resources difference;
}

public class ResultExpensive : BuyResult
{

}