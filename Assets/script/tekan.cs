using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tekan : MonoBehaviour
{
    public bool sesi;
    public GameObject[] desk;
    public GameObject lanjut;
    public GameObject batas;
    public GameObject mengecek;
    public GameObject kanvas;
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
        if(nilai==4)
        {
            batas.SetActive(true);
        }
        if(nilai>desk.Length)
        {
            kanvas.SetActive(false);
            mengecek.SetActive(true);
            belok lanjut = FindObjectOfType<belok>();
            lanjut.mecek();
        }
        if(sesi==true)
        {
            next kelan = FindObjectOfType<next>();
            kelan.dua();
        }
    }
    public void muncul()
    {
        if(nilai<desk.Length-1)
        {
            for (int i = 0 ; i <= nilai; i++)
            {
                desk[i].SetActive(false);
                desk[i+1].SetActive(true);
                lanjut.SetActive(true);
            }
        }
        
    }
    
}
