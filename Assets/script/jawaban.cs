using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jawaban : MonoBehaviour
{
    
    public Button[] jawab;
    public int nilai = 0;
    public Text nil;
    public bool[] buttonClicked;
    private void Start()
    {
        buttonClicked = new bool[jawab.Length];
        // Menginisialisasi array buttonClicked dengan semua elemen false
        for (int i = 0; i < buttonClicked.Length; i++)
        {
            buttonClicked[i] = false;
            int buttonIndex = i; // Simpan nilai i agar bisa digunakan dalam listener
            jawab[i].onClick.AddListener(() => Benar(buttonIndex));
        }
    }
    public void kasi(){
        for (int i = 0; i < buttonClicked.Length; i++){
            if (buttonClicked[i]){
                nilai++;
            }
        }
        UpdateText();
    }
    void UpdateText()
    {
        nil.text = nilai.ToString()+" / 10";
    }

    void Benar(int index)
    {
        if (!buttonClicked[index])
        {
            buttonClicked[index] = true; // Menandai tombol sebagai sudah diklik
            UpdateText(); // Memperbarui teks setelah nilai diubah
        }
    }
    
}