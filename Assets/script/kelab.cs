using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kelab : MonoBehaviour
{
    public GameObject tukang;
    public float waktu = 4f;
    public void mulai()
    {
        StartCoroutine(DelayedAction());
    }
    IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(waktu);
        pindah lanjut = FindObjectOfType<pindah>();
        lanjut.labo();
    }
}
