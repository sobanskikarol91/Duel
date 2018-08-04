using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Wonder> _Wonders { get; set; } = new List<Wonder>();
    public PlayerDeck _playerDeck;
    public Price Resources { get; set; } = new Price();
    public List<ConflictToken> _conflictTokens;
    public int Id;

    private void Awake()
    {
        _playerDeck.Init(this);
    }

    public void Pay(int value)
    {
        Debug.Log("Money erased:" + value);
    }

    public void AddGold()
    {
        Resources.gold += GoldenCardsCount() + Settings.CardCost;
        Debug.Log("Hajs " + Resources.gold);
    }

    int GoldenCardsCount()
    {
        return _playerDeck._cards.ContainsKey(CARD_TYPE.COMMERCIAL) ?
            _playerDeck._cards[CARD_TYPE.COMMERCIAL].Count : 0;
    }

    public void BuyCard(Card c)
    {
        //Resources.gold -= c.cost.gold;
        _playerDeck.AddCardToPlayerSlot(c);
    }
}
