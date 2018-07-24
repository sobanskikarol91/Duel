using UnityEngine;
using System.Collections;

public class ProgressToken : MonoBehaviour
{
    float zoomMultiply = 2.1f;
    SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnMouseEnter()
    {
        Debug.Log("a");
        transform.localScale *= zoomMultiply;
        sr.sortingOrder++;
    }

    private void OnMouseExit()
    {
        transform.localScale /= zoomMultiply;
        sr.sortingOrder--;
    }
}
