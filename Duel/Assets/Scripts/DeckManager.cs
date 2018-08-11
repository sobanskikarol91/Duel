using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class DeckManager : Singleton<DeckManager>
{
    public Deck[] _decksSO;
    private Deck[] _decks;
    public Deck _currentDeck { get; set; }

    int ageNr = 0;

    public void Init()
    {
        CopyDeck();
        CreateSlots();
        DisableSlotsFromLaterAges();
        _decks.ForEach(d => d.Init());
        _currentDeck = _decks[ageNr];
        _currentDeck.DealCards();
        EffectOfDealingCards();
    }

    void CopyDeck()
    {
        _decks = new Deck[_decksSO.Length];
        for (int i = 0; i < _decksSO.Length; i++)
            _decks[i] = Instantiate(_decksSO[i]);
    }
    // TODO: new class
    void EffectOfDealingCards()
    {
        _decks[ageNr]._slots.ForEach(s =>
           StartCoroutine(
               IEnumeratorMethods.Lerp(new Vector3(0, 0.3f, 0), s.transform.position, 1.1f, t => s.transform.position = t)));
    }

    public bool CheckIfItWasTheLastCard()
    {
        return _currentDeck.IsEmpty();
    }

    public void DealCardsFromNewAge()
    {
        ageNr++;
        _currentDeck = _decks[ageNr];
        _currentDeck.EnableDeck();
        _currentDeck.DealCards();
    }

    void CreateSlots()
    {
        for (int i = 0; i < _decks.Length; i++)
        {
            Vector3 pos = GameManager.instance._slotsPosition.position;
            GameObject _layout = Instantiate(_decks[i]._slotsLayoutPrefab, pos, Quaternion.identity);
            _decks[i].SetLayoutPrefab(_layout);
        }
    }

    void DisableSlotsFromLaterAges()
    {
        for (int i = 1; i < _decks.Length; i++)
            _decks[i].DisableDeck();
    }

    public List<Card> GetDiscardedCards()
    {
        List<Card> cards = new List<Card>();
        _decks.ForEach(d => cards.AddRange(d._DiscardedCards));
        return cards;
    }

}
