using UnityEngine;
using System.Collections;

public class ProgressToken : Interactable
{
    float zoomMultiply = 2.1f;
    SpriteRenderer _sr;

    private void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
    }

    private void OnMouseEnter()
    {
        transform.localScale *= zoomMultiply;
        _sr.sortingOrder++;
    }

    private void OnMouseExit()
    {
        transform.localScale /= zoomMultiply;
        _sr.sortingOrder--;
    }
}
