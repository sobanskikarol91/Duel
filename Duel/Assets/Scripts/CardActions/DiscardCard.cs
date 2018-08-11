using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DiscardCard : ICardState
{
    DiscardedCardsUI _ui;
    GameManager gm;
    Card card;

    public DiscardCard(DiscardedCardsUI ui)
    {
        _ui = ui;
    }

    public void PlayerHasChoosenCard()
    {
        gm = GameManager.instance;
        card = gm._selectedCardWindow.Card;
        DiscardedCardsUI.instance.AddCard(card);
        gm._CurrentPlayer.AddGold();
        DeckManager.instance._currentDeck.DiscardCard(card);
        gm.ChangeCurrentPlayer();
        gm._selectedCardWindow.Slot.DestroySlot();
        gm._ResourcesBar.UpdateBar();
    }
}
