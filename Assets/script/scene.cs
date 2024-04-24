using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Diagnostics;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
    public void menu()
    {
        SceneManager.LoadScene("menu");
    }
    public void ar()
    {
        SceneManager.LoadScene("ar");
    }
    public void camera()
    {
        SceneManager.LoadScene("camera");
    }
    public void meteri()
    {
        SceneManager.LoadScene("materi");
    }
    public void latihan()
    {
        SceneManager.LoadScene("latihan");
    }
    public void kompe()
    {
        SceneManager.LoadScene("kompetensi");
    }
    public void petunjuk()
    {
        SceneManager.LoadScene("petunjuk");
    }
    public void info()
    {
        SceneManager.LoadScene("profil");
    }
    public string url; // Tautan yang ingin Anda buka saat tombol diklik
    public void chat()
    {
        Process.Start(url);
    }
    public void tentang()
    {
        SceneManager.LoadScene("tentang");
    }
    public void keluar()
    {
        Application.Quit();
    }
}
