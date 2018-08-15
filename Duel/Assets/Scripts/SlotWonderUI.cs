using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SlotWonderUI : MonoBehaviour
{
    [SerializeField] public WonderManager _wonderManager;

    public Wonder _wonder;
    Image _image;

    private void Awake()
    {
        _image = GetComponent<Image>();
        _wonder = _wonderManager.ReturnRandomWonder();
        _image.sprite = _wonder.sprite;
    }

    public void SelectedWonder()
    {
        _wonderManager.ChoosenWonder(_wonder);
        _image.enabled = false;
    }
}
