using UnityEngine;
using System.Collections;

public class ResourceComparer
{
    protected static Player player = GameManager.instance._CurrentPlayer;

    public static bool EnoughResources(Buyable b)
    {
        Debug.Log("Enought: " + b.name + " " + (GameManager.instance._CurrentPlayer.GetResources() >= b.cost));
        return GameManager.instance._CurrentPlayer.GetResources() >= b.cost;
    }

    public static bool MoneyForResources(Buyable b)
    {
        Resources oponentResources = GameManager.instance.NextPlayer.GetResources();
        Resources difference = b.cost - player.GetResources();
        int oponentCost = Resources.GetPriceDependsOnOponentResources(difference, oponentResources);
        return player.Gold >= oponentCost + difference.gold;
    }

    protected static void CanBuyEffects(Slot s)
    {
        s.GetComponent<SpriteRenderer>().color = Color.white;
    }

    protected static void ToExpensiveEffects(Slot s)
    {
        Debug.Log("Too Expensive: " + s.Card.name);
        s.GetComponent<SpriteRenderer>().color = Settings.toExpensiveCard;
    }
}
