using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keperpus : MonoBehaviour
{
    public float waktu = 2.2f;
    void Start()
    {
        StartCoroutine(DelayedAction());
    }
    IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(waktu);
        pindah lanjut = FindObjectOfType<pindah>();
        lanjut.kedalam();
    }
}
