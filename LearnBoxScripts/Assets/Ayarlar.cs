using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Timeline;
using UnityEngine.SceneManagement;



public class Ayarlar : MonoBehaviour
{

    
    
    public void Sıfırla()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log(" TÜM İLERLEMELER SIFIRLANDI");

    }

}
