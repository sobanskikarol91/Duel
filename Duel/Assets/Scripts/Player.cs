using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{
    Dictionary<CARD_TYPE, List<Card>> cardsDict = new Dictionary<CARD_TYPE, List<Card>>();
    public List<Wonder> _Wonders { get; set; } = new List<Wonder>();
    public CardPositioner _cardPositioner;
    public Price Resources { get; set; } = new Price();
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
        Resources.gold += GoldenCardsCount() + Settings.CardCost;
        Debug.Log("Hajs " + Resources.gold);
    }

    int GoldenCardsCount()
    {
        return cardsDict.ContainsKey(CARD_TYPE.COMMERCIAL) ?
            cardsDict[CARD_TYPE.COMMERCIAL].Count : 0;
    }

    public void AddCard(Card c)
    {
        List<Card> cardLists = cardsDict[c.type];
        cardLists.Add(c);
    }

    public bool CheckSymbol(Card card)
    {
        List<Card> cards = cardsDict[card.type];
        return cards.Exists(c => c.getForSign == card.signToFreeBuy);
    }

    public bool AffordForCard(Card c)
    {
        return true;
    }
}
