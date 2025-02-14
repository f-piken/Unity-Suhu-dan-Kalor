using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  
using UnityEngine.SceneManagement;

public class input : MonoBehaviour
{
    public string nama;
    public GameObject status1;
    public GameObject status2;
    public GameObject popup;
    public GameObject tampilan;
    public string benar;
    public InputField display;
    public void create()
    {
        string jawaban = display.text;
        if (benar == jawaban)
        {
            StartCoroutine(Benar());
        }
        else if (benar != jawaban)
        {
            StartCoroutine(Salah());
        }
        PlayerPrefs.Save();
    }
    IEnumerator Benar()
    {
        yield return new WaitForSeconds(1f);
        popup.SetActive(false);
        tampilan.SetActive(true);
        status1.SetActive(true);
        status2.SetActive(false);
    }
    IEnumerator Salah()
    {
        yield return new WaitForSeconds(1f);
        popup.SetActive(false);
        tampilan.SetActive(true);
        status1.SetActive(false);
        status2.SetActive(true);
    }
    public void selanjut()
    {
        tanya lanjut = FindObjectOfType<tanya>();
        if (lanjut.desk[5].activeSelf || lanjut.desk[6].activeSelf)
        {
            if (status1.activeSelf)
            {
                tampilan.SetActive(false);
                lanjut.keluar();
            }
            else if (status2.activeSelf)
            {
                SceneManager.LoadScene("sadend");
            }
        }
        else if (lanjut.desk[7].activeSelf)
        {
            if (status1.activeSelf)
            {
                SceneManager.LoadScene(nama);
            }
            else if (status2.activeSelf)
            {
                SceneManager.LoadScene("sadend");
            }
        }
    }
    public void jawab()
    {
        string jawaban = display.text;
        if (benar == jawaban)
        {
            StartCoroutine(Benar());
        }
        else if (benar != jawaban)
        {
            StartCoroutine(Salah());
        }
        PlayerPrefs.Save();
    }
    public void kelanjutan()
    {
        if (status1.activeSelf)
        {
            SceneManager.LoadScene(nama);
        }
        else if (status2.activeSelf)
        {
            SceneManager.LoadScene("sadend");
        }
    }
}
