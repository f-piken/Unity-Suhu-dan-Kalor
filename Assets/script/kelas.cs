using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kelas : MonoBehaviour
{
    public GameObject K1;
    public GameObject K2;
    public int nilai;
    public GameObject[] desk;
    public GameObject lanjut1;
    public GameObject lanjut2;
    public GameObject batas;
    public GameObject kanvas;
    void Start()
    {
        StartCoroutine(DelayedAction());
    }
    IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(1f);
        keluar();
    }
    public void keluar()
    {
        muncul();
        nilai++;
    }
    public void muncul()
    {
        if(nilai<6)
        {
            for (int i = 0 ; i <= nilai; i++)
            {
                desk[i].SetActive(false);
                desk[i+1].SetActive(true);
            }
            if (nilai % 2 != 0 || nilai != 0)
            {
                if(desk[2].activeSelf)
                {
                    lanjut2.SetActive(true);
                    lanjut1.SetActive(false);
                }
                else
                {
                    lanjut2.SetActive(false);
                    lanjut1.SetActive(true);
                }
            }
            if(desk[2].activeSelf)
            {
                textBoks();
                batas.SetActive(false);
                kanvas.SetActive(true);
            }
        }
        
    }
    public void textBoks()
    {
        if (desk[2].activeSelf)
        {
            K1.SetActive(false);
            K2.SetActive(true);
        }
    }
}
