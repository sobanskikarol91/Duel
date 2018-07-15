using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : Singleton<GameManager>
{
    const int playersCount = 2;
    public Player[] _Players { get; } = new Player[2] { new Player(), new Player() };
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

        SetPlayersID();
        RandomPlayer();
    }

    // Game Setup
    void SetPlayersID()
    {
        _Players[0].Id = 0;
        _Players[1].Id = 1;
    }

    void RandomPlayer()
    {
        _CurrentPlayer = _Players[Random.Range(0, 1)];
    }

    public void ChangePlayerTurn()
    {
        _CurrentPlayer = _CurrentPlayer == _Players[0] ? _Players[1] : _Players[0];
    }

    public void PlayerHasChoosenCard(Card c)
    {

    }
}
