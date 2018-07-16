using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class SlotWindow : MonoBehaviour
{
    public delegate void MouseAction(Vector3 pos);
    public static event MouseAction HighlightedCard;
    
    static GameObject panel;

    private void Awake()
    {
        panel = gameObject;

        DeactivePanel();   
    }

    public static void ActivePanelOnPos(Vector2 pos)
    {
        panel.SetActive(true);
        panel.transform.position = pos;
    }

    public static void DeactivePanel()
    {
        panel.SetActive(false);
    }
}
