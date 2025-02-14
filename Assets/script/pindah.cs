using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pindah : MonoBehaviour
{
    public void baru()
    {
        song Music = FindObjectOfType<song>();
        Music.muncul2();
        SceneManager.LoadScene("awal");
    }
    public void menu()
    {
        SceneManager.LoadScene("menu");
    }
    public void materi()
    {
        SceneManager.LoadScene("menu materi");
    }
    public void kompe()
    {
        SceneManager.LoadScene("kompetensi");
    }
    public void tujuan()
    {
        SceneManager.LoadScene("tujuan");
    }
    public void bantu()
    {
        SceneManager.LoadScene("bantuan");
    }
    public void info()
    {
        SceneManager.LoadScene("info");
    }
    public void petunjuk()
    {
        SceneManager.LoadScene("petunjuk");
    }
    public void profil()
    {
        SceneManager.LoadScene("profile");
    }
    public void awal()
    {
        SceneManager.LoadScene("penjelasan");
    }
    public void pilihan()
    {
        SceneManager.LoadScene("pemilihan");
    }
    public void masuk()
    {
        SceneManager.LoadScene("luar");
    }
    public void kedalam()
    {
        SceneManager.LoadScene("masuk perpus");
    }
    public void perpus()
    {
        SceneManager.LoadScene("perpus");
    }
    public void labo()
    {
        SceneManager.LoadScene("lab");
    }
    public void kelas()
    {
        SceneManager.LoadScene("kelas");
    }
    public void bicara()
    {
        SceneManager.LoadScene("kepsek");
    }
    public void tanya1_1()
    {
        SceneManager.LoadScene("per_kelas");
    }
    public void tanya1_2()
    {
        SceneManager.LoadScene("per_lab");
    }
    public void tanya1_3()
    {
        SceneManager.LoadScene("per_perpus");
    }

    public void tanya2()
    {
        SceneManager.LoadScene("pertanyaan 2");
    }
    public void salju()
    {
        SceneManager.LoadScene("salju");
    }
    public void keluar()
    {
        Application.Quit();
        Debug.Log("Game Close");
    }
    public void lagu(){
        efek lugu = FindObjectOfType<efek>();
        lugu.mulai();
    }
}
