using UnityEngine;
using System.Collections;
using System.Collections.Generic;


[CreateAssetMenu(fileName = "Deck", menuName = "Deck", order = 3)]
public class DeckSO : ScriptableObject
{
    public List<Card> _Cards { get; }
    public GameObject _cardLayout;
}
