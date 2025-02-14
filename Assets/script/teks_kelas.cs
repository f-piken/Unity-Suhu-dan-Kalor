using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class teks_kelas : MonoBehaviour
{
    public Text textField;
    public string textToShow;
    public int selesai = 1;
    public float timeBetweenLetters = 0.02f;

    void Start()
    {
        StartCoroutine(ShowTextPerLetter());
    }

    IEnumerator ShowTextPerLetter()
    {
        textField.text = "";

        foreach (char letter in textToShow)
        {
            textField.text += letter;
            yield return new WaitForSeconds(timeBetweenLetters);
        }
    }
}
