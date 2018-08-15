public abstract class CheckState
{
    public BuyResult Result { get; protected set; } = new ResultExpensive();
    public abstract bool Check(Buyable c);
}

public class CheckResources : CheckState
{
    public override bool Check(Buyable c)
    {
        bool state = GameManager.instance._CurrentPlayer.GetResources() >= c.cost;
        Result = new ResultResources();
        return state;
    }
}

public class CheckExpensive : CheckState
{
    public override bool Check(Buyable c)
    {
        return true;
    }
}

//public class CheckGold : CheckState
//{
//    public override BuyState Check(Buyable b)
//    {
//        Player player = GameManager.instance._CurrentPlayer;
//        Debug.Log("Player gold: " + player.Gold + " >= " + ChangeResourcesForGold(b));
//        bool isEnoughGold = player.Gold >= ChangeResourcesForGold(b);
//        int different = player.Gold - ChangeResourcesForGold(b);
//        return new CardForGold(isEnoughGold, different);
//    }

//    int ChangeResourcesForGold(Buyable b)
//    {
//        Player player = GameManager.instance._CurrentPlayer;
//        Resources oponentResources = GameManager.instance.NextPlayer.GetResources();
//        Resources difference = b.cost - player.GetResources();
//        int oponentCost = Resources.GetPriceDependsOnOponentResources(difference, oponentResources);
//        return oponentCost + b.cost.gold;
//    }
//}
