using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : Singleton<GameManager>
{
    // jaszczurka jedzaca pieniadze

    const int playersCount = 2;
    public Player[] _players;
    // TODO: Player event
    public Player _CurrentPlayer { get; private set; }
    public Player _NextPlayer { get; private set; }
    public Transform _slotsPosition;

    WarTrackManager _warTrackManager;
    WonderManager _wonderManager;
    TokenManager _tokenManager;
    DeckManager _cardManager;

    void Start()
    {
        Init();
    }

    void Init()
    {
        _cardManager = GetComponent<DeckManager>();
        _tokenManager = GetComponent<TokenManager>();
        _wonderManager = GetComponent<WonderManager>();
        _warTrackManager = GetComponent<WarTrackManager>();

        RandomPlayer();
        _tokenManager.Init();
        _warTrackManager.Init();
        //_wonderManager.Init();
        _cardManager.Init();    
        CardAvailableManager.SetAvailableCards();
    }

    void RandomPlayer()
    {
        int index = Random.Range(0, 1);
        _CurrentPlayer = _players[index];
        _NextPlayer = _players[index == 0 ? 1 : 0];
    }

    public void ChangeCurrentPlayer()
    {
        _NextPlayer = _CurrentPlayer;
        _CurrentPlayer = _CurrentPlayer == _players[0] ? _players[1] : _players[0];
        CardAvailableManager.SetAvailableCards();
    }

    void PrepareTurn()
    {
        _cardManager.DealCardsFromNewAge();
    }

    public void MilitaryWin()
    {

    }
}
