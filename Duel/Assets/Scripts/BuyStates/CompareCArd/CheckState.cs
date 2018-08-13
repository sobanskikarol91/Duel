using UnityEngine;
using System.Collections;

public abstract class CheckState
{
    public abstract BuyState Check(Buyable c);
}

public class CheckResources : CheckState
{
    public override BuyState Check(Buyable c)
    {
        bool state = GameManager.instance._CurrentPlayer.GetResources() >= c.cost;
        return new CardForResources(state);
    }
}

public class CheckGold : CheckState
{
    public override BuyState Check(Buyable b)
    {
        Player player = GameManager.instance._CurrentPlayer;
        Debug.Log("Player gold: " + player.Gold + " >= " + ChangeResourcesForGold(b));
        bool isEnoughGold = player.Gold >= ChangeResourcesForGold(b);
        int different = player.Gold - ChangeResourcesForGold(b);
        return new CardForGold(isEnoughGold, different);
    }

    static int ChangeResourcesForGold(Buyable b)
    {
        Player player = GameManager.instance._CurrentPlayer;
        Resources oponentResources = GameManager.instance.NextPlayer.GetResources();
        Resources difference = b.cost - player.GetResources();
        int oponentCost = Resources.GetPriceDependsOnOponentResources(difference, oponentResources);
        return oponentCost + b.cost.gold;
    }
}