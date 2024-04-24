using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class audio : MonoBehaviour
{
    private static audio instance;
    public AudioSource efek;
    public GameObject canvas;
    public AudioSource lagu; 
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void hilang1()
    {
        if (lagu.mute == false)
        {
        lagu.mute = true;
        }
    }
    public void hilang3()
    {
        if (efek.mute == false)
        {
        efek.mute = true;
        }
    }
    public void hilang2()
    {
        canvas.SetActive(false);
    }
    public void muncul1()
    {
        if (lagu.mute == true)
        {
        lagu.mute = false;
        }
    }
    public void muncul2()
    {
        canvas.SetActive(true);
    }
    public void muncul3()
    {
        if (efek.mute == true)
        {
        efek.mute = false;
        }
    }
}
