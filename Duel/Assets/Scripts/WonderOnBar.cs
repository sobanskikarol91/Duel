using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class WonderOnBar : MonoBehaviour
{
    Image _image;
    Wonder _Wonder;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    public void SetWonder(Wonder w)
    {
        _Wonder = w;
        _image.sprite = w.sprite;
    }
}
