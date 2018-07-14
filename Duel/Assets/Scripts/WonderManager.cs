using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class WonderManager : MonoBehaviour 
{
    public List<Wonder> _wonders;
    public Image[] _wondersImages;

    public void Init()
    {
        ShuffleWonders();
        DealPlayerWonders();
        DisplayWondersOnScreen();
    }

    void ShuffleWonders()
    {
        _wonders.Shuffle();
    }

    void DealPlayerWonders()
    {
        int amount = 8;
        Player[] _players = GameManager.instance._Players;

        while (amount-- > 0)
        {
            Debug.Log(amount);
            _players.ForEach(p => p._Wonders.Add(_wonders[amount]));
        }
    }

    void DisplayWondersOnScreen()
    {
        Player currentPlayer = GameManager.instance.CurrentPlayer;

        int nr = 0;
        _wondersImages.ForEach(w => w.sprite = currentPlayer._Wonders[nr++].sprite);
    }
}
