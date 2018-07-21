using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public Sprite cardImg;
    public Sprite reverseImg;
    public Deck _deck;
    public Resources price;
    public CARD_TYPE type;

    public void EraseFromDeck()
    {
        _deck.EraseCard(this);
    }
}
