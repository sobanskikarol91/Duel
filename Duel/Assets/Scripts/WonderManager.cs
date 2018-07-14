using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;

public class WonderManager : MonoBehaviour
{
    public List<Wonder> _wonders;
    List<Wonder> _wondersGroupToChoose1 = new List<Wonder>();
    List<Wonder> _wondersGroupToChoose2 = new List<Wonder>();

    List<Wonder> _currentDisplayedGroup;
    public Image[] _wondersImages;
    int _choosenCardsAmount = 0;
    Player _currentPlayer;

    public void Init()
    {
        ShuffleWonders();
        ShareWondersFor2Groups();
        _currentPlayer = GameManager.instance.CurrentPlayer;

        _currentDisplayedGroup = _wondersGroupToChoose1;
        DisplayWondersOnScreen();
    }

    void ShuffleWonders()
    {
        _wonders.Shuffle();
    }

    void ShareWondersFor2Groups()
    {
        int amount = 0;
        while (amount < 8)
        {
            _wondersGroupToChoose1.Add(_wonders[amount++]);
            _wondersGroupToChoose2.Add(_wonders[amount++]);
        }
    }

    void ShowPlayerWondersToChoose()
    {
        Player[] _players = GameManager.instance._Players;
    }

    void DisplayWondersOnScreen()
    {
        int nr = 0;
        _wondersImages.Where(p => p.enabled).ForEach(w => w.sprite = _currentDisplayedGroup[nr++].sprite);
    }

    public void PlayerHasChoosenWonder(int nr)
    {
        Wonder _wonder = _currentDisplayedGroup[nr];
        _currentPlayer._Wonders.Add(_wonder);
        _currentDisplayedGroup.Remove(_wonder);
        _choosenCardsAmount++;

        if (_choosenCardsAmount == 1)
            ChangePlayers();
        if (_choosenCardsAmount == 2)
        {
            DisableLastSlotOnScreen();
            ChangePlayers();
            SwapWondersGroupBetweenPlayers();
        }
        if (_choosenCardsAmount == 3)
        {
            DisableLastSlotOnScreen();

        }
        else if (_choosenCardsAmount == 4)
        {

        }
        else if (_choosenCardsAmount == 6)
        {
            SwapWondersGroupBetweenPlayers();
        }


        Debug.Log("Player has choosen: " + nr);
    }

    void ChangePlayers()
    {
        ChangeCurrentGroup();
        DisplayWondersOnScreen();
        GameManager.instance.ChangePlayerTurn();
    }

    void SwapWondersGroupBetweenPlayers()
    {

    }

    void DisableLastSlotOnScreen()
    {
        _wondersImages.Last().enabled = false;
    }

    void ChangeCurrentGroup()
    {
        _currentDisplayedGroup = _currentDisplayedGroup == _wondersGroupToChoose1 ? _wondersGroupToChoose2 : _wondersGroupToChoose1;
    }
}


/*
Wybiera P1: 4
    - Dodaj wybranka karte
    - zmniejsz liste o wybrana karte
Wybiera P2: 4
    - Dodaj wybranka karte
    - zmniejsz liste o wybrana karte
Zmien kupki
        - Dodaj wybranka karte
        - zmniejsz liste o wybrana karte
        - Dodaj wybranka karte
        - zmniejsz liste o wybrana karte
 */
