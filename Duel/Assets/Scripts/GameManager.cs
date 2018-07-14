using UnityEngine;
using System.Collections;

public class GameManager : Singleton<GameManager>
{
    const int playersCount = 2;
     Player[] players = new Player[2] {new Player(), new Player() };
    public Player CurrentPlayer { get; private set; }

    [SerializeField] UIManager uiManager;

    void Start()
    {
        SetPlayersID();
        RandomPlayer();
        uiManager.UpdateStats(CurrentPlayer.Resources);
    }

    void SetPlayersID()
    {
        players[0].Id = 0;
        players[1].Id = 1;
    }

    void RandomPlayer()
    {
        CurrentPlayer = players[Random.Range(0, 1)];
    }

    void ChangePlayerTurn()
    {
        CurrentPlayer = CurrentPlayer == players[0] ? players[1] : players[0];
    }
}
