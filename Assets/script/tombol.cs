using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tombol : MonoBehaviour
{
    public Button[] resetButton;
    public jawaban quizManager; // Anda perlu mengaitkan skrip jawaban Anda melalui Inspector
    public int tempat;

    private void Start()
    {
        for (int i=0; i < resetButton.Length; i++){
            int a = i;
            resetButton[a].onClick.AddListener(ResetButtonClicked);
        }
    }

    void ResetButtonClicked()
    {
        
        quizManager.buttonClicked[tempat] = false;
    }
}
