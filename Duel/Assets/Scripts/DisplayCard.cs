using UnityEngine;
using System.Collections;

public class DisplayCard : MonoBehaviour
{
    private Card _card;
    [HideInInspector] public Card _Card { get { return _card; } set { _card = value; Display(); } }

    void Display()
    {
        GetComponent<SpriteRenderer>().sprite = _card.cardImg;
    }
}
