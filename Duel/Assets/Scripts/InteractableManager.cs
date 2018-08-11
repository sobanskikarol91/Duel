using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class InteractableManager
{
    static List<Interactable> _interactibles = new List<Interactable>();

    public static void Subscribe(Interactable i)
    {
        _interactibles.Add(i);
    }

    public static void Unsubscribe(Interactable i)
    {
        _interactibles.Remove(i);
    }

    public static void InteractableOn()
    {
        _interactibles.ForEach(i => i.SetInteractable(true));
    }

    public static void InteractableOff()
    {
        Debug.Log(_interactibles.Count);
        _interactibles.ForEach(i => i.SetInteractable(false));
    }
}
