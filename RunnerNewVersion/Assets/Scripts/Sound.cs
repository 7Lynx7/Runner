using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Sound : MonoBehaviour {

    public MenuScript CanvasMenuScript;
    public float SelfVolume, TiltSpeed;
    public bool Music;
    public bool Tumbler;
    public GameObject GG;


    private void Awake()
    {
         //SelfVolume = GetComponent<AudioSource>().volume;
    }
    // Update is called once per frame
    //void Update () {
    //    if (CanvasMenuScript.SOUND == 1)

    //        if (Music)
    //            GetComponent<AudioSource>().volume = SelfVolume * CanvasMenuScript.MusicVol;
    //        else
    //            GetComponent<AudioSource>().volume = SelfVolume * CanvasMenuScript.SFXvol;

    //    else GetComponent<AudioSource>().volume = 0;
    //}

    private void Update()
    {
        if (Tumbler)
       poworot();

    }
    void poworot()
    {
        Vector3 Vec3 = new Vector3(0f, 0f, TiltSpeed);
        GG.transform.Rotate(Vec3 * Time.deltaTime);
    }

}

