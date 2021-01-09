using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField]
    Camera gameCamera;
    [SerializeField]
    AudioClip mouseHoverClip;
    [SerializeField]
    AudioClip mouseClickClip;
    void Awake()
    {
        SetUpSingleton();
    }

    private void SetUpSingleton()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Update is called once per frame
    public void PlayButtonHoverSFX()
    {
        AudioSource.PlayClipAtPoint(mouseHoverClip, gameCamera.transform.position);
    }

    public void PlayButtonClickSFX()
    {
        AudioSource.PlayClipAtPoint(mouseClickClip, gameCamera.transform.position);
    }
}
