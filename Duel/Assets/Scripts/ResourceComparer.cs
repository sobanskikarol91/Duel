using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ResourceComparer
{
    protected static List<BuyState> _states;
    protected static Player player = GameManager.instance._CurrentPlayer;

    public static CardForResources EnoughResources(Buyable b)
    {
        bool state = GameManager.instance._CurrentPlayer.GetResources() >= b.cost;
        return new CardForResources(state);
    }

    static int ChangeResourcesForGold(Buyable b)
    {
        Resources oponentResources = GameManager.instance.NextPlayer.GetResources();
        Resources difference = b.cost - player.GetResources();
        int oponentCost = Resources.GetPriceDependsOnOponentResources(difference, oponentResources);
        return oponentCost + b.cost.gold;
    }

    public static CardForGold EnoughGoldToResources(Buyable b)
    {
        Debug.Log("Player gold: " + player.Gold + " >= " + ChangeResourcesForGold(b));
        bool isEnoughGold = player.Gold >= ChangeResourcesForGold(b);
        int different = player.Gold - ChangeResourcesForGold(b);
        return new CardForGold(isEnoughGold, different);
    }
}
