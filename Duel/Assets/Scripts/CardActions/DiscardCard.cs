using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DiscardCard : ICardState
{
    DiscardedCardsUI _ui;
    public DiscardCard(DiscardedCardsUI ui)
    {
        _ui = ui;
    }

    public void PlayerHasChoosenCard(Card card)
    {
        DiscardedCardsUI.instance.AddCard(card);
        GameManager.instance._CurrentPlayer.AddGold();
        DeckManager.instance._currentDeck.DiscardCard(card);
        _ui.ShowCardsOnScreen();
        GameManager.instance.ChangeCurrentPlayer();
    }
}
