using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider2D))]
public class Interactable : MonoBehaviour
{
    virtual protected void Awake()
    {
        InteractableManager.Subscribe(this);    
    }

    virtual protected void OnDestroy()
    {
        InteractableManager.Unsubscribe(this);
    }

    public void SetInteractable(bool state)
    {
        GetComponent<Collider2D>().enabled = state; 
    }
}
