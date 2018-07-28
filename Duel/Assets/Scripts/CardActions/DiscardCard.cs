using UnityEngine;
using System.Collections;

public class DiscardCard : ICardState
{
    public void PlayerHasChoosenCard(Card card)
    {
        GameManager.instance._CurrentPlayer.AddGold();
        //DeckManager.instance._currentDeck.DiscardCard(card);
        //GameManager.instance.ChangeCurrentPlayer();
    }
}
