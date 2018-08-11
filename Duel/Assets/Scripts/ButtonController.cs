using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class ButtonController : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{
    public Clip highlighted;
    public Clip clicked;
    AudioSource _audioSource;
    Button _button;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _button = GetComponent<Button>();
        _audioSource.playOnAwake = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!_button.interactable) return;

        SetClip(highlighted);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!_button.interactable) return;

        ExtensionAudio.PlayAudioClip(clicked, transform.position);
        SetClip(clicked);
    }

    void SetClip(Clip clip)
    {
        _audioSource.clip = clip.clip;
        _audioSource.outputAudioMixerGroup = clip.group;
        _audioSource.Play();
    }
}
