using UnityEngine;
using System.Collections;
using System;

public class BuyCard : ICardState
{
    GameManager gm;
    Card _card;
    bool isCardBought;

    public void PlayerHasChoosenCard()
    {
        gm = GameManager.instance;
        _card = gm._SelectedCardWindow.Slot.Card;
        TryBuyCard();

        if (!isCardBought) return;
        gm._SelectedCardWindow.Slot.DestroySlot();
        gm._ResourcesBar.UpdateBar();
        //    ChooseStateDependsOnBoughtCard();
    }

    void TryBuyCard()
    {
        if (HasCardASign() || HasPlayerEnoughResourceForCard())
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

    bool HasPlayerEnoughResourceForCard()
    {
        return true;
        //Price playerResources = gameManager._CurrentPlayer.Resources;
        // return playerResources >= _card.cost;
    }

    private void BuyThisCard()
    {
        gm._CurrentPlayer.BuyCard(_card);
        isCardBought = true;
    }

    void ChooseStateDependsOnBoughtCard()
    {
        //TODO:
    }

    void BoughtCard(Card c)
    {
        //Player _player = gameManager._CurrentPlayer;
        //_player._cardPositioner.AddCardToPlayerSlot(c);
        //// ChooseStateDependsOnCard(c);
        //gameManager.ChangeCurrentPlayer();
        //c.EraseFromDeck();

        //if (_cardManager.CheckIfItWasTheLastCard())
        //    PrepareTurn();
    }
}
