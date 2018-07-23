using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Dictionary<CARD_TYPE, List<Card>> cardsDict = new Dictionary<CARD_TYPE, List<Card>>();
    public List<Wonder> _Wonders { get; set; } = new List<Wonder>();
    public CardPositioner _cardPositioner;
    public Resources Resources { get; set; }
    public List<ConflictToken> _conflictTokens;
    public int Id;

    private void Awake()
    {
        _cardPositioner.Init(this);
    }

    public void Pay(int value)
    {
        Debug.Log("Money erased:" + value);
    }
}
