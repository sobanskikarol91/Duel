using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //List<Card> cards = new List<Card>();
    Dictionary<CARD_TYPE, List<Card>> cardsDict = new Dictionary<CARD_TYPE, List<Card>>();


    List<Wonder> wonders = new List<Wonder>();
    List<Token> tokens = new List<Token>();
    public Resources Resources { get; set; }
    public int Id { get; set; }

    private void Awake()
    {
        Resources = new Resources(7, 2, 2, 2, 2, 2);
        // Resources = new Resources(7);
    }

    public bool BuyCard(Card card)
    {
        if (card.price > Resources) return false;

        AddCard(card);

        Resources -= card.price;
        Resources = Resources + card.production;
        Resources.Info();
        return true;
    }
    
    void AddCard(Card c)
    {
        List<Card> newGroup = new List<Card>();

        if (cardsDict.TryGetValue(c.type, out newGroup))
        {
            Debug.Log("Added card to exist group" + c.type);
            newGroup.Add(c);
        }
        else
        {
            Debug.Log("There isn't group for: " + c.type.ToString());
            cardsDict.Add(c.type, new List<Card>());
        }

        Debug.Log(cardsDict.Count);
    }
}
