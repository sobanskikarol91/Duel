using UnityEngine;
using System.Collections;

public class PlayerCard : MonoBehaviour
{
    public CARD_TYPE type;
    public Card _card { get; set; }

    public void Display()
    {
        GetComponent<SpriteRenderer>().sprite = _card.cardImg;
    }
}
