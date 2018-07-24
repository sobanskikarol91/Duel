using UnityEngine;
using System.Collections;

public class OnMouseSnd : MonoBehaviour
{
    AudioSource _as;
    public Clip OnClickSnd;
    public Clip OnEnterSnd;

    void Start()
    {
        _as = GetComponent<AudioSource>();
    }

    private void OnMouseEnter()
    {
        if (OnEnterSnd.clip == null) return;
        ExtensionAudio.PlayAudioClip(OnEnterSnd, transform.position);
    }

    private void OnMouseDown()
    {
        if (OnClickSnd.clip == null) return;
        ExtensionAudio.PlayAudioClip(OnClickSnd, transform.position);
    }

}
