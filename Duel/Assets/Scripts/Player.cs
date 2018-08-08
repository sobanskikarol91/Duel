using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Wonder> _Wonders { get; set; } = new List<Wonder>();
    public PlayerDeck _playerDeck;
    public Price Resources { get; set; } = new Price(0, 0, 0, 0, 0, 1);
    public List<ConflictToken> _conflictTokens;
    public List<SYMBOL_CARD> card_signs;
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
        Debug.Log(GoldenCardsCount() + " gold");
        Resources.gold += GoldenCardsCount() + Settings.CardCost;
        Debug.Log("Hajs " + Resources.gold);
    }

    int GoldenCardsCount()
    {
        return _playerDeck._cards.ContainsKey(CARD_TYPE.COMMERCIAL) ?
            _playerDeck._cards[CARD_TYPE.COMMERCIAL].Where(c => c._card != null).Count() : 0;
    }

    public void BuyCard(Card c)
    {
        //Resources.gold -= c.cost.gold;
        _playerDeck.AddCardToPlayerSlot(c);
    }

    public int GetResourceAmount(PRODUCE type)
    {
        List<PlayerCard> _playerCards = new List<PlayerCard>();

        if (type == PRODUCE.GLASS || type == PRODUCE.PAPYRUS)
            _playerDeck._cards.TryGetValue(CARD_TYPE.MANUFACTURE, out _playerCards);
        else
            _playerDeck._cards.TryGetValue(CARD_TYPE.RAW_MATERIAL, out _playerCards);

        List<RawMaterial> produceCards = new List<RawMaterial>();

        _playerCards?.ForEach(p => produceCards.Add((RawMaterial)p?._card));

        return produceCards.Where(p => p?.produce == type).Count();
    }
}
