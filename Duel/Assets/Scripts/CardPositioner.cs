using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[System.Serializable]
public class CardPositioner
{
    public List<DisplayCard> slotOnTable;
    Dictionary<CARD_TYPE, List<DisplayCard>> _cardSlotDict = new Dictionary<CARD_TYPE, List<DisplayCard>>();
    Card _card;

    #region Convert List of Empty slots to Dictionary
    public void Init()
    {
        ConvertListSlotsToDict();
        SortSlotsInLists();
        SetOrderingInLayerSlots();
    }

    void ConvertListSlotsToDict()
    {
        for (int i = 0; i < slotOnTable.Count; i++)
        {
            CARD_TYPE type = slotOnTable[i].type;

            if (_cardSlotDict.ContainsKey(type))
                AddEmptySlotToExistListInDictionary(slotOnTable[i]);
            else
                AddSlotAsNewKeyInDirection(slotOnTable[i]);
        }
    }

    void AddEmptySlotToExistListInDictionary(DisplayCard slot)
    {
        List<DisplayCard> slotList = _cardSlotDict[slot.type];
        slotList.Add(slot);
    }

    void AddSlotAsNewKeyInDirection(DisplayCard slot)
    {
        _cardSlotDict.Add(slot.type, new List<DisplayCard>());
    }

    #endregion

    #region Add bought Card to Player's specific cards group
    public void AddCardToPlayerSlot(Card _card)
    {
        this._card = _card;

        DisplayCard empty = FindEmptySpotInGroup();
        empty._Card = _card;
        empty.Display();
    }

    DisplayCard FindEmptySpotInGroup()
    {
        List<DisplayCard> _cardGroup = GetAllSlotsForCardType();
        return _cardGroup.First(p => p._Card == null);
    }

    List<DisplayCard> GetAllSlotsForCardType()
    {
        return _cardSlotDict[_card.type];
    }
    #endregion

    public void SortSlotsInLists()
    {
        foreach (var list in _cardSlotDict)
        {
            list.Value.Sort(
                    delegate (DisplayCard p1, DisplayCard p2)
                    {
                        return ((-1) * p1.transform.position.y).CompareTo(p2.transform.position.y * (-1));
                    }
                );
        }
    }

    void SetOrderingInLayerSlots()
    {
        foreach (var list in _cardSlotDict)
        {
            for (int i = 0; i < list.Value.Count; i++)
            {
                list.Value[i].GetComponent<SpriteRenderer>().sortingOrder = i;
            }
        }
    }
}
