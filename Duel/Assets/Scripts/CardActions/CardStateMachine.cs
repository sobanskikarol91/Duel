using UnityEngine;
using System.Collections;

public class CardStateMachine : Singleton<CardStateMachine>
{
    [SerializeField] DiscardedCardsUI _discardedCardUI;
    ICardState _buy;
    ICardState _discard;
    ICardState _buildWonder;

    private void Start()
    {
        _buy = new BuyCard();
        _discard = new DiscardCard(_discardedCardUI);
    }

    public void BuyWonder()
    {
        _buildWonder.PlayerHasChoosenCard();
    }

    public void DiscardCard()
    {
         _discard.PlayerHasChoosenCard();
    }

    public void BuyCard()
    {
        _buy.PlayerHasChoosenCard();
    }
}
