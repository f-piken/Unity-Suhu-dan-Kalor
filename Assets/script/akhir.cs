using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class akhir : MonoBehaviour
{
    public GameObject K1;
    public GameObject K2;
    public GameObject tombol;

    public void kamera()
    {
        tekan teks = FindObjectOfType<tekan>();
        if (teks.desk[3].activeSelf||teks.desk[6].activeSelf)
        {
            K1.SetActive(false);
            K2.SetActive(true);
        }
        else if (teks.desk[5].activeSelf)
        {
            K1.SetActive(true);
            K2.SetActive(false);
        }
        else if (teks.desk[teks.desk.Length-1].activeSelf)
        {
            tombol.SetActive(false);
            K1.SetActive(false);
            K2.SetActive(false);
        }
    }
}
