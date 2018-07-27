using UnityEngine;
using System.Collections;

public class SelectedCard : MonoBehaviour
{
    GameManager gameManager;
    Card _card;
    private void Awake()
    {
        gameManager = GameManager.instance;
    }

    public void TryBuyCard(Card c)
    {
        if (HasCardASign())
            gameManager._CurrentPlayer.AddCard(_card);
        else if (HasPlayerEnoughResourceForCard())
            _card = c;
    }

    #region Card for Sign
    bool HasCardASign()
    {
        return _card.getForSign != SIGN_CARD.NONE ?
        CheckIfPlayerHasCardSign() : false;
    }

    bool CheckIfPlayerHasCardSign()
    {
        return gameManager._CurrentPlayer.CheckSymbol(_card);
    }
    #endregion

    bool HasPlayerEnoughResourceForCard()
    {
        return gameManager._CurrentPlayer.AffordForCard(_card);
    }

    void ChooseStateDependsOnCard()
    {
        //if (c.getForSign)
        //    if (c.type == CARD_TYPE.MILITARY)
        //    {
        //        _warTrackManager.MovePawn(((Military)c).strength);
        //    }
    }
    void BoughtCard(Card c)
    {
        Player _player = gameManager._CurrentPlayer;
        _player._cardPositioner.AddCardToPlayerSlot(c);
        ChooseStateDependsOnCard(c);
        gameManager.ChangeCurrentPlayer();
        c.EraseFromDeck();

        //if (_cardManager.CheckIfItWasTheLastCard())
        //    PrepareTurn();
    }
}
