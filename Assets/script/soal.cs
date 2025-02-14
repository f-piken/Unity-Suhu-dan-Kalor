using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soal : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DelayedAction());
    }
    IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(8.5f);
        pindah lanjut = FindObjectOfType<pindah>();
        lanjut.tanya2();
    }
}
