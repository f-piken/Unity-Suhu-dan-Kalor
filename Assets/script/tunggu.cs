using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tunggu : MonoBehaviour
{
    public float waktu = 2.7f;
    public GameObject kepsek;
    void Start()
    {
        StartCoroutine(DelayedAction());
    }
    IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(waktu);
        kepsek.SetActive(true);
    }
}
