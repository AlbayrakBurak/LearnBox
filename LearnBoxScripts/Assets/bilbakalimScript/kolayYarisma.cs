using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;
using UnityEngine.SceneManagement;



public class kolayYarisma : MonoBehaviour
{

    public int buildIndex = 1;

    

    public Text soruismi, cevapA, cevapB, cevapC, soruNumara, kalanZaman;
    public Image resim1, resim2;

    public List<bool> sorulanlar; // sorulan soruları saklamak için

    public int soruNum, cevap;
    public float zaman;

    Sorular sr; //Sorular scriptini rahat kullanabilmek için tanımladık

    

    void Start()
    {


        buildIndex = SceneManager.GetActiveScene().buildIndex;

        sr = GetComponent<Sorular>();
        for (int i = 0; i < sr.sorular.Count; i++) //soru sayısı ile sorulanları eşitleme işlemi
        {
            sorulanlar.Add(false);
        }
        SoruEkle();
    }


    void Update()
    {
        if (zaman > 0)
        {
            zaman -= Time.deltaTime;
            kalanZaman.text = zaman.ToString("00");

        }
        else { Debug.Log("OYUN BİTTİ!");
            SceneManager.LoadScene("kolaySorularB");
        }
        
    }

    public void SoruEkle()
    {
        

        for (int i = 0; i < sorulanlar.Count; i++)
        {
            if (sorulanlar[i] == false)
            {

                int soruSayi = Random.Range(0, sorulanlar.Count); //random soru sor
                if (sorulanlar[soruSayi] == false)
                {
                    sorulanlar[soruSayi] = true;
                    soruNum++;
                    soruNumara.text = "" + soruNum;
                    zaman = 30;
                    soruismi.text = sr.sorular[soruSayi].soruismi;
                    cevapA.text = sr.sorular[soruSayi].cevapA;
                    cevapB.text = sr.sorular[soruSayi].cevapB;
                    cevapC.text = sr.sorular[soruSayi].cevapC;
                    cevap = sr.sorular[soruSayi].cevap;
                    resim1.sprite = sr.sorular[soruSayi].resim1;
                    resim2.sprite = sr.sorular[soruSayi].resim2;

                }
                else
                {
                    SoruEkle();
                }

                break;
            }
            if (i == sorulanlar.Count - 1 )
            {

                Debug.Log("BU BÖLÜMÜ BAŞARIYLA TAMAMLADIN !");
                Debug.Log("Yeni Bölüm Açıldı");
                

                //PlayerPrefs.GetInt("saveIndex");
                

                int saveIndex = PlayerPrefs.GetInt("SaveIndex");

                if (buildIndex > saveIndex)
                {
                    PlayerPrefs.SetInt("SaveIndex", buildIndex);
                }

                if (buildIndex == saveIndex) 
                {
                    SceneManager.LoadScene("kolaySorularB");
                    Debug.Log("TÜM SORULAR BİTTİ TEBRİKLER !!!");

                }
                else
                {

                    SceneManager.LoadScene("kolaySorularB");
                }



            }
            

        }


    }

    

        public void cevapVer(int deger)
    {
        if (deger == cevap)
        {
            SoruEkle();
        }
        else
        {
            Debug.Log("YANLIŞ CEVAP");

            SceneManager.LoadScene("yanlisCevap");
        }
    }

   
}

 

