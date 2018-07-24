using UnityEngine;
using System.Collections;

public class OnMouseSnd : MonoBehaviour
{
    AudioSource _as;
    public Clip OnClickSnd;
  public  Clip OnEnterSnd;

    float timeToPlaySndAgain = 0.3f;
    bool isReady = true;

    void Start()
    {
        _as = GetComponent<AudioSource>();
    }

    private void OnMouseEnter()
    {
        //if (!isReady) return;

        //_as.Play();
        //isReady = false;
        //Invoke("PlayAgainSndAfterTime", timeToPlaySndAgain);
    }

    private void OnMouseDown()
    {
        if (OnClickSnd == null) return;
        ExtensionAudio.PlayAudioClip(OnClickSnd, transform.position);
    }

    void PlayAgainSndAfterTime()
    {
        isReady = true;
    }
}
