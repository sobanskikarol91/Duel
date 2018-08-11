using UnityEngine;
using System.Collections;
using System;

public class BuyCard : ICardState
{
    GameManager gm;
    Card _card;
    bool isCardBought;

    public BuyCard()
    {
        gm = GameManager.instance;
    }

    public void PlayerHasChoosenCard()
    {
        _card = gm._SelectedCardWindow.Slot.Card;
        TryBuyCard();
    }

    void TryBuyCard()
    {
        if (HasCardASign() || EnoughResources())
            BuyThisCard();
    }

    bool HasCardASign()
    {
        return _card.getForSign != SYMBOL_CARD.NONE ?
        CheckIfPlayerHasCardSign() : false;
    }

    bool CheckIfPlayerHasCardSign()
    {
        return gm._CurrentPlayer._playerDeck.CheckSymbol(_card);
    }

    bool EnoughResources()
    {
        return gm._CurrentPlayer.GetResources() >= _card.cost;
    }

    private void BuyThisCard()
    {
        gm._CurrentPlayer.BuyCard(_card);
        isCardBought = true;
        gm._SelectedCardWindow.Slot.DestroySlot();
        gm._ResourcesBar.UpdateBar();
    }


    void ChooseStateDependsOnBoughtCard()
    {
        //TODO:
    }
}
