using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class latihan : MonoBehaviour
{
    public GameObject[] obj;
    public GameObject kumpul;
    public GameObject has;
    public GameObject sel;
    public GameObject ka;
    public GameObject ki;
    public Button kanan;
    public Button kiri;
    public Button selesai;
    private int currentIndex = 0;
    private void Start()
    {
        // Pastikan objek pertama aktif
        SetActiveObject(currentIndex);

        // Menambahkan fungsi onClick ke tombol kanan
        kanan.onClick.AddListener(MoveToNext);

        // Menambahkan fungsi onClick ke tombol kiri
        kiri.onClick.AddListener(MoveToPrevious);
        selesai.onClick.AddListener(hasil);
    }

    void hasil(){
        has.SetActive(true);
        kumpul.SetActive(false);
    }
    void MoveToNext()
    {
        if (obj[9].activeSelf)
        {
            sel.SetActive(true);
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
            sel.SetActive(false);
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

