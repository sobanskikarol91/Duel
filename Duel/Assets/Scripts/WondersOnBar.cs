using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

[System.Serializable]
public class WonderWithImage
{
    public Image _image;
    [HideInInspector] public Wonder _wonder;
}

public class WondersOnBar : MonoBehaviour
{
    public WonderWithImage[] _wonders;

    public void SetWonders(List<Wonder> playerWonders)
    {
        for (int i = 0; i < playerWonders.Count; i++)
        {
            _wonders[i]._wonder = playerWonders[i];
            _wonders[i]._image.sprite = playerWonders[i].sprite;
        }
    }
}
