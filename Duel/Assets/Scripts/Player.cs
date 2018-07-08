using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    List<Card> cards = new List<Card>();
    List<Wonder> wonders = new List<Wonder>();
    List<Token> tokens = new List<Token>();
    public Resources Resources { get; set; }
    public int Id { get; set; }

    private void Start()
    {
        Resources = new Resources(7);
    }

    public void AddCard(Card card)
    {
        cards.Add(card);
        Resources = Resources + card.price;
        Resources.Info();
    }

}
