using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip click;
    public AudioClip highlight;
    public static SFXManager sfxInstance;

    private void Awake()
    {
        if (sfxInstance != null && sfxInstance != this)
        {
            Debug.Log("destroy");
            Destroy(this.gameObject);
           return;
        }

        Debug.Log("dont destroy");
        sfxInstance = this;
        DontDestroyOnLoad(this);
    }
}
