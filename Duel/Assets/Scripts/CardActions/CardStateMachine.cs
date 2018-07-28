using UnityEngine;
using System.Collections;

public static class CardStateMachine
{
    [SerializeField] static DiscardedCardsUI _discardedCardUI;
    static ICardState _buy = new BuyCard();
    static ICardState _discard = new DiscardCard();
    static ICardState _buildWonder;

    static public void BuyWonder(Card c)
    {
        _buy.PlayerHasChoosenCard(c);
    }

    static public void DiscardCard(Card c)
    {
        _discard.PlayerHasChoosenCard(c);
    }

    static public void BuyCard(Card c)
    {
        _buildWonder.PlayerHasChoosenCard(c);
    }
}
