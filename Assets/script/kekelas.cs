using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kekelas : MonoBehaviour
{
    public float waktu = 4f;
    void Start()
    {
        StartCoroutine(DelayedAction());
    }
    IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(waktu);
        pindah lanjut = FindObjectOfType<pindah>();
        lanjut.kelas();
    }
}
