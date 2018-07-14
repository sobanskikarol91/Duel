using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;

public class WonderManager : MonoBehaviour
{
    public List<Wonder> _wonders;
    public GameObject[] _wondersGrids;

    private GameObject _currentWonderGrid;
    private Player _currentPlayer;

    int _choosenWondersCount = 0;

    public void Init()
    {
        _currentPlayer = GameManager.instance._CurrentPlayer;
        _currentWonderGrid = _wondersGrids[0];
        ChangeCurrentGrid();
    }

    void ChangeCurrentGrid()
    {
        _currentWonderGrid.SetActive(false);
        _currentWonderGrid = _currentWonderGrid == _wondersGrids[1] ? _wondersGrids[0] : _wondersGrids[1];
        _currentWonderGrid.SetActive(true);
    }

    public void ChoosenWonder(Wonder w)
    {
        _currentPlayer._Wonders.Add(w);
        _choosenWondersCount++;
        StateDependingOnChoosenWondersCount();
    }

    void StateDependingOnChoosenWondersCount()
    {
        if (_choosenWondersCount == 1)
        {
            ChangePlayers();
            ChangeCurrentGrid();
        }
        else if (_choosenWondersCount == 2)
        {
            ChangePlayers();
        }
        else if (_choosenWondersCount == 4)
        {
            ChangePlayers();
            ChangeCurrentGrid();
        }
        else if (_choosenWondersCount == 6)
        {
            ChangePlayers();
        }
        else if (_choosenWondersCount == 7)
        {
            ChangePlayers();
            ChangeCurrentGrid();
        }
    }

    void ChangePlayers()
    {
        GameManager.instance.ChangePlayerTurn();
    }

    public Wonder ReturnRandomWonder()
    {
        return _wonders.ReturnAndRemoveRandom();
    }
}
