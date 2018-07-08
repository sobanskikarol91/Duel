using UnityEngine;
using System.Collections;

public class GameManager : Singleton<GameManager>
{
    const int playersCount = 2;
    public Player[] players = new Player[playersCount];
    public Player CurrentPlayer { get; private set; }

   [SerializeField] UIManager uiManager;

    public void SelectedCard(Card card)
    {
        CurrentPlayer.AddCard(card);
        uiManager.UpdateStats(CurrentPlayer.Resources);
        ChangePlayerTurn();
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

    void Start()
    {
        SetPlayersID();
        RandomPlayer();
    }
}
