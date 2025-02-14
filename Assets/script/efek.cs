using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class efek : MonoBehaviour
{
    public AudioSource lagu;
    
    public void mulai()
    {
        lagu.Play();
    }
    public void bisu()
    {
        if (lagu.mute == true)
        {
        lagu.mute = false;
        }
    }
    public void bunyi()
    {
        if (lagu.mute ==false)
        {
        lagu.mute = true;
        }
    }
}
