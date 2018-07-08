using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Card> Cards { get; set; }
    List<Wonder> wonders = new List<Wonder>();
    List<Token> tokens = new List<Token>();
    public Resources Resources { get; set; }
    public int Id { get; set; }

    private void Start()
    {
        Cards = new List<Card>();
        Resources = new Resources();
    }

}
