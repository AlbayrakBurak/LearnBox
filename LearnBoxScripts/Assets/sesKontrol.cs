using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Timeline;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class sesKontrol : MonoBehaviour
{

    AudioSource seskontroll;
    void Start()
    {
        seskontroll=GetComponent<AudioSource>();
    }
    

    public void sesKapat()
    {

        seskontroll.mute = true;
        PlayerPrefs.SetInt("sesDurum", 0);
        
    }



    public void sesAc()
    {
        seskontroll.mute = false;
        PlayerPrefs.SetInt("sesDurum", 1);

    }
}
