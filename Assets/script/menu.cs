using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void hilang(){
        song Music = FindObjectOfType<song>();
        Music.hilang2();
        SceneManager.LoadScene("penjelasan");
    }
}
