using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIRocket : MonoBehaviour
{
    private TextMeshProUGUI _inventoryText;

    void Start()
    {
        _inventoryText = GetComponent<TextMeshProUGUI>();
        HideText();
    }

    public void ShowText()
    {
        gameObject.SetActive(true);
    }

    public void ShowCollectionCompeteText()
    {
        _inventoryText.text = "Press F to repair and launch the rocket";
        ShowText();
    }

    public void HideText()
    {
        gameObject.SetActive(false);
    }
}
