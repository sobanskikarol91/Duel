using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SelectedCardWindow : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] Image _cardImg;
    Slot slot;
    Card card;

    private void Awake()
    {
        panel.SetActive(false); 
    }

    public void DisplayOnPanel(Slot s)
    {
        slot = s;
        card = slot.Card;
        panel.SetActive(true);
        _cardImg.sprite = card.cardImg;
    }
}
