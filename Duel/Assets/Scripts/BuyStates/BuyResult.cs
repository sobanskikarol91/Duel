using UnityEngine;
using System.Collections;

public interface IResult : IDisplayed, ISelected
{

}


public interface IDisplayed
{
    void Displayed();
}

public interface ISelected
{
    void Selected();
}

public interface IBought
{
    void Bought();
}

public class ResultResources :  IResult
{
    Resources difference;
    Slot slot;

    public ResultResources(Slot slot)
    {
        this.slot = slot;
    }

    public void Displayed()
    {
        slot.spriteRenderer.color = Color.green;
    }

    public void Selected()
    {
      
    }
}

public class ResultExpensive : IResult
{
    public ResultExpensive(Slot slot) { }
    Slot slot;

    public void Selected()
    {
        GameManager.instance._selectedCardWindow.DisableBuyButton();
    }

    public void Displayed()
    {
        slot.spriteRenderer.color = Color.red;
    }
}

public class ResultGold : IResult
{
    public int AdditionalGold { get; private set; }
    Slot slot;

    public ResultGold(SlotCard slot, int additionalGold)
    {
        this.slot = slot;
        AdditionalGold = additionalGold;
    }

    void Bought()
    {
        GameManager gm = GameManager.instance;
        //slot.DestroySlot();
        gm._CurrentPlayer.BuyCard();
        gm._ResourcesBar.UpdateBar();
        gm.ChangeCurrentPlayer();
    }

    public void Displayed()
    {
        slot.spriteRenderer.color = Color.yellow;
    }

    public void Selected()
    {
        GameManager.instance._selectedCardWindow.AditionalPayment(AdditionalGold);
    }
}