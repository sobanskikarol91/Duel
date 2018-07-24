using UnityEngine;
using System.Collections;

public class PlayerActions : MonoBehaviour
{
    public void SellCard(Card c)
    {
        // Discard Card
        Player _player = GameManager.instance._CurrentPlayer;
        _player.AddGold();
        GameManager.instance.ChangeCurrentPlayer();           
    }

    public void BuildWonder(Card c, Wonder w)
    {
        // moves Card to Wonder
        // Pay
        // Do: Wonder Action
    }

    public void BuyCard(Card c)
    {

    }
}
