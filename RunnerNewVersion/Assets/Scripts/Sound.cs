using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Sound : MonoBehaviour
{

    public MenuScript CanvasMenuScript;
    public float SelfVolume;
    public bool Music;


    private void Awake()
    {
        SelfVolume = GetComponent<AudioSource>().volume;
    }

    void Update()
    {
        if (CanvasMenuScript.SOUND == 1)

            if (Music)
                GetComponent<AudioSource>().volume = SelfVolume * CanvasMenuScript.MusicVol;
            else
                GetComponent<AudioSource>().volume = SelfVolume * CanvasMenuScript.SFXvol;

        else GetComponent<AudioSource>().volume = 0;
    }
}