using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class perpus : MonoBehaviour
{
    public float waktu = 5.7f;
    public GameObject jalan;
    public GameObject kemera;
    void Start()
    {
        StartCoroutine(DelayedAction());
    }
    IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(waktu);
        jalan.SetActive(false);
        kelab orang = FindObjectOfType<kelab>();
        orang.tukang.SetActive(true);
        orang.mulai();
    }
}
