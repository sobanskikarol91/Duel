using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SelectedCardWindow : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] Image _cardImg;
    public Slot Slot { get; private set; }
    public Card Card { get; private set; }

    [SerializeField] Button buyBTN;
    [SerializeField] Button buildBtn;

    private void Start()
    {
        panel.SetActive(false);
    }

    public void DisplayOnPanel(Slot s)
    {
        Slot = s;
        Card = Slot.Card;
        panel.SetActive(true);

        SetCard();
        SetBuyBTN();
        SetBuildBTN();
    }

    void SetCard()
    {
        _cardImg.sprite = Card.cardImg;
        _cardImg.color = Slot.GetComponent<SpriteRenderer>().color;
    }

    void SetBuyBTN()
    {
        
    }

    void SetBuildBTN()
    {

    }

    void ClosePanel()
    {
        panel.SetActive(false);
    }
}
