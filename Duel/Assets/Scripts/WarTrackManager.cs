using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WarTrackManager : MonoBehaviour
{
    [SerializeField] ConflictPawn _pawn;

    [SerializeField] VisualConflictToken[] _visualTokens;
    public void Init()
    {
        CreateTokens();
    }

    void CreateTokens()
    {
        Player[] _players = GameManager.instance._players;

        int nr = 0;
        foreach (Player p in _players)
        {
            List<ConflictToken> tokens = new List<ConflictToken>();
            tokens.Add(new ConflictToken(p.Pay, Settings.FirstConflictToken, _visualTokens[nr++]));
            tokens.Add(new ConflictToken(p.Pay, Settings.SecondConflictToken, _visualTokens[nr++]));
            p._conflictTokens = tokens;
        }
    }

    public void MovePawn(int steps)
    {
        int value = steps * GetDirection();
        _pawn.Move(value);
        CheckTokenDiscard();
    }

    void CheckTokenDiscard()
    {
        Player _player = GameManager.instance.NextPlayer;

        int pos = Mathf.Abs(_pawn.StandingPoint);
        if (pos > 2) _player._conflictTokens[0].DiscardIt();
        if (pos > 5) _player._conflictTokens[1].DiscardIt();
        if (pos == 10) GameManager.instance.MilitaryWin();
    }

    int GetDirection()
    {
        int id = GameManager.instance._CurrentPlayer.Id;
        return id == 1 ? -1 : 1;
    }
}
