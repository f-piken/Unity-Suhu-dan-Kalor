using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class belok : MonoBehaviour
{
    public float orang =5f;
    public GameObject jalan;
    public void mecek()
    {
        StartCoroutine(DelayedAction());
    }
    IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(orang);
        tekan lanjut = FindObjectOfType<tekan>();
        lanjut.mengecek.SetActive(false);
        jalan.SetActive(true);
        otomatis terus = FindObjectOfType<otomatis>();
        terus.Jalan();
    }
}
