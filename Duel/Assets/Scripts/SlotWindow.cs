using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class SlotWindow : MonoBehaviour
{
    public delegate void MouseAction(Vector3 pos);
    public static event MouseAction HighlightedCard;



    [SerializeField] GameObject panel;

    private void Awake()
    {
        DeactivePanel();   
    }

    public void ActivePanelOnPos(Vector2 pos)
    {
        panel.SetActive(true);
        panel.transform.position = pos;
    }

    public void DeactivePanel()
    {
        panel.SetActive(false);
    }
}
