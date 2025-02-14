using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pilihan : MonoBehaviour
{
    public GameObject[] desk;
    public GameObject neks;
    public GameObject tombol;
    public GameObject pilih;
    public GameObject pln;
    public GameObject plts;
    public GameObject pindahdalam;
    public int nilai;
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
        if(desk[2].activeSelf)
        {
            pilih.SetActive(true);
            tombol.SetActive(false);
        }
        if(desk[3].activeSelf || desk[4].activeSelf)
        {
            pindahdalam.SetActive(true);
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
            }
        }
    }
    public void PLTS()
    {
        pln.SetActive(false);
        keluar();
    }
    public void PLN()
    {
        plts.SetActive(false);
        nilai=3;
        keluar();
    }
}
