using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SelectedCardWindow : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] Image _cardImg;
    public Slot Slot { get; private set; }
    public Card Card { get; private set; }

    private void Start()
    {
        panel.SetActive(false); 
    }

    public void DisplayOnPanel(Slot s)
    {
        Slot = s;
        Card = Slot.Card;
        panel.SetActive(true);
        _cardImg.sprite = Card.cardImg;
    }

    public void ClosePanel()
    {
        panel.SetActive(false);
    }
}
