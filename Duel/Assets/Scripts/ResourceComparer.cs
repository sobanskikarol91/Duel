using UnityEngine;
using System.Collections;

public class ResourceComparer
{
    protected static Player player = GameManager.instance._CurrentPlayer;

    public static bool EnoughResources(Buyable b)
    {
        return GameManager.instance._CurrentPlayer.GetResources() >= b.cost;
    }

    public static int ChangeResourcesForGold(Buyable b)
    {
        Resources oponentResources = GameManager.instance.NextPlayer.GetResources();
        Resources difference = b.cost - player.GetResources();
        int oponentCost = Resources.GetPriceDependsOnOponentResources(difference, oponentResources);
        return oponentCost + b.cost.gold;
    }

    public static bool EnoughGoldToResources(Buyable b)
    {
        Debug.Log("Player gold: " + player.Gold + " >= " + ChangeResourcesForGold(b));
        return player.Gold >= ChangeResourcesForGold(b);
    }

    protected static void CanBuyEffects(Slot s)
    {
        s.GetComponent<SpriteRenderer>().color = Color.white;
    }

    protected static void ToExpensiveEffects(Slot s)
    {
        s.GetComponent<SpriteRenderer>().color = Settings.toExpensiveCard;
    }
}
