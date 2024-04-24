using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class login : MonoBehaviour
{
    public GameObject masuk;
    public InputField nama;
    public InputField kelas;
    public InputField nomor;
    public void manuk()
    {
        string namaku = nama.text;
        string kelasku = kelas.text;
        string noku = nomor.text;

        // Periksa apakah salah satu InputField kosong
        if (string.IsNullOrEmpty(namaku) || string.IsNullOrEmpty(kelasku) || string.IsNullOrEmpty(noku))
        {
            masuk.SetActive(true);
        }
        else
        {
            masuk.SetActive(false);
        }
    }
}
