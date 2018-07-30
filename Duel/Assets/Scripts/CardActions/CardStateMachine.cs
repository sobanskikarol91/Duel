using UnityEngine;
using System.Collections;

public class CardStateMachine : Singleton<CardStateMachine>
{
    [SerializeField] DiscardedCardsUI _discardedCardUI;
    ICardState _buy = new BuyCard();
    ICardState _discard;
    ICardState _buildWonder;

    private void Start()
    {
        _discard = new DiscardCard(_discardedCardUI);
    }

    public void BuyWonder(Card c)
    {
        _buy.PlayerHasChoosenCard(c);
    }

    public void DiscardCard(Card c)
    {
         _discard.PlayerHasChoosenCard(c);
    }

    public void BuyCard(Card c)
    {
        _buildWonder.PlayerHasChoosenCard(c);
    }
}
