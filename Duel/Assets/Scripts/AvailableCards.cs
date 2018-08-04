using UnityEngine;
using System.Collections;

public class AvailableCards : MonoBehaviour
{
    public Sprite inaccessibleImg;
    public Sprite accessibleImg;
    SpriteRenderer _spriteRenderer;
    Slot _slot;

    private void Awake()
    {
        _slot = GetComponent<Slot>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void SetInaccessibleCard()
    {
        GetComponent<SpriteRenderer>().sprite = inaccessibleImg;
    }

    void SetAccessibleCard()
    {
        if (GameManager.instance._CurrentPlayer.Resources >= _slot.Card.cost)
            return;
        GetComponent<SpriteRenderer>().sprite = accessibleImg;
    }
}
