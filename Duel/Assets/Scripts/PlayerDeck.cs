using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[System.Serializable]
public class PlayerDeck
{
    public List<PlayerCard> slotOnTable;
    public Dictionary<CARD_TYPE, List<PlayerCard>> _cards { get; set; } = new Dictionary<CARD_TYPE, List<PlayerCard>>();
    Card _card;
    Player _player;

    public bool CheckSymbol(Card card)
    {
        // List<Card> cards = _cards[card.type];
        // return cards.Exists(c => c.getForSign == card.signToFreeBuy);
        return false;
    }
    
    #region Convert List of Empty slots to Dictionary
    public void Init(Player p)
    {
        _player = p;
        ConvertListSlotsToDict();
        SortSlotsInLists();
        SetOrderingInLayerSlots();
    }

    void ConvertListSlotsToDict()
    {
        for (int i = 0; i < slotOnTable.Count; i++)
        {
            CARD_TYPE type = slotOnTable[i].type;

            if (_cards.ContainsKey(type))
                AddEmptySlotToExistListInDictionary(slotOnTable[i]);
            else
                AddSlotAsNewKeyInDirection(slotOnTable[i]);
        }
    }

    void AddEmptySlotToExistListInDictionary(PlayerCard slot)
    {
        List<PlayerCard> slotList = _cards[slot.type];
        slotList.Add(slot);
    }

    void AddSlotAsNewKeyInDirection(PlayerCard slot)
    {
        _cards.Add(slot.type, new List<PlayerCard>());
    }

    #endregion

    #region Add bought Card to Player's specific cards group
    public void AddCardToPlayerSlot(Card _card)
    {
        this._card = _card;

        PlayerCard empty = FindEmptySpotInGroup();
        empty._card = _card;
        empty.Display();
    }

    PlayerCard FindEmptySpotInGroup()
    {
        List<PlayerCard> _cardGroup = GetAllSlotsForCardType();
        return _cardGroup.First(p => p._card == null);
    }

    List<PlayerCard> GetAllSlotsForCardType()
    {
        List<PlayerCard> c = new List<PlayerCard>();
        if (!_cards.TryGetValue(_card.Type, out c))
            Debug.Log("Nie ma takiego typu:" + _card.Type);
        return _cards[_card.Type];
    }
    #endregion

    public void SortSlotsInLists()
    {
        int direction = _player.Id == 1 ? 1 : -1;
        foreach (var list in _cards)
        {
            list.Value.Sort(
                    delegate (PlayerCard p1, PlayerCard p2)
                    { return ((direction) * p1.transform.position.y).
                        CompareTo(p2.transform.position.y * (direction));}
                );
        }
    }

    void SetOrderingInLayerSlots()
    {
        foreach (var list in _cards)
            for (int i = 0; i < list.Value.Count; i++)
                list.Value[i].GetComponent<SpriteRenderer>().sortingOrder = i;
    }
}
