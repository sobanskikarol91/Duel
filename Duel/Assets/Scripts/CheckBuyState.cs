﻿public abstract class CheckState
{
    public BuyResult Result { get; protected set; }
    public abstract bool Check(SlotCard s);
}

public class CheckResources : CheckState
{
    public override bool Check(SlotCard s)
    {
        bool state = GameManager.instance._CurrentPlayer.GetResources() >= s.Card.cost;
        Result = new ResultResources(s);
        return state;
    }
}

public class CheckExpensive : CheckState
{
    public override bool Check(SlotCard s)
    {
        Result = new ResultExpensive(s);
        return true;
    }
}

public class CheckGold : CheckState
{
    public override bool Check(SlotCard s)
    {
        Player player = GameManager.instance._CurrentPlayer;
        // Debug.Log("Player gold: " + player.Gold + " >= " + ChangeResourcesForGold(b));
        bool isEnoughGold = player.Gold >= ChangeResourcesForGold(s.Card);
        int different = player.Gold - ChangeResourcesForGold(s.Card);
        Result = new ResultGold(s, different);
        return isEnoughGold;
    }

    int ChangeResourcesForGold(Buyable b)
    {
        Player player = GameManager.instance._CurrentPlayer;
        Resources oponentResources = GameManager.instance.NextPlayer.GetResources();
        Resources difference = b.cost - player.GetResources();
        int oponentCost = Resources.GetPriceDependsOnOponentResources(difference, oponentResources);
        return oponentCost + b.cost.gold;
    }
}

public class CheckSign : CheckState
{
    public override bool Check(SlotCard s)
    {
        return s.Card.getForSign != SYMBOL_CARD.NONE ?
        CheckIfPlayerHasCardSign() : false;
    }

    bool CheckIfPlayerHasCardSign()
    {
        return false;
    }
}
 