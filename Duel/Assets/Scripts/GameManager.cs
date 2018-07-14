﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : Singleton<GameManager>
{
    const int playersCount = 2;
    public Player[] _Players { get; } = new Player[2] { new Player(), new Player() };
    public Player CurrentPlayer { get; private set; }
    WonderManager _wonderManager;
   

    void Start()
    {
        Init();
        _wonderManager.Init();
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
        CurrentPlayer = _Players[Random.Range(0, 1)];
    }

    void ChangePlayerTurn()
    {
        CurrentPlayer = CurrentPlayer == _Players[0] ? _Players[1] : _Players[0];
    }
}
