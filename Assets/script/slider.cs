using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider : MonoBehaviour
{
    public GameObject[] obj;
    public GameObject ka;
    public GameObject ki;
    public Button kanan;
    public Button kiri;
    public int para;
    private int currentIndex = 0;
    private void Start()
    {
        // Pastikan objek pertama aktif
        SetActiveObject(currentIndex);

        // Menambahkan fungsi onClick ke tombol kanan
        kanan.onClick.AddListener(MoveToNext);

        // Menambahkan fungsi onClick ke tombol kiri
        kiri.onClick.AddListener(MoveToPrevious);
    }
    void MoveToNext()
    {
        if (obj[para].activeSelf)
        {
            ka.SetActive(false);
        }else{
            currentIndex = (currentIndex + 1) % obj.Length;
            SetActiveObject(currentIndex);
            ki.SetActive(true);
        }
    }

    void MoveToPrevious()
    {
        if (obj[0].activeSelf)
        {
            ki.SetActive(false);
        }else{
            currentIndex = (currentIndex - 1 + obj.Length) % obj.Length;
            SetActiveObject(currentIndex);
            ka.SetActive(true);
        }
    }

    void SetActiveObject(int index)
    {
        for (int i = 0; i < obj.Length; i++)
        {
            obj[i].SetActive(i == index);
        }
    }
}

