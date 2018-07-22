using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class CardManager : MonoBehaviour
{
    public Deck[] _decks = new Deck[3];
    private Deck _currentDeck;

    int ageNr = 0;

    public void Init()
    {
        CreateSlots();
        DisableSlotsFromLaterAges();
        _decks.ForEach(d => d.Init());
        _currentDeck = _decks[ageNr];
        _currentDeck.DealCards();
        EffectOfDealingCards();
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
            GameObject _layout = Instantiate(_decks[i]._slotsLayoutPrefab, GameManager.instance._slotsPosition.position, Quaternion.identity);
            _decks[i].SetLayoutPrefab(_layout);
        }
    }

    void DisableSlotsFromLaterAges()
    {
        for (int i = 1; i < _decks.Length; i++)
            _decks[i].DisableDeck();
    }
}
