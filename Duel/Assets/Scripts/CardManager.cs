using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class CardManager : MonoBehaviour
{
    [SerializeField] public GameObject[] _decksPrefab; // TODO
    public Deck[] _decks = new Deck[3];
    private Deck _currentDeck;

    int ageNr = 0;

    public void Init()
    {
        _decks.ForEach(d => d.Init());
        _currentDeck = _decks[ageNr];
        _currentDeck.DealCards();
        EffectOfDealingCards();
        ageNr++;
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


}
