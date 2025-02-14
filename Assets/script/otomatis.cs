using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class otomatis : MonoBehaviour
{
    public float orang =2.2f;
    public void Jalan()
    {
        StartCoroutine(DelayedAction());
    }
    IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(orang);
        pindah lanjut = FindObjectOfType<pindah>();
        lanjut.kedalam();
    }
}
