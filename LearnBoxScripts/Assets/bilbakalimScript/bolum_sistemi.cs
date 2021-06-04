using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class bolum_sistemi : MonoBehaviour
{

    public List<Button> bolumButonlari;
    public bool delete;


    // Start is called before the first frame update
    void Start()
    {

        if (delete)
            PlayerPrefs.DeleteAll();

        int saveIndex = PlayerPrefs.GetInt("SaveIndex");

        for (int i = 0; i < bolumButonlari.Count; i++)
        {
            if (i <= saveIndex)
            {
                bolumButonlari[i].interactable = true;
            }
            else
            {

                bolumButonlari[i].interactable = false;
            }


            
        }
    }



    public void bolum_ac(string bolum_ismi)
    {
        SceneManager.LoadScene(bolum_ismi);
    }


}
