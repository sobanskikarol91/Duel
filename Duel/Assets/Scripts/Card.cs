using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "Card/")]
public class Card : ScriptableObject
{
    public Sprite cardImg;
    public Sprite reverseImg;

    public Resources price;
    public Resources production;
    public CARD_TYPE type;
}
