using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardManager : MonoBehaviour
{
    public Deck[] _decks = new Deck[3];
    int ageNr = 0;

    public void Init()
    {
        _decks[ageNr].Shuffle();
        _decks[ageNr].DealCads();
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
}
