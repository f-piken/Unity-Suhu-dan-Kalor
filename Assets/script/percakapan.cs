using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class percakapan : MonoBehaviour
{
    public GameObject Percakapan;
    public GameObject kerja;
    public float waktu = 5f;
    void Start()
    {
        StartCoroutine(DelayedAction());
    }
    IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(waktu);
        Percakapan.SetActive(true);
        kerja.SetActive(false);
        pindah lanjut = FindObjectOfType<pindah>();
    }
}
