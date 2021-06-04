using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

[System.Serializable]
public class Soru { 

    public string soruismi,cevapA,cevapB,cevapC;
    public int cevap;
    public Sprite resim1;
    public Sprite resim2;

    public Soru(string soru, string cevap1, string cevap2, string cevap3, int cvp, Sprite rsm1, Sprite rsm2) {
        
        soruismi = soru;
        cevapA = cevap1;
        cevapB = cevap2;
        cevapC = cevap3;
        cevap = cvp;
        resim1 = rsm1;
        resim2 = rsm2;

    }
}
