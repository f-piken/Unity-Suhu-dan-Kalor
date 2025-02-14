using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kamera : MonoBehaviour
{
    public GameObject K1;
    public GameObject kvs;
    void Start()
    {
        StartCoroutine(DelayedAction());
    }
    IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(5f);
        K1.SetActive(true);
        kvs.SetActive(true);
    }
}