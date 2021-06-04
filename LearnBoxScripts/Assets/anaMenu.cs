using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class anaMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Oyna()
    {
        SceneManager.LoadScene("Ic_Menu");
    }

    public void Ayarlar()
    {
        SceneManager.LoadScene("Ayarlar");
    }

    public void Çıkış()
    {

        Application.Quit();
    }

    public void anaMenuDon()
    {
        SceneManager.LoadScene("Giris");
    }

    public void bilBakalim()
    {
        SceneManager.LoadScene("kolaySorularB");

    }

}
