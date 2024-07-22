using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSelectionButton : MonoBehaviour
{
    public Button uiButton;

    public Image PaddleReference;

    public bool isColorPlayer = false;

    private Image colorRef;

    private void Awake()
    {
        colorRef = GetComponent<Image>();
    }

    public void OnbuttonClick()
    {
        PaddleReference.color = uiButton.colors.normalColor;

        if(isColorPlayer)
        {
            SaveController.Instance.colorPlayer = PaddleReference.color;
        }
        else
        {
            SaveController.Instance.colorEnemy = PaddleReference.color;
        }
    }
}
