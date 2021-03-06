﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : Singleton<GameManager>
{
    // jaszczurka jedzaca pieniadze

    const int playersCount = 2;
    public Player[] _players;
    // TODO: Player event
    public Player _CurrentPlayer { get; private set; }
    public Player NextPlayer { get; private set; }
    public Transform _slotsPosition;

    [SerializeField] WarTrackManager _warTrackManager;
    [SerializeField] WonderManager _wonderManager;
    [SerializeField] TokenManager _tokenManager;
    [SerializeField] DeckManager _cardManager;
    public ResourcesBar _ResourcesBar { get; private set; }
    public SelectedCardWindow _selectedCardWindow;

    protected override void Awake()
    {
        base.Awake();
        Init();
    }

    void Init()
    {
        _ResourcesBar = GetComponent<ResourcesBar>();
        RandomPlayer();

        _tokenManager.Init();
        _warTrackManager.Init();
        //_wonderManager.Init();
        _cardManager.Init();
        CardAvailableManager.SetCardStates();
        _ResourcesBar.UpdateBar();
    }

    void RandomPlayer()
    {
        int index = Random.Range(0, 1);
        _CurrentPlayer = _players[index];
        NextPlayer = _players[index == 0 ? 1 : 0];
    }

    public void ChangeCurrentPlayer()
    {
        //NextPlayer = _CurrentPlayer;
        //_CurrentPlayer = _CurrentPlayer == _players[0] ? _players[1] : _players[0];
        CardAvailableManager.SetCardStates();
    }

    void PrepareTurn()
    {
        _cardManager.DealCardsFromNewAge();
    }

    public void MilitaryWin()
    {

    }

    public void PlayerHasSellectedSlot(SlotCard s)
    {
        _CurrentPlayer.SelectedSlot = s;
        _selectedCardWindow.DisplayPanel(s);
    }
}
