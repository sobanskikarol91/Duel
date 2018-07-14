using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : Singleton<GameManager>
{
    const int playersCount = 2;
    Player[] _players = new Player[2] { new Player(), new Player() };
    public List<Wonder> _wonders;
    public Player CurrentPlayer { get; private set; }

    void Start()
    {
        SetPlayersID();
        RandomPlayer();
        ShuffleWonders();
        DealPlayerWonders();
    }

    // Game Setup
    void SetPlayersID()
    {
        _players[0].Id = 0;
        _players[1].Id = 1;
    }


    void RandomPlayer()
    {
        CurrentPlayer = _players[Random.Range(0, 1)];
    }

    void ShuffleWonders()
    {
        _wonders.Shuffle();
       // _wonders.ForEach(w => w.Name());
    }

    void DealPlayerWonders()
    {
        int amount = 8;

        while (amount-- > 0)
        {
            Debug.Log(amount);
            _players.ForEach(p => p._Wonders.Add(_wonders[amount]));
        }
    }


    void ChangePlayerTurn()
    {
        CurrentPlayer = CurrentPlayer == _players[0] ? _players[1] : _players[0];
    }
}
