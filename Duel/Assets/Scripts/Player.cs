using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Dictionary<CARD_TYPE, List<Card>> cardsDict = new Dictionary<CARD_TYPE, List<Card>>();
    public List<Wonder> _Wonders { get; set; } = new List<Wonder>();
    public CardPositioner _cardPositioner;
    public Price Resources { get; set; }
    public List<ConflictToken> _conflictTokens;
    public int Id;

    private void Awake()
    {
        _cardPositioner.Init(this);
    }

    public void Pay(int value)
    {
        Debug.Log("Money erased:" + value);
    }

    public void AddGold()
    {
        Resources.gold = GoldenCardsCount() * Settings.CardCost;
    }

    int GoldenCardsCount()
    {
        return cardsDict[CARD_TYPE.COMMERCIAL].Count;
    }

    public void AddCard(Card c)
    {
        List<Card> cardLists = cardsDict[c.type];
        cardLists.Add(c);
    }
}
