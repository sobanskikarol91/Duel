﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class SelectedCardWindow : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] Image _cardImg;
    public SlotCard Slot { get; private set; }
    public Card Card { get; private set; }

    [SerializeField] Button buyBTN;
    [SerializeField] Button buildBtn;
    [SerializeField] GameObject additionalPayment;
    [SerializeField] AudioSource _as;

    private void Start()
    {
        panel.SetActive(false);
    }

    public void DisplayPanel(SlotCard s)
    {
        InteractableManager.InteractableOff();
        _as.Play();
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
        additionalPayment.SetActive(false);
        buyBTN.interactable = true;


        //Slot.BuyResult.Selected();
        //if (CardAvailableManager.GetCardForSymbol(Card))
        //    ShowSymbol();
        //else if (ResourceComparer.EnoughResources(Card)) return;
        //else if (ResourceComparer.EnoughGoldToResources(Card))
        //    AditionalPayment();
        //else
        //    buyBTN.interactable = false;
    }

    void SetBuildBTN()
    {

    }

    public void ClosePanel()
    {
        InteractableManager.InteractableOn();
        panel.SetActive(false);
    }

    public void ClosePanelWithSnd()
    {
        _as.Play();
        ClosePanel();
    }

    public void DisableBuyButton()
    {
        buyBTN.interactable = false;
    }

    void ShowSymbol()
    {
        //TODO
    }

    public void AditionalPayment(int payment)
    {
        additionalPayment.SetActive(true);
        additionalPayment.GetComponentInChildren<Text>().text = payment.ToString();
    }
}
