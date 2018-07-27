using UnityEngine;
using System.Collections;
using System;

public class SelectedCard : MonoBehaviour
{
    GameManager gameManager;
    Card _card;
    bool isCardBought;

    private void Awake()
    {
        gameManager = GameManager.instance;
    }

    void PlayerHasSelectedCard(Card c)
    {
        _card = c;
        TryBuyCard();

        if (isCardBought)
            ChooseStateDependsOnBoughtCard();
    }

    void TryBuyCard()
    {
        if (HasCardASign() || HasPlayerEnoughResourceForCard())
            BuyCard();
    }

    bool HasCardASign()
    {
        return _card.getForSign != SIGN_CARD.NONE ?
        CheckIfPlayerHasCardSign() : false;
    }

    bool CheckIfPlayerHasCardSign()
    {
        return gameManager._CurrentPlayer.CheckSymbol(_card);
    }

    bool HasPlayerEnoughResourceForCard()
    {
        return gameManager._CurrentPlayer.AffordForCard(_card);
    }

    private void BuyCard()
    {
        gameManager._CurrentPlayer.AddCard(_card);
        isCardBought = true;
    }

    void ChooseStateDependsOnBoughtCard()
    {
        //if(_card.type == CARD_TYPE.MILITARY)
        //{
        //    GameManager.instance.pa
        //}
    }

    void BoughtCard(Card c)
    {
        // Player _player = gameManager._CurrentPlayer;
        // _player._cardPositioner.AddCardToPlayerSlot(c);
        //// ChooseStateDependsOnCard(c);
        // gameManager.ChangeCurrentPlayer();
        // c.EraseFromDeck();

        //if (_cardManager.CheckIfItWasTheLastCard())
        //    PrepareTurn();
    }
}
