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
        gm = GameManager.instance;
        _ui = ui;
    }

    public void PlayerHasChoosenCard()
    {
        card = gm._SelectedCardWindow.Card;
        DiscardedCardsUI.instance.AddCard(card);
        GameManager.instance._CurrentPlayer.AddGold();
        DeckManager.instance._currentDeck.DiscardCard(card);
        GameManager.instance.ChangeCurrentPlayer();
        
    }
}
