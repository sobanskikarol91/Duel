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

        ageNr++;
    }
}
