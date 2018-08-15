using UnityEngine;
using System.Collections;
using System;

public class BuyCard : ICardState
{
    GameManager gm;

    public BuyCard()
    {
        gm = GameManager.instance;
    }

    public void PlayerHasChoosenCard()
    {
        //gm._CurrentPlayer.BuyCard();
        //gm._selectedCardWindow.Slot.DestroySlot();
        //gm._ResourcesBar.UpdateBar();
        //gm.ChangeCurrentPlayer();
    }
}
