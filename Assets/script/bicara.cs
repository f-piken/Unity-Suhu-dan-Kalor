using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bicara : MonoBehaviour
{
    public GameObject KM1;
    public GameObject KM2;
    void Start()
    {
        KM1.SetActive(false);
        KM2.SetActive(true);
    }

    void Update()
    {
        
    }
}
