using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenuControler : MonoBehaviour
{
    public TextMeshProUGUI uiWinner;
    public 
    void Start()
    {
        SaveController.Instance.Reset();

        string lastWinner = SaveController.Instance.GetLastWinner();

        if (lastWinner != "")
            uiWinner.text = "Ultimo vencedor" + lastWinner;
        else
            uiWinner.text = "";
    }
}
