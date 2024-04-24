using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mana_mana : MonoBehaviour
{
    public void mulai(){
    audio Mus = FindObjectOfType<audio>();
        Mus.efek.Play();
    }
    public void cameraN(){
    audio Mus = FindObjectOfType<audio>();
        Mus.canvas.SetActive(false);
        Mus.hilang1();
    }
    public void cameraM(){
    audio Mus = FindObjectOfType<audio>();
        Mus.canvas.SetActive(true);
        Mus.muncul1();
    }
}
