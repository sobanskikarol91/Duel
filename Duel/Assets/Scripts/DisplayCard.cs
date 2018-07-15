using UnityEngine;
using System.Collections;

public class DisplayCard : MonoBehaviour
{
    public CARD_TYPE type;
    private Card _card;
    public Card _Card { get { return _card; } set { _card = value; } }

   public void Display()
    {
        Debug.Log(_card == null);
        GetComponent<SpriteRenderer>().sprite = _card.cardImg;
    }
}
