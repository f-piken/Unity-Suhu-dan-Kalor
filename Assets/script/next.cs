using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class next : MonoBehaviour
{
    public GameObject lanjut1;
    public GameObject lanjut2;
    public void pertama()
    {
        tekan nesk = FindObjectOfType<tekan>();
        if (nesk.desk[2].activeSelf)
        {
            lanjut2.SetActive(true);
            lanjut1.SetActive(false);
        }
        else
        {
            lanjut1.SetActive(true);
            lanjut2.SetActive(false);
        }
    }
    public void dua()
    {
        tekan nesk = FindObjectOfType<tekan>();
        
        if (nesk.desk[1].activeSelf || nesk.desk[4].activeSelf)
        {
            lanjut1.SetActive(true);
            lanjut2.SetActive(false);
        }
        else if(nesk.desk[3].activeSelf || nesk.desk[5].activeSelf)
        {
            lanjut2.SetActive(true);
            lanjut1.SetActive(false);
        }
        else
        {
            lanjut1.SetActive(false);
            lanjut2.SetActive(false);
        }
    }
}
