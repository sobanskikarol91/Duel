using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : Singleton<GameManager>
{
    // jaszczurka jedzaca pieniadze

    const int playersCount = 2;
    public Player[] _players;
    public Player _CurrentPlayer { get; private set; }
    WonderManager _wonderManager;
    [SerializeField] CardManager _cardManager;

    void Start()
    {
        Init();
        _wonderManager.Init();
        _cardManager.Init();
    }

    void Init()
    {
        _wonderManager = GetComponent<WonderManager>();
        RandomPlayer();
    }

    void RandomPlayer()
    {
        _CurrentPlayer = _players[Random.Range(0, 1)];
    }

    public void ChangeCurrentPlayer()
    {
        _CurrentPlayer = _CurrentPlayer == _players[0] ? _players[1] : _players[0];
    }

    public void PlayerHasChoosenCard(Card c)
    {
        _CurrentPlayer._cardPositioner.AddCardToPlayerSlot(c);
        ChangeCurrentPlayer();
    }
}
