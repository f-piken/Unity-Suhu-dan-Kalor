using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tanya : MonoBehaviour
{
    public GameObject[] desk;
    public GameObject lanjut;
    public GameObject tombol;

    private int nilai = 0;
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
        if (desk[3].activeSelf)
        {
            tombol.SetActive(false);
        }
    }
    public void muncul()
    {
        if(nilai<3)
        {
            for (int i = 0 ; i <= nilai; i++)
            {
                desk[i].SetActive(false);
                desk[i+1].SetActive(true);
            }
            if (desk[1].activeSelf||desk[2].activeSelf)
            {
            lanjut.SetActive(true);
            }
            else
            {
            lanjut.SetActive(false);
            }
        }
        
    }
    public void ada()
    {
        wujut();
        nilai++; 
        if (desk[3].activeSelf)
        {
            tombol.SetActive(false);
        }
    }
    public void wujut()
    {
        if(nilai<16)
        {
            for (int i = 0 ; i <= nilai; i++)
            {
                desk[i].SetActive(false);
                desk[i+1].SetActive(true);
            }
            if (nilai % 2 == 0 || nilai == 0)
            {
            lanjut.SetActive(false);
            }
            else
            {
            lanjut.SetActive(true);
            }
        }
        
    }
}
