using UnityEngine;
using System.Collections;

public class WarTrackManager : MonoBehaviour
{
    [SerializeField] ConflictPawn _pawn;

    void Init()
    {
        CreateTokens();
    }

    void CreateTokens()
    {
        Player[] _players = GameManager.instance._players;

        foreach (Player p in _players)
        {
            ConflictToken minus2gold = new ConflictToken(p.Pay , Settings.secondConflictToken);
            ConflictToken minus5gold = new ConflictToken(p.Pay, Settings.secondConflictToken);
        }
    }

    public void MovePawn(int steps)
    {
        int value = steps * GetDirection();
        _pawn.Move(value);
    }

    void CheckTokenDiscard()
    {
        int pos = _pawn.StangingPoint;

        float direction = Mathf.Sign(pos);
    }

    int GetDirection()
    {
        int id = GameManager.instance._CurrentPlayer.Id;
        return id == 1 ? -1 : 1;
    }
}
