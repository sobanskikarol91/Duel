public interface ICheckCard
{
    IResult Check(SlotCard s);
}

public interface ICheckBuyable
{
    IResult Check(Slot s);
}

public class CheckResult
{
    public Buyable Result { get; protected set; }
}

public class CheckResources : CheckResult, ICheckBuyable
{
    public IResult Check(Slot s)
    {
        //bool state = GameManager.instance._CurrentPlayer.GetResources() >= s.Card.cost;
        return new ResultResources(s);
    }
}

public class CheckExpensive : ICheckBuyable
{
    public IResult Check(Slot s)
    {
       return new ResultExpensive(s);
    }
}

//public class CheckGold : CheckState
//{
//    public override bool Check(SlotCard s)
//    {
//        Player player = GameManager.instance._CurrentPlayer;
//        // Debug.Log("Player gold: " + player.Gold + " >= " + ChangeResourcesForGold(b));
//        bool isEnoughGold = player.Gold >= ChangeResourcesForGold(s.Card);
//        int different = player.Gold - ChangeResourcesForGold(s.Card);
//        Result = new ResultGold(s, different);
//        return isEnoughGold;
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

//public class CheckSign : ICheckCard
//{
//    public bool Check(SlotCard s)
//    {
//        return s.Card.getForSign != SYMBOL_CARD.NONE ?
//         CheckIfPlayerHasCardSign() : false;
//    }

//    bool CheckIfPlayerHasCardSign()
//    {
//        return false;
//    }
//}
